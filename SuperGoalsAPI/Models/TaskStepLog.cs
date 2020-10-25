﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class TaskStepLog
    {
        public TaskStepLog()
        {

        }
        [Key]
        public Guid TaskStepLogId { get; set; }
        public Guid TaskStepId { get; set; }
        public bool WasCompleted { get; set; }
        public DateTime? DateCompleted { get; set; }

    }
}
