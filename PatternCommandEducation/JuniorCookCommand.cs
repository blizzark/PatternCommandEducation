namespace PatternCommandEducation
{
    public class JuniorCookCommand : ICommand
    {
        private JuniorCook _juniorCook;
        private Queue<string>? _order;
        public JuniorCookCommand(string name, Queue<string> order)
        {
            _juniorCook = new JuniorCook(name);
            _order = order;
        }

        public void Execute()
        {
            if (_juniorCook != null)
            {
                while(_order != null) // надо делать lock, походу
                {
                    _juniorCook.StartCooking(_order.Dequeue());
                }
            }
              
        }

        public void Undo()
        {
            if (_juniorCook != null)
                _juniorCook.StopCooking();
        }

    }
}
