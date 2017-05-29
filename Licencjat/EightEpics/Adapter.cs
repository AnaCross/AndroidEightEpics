using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightEpics.Challenges;
using EightEpics.Heroes;

namespace EightEpics
{
    class Adapter
    {
        public String readYesNo()
        {
            while (true)
            {
                switch (read().ToLower())
                {
                    case "y":
                        return "Y";
                    case "n":
                        return "N";
                    default:
                        Console.WriteLine("Breaking date. Write return [Y/N]:");
                        break;

                }
            }
        }

        public String readLevel()
        {
            while (true) {
                switch (read().ToLower())
                {
                    case "e":
                        return "E";
                    case "m":
                        return "M";
                    case "h":
                        return "H";
                    default:
                        Console.WriteLine("Breaking date. Write return [E/M/H]:");
                        break;
                }
            }
        }

        public EnumHeroName readHero()
        {
            while (true)
            {
                switch (read().ToLower())
                {
                    case "a":
                        return EnumHeroName.AURIEL;
                    case "c":
                        return EnumHeroName.CAROOSH;
                    case "g":
                        return EnumHeroName.GRON;
                    case "j":
                        return EnumHeroName.JAROTH;
                    case "k":
                        return EnumHeroName.KHANTOS;
                    case "l":
                        return EnumHeroName.LEAFWIND;
                    case "o":
                        return EnumHeroName.OPHINIA;
                    case "s":
                        return EnumHeroName.SYLLIPH;
                    default:
                        Console.WriteLine("Breaking date. Write return [A/C/G/J/K/L/O/S]:");
                        break;
                }
            }
        }

        public void writeChallenge(Threats threat, Challenge ch, int i)
        {
            switch (ch.getChallenge())
            {
                case EnumThreatChallenge.LESS:
                    Console.WriteLine("{0}D: {1}-", ch.getQuantityDice(), ch.getValue());
                    break;
                case EnumThreatChallenge.MORE:
                    Console.WriteLine("{0}D: {1}+", ch.getQuantityDice(), ch.getValue());
                    break;
                case EnumThreatChallenge.OTHER:
                    writeOtherChallange(threat, ch, i);
                    break;
                case EnumThreatChallenge.SAME_NUMBER:
                    Console.WriteLine("{0}D: Same number", ch.getQuantityDice());
                    break;
            }
        }

        private void writeOtherChallange(Threats threat, Challenge ch, int i)
        {
            switch (threat.iD)
            {
                case EnumThreatName.MAKANO:
                    Console.WriteLine("{0}D: 1 1 2 3 4 5 6 6", ch.getQuantityDice());
                    break;
                case EnumThreatName.NARSSIS:
                    Console.WriteLine("{0}D: 1 2 3 4 5 6", ch.getQuantityDice());
                    break;
                case EnumThreatName.SERRIN:
                    if (i == 0)
                    {
                        Console.WriteLine("{0}D: 6 6 6 6 6 6 6 6 : 1 1 1 1 1 1 1 1", ch.getQuantityDice());
                    }else
                    {
                        Console.WriteLine("{0}D: 1 1 1 1 1 1 1 1 : 6 6 6 6 6 6 6 6", ch.getQuantityDice());
                    }
                    break;
            }
        }

        public void writeHero(EnumGameLevel egl, Round round)
        {
            switch (egl)
            {
                case EnumGameLevel.EASY:
                    for (int i = 0; i < 8; ++i)
                    {
                        if (round.heroList[i].iD == round.currentHero.iD)
                        {
                            Console.Write("i:" + i + "\n");
                            Console.WriteLine("-> {0,-6} {1, -18} {2}", round.heroList[i].click, round.heroList[i].name, round.heroList[i].descSkill);
                        }else
                        {
                            if(round.heroList[i].isExhausted == true)
                            {
                                Console.WriteLine("EXHAUSTED {0,-3} {1, -18} {2}", round.heroList[i].click, round.heroList[i].name, round.heroList[i].descSkill);
                            }
                            else
                            {
                                Console.WriteLine("   {0,-6} {1, -18} {2}", round.heroList[i].click, round.heroList[i].name, round.heroList[i].descSkill);
                            }
                            
                        }
                    }
                    break;
                default:
                    for (int i = 0; i < 8; ++i)
                    {
                        if (round.heroList[i].iD == round.currentHero.iD)
                        {
                            Console.WriteLine("-> {0,-15} {1}", round.heroList[i].name, round.heroList[i].descSkill);
                        }
                        else
                        {
                            if (round.heroList[i].isExhausted == true)
                            {
                                Console.WriteLine("EXHAUSTED {0,-24} {1}", round.heroList[i].name, round.heroList[i].descSkill);
                            }
                            else
                            {
                                Console.WriteLine("{0,-15} {1}", round.heroList[i].name, round.heroList[i].descSkill);
                            }

                        }
                    }
                    break;
            }
        }

        private String read()
        {
            return Console.ReadLine();
        }

        public String readSR()
        {
            while (true)
            {
                switch (read().ToLower())
                {
                    case "s":
                        return "S";
                    case "r":
                        return "R";
                    default:
                        Console.WriteLine("Breaking date. Write return [S/R]:");
                        break;
                }
            }
        }

        public List<int> readNumber(Round round)
        {
            String[] numbers = read().Split(' ');
            List<int> listNumber = new List<int>();
            if (isGoodLong(numbers) == true)
            {
                foreach (String s in numbers)
                {
                    try
                    {
                        //Console.WriteLine(s);
                        listNumber.Add(Convert.ToInt32(s));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Breaking format. Write value 1 to 6: ");
                        readNumber(round);
                    }
                }
                if(isGoodValue(listNumber) == true)
                {
                    return listNumber;
                }else
                {
                    Console.WriteLine("Too big value. Write value 1 to 6: ");
                    readNumber(round);
                    return listNumber;
                }
                
            }else
            {
                Console.WriteLine("Too mach numbers. Write max 3 value 1 to 6: ");
                readNumber(round);
                return listNumber;
            }
        }

        private bool isGoodLong(String[] list)
        {
            int i = 0;
            bool b;
            foreach(String s in list)
            {
                i++;
            }
            return b = (i > 3) ? false : true;
        }

        private bool isGoodValue(List<int> list)
        {
            int i = 0;
            bool b;
            foreach (int s in list)
            {
                i = (s < 7 && s > 0) ? ++i : i;
                //Console.WriteLine("i={0}", i);
            }
            return b = (i == list.Count) ? true : false;
        }
        /*
        private bool isOnList(Round round)
        {
            foreach ()
            {

            }
        }
        */
    }
}
