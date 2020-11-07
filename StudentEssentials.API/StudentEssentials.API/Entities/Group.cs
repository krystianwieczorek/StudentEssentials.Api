using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Entities
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int UserId { get; set; }

        public int SheduleId { get; set; }

        public ICollection<User> UserList { get; set; }

    }
}
