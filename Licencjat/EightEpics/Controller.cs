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

        public void createDicePool()
        {

        }

        public void addDice()
        {

        }

        public void removeDice()
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
                activity.showHero[i].SkillText.Text = Resource.String.textHeroPower.ToString(resources.GetString(Resource.String.textHeroPower, newGame.heroList[i].descSkill));
            }
        }

        public void changeHeroLifePoint(Resources resources)
        {

        }

        public void createThreat()
        {

        }

        public void chooseHero()
        {

        }
    }
}