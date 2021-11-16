using CodeChallenge1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CodeChallenge1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<AlbumTitleVM>>> GetAll()
        {
            List<AlbumTitleVM> albumTitles = new();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
               
                //in the "" can go additional url folders to add to the baseurl
                HttpResponseMessage Res = await client.GetAsync("albums");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var albumResponse = Res.Content.ReadAsStringAsync().Result;
                    albumTitles = JsonConvert.DeserializeObject<List<AlbumTitleVM>>(albumResponse);
                }

                return Ok(albumTitles);
            }
        }
    }
}
