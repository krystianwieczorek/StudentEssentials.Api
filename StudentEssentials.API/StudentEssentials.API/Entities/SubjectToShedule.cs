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

        public int SheduleId { get; set; }

        [ForeignKey(nameof(SheduleId))]
        public Shedule Shedule { get; set; }

        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }
    }
}
