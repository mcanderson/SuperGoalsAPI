﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalCategory
    {
        public GoalCategory()
        {

        }
        [Key]
        public Guid GoalCategoryId { get; set; }
        public string GoalCategoryName { get; set; }
        public string GoalCategoryDescription { get; set; }
        public virtual ICollection<GoalCategoryXwalk> GoalsList { get; set; }
    }
}
