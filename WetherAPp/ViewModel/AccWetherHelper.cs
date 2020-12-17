using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WetherAPp.Model;

namespace WetherAPp.ViewModel
{
    public class AccWetherHelper
    {
        public const string BASE_URL = "http://dataservice.accuweather.com/";
        public const string AUTOCOMPLETE = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
        public const string CONDITION = "currentconditions/v1/{0}?apikey={1}";
        public const string KEY = "4MndzhpRCyqkCChXgHGa9GqneDPzIyK8";

        public async static Task<List<City>> GetCities(string query)
        {
            List<City> cities = new List<City>();
            string url = BASE_URL + string.Format(AUTOCOMPLETE, KEY, query);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                cities = JsonConvert.DeserializeObject<List<City>>(json);

            }



            return cities;
        }
        public async static Task<CurrentCondition> GetCondition(string citykey)
        {
            CurrentCondition cond = new CurrentCondition();
            string url = BASE_URL + string.Format(CONDITION, citykey,KEY);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                cond = JsonConvert.DeserializeObject<List<CurrentCondition>>(json).FirstOrDefault();

            }



            return cond;
        }
    }
}
