using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class GoalCategoryXwalk
    {
        public GoalCategoryXwalk()
        {

        }

        [Key]
        public Guid GoalId { get; set; }
        [Key]
        public Guid GoalCategoryId { get; set; }
        public Goal GoalObj { get; set; }
        public GoalCategory GoalCategoryObj {get; set;}
    }
}
