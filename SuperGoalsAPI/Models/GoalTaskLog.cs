using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalTaskLog
    {
        public GoalTaskLog()
        {

        }
        [Key]
        public Guid GoalTaskLogId { get; set; }
        public Guid GoalTaskId { get; set; }
        // An item should only get logged if it was completed OR not completed. 
        public bool WasCompleted { get; set; }
        // Acceptable for DateCompleted to be null if WasCompleted is false. Don't care about dates for skipped goals. 
        public DateTime? DateCompleted { get; set; }
        
    }
}
