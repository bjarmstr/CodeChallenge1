using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge1.Models
{
    public class Album
    {
   
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public string Title { get; set; }

    }
}
