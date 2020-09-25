using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalCategory
    {
        public GoalCategory()
        {

        }

        Guid GoalCategoryId { get; set; }
        string GoalCategoryName { get; set; }
        string GoalCategoryDescription { get; set; }
        ICollection<Goal> GoalsList { get; set; }
    }
}
