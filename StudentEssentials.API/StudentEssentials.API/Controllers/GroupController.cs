using Microsoft.AspNetCore.Mvc;
using StudentEssentials.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Controllers
{
    [ApiController]
    [Route("api/groups")]
    public class GroupController : ControllerBase
    {
        private readonly IStudentEssentialsRespository _studentEssentialsRepo;

        public GroupController(IStudentEssentialsRespository studentEssentialsRepo)
        {
            _studentEssentialsRepo = studentEssentialsRepo ?? throw new ArgumentNullException(nameof(studentEssentialsRepo));
        }

        //[Authorize]
        [HttpGet("groupId")]
        public IActionResult GetShedule(int groupId)
        {
            var groupFromRepo = _studentEssentialsRepo.GetGroup(groupId);

            if (groupFromRepo == null)
            {
                return NotFound();
            }

            return Ok(groupFromRepo);
        } 
        
        [HttpGet]
        public IActionResult GetAllGroups()
        {
            var groupsFromRepo = _studentEssentialsRepo.GetAllGroups();

            if (groupsFromRepo == null)
            {
                return NotFound();
            }

            return Ok(groupsFromRepo);
        }
    }
}



