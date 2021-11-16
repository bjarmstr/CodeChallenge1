using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CodeChallenge1.Helpers
{
    public static class ApiHelper
    {
        //static -open only one HttpClient for the whole application -- setup only happens once
        public static HttpClient ApiClient { get; set; } 
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
        }


    }
}
