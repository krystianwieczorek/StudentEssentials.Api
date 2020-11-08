﻿using StudentEssentials.API.Entities;
using StudentEssentials.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Services
{
    public interface IStudentEssentialsRespository
    {
        User GetUser(int userId);

        bool AddNewUser(UserRequest userRequest);
        bool AddNewGroup(GroupRequest groupRequest);
        bool UpdateUser(UserRequest userRequest);
        bool AddNewSheduleElement(SheduleRequest sheduleRequest);
        bool DeleteSheduleElement(SheduleRequest sheduleRequest);
        IEnumerable<SubjectToShedule> GetShedulePerDay(int sheduleId, DayOfWeek sheduleDay);

        Group GetGroup(int groupId);
        IEnumerable<Group> GetAllGroups();
        SubjectToShedule GetSubjectToSedule(int subjectToShedule);

        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
