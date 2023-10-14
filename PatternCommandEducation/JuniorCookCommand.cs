namespace PatternCommandEducation
{
    public class JuniorCookCommand : ICommand
    {
        private JuniorCook _juniorCook;

        public JuniorCookCommand(string name)
        {
            _juniorCook = new JuniorCook(name);
        }
        public void SetCommand(JuniorCook juniorCook)
        {
            _juniorCook = juniorCook;
        }

        public void Execute()
        {
            if (_juniorCook != null)
                _juniorCook.StartCooking();
        }

        public void Undo()
        {
            if (_juniorCook != null)
                _juniorCook.StopCooking();
        }

    }
}
