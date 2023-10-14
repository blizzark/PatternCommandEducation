using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommandEducation
{
    public class ChefInvoker
    {
        private ICommand? _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void SendСommand()
        {
            if (_command != null)
            {
                _command.Execute();
            }
        }

        public void CanselСommand()
        {
            if (_command != null)
            {
                _command.Undo();
            }
        }
    }
}
