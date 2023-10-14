using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommandEducation
{
    public class WaherRunForChemistryCommand : ICommand
    {
        private readonly Washer _washer;

        public WaherRunForChemistryCommand(Washer washer)
        {
            _washer = washer;
        }

        public void Execute()
        {
            _washer.RunInShop().BuyChemistry();
        }

        public void Undo()
        {
            _washer.RunInRestoran();
        }
    }
}
