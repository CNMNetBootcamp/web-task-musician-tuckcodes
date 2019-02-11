using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{

    public enum Key
    {
        A, Bb, B, C, Db, D, Eb, E, F, Gb, G, Ab
    }

    public class Song
    {
        // Each song recorded at Notown has a title and an author.
        // Each album has a number of songs on it, but no song may appear on more than one album.
        // Each song is performed by one or more musicians, and a musician may perform a number of songs.


        public int ID { get; set; }

        [Required]
        public Key Key { get; set; }

        public Album Album { get; set; }
        public ICollection<Performance> Performers { get; set; }
    }
}