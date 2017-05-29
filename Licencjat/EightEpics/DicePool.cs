using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpics
{
    class DicePool : List<Dice>
    {
        //public List<Dice> dicePool;
        public DicePool(int qua)
        {
            //dicePool = new List<Dice>();
            for(int i=0; i<qua; ++i)
            {
                Add(new Dice());
            }
            this.Sort();
        }

        public void SerrinDicePool()
        {
            for (int i=0; i<this.Count; ++i)
            {
                this[i].setValue(6);
            }
        }

        public void rerollDicePool()
        {
            foreach(Dice d in this)
            {
                d.reroll();
                Console.Write(d.value+" ");
            }
            this.Sort();
        }

        public void rerollDicePool(List<int> fewDice)
        {
            foreach(int d in fewDice)
            {
               for(int i=0; i<this.Count; ++i)
                {
                    if(d == this[i].value)
                    {
                        this[i].reroll();
                        break;
                    }
                }
            }
            this.Sort();
        }

        private new void Sort()
        {
            bool end = false;
            Dice buf;
            int sum = 0;
            while (end == false)
            {
                sum = 0;
                for (int i = 0; i < this.Count - 1; ++i)
                {
                    if (this[i].value > this[i + 1].value)
                    {
                        buf = this[i];
                        this[i] = this[i + 1];
                        this[i + 1] = buf;
                        sum++;
                    }
                }
                end = sum == 0 ? true : false;
            }
        }
        public int count()
        {
            int sum = 0;
            foreach(Dice d in this)
            {
                sum += d.value;
            }
            return sum;
        }
    }
}
