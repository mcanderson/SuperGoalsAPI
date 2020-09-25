using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class TaskSteps
    {
        public TaskSteps()
        {

        }

        Guid TaskStepId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime DateCompleted { get; set; }
    }
}
