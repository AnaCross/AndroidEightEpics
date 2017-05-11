using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Licencjat
{
    [Activity(Label = "Eight Epics", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button chooseLevel, instruction, achivement;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            chooseLevel = FindViewById<Button>(Resource.Id.buttonPlay);
            instruction = FindViewById<Button>(Resource.Id.buttonInstruction);
            achivement = FindViewById<Button>(Resource.Id.buttonAchievement);

            chooseLevel.Click += (sender, e) => {
                var intent = new Intent(this, typeof(ChooseLevelActivity));
                StartActivity(intent);
            };
        }
    }
}

