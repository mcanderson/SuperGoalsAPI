using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalSchedule : Schedule
    {

        public GoalSchedule()
        {

        }
        [Key]
        public Guid ScheduleId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? Deadline { get; set; }
        public Guid PriorityId { get; set; }
    }
}
