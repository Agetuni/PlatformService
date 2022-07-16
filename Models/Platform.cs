namespace platfromServices.Models
{
    public class Platform {
        public int Id { get; set; }
        [Required]
        public string Publisher { get; set; } 
        public string MyProperty { get; set; }
        public string Cost { get; set; }

    }
}