using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommandEducation
{
    public class WasherCommand : ICommand
    {
        private readonly Washer _washer;

        public WasherCommand(Washer washer)
        {
            _washer = washer;
        }

        public void Execute()
        {
            _washer.StartWash();
        }

        public void Undo()
        {
            _washer.StopWash();
        }
    }
}
