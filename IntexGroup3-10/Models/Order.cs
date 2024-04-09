using System.ComponentModel.DataAnnotations;

namespace IntexGroup3_10.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int Transaction_ID { get; set; }

        [Required]
        public int Customer_ID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(50)]
        public string Day_Of_Week { get; set; }

        [Required]
        public int Time { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type_Of_Card { get; set; }

        [Required]
        [MaxLength(50)]
        public string Entry_Mode { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type_Of_Transaction { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country_Of_Transaction { get; set; }

        [Required]
        [MaxLength(100)]
        public string Shipping_Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Bank { get; set; }

        [Required]
        public bool Fraud { get; set; }
    }
}
