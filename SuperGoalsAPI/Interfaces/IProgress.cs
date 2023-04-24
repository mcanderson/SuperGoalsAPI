namespace SuperGoalsAPI.Interfaces
{
    public interface IProgress
    {
        void MarkCompleted();
        void SkipAllButLast();
    }
}
