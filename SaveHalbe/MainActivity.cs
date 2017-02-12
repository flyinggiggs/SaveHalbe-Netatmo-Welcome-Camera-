using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using SaveHalbe.Core.Helper;
using SaveHalbe.Core.Model;
using SaveHalbeCore.Repository;
using SaveHalbeCore.Service;
using System;


namespace SaveHalbe
{
    [Activity(Label = "SaveHalbe", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button loginButton;
        private EditText userID;
        private EditText password;
        //private LoginHelper loginHelper;
        private HomeDataService homeDataService;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            FindViews();

            HandleEvents();
        }

        private void FindViews()
        {
            //Initializing button from layout
            this.loginButton = FindViewById<Button>(Resource.Id.login);
            this.userID = FindViewById<EditText>(Resource.Id.userId);
            this.password = FindViewById<EditText>(Resource.Id.password);
        }

        private void HandleEvents()
        {
            loginButton.Click += LoginButton_Click;       
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string accessToken = LoginHelper.ValidateLogin(userID.Text, password.Text);

            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                RetrievedData retrievedData = RetrieveDataHelper.GetData(accessToken);
                homeDataService = new HomeDataService(retrievedData);

                var intent = new Intent(this, typeof(WelcomeHomeActivity));
                string serializedData = JsonConvert.SerializeObject(homeDataService);
                intent.PutExtra("HomeDataService", serializedData);
                StartActivity(intent);
            }
            else
            {
                Android.Widget.Toast.MakeText(this, "Login Failed! Please Check ID or Password.", Android.Widget.ToastLength.Short).Show();
            }

        }
    }
}

