using System.Collections.Generic;

namespace App.Models
{
    public class Producer : Musician
    {
        public ICollection<Album> Productions { get; set; }

    }
}