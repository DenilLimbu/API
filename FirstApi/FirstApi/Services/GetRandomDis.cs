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
                var url = new Uri($"http://gateway.marvel.com/v1/public/characters?name={model.searchCriteria}&limit=10&ts=Jan222019918:22:00&apikey=8f47ffeea3ab770036a58f770f94d943&hash=a11c01ec99b93a70073d7d1d3598e24c");

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
