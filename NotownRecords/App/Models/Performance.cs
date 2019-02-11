namespace App.Models
{
    // Each musician may play several instruments, and a given instrument may be played by several musicians.

    public enum Instrument
    {
        LeadGtr, Drums, Bass, Vocals, RythmeGtr
    }

    public class Performance
    {
        // Each song is performed by one or more musicians, and a musician may perform a number of songs.

        public int ID { get; set; }
        public int MusicianID { get; set; }
        public int SongID { get; set; }
        public Instrument Instrument { get; set; }

        public Musician Musician { get; set; }
        public Song Song { get; set; }

    }
}
