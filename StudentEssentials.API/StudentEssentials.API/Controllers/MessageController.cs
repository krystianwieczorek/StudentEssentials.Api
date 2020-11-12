using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentEssentials.API.Models;
using StudentEssentials.API.Services;

namespace StudentEssentials.API.Controllers
{

    [ApiController]
    [Route("api/messages")]
    public class MessageController : ControllerBase
    {

        private readonly IStudentEssentialsRespository _studentEssentialsRepo;

        public MessageController(IStudentEssentialsRespository studentEssentialsRepo)
        {
            _studentEssentialsRepo = studentEssentialsRepo ?? throw new ArgumentNullException(nameof(studentEssentialsRepo));
        }


        [HttpGet("groupId")]
        public IActionResult GetMessages(int groupId)
        {
            var messages = _studentEssentialsRepo.GetMessages(groupId);

            if (messages == null)
            {
                return NotFound();
            }

            return Ok(messages);
        }

        [HttpPost("send")]
        public IActionResult SendMessage([FromBody] MessageRequest messageRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Errors = "Model is invalid" });

            }
            bool result = _studentEssentialsRepo.SendMessage(messageRequest);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Error = "Server error" });
            }


            return Ok();
        }
    }
}
