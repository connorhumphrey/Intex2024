using System.ComponentModel.DataAnnotations;

namespace IntexGroup3_10.Models
{
    public class LineItem
    {
        [Key]
        [Required]
        public int Transaction_ID { get; set; }

        [Key]
        [Required]
        public int Product_ID { get; set; }

        [Required]
        public int Qty { get; set; }

        public int Rating { get; set; }
    }
}
