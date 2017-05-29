using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Heroes
{
    class HeroAuriel : Hero
    {
        public HeroAuriel()
        {
            livePoint = 5;
            name = "Auriel";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.AURIEL;
            isExhausted = false;
            descSkill = "Restore 1 life point to another avatar, then reroll up to 2 dice.";
        }

        public override void heroSkill(Round round)
        {
            throw new NotImplementedException();
        }
        /*
public override void heroSkill(Round round)
{
   EnumHeroName ehn;
   Console.WriteLine("Change hero to restore 1 life point [A/C/G/J/K/L/O/S]:");
   foreach(Hero h in round.heroList)
   {
       Console.WriteLine(h.click + h.name);
   }
   ehn = round.ui.adapter.readHero();
   foreach(Hero h in round.heroList)
   {
       if(h.iD == ehn)
       {
           h.livePoint++;
       }
   }
   Console.WriteLine("\nChange max 2 dice to reroll. Write number 1 to 6:");
   round.reroll(round.ui.adapter.readNumber(round));
   round.ui.showDicePool(round);
}
*/
    }
}
