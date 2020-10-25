using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperGoalsAPI.Models
{
    public class Priority
    {
        public Priority()
        {

        }
        [Key]
        public Guid PriorityId { get; set; }
        public string PriorityName { get; set; }
        public int Rank { get; set; }
    }
}
