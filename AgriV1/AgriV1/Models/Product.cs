using System;
using System.ComponentModel.DataAnnotations;
using AgriV1.Areas.Identity.Data;

namespace AgriV1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }

        public string FarmerId { get; set; } // Foreign key to track owner
        public AgriV1User Farmer { get; set; }
    }
}

