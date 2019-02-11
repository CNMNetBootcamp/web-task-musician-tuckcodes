using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Address
    {
        public int ID { get; set; }
        
        [Required]
        public int StreetNumber { get; set; }

        [Required]
        public string StreetName { get; set; }
        
        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        public ICollection<Musician> Musicians { get; set; }


    }
}