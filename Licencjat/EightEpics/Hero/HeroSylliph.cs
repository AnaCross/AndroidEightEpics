using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Heroes
{
    class HeroSylliph : Hero
    {
        public HeroSylliph()
        {
            livePoint = 5;
            name = "Sylliph";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.SYLLIPH;
            isExhausted = false;
            descSkill = "Choose the result of a die. Increase or decrease by 1 all dice showing that result.";
        }
        public override void heroSkill(Round round)
        {
            Console.WriteLine("\nChange 1 result. Write number 1 to 6:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decrease or increase results? [D/I]:");
            string s = Console.ReadLine();
            int buf = i;
            foreach (Dice d in round.dicePool)
            {
                if(d.value == i)
                {
                    if(s == "D" || s == "d")
                    {
                        d.setValue(buf-1);
                        buf = i;
                    }else
                    {
                        d.setValue(buf + 1);
                        buf = i;
                    }
                }
            }
           // round.ui.showDicePool(round);
        }
    }
}
