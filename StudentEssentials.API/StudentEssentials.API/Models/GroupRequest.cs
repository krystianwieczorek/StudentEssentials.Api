using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Models
{
    public class GroupRequest
    {
        public int? GroupId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
