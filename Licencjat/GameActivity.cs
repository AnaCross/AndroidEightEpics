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
using Licencjat.EightEpics;

namespace Licencjat
{
    public struct GUIHero
    {
        LinearLayout container;
        public TextView NameText;
        public TextView LifePointsText;
        public TextView SkillText;
        public Button UseSkillbutton;
        public GUIHero(LinearLayout container)
        {
            this.container = container;
            NameText = (TextView)container.GetChildAt(0);
            LifePointsText = (TextView)container.GetChildAt(1);
            SkillText = (TextView)container.GetChildAt(2);
            UseSkillbutton = (Button)container.GetChildAt(3);
        }
    }
    [Activity(Theme = "@android:style/Theme.NoTitleBar")]
    public class GameActivity : Activity
    {
        public List<GUIHero> showHero = new List<GUIHero>();
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            /*
            Context context = this;
            createHeroes(context.Resources);
            */
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Game);

            NewGame newGame = NewGame.CreateNewGame();
            EnumGameLevel level = (EnumGameLevel)Intent.GetIntExtra("level",-1);
            newGame.setLevel(level);
            LinearLayout HeroPanel = FindViewById<LinearLayout>(Resource.Id.HeroPanel);
            for (int i=0; i<HeroPanel.ChildCount; ++i)
            {
                LinearLayout dziecko = (LinearLayout)HeroPanel.GetChildAt(i);
                showHero.Add(new GUIHero(dziecko));
            }
            Context context = this;
            Controller controller = new Controller(newGame, this);  
            controller.createHeroes(context.Resources);
            // Create your application here
        }

        
    }
}