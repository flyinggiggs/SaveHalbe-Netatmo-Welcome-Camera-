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
using SaveHalbe.Core;
using Newtonsoft.Json;
using SaveHalbeCore.Service;
using SaveHalbe.Core.Model;
using SaveHalbe.Adapters;

namespace SaveHalbe
{
    [Activity(Label = "WelcomeHomeActivity")]
    public class WelcomeHomeActivity : Activity
    {
        private ListView homesView;
        private List<Home> homes;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.WelcomeHome);

            homesView = FindViewById<ListView>(Resource.Id.homeListView);

            string retriedData = Intent.GetStringExtra("HomeDataService");
            var homeDateService = JsonConvert.DeserializeObject<HomeDataService>(retriedData);

            var homeRepository = homeDateService.GetHomeRepository();

            this.homes = homeRepository.GetHome();

            HomeListAdapter homeListAdapter = new HomeListAdapter(this, this.homes);

            homesView.Adapter = homeListAdapter;

            homesView.ItemClick += HomeListView_ItemClick;
        }


        private void HomeListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var home = homes[e.Position];

            var intent = new Intent(this, typeof(HomeDetailActivity));

            string serializedData = JsonConvert.SerializeObject(home);
            intent.PutExtra("homeDetail", serializedData);

            StartActivityForResult(intent, 100);
        }
    }

}