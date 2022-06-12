using System.ComponentModel;

namespace SuperGoalsAPI.Enums
{
    public enum StatusType
    {
        [Description("New")]
        New = 1,
        [Description("InProgress")]
        InProgress = 2,
        [Description("Completed")]
        Completed = 3,
        [Description("Skipped")]
        Skipped = 4

    }
}
