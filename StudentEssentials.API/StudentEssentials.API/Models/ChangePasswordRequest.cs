using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Models
{
    public class ChangePasswordRequest
    {
        public int UserId { get; set; }
        public string Password0 { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

    }
}
