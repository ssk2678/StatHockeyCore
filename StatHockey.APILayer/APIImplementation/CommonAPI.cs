using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using StatHockey.APILayer.APIInterfaces;
using StatHockey.BusinessLayer.BOImplementation;


namespace StatHockey.APILayer.APIImplementation
{
    public class CommonAPI : ICommonAPI
    {
        HttpClient client = new HttpClient();
       

        public CommonAPI (IConfiguration configuration)
        {
            client.BaseAddress = new Uri(configuration["StatHockeyCoreConfig:NHLApi"]);
            //Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<LeagueSeason> GetSeasons()
        {
            HttpResponseMessage response = await client.GetAsync("api/v1/seasons");
            LeagueSeason seasonList = new LeagueSeason();
            
            if (response.IsSuccessStatusCode)
            {
                //Parse the response body. Blocking! -- page 640 .NET Core book
                seasonList = await response.Content.ReadFromJsonAsync<LeagueSeason>();
                
            }

            return seasonList;
        } 
        
    }
}
