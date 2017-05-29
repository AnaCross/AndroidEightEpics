using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics.Heroes
{
    class HeroOphinia : Hero
    {
        public HeroOphinia()
        {
            livePoint = 4;
            name = "Ophinia";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.OPHINIA;
            isExhausted = false;
            descSkill = "Use the power of another avatar (ready or exhausted)";
        }
        public override void heroSkill(Round round)
        {
            EnumHeroName ehn;
            Console.WriteLine("Change hero to use skill [A/C/G/J/K/L/O/S]:");
            foreach (Hero h in round.heroList)
            {
                Console.WriteLine(h.click + h.name);
            }
            //ehn = round.ui.adapter.readHero();
            foreach (Hero h in round.heroList)
            {
               // if (h.iD == ehn)
               // {
                    h.heroSkill(round);
               // }
            }
        }
    }
}
