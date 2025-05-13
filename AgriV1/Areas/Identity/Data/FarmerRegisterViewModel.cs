using System.ComponentModel.DataAnnotations;

namespace AgriV1.Areas.Identity.Data
{
    public class FarmerRegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
