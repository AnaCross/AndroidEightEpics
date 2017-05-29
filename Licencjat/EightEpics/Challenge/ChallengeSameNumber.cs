using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Challenges
{
    class ChallengeSameNumber : Challenge
    {
        public override EnumThreatChallenge getChallenge()
        {
            return EnumThreatChallenge.SAME_NUMBER;
        }

        public override bool skillChallenge(DicePool dicepool)
        {
            int val = dicepool[0].value;
            foreach(Dice d in dicepool)
            {
                if(d.value != val)
                {
                    return false;
                }
            }
            return true;
        }

        public override bool skillChallenge(int sum)
        {
            throw new NotImplementedException();
        }
    }
}
