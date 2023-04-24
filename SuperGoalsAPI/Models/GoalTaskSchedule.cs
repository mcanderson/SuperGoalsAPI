using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalTaskSchedule
    {
        public Guid ScheduleId { get; set; }
        public DateOnly? DeadlineDay { get; set ; }
        public TimeOnly? DeadlineTime { get; set ; }
        public Guid? PriorityId { get; set ; }
        public Guid GoalTaskId { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsSkipped { get; set; }
    }
}
