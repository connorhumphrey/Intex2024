using System.ComponentModel.DataAnnotations;

namespace IntexGroup3_10.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Product_ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Num_Parts { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [MaxLength(255)]
        public string Img_Link { get; set; }

        [MaxLength(50)]
        public string Primary_Color { get; set; }

        [MaxLength(50)]
        public string Secondary_Color { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Category { get; set; }
    }
}
