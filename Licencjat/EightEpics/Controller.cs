using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EightEpics;
using Android.Content.Res;
using EightEpics.Challenges;

namespace Licencjat.EightEpics
{
    class Controller
    {
        NewGame newGame;
        GameActivity activity;
        public Controller(NewGame NG, GameActivity AC)
        {
            newGame = NG;
            activity = AC;
        }

        public void createDicePool(Resources resources)
        {
            int sum = 0;
            LinearLayout layout = activity.FindViewById<LinearLayout>(Resource.Id.diceLayout);
            for (int i=0; i<newGame.round.countDicePool; ++i)
            {
                TextView tv = new TextView(activity);
                tv.Text = newGame.round.dicePool[i].value.ToString();
                sum += newGame.round.dicePool[i].value;
                layout.AddView(tv);
            }
            TextView suma = activity.FindViewById<TextView>(Resource.Id.textSum);
            suma.Text = sum.ToString();
        }

        public void addDie()
        {

        }

        public void removeDie()
        {

        }

        public void changeDie()
        {

        }

        public void showSum()
        {

        }

        public void createHeroes(Resources resources)
        {
            for (int i = 0; i < 8; ++i) {
                activity.showHero[i].NameText.Text=Resource.String.textNameHero.ToString(resources.GetString(Resource.String.textNameHero, newGame.heroList[i].name));
                activity.showHero[i].LifePointsText.Text = Resource.String.textHeroLifePoint.ToString(resources.GetString(Resource.String.textHeroLifePoint, newGame.heroList[i].livePoint, newGame.heroList[i].livePoint));
                //activity.showHero[i].SkillText.Text = Resource.String.textHeroPower.ToString(resources.GetString(Resource.String.textHeroPower, newGame.heroList[i].descSkill));
            }
        }

        public void changeHeroLifePoint(Resources resources)
        {

        }

        public void createThreat(Resources resources)
        {
            TextView thName = activity.FindViewById<TextView>(Resource.Id.textNameThreat);
            thName.Text = Resource.String.textNameThreat.ToString(resources.GetString(Resource.String.textNameThreat, newGame.round.threat.name));
            LinearLayout layout = activity.FindViewById<LinearLayout>(Resource.Id.ThreatPanel);
            Console.WriteLine("jestem w createThreat");
            for (int i=0; i<newGame.round.threat.getChallengeList().Count; ++i)
            {
                //Console.WriteLine(i + " przed");
                layout.AddView(switchThreat(newGame.round.threat.getChallenge(i).getChallenge(), resources, i));
                //Console.WriteLine(i + " po");
                //tv.Text = Resource.String.text.ToString(resources.GetString(Resource.String.textNameThreat, newGame.round.threat.name));
            }
        }

        TextView switchThreat(EnumThreatChallenge ch, Resources resources, int i)
        {
            //Console.WriteLine("weszło " + i);
            TextView tv = new TextView(activity);
            switch (ch)
            {
                case EnumThreatChallenge.LESS:
                    Console.WriteLine("Less : " + newGame.round.threat.getChallenge(i).getValue());
                    tv.Text = String.Format(resources.GetString(Resource.String.textChallengeLess, newGame.round.threat.getChallenge(i).getQuantityDice(), newGame.round.threat.getChallenge(i).getValue()));
                    break;
                case EnumThreatChallenge.MORE:
                    Console.WriteLine("More : " + newGame.round.threat.getChallenge(i).getValue());
                    tv.Text = resources.GetString(Resource.String.textChallengeMore, newGame.round.threat.getChallenge(i).getQuantityDice(), newGame.round.threat.getChallenge(i).getValue());
                    break;
                case EnumThreatChallenge.SAME_NUMBER:
                    tv.Text = String.Format(resources.GetString(Resource.String.textChallengeSameNumber, newGame.round.threat.getChallenge(i).getQuantityDice()));
                    break;
                case EnumThreatChallenge.OTHER:
                    switch (newGame.round.threat.name)
                    {
                        case "Serrin":
                            if(i==0)
                                tv.Text = resources.GetString(Resource.String.textChallengeSerrin1); //.ToString(resources.GetString(Resource.String.textChallengeLess, newGame.round.threat.getChallenge(i).getQuantityDice()));
                            else
                                tv.Text = resources.GetString(Resource.String.textChallengeSerrin2);
                            break;
                        case "Narssis":
                            tv.Text = Resource.String.textChallengeNarssis.ToString(resources.GetString(Resource.String.textChallengeNarssis, newGame.round.threat.getChallenge(i).getQuantityDice()));
                            break;
                        case "Makano":
                            tv.Text = Resource.String.textChallengeMakano.ToString(resources.GetString(Resource.String.textChallengeMakano, newGame.round.threat.getChallenge(i).getQuantityDice()));
                            break;
                    }
                    break;
            }
            return tv;
        }

        public void showHeroSkill()
        {

        }

        public void chooseHero()
        {

        }
    }
}