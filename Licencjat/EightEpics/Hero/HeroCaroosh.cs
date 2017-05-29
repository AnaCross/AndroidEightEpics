using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Heroes
{
    class HeroCaroosh : Hero
    {
        public HeroCaroosh()
        {
            livePoint = 6;
            name = "Caroosh";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.CAROOSH;
            isExhausted = false;
            descSkill = "Change the result od 1 die to a 1.";
        }
        public override void heroSkill(Round round)
        {
            Console.WriteLine("\nChange 1 die. Write number 1 to 6:");
            int i = Convert.ToInt32(Console.ReadLine());
            foreach(Dice d in round.dicePool)
            {
                if(d.value == i)
                {
                    d.setValue(1);
                    break;
                }
            }
            //round.ui.showDicePool(round);
        }
    }
}
