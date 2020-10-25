using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalTask
    {
        public GoalTask()
        {

        }
        [Key]
        public Guid GoalTaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public Guid GoalId { get; set; }
        public virtual Goal GoalName { get; set; }
        [ForeignKey("GoalTaskId")]
        public virtual ICollection<GoalTask> GoalTasks { get; set; }
        [ForeignKey("GoalTaskLogId")]
        public virtual ICollection<GoalTaskLog> GoalTaskLogs { get; set; }
    }
}
