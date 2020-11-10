using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentEssentials.API.Models;
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


        [HttpGet("{groupId}/{sheduleDay}")]
        public IActionResult GetShedulePerDay(int groupId, DayOfWeek sheduleDay)
        {
            var sheduleFromRepo = _studentEssentialsRepo.GetShedulePerDay(groupId, sheduleDay);

            if (sheduleFromRepo == null)
            {
                return NotFound();
            }

            return Ok(sheduleFromRepo);
        }

        [HttpPost("add")]
        public IActionResult AddNewSheduleElement([FromBody] SheduleRequest sheduleRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Errors = "Model is invalid" });

            }
            bool result = _studentEssentialsRepo.AddNewSheduleElement(sheduleRequest);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Error = "Server error" });
            }


            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult DeleteSheduleElement([FromBody] SheduleRequest sheduleRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Errors = "Model is invalid" });

            }
            bool result = _studentEssentialsRepo.DeleteSheduleElement(sheduleRequest);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Error = "Server error" });
            }

            return Ok();
        }

        [HttpPut("edit")]
        public IActionResult EditSheduleElement([FromBody] SheduleRequest sheduleRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Errors = "Model is invalid" });

            }
            bool result = _studentEssentialsRepo.EditSheduleElement(sheduleRequest);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Error = "Server error" });
            }

            return Ok();
        }



    }
}
