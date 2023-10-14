namespace PatternCommandEducation
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
