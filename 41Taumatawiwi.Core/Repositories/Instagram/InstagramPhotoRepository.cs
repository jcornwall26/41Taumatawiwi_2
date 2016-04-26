using _41Taumatawiwi.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _41Taumatawiwi.Core.Repositories.Instagram
{
    public class InstagramPhotoRepository
    {
        private const string url = "https://www.instagram.com/Wakainga_Opononi/media/";

        public List<Photo> GetAll()
        {
            using (var httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync(url).Result;

                var jsonResult = result.Content.ReadAsStringAsync().Result;

                var root = JsonConvert.DeserializeObject<RootObject>(jsonResult);

                return root.items.Select(x => new Photo() { Url = x.images.standard_resolution.url, Caption = x.caption.text }).ToList();
            }

        }
    }
}
