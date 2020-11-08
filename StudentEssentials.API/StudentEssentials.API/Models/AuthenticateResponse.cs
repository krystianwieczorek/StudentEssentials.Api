using StudentEssentials.API.Entities;

namespace StudentEssentials.API.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? GroupId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.UserId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            GroupId = user.GroupId;
            Email = user.Email;
            Token = token;
        }
    }
}
