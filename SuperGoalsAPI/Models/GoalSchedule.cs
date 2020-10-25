using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalSchedule
    {

        public GoalSchedule()
        {

        }
        [Key]
        public Guid GoalScheduleId { get; set; }
        public DateTime? Deadline { get; set; }
        public Guid PriorityId { get; set; }

    }
}
