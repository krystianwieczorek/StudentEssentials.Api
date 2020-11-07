using Microsoft.AspNetCore.Mvc;
using StudentEssentials.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Controllers
{
    [ApiController]
    [Route("api/shedules")]
    public class SheduleController : ControllerBase
    {
        private readonly IStudentEssentialsRespository _studentEssentialsRepo;

        public SheduleController(IStudentEssentialsRespository studentEssentialsRepo)
        {
            _studentEssentialsRepo = studentEssentialsRepo ?? throw new ArgumentNullException(nameof(studentEssentialsRepo));
        }

        //[Authorize]
        [HttpGet("sheduleId")]
        public IActionResult GetShedule(int sheduleId)
        {
            var sheduleFromRepo = _studentEssentialsRepo.GetShedule(sheduleId);

            if (sheduleFromRepo == null)
            {
                return NotFound();
            }

            return Ok(sheduleFromRepo);
        }

        [HttpGet("{sheduleId}/{sheduleDay}")]
        public IActionResult GetShedulePerDay(int sheduleId, DayOfWeek sheduleDay)
        {
            var sheduleFromRepo = _studentEssentialsRepo.GetShedulePerDay(sheduleId, sheduleDay);

            if (sheduleFromRepo == null)
            {
                return NotFound();
            }

            return Ok(sheduleFromRepo);
        }
    }
}
