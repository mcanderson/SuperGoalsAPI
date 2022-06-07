using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class PomodoroTimerLog
    {
        public Guid PomodoroTimerId { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan TimeRemaining { get; set; }
        public bool? WasCompleted { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
