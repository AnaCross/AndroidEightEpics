using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics
{
    class Dice
    {
        int[] wall = {1, 2, 3, 4, 5, 6};
        public int value { get; private set; }
        static Random rnd = new Random();

        public Dice()
        {
            value = wall[rnd.Next(0, 6)];
        }

        public int reroll()
        {
            value = wall[rnd.Next(0, 6)];
            return value;
        }
        public void setValue(int value)
        {
            this.value = value;
        }

        public void reverseDie(int i)
        {
            switch (i)
            {
                case 1:
                    value = 6;
                    break;
                case 2:
                    value = 5;
                    break;
                case 3:
                    value = 4;
                    break;
                case 4:
                    value = 3;
                    break;
                case 5:
                    value = 2;
                    break;
                case 6:
                    value = 1;
                    break;
            }
        }
    }
}
