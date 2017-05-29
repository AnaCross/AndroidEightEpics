using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFinish = false;
            
            /*
             * 1. Roll dice pull
             * 2. Change hero
             * 3. Reroll 3 dice
             * 4. Use skill
             */
            NewGame newGame = NewGame.CreateNewGame();
            //UI ui = UI.createUI();
            //ui.hello();
           // newGame.setLevel(ui.changeLevel());
            //Round round = new Round(newGame.randomThreatList[0], newGame.heroList);
            //ui.startRound(round);
            //round.printCurrentHero();
            //round.heroList[0].isExhausted = true;
            while (isFinish == false)
            {
            
            //for (int i = 0; i < 10; ++i)
            //{
                if (newGame.gameLevel.Equals(EnumGameLevel.EASY))
                {
                    //round.changeHero(ui.changeHero());
                }
                else
                {
                   // ui.actualHero(round);
                   // round.nextHero();
                    
                    //round.printCurrentHero();
                }
            //}
            }
            Console.ReadKey();
        }
    }
}
