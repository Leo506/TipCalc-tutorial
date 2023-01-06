﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using TipCalc.Core;
using TipCalc.Forms.UI;

namespace TipCalc.Forms.Droid
{
    [Activity(
        Label = "TipCalc.Forms.Droid", 
        Theme = "@style/MyTheme", 
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity : MvxFormsAppCompatActivity<Setup, App, FormsApp>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);
        }
    }
}