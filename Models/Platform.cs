using System.ComponentModel.DataAnnotations;

namespace platfromServices.Models
{
    public class Platform {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Publisher { get; set; } 
        public string Cost { get; set; }

    }
}