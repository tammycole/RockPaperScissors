using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                RPSGenerator rps = new RPSGenerator();

                HumanPlayer human = new HumanPlayer(rps);
                Rocky r = new Rocky(rps);
                Other other = new Other(rps);

                string name = human.GetName();
                string against = RPSapp.Opponent();
                string hc = human.GenerateRPS();
                Console.WriteLine(name + ": " + hc);

                string computerResponse = RPSapp.Calculate(against, r, other);

               RPSapp.Winner(computerResponse, hc, name, against);

                run = RPSapp.Continue();

            }
        }
        

    }
}