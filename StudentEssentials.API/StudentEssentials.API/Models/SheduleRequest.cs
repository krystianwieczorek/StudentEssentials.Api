using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Models
{
    public class SheduleRequest
    {
        public int? SubjectToSheduleId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DayOfWeek? SheduleDay { get; set; }
        public string Subject { get; set; }
        public string Profesor { get; set; }
        public int? GroupId { get; set; }
    }
}
