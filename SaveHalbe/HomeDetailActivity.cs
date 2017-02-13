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
using Newtonsoft.Json;
using SaveHalbe.Core.Model;
using SaveHalbe.Adapters;

namespace SaveHalbe
{
    [Activity(Label = "HomeDetailActivity")]
    public class HomeDetailActivity : Activity
    {
        private ListView personsView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.HomeDetail);

            personsView = FindViewById<ListView>(Resource.Id.personListView);

            string retrievedData = Intent.GetStringExtra("HomeDataService");
            var home = JsonConvert.DeserializeObject<Home>(retrievedData);

            PersonListAdapter personListadapter = new PersonListAdapter(this, home.Persons.ToList());

            personsView.Adapter = personListadapter;
        }

    }
}