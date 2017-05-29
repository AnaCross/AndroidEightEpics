using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightEpics.Heroes;

namespace EightEpics
{
    class Round
    {
        public Threats threat { get; }
        public DicePool dicePool { get; private set; }
        public List<Hero> heroList { get; }
        public Hero currentHero { get; private set; }
        public int numberChallange { get; private set; }
        public int countDicePool { get; }

        public Round(Threats th, List<Hero> hL)
        {
            threat = th;
            heroList = hL;
            numberChallange = 0;
            currentHero = heroList[0];
            if (threat.iD.Equals(EnumThreatName.SERRIN))
            {
                createDicePool();
                dicePool.SerrinDicePool();
            }
            else
            {
                createDicePool();
            }
            countDicePool = dicePool.Count;
        }

        void createDicePool()
        {
            dicePool = new DicePool(threat.getChallenge(numberChallange).getQuantityDice());
        }

        public void changeHero(EnumHeroName hero)
        {
            for(int i=0; i<heroList.Count; ++i)
            {
                if(hero == heroList[i].iD)
                {
                    currentHero = heroList[i];
                }
            }
        }

        public void nextHero()
        {
            int i = 0;
            Hero buf = currentHero;

            if (currentHero == heroList.Last())
            {
                while (heroList[i] != heroList.Last())
                {
                    if (heroList[i].isExhausted == false)
                    {
                        currentHero = heroList[i];
                        break;
                    }
                    ++i;
                }
                gameOver();
            }
            else
            {
                i = 0;
                do
                {
                    if (currentHero == heroList[i] && currentHero != heroList.Last())
                    {
                        currentHero = heroList[i + 1];
                        heroList[i + 1].isExhausted = true;
                    }
                    else
                    {
                        i++;
                    }
                } while (currentHero == buf);
            }
        }
        public void printCurrentHero()
        {
            Console.WriteLine(currentHero.name);
        }

        public void exhaustedHero()
        {
            currentHero.isExhausted = currentHero.isExhausted == false ? true : false;
        }
        private void gameOver()
        {
            //TODO game over
            Console.WriteLine("Game over");
            Console.ReadKey();
        }

        public void reroll(List<int> list)
        {
            dicePool.rerollDicePool(list);
        }

        public void nextChallenge()
        {
            numberChallange++;
        }
    }
}
