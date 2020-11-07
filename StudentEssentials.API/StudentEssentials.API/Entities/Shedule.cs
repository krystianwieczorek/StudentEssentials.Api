using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEssentials.API.Entities
{
    public class Shedule
    {

        [Key]
        public int SheduleId { get; set; }

        public ICollection<SubjectToShedule> SubjectList { get; set; }
    }
}
