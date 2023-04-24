using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalTaskSchedule
    {
        public Guid ScheduleId { get; set; }
        public DateTime? Deadline { get; set ; }
        public Guid? PriorityId { get; set ; }
    }
}
