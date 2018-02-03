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

namespace AISCM.Droid
{
    [Activity(Label = "farmer_home")]
    public class farmer_home : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.farmer_home);
            Button monitorstatus = FindViewById<Button>(Resource.Id.button1);
            monitorstatus.Click += delegate
            {
                StartActivity(typeof(monitorstatus));
            };

        }
    }
}