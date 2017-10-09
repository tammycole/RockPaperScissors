using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Other : Player
    {

        public Other (RPSGenerator r) : base(r)
        {
            name = "Tim";
        }

        public override string GenerateRPS()
        {
          int rand =  GetRandom();
          var randomrps= rpsList.GetByIndex(rand);
          return name+": "+randomrps;
        }
        public int GetRandom()
        {
            Random rng = new Random();
            var ind = rng.Next(0, 3);
            return ind;

        }
      
    }
}
