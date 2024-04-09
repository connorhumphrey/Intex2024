using System.ComponentModel.DataAnnotations;

namespace IntexGroup3_10.Models
{
    public class User
    {
        [Key]
        [Required]
        public int User_ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string User_Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string Role { get; set; }

        [Required]
        public bool Login_Status { get; set; }
    }
}