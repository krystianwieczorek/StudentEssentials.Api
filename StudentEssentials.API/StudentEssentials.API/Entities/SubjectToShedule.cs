using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Entities
{
    public class SubjectToShedule
    {
        [Key]
        public int SubjectToSheduleId { get; set; }

        [Required]
        [MaxLength(50)]
        public TimeSpan StartTime { get; set; }

        [Required]
        [MaxLength(50)]
        public TimeSpan EndTime { get; set; }

        [Required]
        [MaxLength(50)]
        public DayOfWeek SheduleDay { get; set; }

        [Required]
        [MaxLength(50)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(50)]
        public string Profesor { get; set; }
        public string Classroom { get; set; }

        [JsonIgnore]
        public int GroupId { get; set; }

        
        [ForeignKey(nameof(GroupId)), JsonIgnore]
        public Group Group { get; set; }


    }
}
