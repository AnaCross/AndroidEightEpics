using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Heroes
{
    class HeroJarroth : Hero
    {
        public HeroJarroth()
        {
            livePoint = 5;
            name = "Jarroth";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.JAROTH;
            isExhausted = false;
            descSkill = "Choose up to 2 dice and flip their currently facedown side faceup";
        }
        public override void heroSkill(Round round)
        {
            Console.WriteLine("\nChange 2 dice. Write number 1 to 6:");
            //List<int> list = round.ui.adapter.readNumber(round);
            //foreach(int i in list)
            //{
           //     changeDie(round, i);
            //}
        }

        private void changeDie(Round round, int i)
        {
            foreach (Dice d in round.dicePool)
            {
                if (d.value == i)
                {
                    d.reverseDie(i);
                    break;
                }
            }
        }
    }
}
