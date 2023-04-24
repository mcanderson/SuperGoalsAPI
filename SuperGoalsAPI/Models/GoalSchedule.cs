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
        public Guid ScheduleId { get; set; }
        public DateOnly? DeadlineDay { get; set; }
        public TimeOnly? DeadlineTime { get; set; }
        public Guid? PriorityId { get; set; }
        public Guid GoalId { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsSkipped { get; set; }
    }
}
