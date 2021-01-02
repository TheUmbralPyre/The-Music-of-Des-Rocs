using Android.App;
using Android.Content;
using AndroidX.AppCompat.App;
using System;
using System.Threading.Tasks;

namespace The_Music_of_Des_Rocs.Droid
{
    [Activity(Theme = "@style/MainTheme.Splash",
              MainLauncher = true,
              NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            // Display the json animation
            SetContentView(Resource.Layout.splash);
            // Initialize a Task
            Task startupWork = new Task(() => { SimulateStartupAsync(); });
            // Start the Task
            startupWork.Start();
        }

        private async void SimulateStartupAsync()
        {
            // Wait for a while
            await Task.Delay(1000);

            // Start the App
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
