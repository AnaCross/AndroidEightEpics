using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Heroes
{
    class HeroKhantos : Hero
    {
        public HeroKhantos()
        {
            livePoint = 6;
            name = "Khantos";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.KHANTOS;
            isExhausted = false;
            descSkill = "Add 1 die to or remove w die from the dice pool.";
        }
        public override void heroSkill(Round round)
        {
            Console.WriteLine("Add or remove 1 die [A/R]:");
            String s = Console.ReadLine();
            if (s == "a" || s == "A")
            {
                round.dicePool.Add(new EightEpics.Dice());
                //round.ui.showDicePool(round);
            }
            else
            {
                Console.WriteLine("\nChange 1 die. Write number 1 to 6:");
                int i = Convert.ToInt32(Console.ReadLine());
                for(int j=0; j<round.dicePool.Count; ++j)
                {
                    if (round.dicePool[j].value == i)
                    {
                        round.dicePool.Remove(round.dicePool[j]);
                    }
                }
                //round.ui.showDicePool(round);
            }
        }
    }
}
