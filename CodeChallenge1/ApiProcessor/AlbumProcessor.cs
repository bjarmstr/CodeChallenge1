using CodeChallenge1.ApiProcessor.Interfaces;
using CodeChallenge1.Helpers;
using CodeChallenge1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodeChallenge1.ApiProcessor
{
    public class AlbumProcessor: IAlbumProcessor
    { 
        public async Task<List<AlbumTitleVM>> LoadAlbums()
        {
            using (HttpResponseMessage Res = await ApiHelper.ApiClient.GetAsync("albums"))
            {
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var albumResponse = Res.Content.ReadAsStringAsync().Result;
                    var albumTitles = JsonConvert.DeserializeObject<List<AlbumTitleVM>>(albumResponse);
                    return albumTitles;
                }
                else
                {
                    throw new Exception(Res.ReasonPhrase);
                }
            }
        }
    }
}
