using CodeChallenge1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge1.ApiProcessor.Interfaces
{
    public interface IAlbumProcessor
    {
        Task<List<AlbumTitleVM>> LoadAlbums(string search);

    }
}
