using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge1.Models
{
    public class AlbumTitleVM
    {
        public AlbumTitleVM() { }

        public AlbumTitleVM(Album src)
        {
            Title = src.Title;
        }

        public string Title { get; set; }
    }
}
