using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StudentEssentials.API.DbContexts;
using StudentEssentials.API.Entities;
using StudentEssentials.API.Helpers;
using StudentEssentials.API.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentEssentials.API.Services
{
    public class StudentEssentialsRespository : IStudentEssentialsRespository
    {

        private readonly StudentEssentialsContext _context;
        private readonly AppSettings _appSettings;

        public StudentEssentialsRespository(StudentEssentialsContext context, IOptions<AppSettings> appSettings)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _appSettings = appSettings.Value;

        }

        public User GetUser(int userId)
        {
            return _context.Users
                .Include(s => s.Group)
                .Where(a => a.UserId == userId)
                .FirstOrDefault();
        }

        public bool UpdateUser(UserRequest userRequest)
        {
            try
            {
                User user = _context.Users.Where(s => s.UserId == userRequest.UserId).FirstOrDefault();
                user.GroupId = userRequest.GroupId;
                _context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;

            }
        }

        public bool AddNewUser(UserRequest userRequest)
        {
            try
            {
                User newUser = new User()
                {
                    FirstName = userRequest.FirstName,
                    LastName = userRequest.LastName,
                    Email = userRequest.Email,
                    GroupId = userRequest.GroupId,
                    Password = userRequest.Password,
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;

            }
        }


        public bool AddNewSheduleElement(SheduleRequest sheduleRequest)
        {
            try
            {
                SubjectToShedule newSubjectToShedule = new SubjectToShedule()
                {
                    StartTime = sheduleRequest.StartTime,
                    EndTime = sheduleRequest.EndTime,
                    SheduleDay = sheduleRequest.SheduleDay,
                    Subject = sheduleRequest.Subject,
                    Profesor = sheduleRequest.Profesor,
                    GroupId = sheduleRequest.GroupId,
                };
                _context.SubjectToShedules.Add(newSubjectToShedule);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public IEnumerable<SubjectToShedule> GetShedulePerDay(int sheduleId, DayOfWeek sheduleDay)
        {
            return _context.SubjectToShedules
                .Where(s => s.SheduleDay == sheduleDay && s.GroupId == sheduleId);

        }

        public Group GetGroup(int groupId)
        {
            return _context.Groups
                .Include(s => s.UserList)
                .Where(s=> s.GroupId == groupId)
                .FirstOrDefault();

        }

        public IEnumerable<Group> GetAllGroups()
        {
            return _context.Groups;

        }



        public SubjectToShedule GetSubjectToSedule(int subjectToShedule)
        {
            return _context.SubjectToShedules.FirstOrDefault(s => s.SubjectToSheduleId == subjectToShedule);
        }


















        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _context.Users.SingleOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.UserId == id);
        }

        // helper methods

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.UserId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }












    }
}
