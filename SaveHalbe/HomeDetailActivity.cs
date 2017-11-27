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
        private Home home;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.HomeDetail);

            personsView = FindViewById<ListView>(Resource.Id.personListView);

            string retrievedData = Intent.GetStringExtra("homeDetail");
            home = JsonConvert.DeserializeObject<Home>(retrievedData);

            PersonListAdapter personListadapter = new PersonListAdapter(this, home.Persons.ToList());

            personsView.Adapter = personListadapter;

            personsView.ItemClick += PersonsView_ItemClick;
        }

        private void PersonsView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var id = home.Persons[e.Position].Face.Id;
            var key = home.Persons[e.Position].Face.Key;

            var intent = new Intent(this, typeof(AnalyzedPictureActivity));

            intent.PutExtra("faceId", id);
            intent.PutExtra("faceKey", key);

            StartActivityForResult(intent, 100);
        }
    }
}