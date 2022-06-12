using SuperGoalsAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class TaskStep
    {
        public TaskStep()
        {

        }
        [Key]
        public Guid TaskStepId { get; set; }
        public Guid GoalTaskId { get; set; }
        public string TaskStepName { get; set; }
        public string TaskStepDescription { get; set; }
        public StatusType TaskStepStatus { get; set; }
    }
}
