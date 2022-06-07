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

        public DbSet<GoalSchedule> GoalSchedules { get; set; }
        public DbSet<GoalTask> GoalTasks { get; set; }
        public DbSet<GoalTaskLog> GoalTaskLogs { get; set; }
        public DbSet<TaskStepLog> GoalTaskStepLogs { get; set; }
        public DbSet<TaskStep> GoalTaskSteps { get; set; }

        public DbSet<GoalTaskStepXwalk> GoalTaskStepXwalks { get; set; }
        public DbSet<Priority> Priorities { get; set; }

        // TODO update and story as secrets/key vault
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goal>()
                .HasKey(o => o.GoalId);

            modelBuilder.Entity<GoalTask>().HasKey(o => o.GoalTaskId);


            modelBuilder.Entity<GoalCategory>(entity => 
            {
                entity.HasKey(o => o.GoalCategoryId);

            });


            modelBuilder.Entity<GoalCategoryXwalk>(entity =>
            {
                entity.HasKey(dt => new { dt.GoalId, dt.GoalCategoryId });

                entity.HasOne(g => g.GoalObj)
                .WithMany(gcx => gcx.GoalCategories)
                .HasForeignKey(fk => fk.GoalId);

                entity.HasOne(g => g.GoalCategoryObj)
                .WithMany(gcx => gcx.GoalsList)
                .HasForeignKey(fk => fk.GoalCategoryId);
            });

            modelBuilder.Entity<GoalTaskLog>().HasKey(o => o.GoalTaskLogId);

            modelBuilder.Entity<GoalTaskStepXwalk>().HasKey(dt => new { dt.GoalTaskId, dt.GoalTaskStepId });

            modelBuilder.Entity<Priority>().HasKey(o => o.PriorityId);

            modelBuilder.Entity<GoalSchedule>().HasKey(o => o.ScheduleId);

            modelBuilder.Entity<TaskStep>().HasKey(o => o.TaskStepId);

            modelBuilder.Entity<TaskStepLog>().HasKey(o => o.TaskStepLogId);
        }

    }
}
