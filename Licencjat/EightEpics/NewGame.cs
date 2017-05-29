using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightEpics.Challenges;
using EightEpics.Heroes;
using Android.App;

namespace EightEpics
{
    class NewGame
    {
        static NewGame newGame = new NewGame();
        bool isHeroRandom;
        int numberThreats = 0;
        public List<Hero> heroList = new List<Hero>();
        public List<Hero> randomHeroList = new List<Hero>();
        List<Threats> threatList = new List<Threats>();
        public List<Threats> randomThreatList = new List<Threats>();
        List<Challenge> challengeList = new List<Challenge>();
        static Random rnd = new Random();
        public EnumGameLevel gameLevel;
        public Round round;
       // Array values = Enum.GetValues(typeof(EnumGameLevel));
        

        private NewGame() { }
        public static NewGame CreateNewGame()
        {
            return newGame;
        }

        public void setLevel(EnumGameLevel gl)
        {
            switch (gl)
            {
                case EnumGameLevel.EASY:
                    isHeroRandom = false;
                    numberThreats = 5;
                    gameLevel = gl;
                    break;
                case EnumGameLevel.MEDIUM:
                    isHeroRandom = true;
                    numberThreats = 5;
                    gameLevel = gl;
                    break;
                case EnumGameLevel.HARD:
                    isHeroRandom = true;
                    numberThreats = 8;
                    gameLevel = gl;
                    break;
            }
            createHeroList();
            createThreatList();
            round = new Round(randomThreatList[0], heroList);
        }

        void createThreatList()
        {
            createChallenge();
            createThreat();
            int hero;
            while (randomThreatList.Count != numberThreats)
            {
                hero = rnd.Next(8);
                if (randomThreatList.Exists(h => h.ident == hero).Equals(false))
                {
                    randomThreatList.Add(threatList[hero]);
                    //Console.WriteLine(threatList[hero].name);
                }
            }

        }

        void createHeroList()
        {
            //EnumGameLevel randomHero; 
            if (isHeroRandom == false)
            {
                createHero();
            }
            else
            {
                createHero();
                int hero;
                //Console.WriteLine("Hero List");
                heroList = new List<Hero>();
                while (randomHeroList.Count != 8)
                {
                    //randomHero = (EnumGameLevel)values.GetValue(rnd.Next(values.Length));
                    hero = rnd.Next(8);
                    if ((randomHeroList.Exists(h => h.iD == heroList[hero].iD)) == false)
                    {
                        randomHeroList.Add(heroList[hero]);
                        //Console.WriteLine(heroList[hero].name);
                    }
                }
                //Console.ReadKey();
                heroList.Clear();
                for(int i=0; i<8; ++i)
                {
                    heroList.Add(randomHeroList[i]);
                    //Console.WriteLine(heroList[i].name);
                }
                //Console.ReadKey();
            }
        }

        void createHero()
        {
            heroList = new List<Hero>{
                new HeroAuriel(),
                new HeroCaroosh(),
                new HeroGron(),
                new HeroJarroth(),
                new HeroKhantos(),
                new HeroLeafwind(),
                new HeroOphinia(),
                new HeroSylliph()
            };
        }

        void createChallenge()
        { challengeList = new List<Challenge> {
                new ChallengeLess(),
                new ChallengeMore(),
                new ChallengeSameNumber(),
                new ChallengeOther(),
            };
            
        }


        void createThreat()
        {
            Threats Broxix = new Threats("Broxix", 8, EnumThreatName.BROXIX,0);
            Threats Durge = new Threats("Durge", 8, EnumThreatName.DURGE, 1);
            Threats Hronthar = new Threats("Hronthar", 3, EnumThreatName.HRONTHAR,2);
            Threats Makano = new Threats("Makano", 4, EnumThreatName.MAKANO,3);
            Threats Narssis = new Threats("Narssis", 4, EnumThreatName.NARSSIS,4);
            Threats Pirn = new Threats("Pirn", 3, EnumThreatName.PIRN,5);
            Threats Serrin = new Threats("Serrin", 2, EnumThreatName.SERRIN,6);
            Threats Uluwash = new Threats("Uluwash", 3, EnumThreatName.ULUWASH,7);
            //Console.WriteLine("Broxix");
            Broxix.setChallengeList(new ChallengeMore());
            Broxix.completeChallenge(15, 3);
            //Console.WriteLine("Durge");
            //Durge.setChallengeList(new Challenge(EnumThreatChallenge.LESS));
            Durge.completeChallenge(1, 5, 1, new ChallengeLess());
            Durge.completeChallenge(2, 2, 2, new ChallengeLess());
            Durge.completeChallenge(3, 1, 3, new ChallengeLess());
            //Console.WriteLine("Hronthar");
            //Hronthar.setChallengeList(new Challenge(EnumThreatChallenge.MORE));
            Hronthar.completeChallenge(32, 1, 6, new ChallengeMore());
            Hronthar.completeChallenge(40, 1, 7, new ChallengeMore());
            Hronthar.completeChallenge(48, 1, 8, new ChallengeMore());
            //Console.WriteLine("Makano");
            //Makano.setChallengeList(challengeList);
            Makano.completeChallenge(10, 1, 8, new ChallengeLess());
            Makano.completeChallenge(0, 1, 8, new ChallengeOther());
            Makano.completeChallenge(45, 1, 8, new ChallengeMore());
            Makano.completeChallenge(0, 1, 8, new ChallengeSameNumber());
            //Console.WriteLine("Narssis");
            Narssis.setChallengeList(new ChallengeOther());
            Narssis.completeChallenge(0, 6);
            //Console.WriteLine("Pirn");
            //Pirn.setChallengeList(new Challenge(EnumThreatChallenge.SAME_NUMBER));
            Pirn.completeChallenge(0, 1, 6, new ChallengeSameNumber());
            Pirn.completeChallenge(0, 1, 7, new ChallengeSameNumber());
            Pirn.completeChallenge(0, 1, 8, new ChallengeSameNumber());
            //Console.WriteLine("Serrin");
            Serrin.setChallengeList(new ChallengeOther());
            Serrin.completeChallenge(0, 8);
            //Console.WriteLine("Uluwash");
            //Uluwash.setChallengeList(new Challenge(EnumThreatChallenge.LESS));
            //warość, liczba_challenge, liczba kości
            Uluwash.completeChallenge(10, 1, 6, new ChallengeLess());
            Uluwash.completeChallenge(9, 1, 7, new ChallengeLess());
            Uluwash.completeChallenge(8, 1, 8, new ChallengeLess());

            threatList.Add(Broxix);
            threatList.Add(Durge);
            threatList.Add(Hronthar);
            threatList.Add(Makano);
            threatList.Add(Narssis);
            threatList.Add(Pirn);
            threatList.Add(Serrin);
            threatList.Add(Uluwash);
        }
    }
}
