using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Challenges
{
    class ChallengeOther : Challenge
    {
        List<int> serrinList =new List<int>{6, 6, 6, 6, 6, 6, 6, 6 };
        List<int> makanoList = new List<int> {1, 1, 2, 3, 4, 5, 6, 6 };
        List<int> narssisList = new List<int> {1, 2, 3, 4, 5, 6 };
        public override EnumThreatChallenge getChallenge()
        {
            return EnumThreatChallenge.OTHER;
        }

        public override bool skillChallenge(DicePool dicepool)
        {
            throw new NotImplementedException();
        }

        public override bool skillChallenge(int sum)
        {
            throw new NotImplementedException();
        }

        public bool serrinChallenge(DicePool dicepool)
        {
            int val = serrinList[0];
            foreach(Dice d in dicepool)
            {
                if(d.value != val)
                {
                    return false;
                }
            }
            for(int i=0; i<serrinList.Count; ++i)
            {
                serrinList[i] = 1;
            }
            return true;
        }

        public bool mnChallenge(DicePool dicepool) //makano & narssis
        {
            for(int i=0; i<makanoList.Count; ++i)
            {
                if(makanoList[i] != dicepool[i].value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
