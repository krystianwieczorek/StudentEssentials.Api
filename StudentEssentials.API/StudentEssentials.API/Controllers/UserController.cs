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
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IStudentEssentialsRespository _userService;

        public UserController(IStudentEssentialsRespository userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        //[Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        } 
        
        //[Authorize]
        [HttpGet("userId")]
        public IActionResult GetUser(int userId)
        {
            var user = _userService.GetUser(userId);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost("add")]
        public IActionResult AddNewUser([FromBody] UserRequest userRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Errors = "Model is invalid" });

            }
            bool result = _userService.AddNewUser(userRequest);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Error = "Server error" });
            }

            return Ok();
        }

        [HttpPut("update")]
        public IActionResult UpdateUser([FromBody] UserRequest userRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Errors = "Model is invalid" });

            }
            bool result = _userService.UpdateUser(userRequest);

            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Error = "Server error" });
            }

            return Ok();
        }

    }
}
