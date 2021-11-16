using CodeChallenge1.ApiProcessor;
using CodeChallenge1.ApiProcessor.Interfaces;
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
        private readonly IAlbumProcessor _albumProcessor;

        public AlbumsController(IAlbumProcessor albumProcessor)
        {
            _albumProcessor = albumProcessor;
        }
        [HttpGet]
        public async Task<ActionResult<List<AlbumTitleVM>>> GetAll()
        {
            var albumTitles = await _albumProcessor.LoadAlbums();
                
                return Ok(albumTitles);
            
        }
    }
}
