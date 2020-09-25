using Microsoft.EntityFrameworkCore;
using SuperGoalsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Data
{
    public class GoalDbContext : DbContext
    {
        public GoalDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Goal> Goals { get; set;  }
        public DbSet<GoalCategory> GoalCategories { get; set; }
        public DbSet<GoalTask> Tasks { get; set; }
        public DbSet<TaskLog> TaskLogs { get; set; }
        public DbSet<TaskStepLog> TaskStepLogs { get; set; }
        public DbSet<TaskSteps> TaskSteps { get; set; }

    }
}
