using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FirstApi.Model;
using Newtonsoft.Json;

namespace FirstApi.Services
{
    public class GetRandomDis : IGetRandomDis
    {
        public async Task<CharacterDataWrapper> ReturnRandomDisBasedOnTag(Search model)
        {       
            const string disKey = "";

            using (var client = new HttpClient())
            {
                string url = "";

                var response = await client.GetAsync(url);

                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<CharacterDataWrapper>(json);
            }
        }

    }
}
