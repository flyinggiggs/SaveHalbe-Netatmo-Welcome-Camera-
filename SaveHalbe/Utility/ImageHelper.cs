using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using SaveHalbe.Core.Constants;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using System.Net;

namespace SaveHalbe.Utility
{
    public class ImageHelper
    {
        public static Bitmap GetPicture(string imageId, string key)
        {
            Bitmap imageBitmap = null;
            try
            {
                using (var client = new HttpClient())
                {
                    var content = new Dictionary<string, string>
                    {
                        {"image_id", imageId},
                        {"key", key}
                    };

                    var encodedAccessToken = new FormUrlEncodedContent(content);

                    var response = client.PostAsync(Url.getCameraPictureUrl, encodedAccessToken);
                    
                    var imageBytes = response.Result.Content.ReadAsByteArrayAsync();
                    imageBytes.Wait();

                    var s = response.Result.Content.ReadAsStringAsync();

                    if (imageBytes != null && imageBytes.Result.Length > 0)
                    {
                        imageBitmap = BitmapFactory.DecodeByteArray(imageBytes.Result, 0, imageBytes.Result.Length);
                    }
                }
            }
            catch (Exception)
            {
                // Handle Exception
            }

            return imageBitmap;
        }

        public static byte[] GetBytePicture(string imageId, string key)
        {
            byte[] imageBitmap = null;
            try
            {
                using (var client = new HttpClient())
                {
                    var content = new Dictionary<string, string>
                    {
                        {"image_id", imageId},
                        {"key", key}
                    };

                    var encodedContent = new FormUrlEncodedContent(content);

                    var response = client.PostAsync(Url.getCameraPictureUrl, encodedContent);

                    var imageBytes = response.Result.Content.ReadAsByteArrayAsync();
                    imageBytes.Wait();
                    imageBitmap = imageBytes.Result;
                }
            }
            catch (Exception)
            {
                // Handle Exception
            }
            return imageBitmap;
        }

        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }

        public static Bitmap GetImageBitmapFromFilePath(string fileName, int width, int height)
        {
            // First we get the the dimensions of the file on disk
            BitmapFactory.Options options = new BitmapFactory.Options { InJustDecodeBounds = true };
            BitmapFactory.DecodeFile(fileName, options);

            // Next we calculate the ratio that we need to resize the image by
            // in order to fit the requested dimensions.
            int outHeight = options.OutHeight;
            int outWidth = options.OutWidth;
            int inSampleSize = 1;

            if (outHeight > height || outWidth > width)
            {
                inSampleSize = outWidth > outHeight
                                   ? outHeight / height
                                   : outWidth / width;
            }

            // Now we will load the image and have BitmapFactory resize it for us.
            options.InSampleSize = inSampleSize;
            options.InJustDecodeBounds = false;
            Bitmap resizedBitmap = BitmapFactory.DecodeFile(fileName, options);

            return resizedBitmap;
        }
    }
}