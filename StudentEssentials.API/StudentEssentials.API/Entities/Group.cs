using Newtonsoft.Json;
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

        [ForeignKey(nameof(UserId))]

        public int UserId { get; set; }
        public User Owner { get; set; }

        public ICollection<User> UserList { get; set; }

        [JsonIgnore]

        public ICollection<SubjectToShedule> SubjectList { get; set; }

    }
}
