using SuperGoalsAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class Goal
    {
        public Goal()
        {

        }

        [Key]
        public Guid GoalId { get; set; }
        public string GoalName { get; set; }
        public string GoalDescription { get; set; }
        [ForeignKey("GoalTaskId")]
        public StatusType GoalStatus { get; set; } 
        public virtual ICollection<GoalTask> GoalTasks { get; set; }
        [ForeignKey("GoalCategoryId")]
        public virtual ICollection<GoalCategoryXwalk> GoalCategories { get; set; }
    }
}
