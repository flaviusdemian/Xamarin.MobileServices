using Android.App;
using Android.OS;

namespace com.fundora.mobileservices.demo
{
    [Activity(Label = "Test Mobile Services", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_login);
        }
    }
}