using System.ComponentModel;

namespace SuperGoalsAPI.Enums
{
    public enum PriorityType
    {
        [Description("Critical")]
        Critical = 1,
        [Description("High")]
        High = 2,
        [Description("Medium")]
        Medium = 3,
        [Description("Low")]
        Low = 4,
        [Description("Meh")]
        Meh = 5
    }
}
