using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class Goal
    {
        public Goal()
        {

        }

        Guid GoalId { get; set; }
        string GoalName { get; set; }
        string GoalDescription { get; set; }
        ICollection<GoalTask> GoalTasks { get; set; }
        ICollection<GoalCategory> GoalCategories { get; set; }
    }
}
