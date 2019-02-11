using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Album
    {
        // Each album recorded on the Notown label has a unique identification number, a title, a copyright date, a format (e.g., CD or MC), and an album identifier.

        // Each album has a number of songs on it, but no song may appear on more than one album.

        [Key]
        public Guid ID { get; set; }

        public ICollection<Song> Songs { get; set; }
        public Producer Producer { get; set; }

    }
}
