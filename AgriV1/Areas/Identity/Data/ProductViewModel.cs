using System;
using System.ComponentModel.DataAnnotations;

namespace AgriV1.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
    }
}

