
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

namespace Intent_Practice
{
	[Activity (Label = "Display_Info")]			
	public class Display_Info : Activity
	{
		TextView Greeting, Age;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView(Resource.Layout.display_info);
			// Create your application here
			Init();
			Greeting.Text += Intent.GetStringExtra("Username") ?? "Guest";
            Age.Text += Intent.GetStringExtra("Age") ?? "0";
        }

        void Init()
		{
			Greeting = FindViewById<TextView>(Resource.Id.greeting);
			Age = FindViewById<TextView>(Resource.Id.AgeInfo);
		}
	}
}

