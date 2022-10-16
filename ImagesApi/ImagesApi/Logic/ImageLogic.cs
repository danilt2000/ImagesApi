using ImagesApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Image = ImagesApi.Model.Image;

namespace ImagesApi.Logic
{
    public class ImageLogic
    {
        public static async Task<string> GetImage(string name)
        {
            string urlImage = string.Empty;
            string url = ImageRoot.GenerateUrl(name);

            //using (HttpClient client = new HttpClient())
            //{
            //    var response = await client.GetAsync(url);
            //    var json = await response.Content.ReadAsStringAsync();
            //    var venueRoot = JsonConvert.DeserializeObject<VenueRoot>(json);

            //    images = venueRoot.response.venues as List<Venue>;
            //}


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
    {
        { "X-RapidAPI-Key", "a7cad4f6dfmshce500d0f32c61d8p140758jsnfb0692b4be37" },
        { "X-RapidAPI-Host", "contextualwebsearch-websearch-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
              //var  imageRoot = JsonConvert.DeserializeObject<Image>(json);
              Image image = JsonConvert.DeserializeObject<Image>(json);
                urlImage= image.value[0].thumbnail;

                //images = imageRoot.response.images as List<Image>;

            }





            return urlImage;

        }




    }
}
