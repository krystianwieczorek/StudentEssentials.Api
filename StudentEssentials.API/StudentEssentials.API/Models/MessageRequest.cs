using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Models
{
    public class MessageRequest
    {
        public int? MessageId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }

    }
}
