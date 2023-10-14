namespace PatternCommandEducation
{
    public class ChefInvoker
    {
        private List<ICommand>? _command;

        public void SetCommand(List<ICommand> command)
        {
            _command = command;
        }

        public void SendСommand()
        {
            if (_command != null)
                foreach (ICommand command in _command)
                    command.Execute();
        }

        public void CanselСommand()
        {
            if (_command != null)
                foreach (ICommand command in _command)
                    command.Undo();
        }
    }
}
