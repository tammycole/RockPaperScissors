using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanPlayer : Player
    {
        public HumanPlayer(RPSGenerator r) : base(r)
        {
            //string name = RPSapp.Welcome();
        }

        public new string GetName()
        {
            string a = RPSapp.Welcome();
            return a;
        }

        public override string GenerateRPS()
        {
            string humanChoice = RPSapp.Choice();
            string c = rpsList.GetByString(humanChoice);
            //return name + ": " + c;
            return c;
        }
    }
}
