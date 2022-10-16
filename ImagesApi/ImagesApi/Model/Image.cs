using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static System.Net.WebRequestMethods;

namespace ImagesApi.Model
{
    public class Provider
    {
        public string name { get; set; }
        public string favIcon { get; set; }
        public string favIconBase64Encoding { get; set; }
    }

    public class Value
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string thumbnail { get; set; }
        public int thumbnailHeight { get; set; }
        public int thumbnailWidth { get; set; }
        public object base64Encoding { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Provider provider { get; set; }
        public string imageWebSearchUrl { get; set; }
        public string webpageUrl { get; set; }
    }

    public class Image
    {
        public string _type { get; set; }
        public int totalCount { get; set; }
        public IList<Value> value { get; set; }
    }

    //public class Image
    //{
    //    public string _type { get; set; }
    //    public int totalCount { get; set; }
    //    public IList<Value> value { get; set; }
    //}
    public class Response
    {
        public IList<Image> images { get; set; }
    }


    public class ImageRoot
    {
        public Response response { get; set; }

        public static string GenerateUrl(string name)
        {
            String[] words = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            name = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (i + 1 == words.Length)
                {
                    name += words[i];
                    break;
                }
                name += words[i] + "%20";

            }

            return $"https://contextualwebsearch-websearch-v1.p.rapidapi.com/api/Search/ImageSearchAPI?q={name}&pageNumber=1&pageSize=1&autoCorrect=true"; 
        }



    }



}
