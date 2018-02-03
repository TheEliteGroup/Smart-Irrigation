using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AISCM.Droid
{
    [Activity(Label = "AISCM", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
        
    {

        public string email = "";
        
        protected override void OnCreate(Bundle bundle)
        {
            
              TabLayoutResource = Resource.Layout.Tabbar;
                ToolbarResource = Resource.Layout.Toolbar;

                base.OnCreate(bundle);

                global::Xamarin.Forms.Forms.Init(this, bundle);
            OxyPlot.Xamarin.Forms.Platform.Android.PlotViewRenderer.Init();
            LoadApplication(new App());
             if(Global_portable.email!=null)
             {
                 Xamarin.Forms.NavigationPage np = new Xamarin.Forms.NavigationPage(new homepage());
             }
             else
             {
             StartActivity(typeof(Login));
             }
            //StartActivity(typeof(Login));
                
           

        }
        
    }
}

