using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class TaskLog
    {
        public TaskLog()
        {

        }

        Guid TaskLogId { get; set; }
        Guid TaskId { get; set; }
        DateTime DateCompleted { get; set; }
        
    }
}
