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

namespace Licencjat
{
    [Activity(Label = "Choose Level")]
    public class ChooseLevelActivity : Activity
    {
        Button easy, medium, hard;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Level);
            easy = FindViewById<Button>(Resource.Id.buttonEasy);
            medium = FindViewById<Button>(Resource.Id.buttonMedium);
            hard = FindViewById<Button>(Resource.Id.buttonHard);
            

            easy.Click += (sender, e) => {
                var intent = new Intent(this, typeof(GameActivity));
                intent.PutExtra("level", (int)EnumGameLevel.EASY);
                StartActivity(intent);
            };

            medium.Click += (sender, e) => {
                var intent = new Intent(this, typeof(GameActivity));
                intent.PutExtra("level", (int)EnumGameLevel.MEDIUM);
                StartActivity(intent);
            };

            hard.Click += (sender, e) => {
                var intent = new Intent(this, typeof(GameActivity));
                intent.PutExtra("level", (int)EnumGameLevel.HARD);
                StartActivity(intent);
            };
        }
    }
}