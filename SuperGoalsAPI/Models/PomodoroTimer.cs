using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace SuperGoalsAPI.Models
{
    public class PomodoroTimer
    {
        public Guid PomodoroTimerId { get; set; }
        public Timer PomoTimer { get; set; }
    }
}
