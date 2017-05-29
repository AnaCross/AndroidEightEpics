using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Challenges
{
    class ChallengeLess : Challenge
    {
        public override EnumThreatChallenge getChallenge()
        {
            return EnumThreatChallenge.LESS;
        }

        public override bool skillChallenge(DicePool dicepool)
        {
            int sum = dicepool.count();
            if (sum <= value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool skillChallenge(int sum)
        {
            if(sum <= value)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
