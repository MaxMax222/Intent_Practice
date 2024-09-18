using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using Android.Content;

namespace Intent_Practice
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button Next;
        EditText Age, Username;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Init();
            SetClicks();
        }

        void SetClicks()
        {
            Next.Click += Next_Click;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Display_Info));
            intent.PutExtra("Age", Age.Text);
            intent.PutExtra("Username", Username.Text);
            StartActivity(intent);
        }

        void Init()
        {
            Next = FindViewById<Button>(Resource.Id.Next);
            Age = FindViewById<EditText>(Resource.Id.Age);
            Username = FindViewById<EditText>(Resource.Id.Username);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
