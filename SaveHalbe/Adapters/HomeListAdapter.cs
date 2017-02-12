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
using SaveHalbe.Core.Model;

namespace SaveHalbe.Adapters
{
    public class HomeListAdapter : BaseAdapter<Home>
    {
        private List<Home> items;
        private Activity context;

        public HomeListAdapter(Activity context, List<Home> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override Home this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];

            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleDropDownItem1Line, null);
            }

            // set view properties to reflect data for the given row
            convertView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = string.Format("{0}, {1}, {2}", item.Place.City, item.Place.Country, item.Name);

            return convertView;
        }
    }
}