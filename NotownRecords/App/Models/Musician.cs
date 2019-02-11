using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Musician
    {
        //Each musician that records at Notown has an SSN, a name, an address, and a phone number. Poorly paid musicians often share the same address, and no address has more than one phone.

        // Each musician may play several instruments, and a given instrument may be played by several musicians.


        public int ID { get; set; }

        [Required]
        public int SSN { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        //navigational properties

        public Address Address { get; set; }
        public ICollection<Performance> Performances { get; set; }


    }
}
