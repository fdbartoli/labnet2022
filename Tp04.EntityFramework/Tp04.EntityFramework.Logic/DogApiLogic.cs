using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Tp04.EntityFramework.Entities;


namespace Tp04.EntityFramework.Logic
{
    public class DogApiLogic
    {
        readonly string url = "https://dog.ceo/api/breeds/image/random";
        public async Task<Dog> Get()
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync(url);
            dynamic dogs = JsonConvert.DeserializeObject<Dog>(json);
            return dogs;
        }
    }
}
