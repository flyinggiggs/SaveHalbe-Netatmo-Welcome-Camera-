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
using SaveHalbe.Utility;
using SaveHalbe.Core.Model;

namespace SaveHalbe
{
    [Activity(Label = "AnalyzedPictureActivity")]
    public class AnalyzedPictureActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AnalyzedPicture);

            string id = Intent.GetStringExtra("faceId");
            string key = Intent.GetStringExtra("faceKey");

            var byteImage = ImageHelper.GetBytePicture(id, key);
            var data = FaceDetectHelper.MakeRequest(byteImage);

            FindViews(data);
        }

        private void FindViews(DetectedFace data)
        {
            if(data == null)
            {
                FindViewById<TextView>(Resource.Id.analyzation).Text = "Analyzation Failed. Picture quality is too low to analyze.";
                return;
            }
            else
            {
                FindViewById<TextView>(Resource.Id.analyzation).Text = "Analyzation Completed.";
            }

            //Initializing button from layout
            FindViewById<TextView>(Resource.Id.age).Text = "Age: " + data.faceAttributes.age.ToString();
            FindViewById<TextView>(Resource.Id.gender).Text = "Gender: " + data.faceAttributes.gender;
            FindViewById<TextView>(Resource.Id.smile).Text = "Smile: " + Convert.ToDecimal(data.faceAttributes.smile) * 100 + "%";
            FindViewById<TextView>(Resource.Id.beard).Text = "Beard: " + Convert.ToDecimal(data.faceAttributes.facialHair.beard) * 100 + "%";
            FindViewById<TextView>(Resource.Id.mustache).Text = "Mustache: " + Convert.ToDecimal(data.faceAttributes.facialHair.beard) * 100 + "%";
            FindViewById<TextView>(Resource.Id.sideburns).Text = "Sideburns: " + Convert.ToDecimal(data.faceAttributes.facialHair.sideburns) * 100 + "%";
            //FindViewById<TextView>(Resource.Id.glasses).Text = "Glasses: " + string.Format("{0}", string.IsNullOrWhiteSpace(data.glasses) ? "None" : data.glasses);
        }
    }
}