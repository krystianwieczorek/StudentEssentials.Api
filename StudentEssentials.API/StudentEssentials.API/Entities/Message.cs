using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Entities
{
    public class Message
    {
        public int MessageId { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(nameof(GroupId))]
        public int? GroupId { get; set; }

        public Group Group { get; set; }

        [ForeignKey(nameof(UserId))]
        public int? UserId { get; set; }

        public User User { get; set; }

    }
}
