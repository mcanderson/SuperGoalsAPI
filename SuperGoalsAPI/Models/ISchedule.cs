using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    interface ISchedule
    {
        public Guid ScheduleId { get; set; }
        public DateTime? Deadline { get; set; }
        public Guid PriorityId { get; set; }

      //  public Guid GoalTaskId { get; set; }
    }
}
