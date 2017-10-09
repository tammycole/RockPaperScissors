using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rocky : Player
    {
        public Rocky(RPSGenerator r) : base(r)
        {
            name = "Rocky";
        }

        public override string GenerateRPS()
        {
            string ro = rpsList.GetByIndex(0);
            return name + ": " + ro;
        }
    }
}
