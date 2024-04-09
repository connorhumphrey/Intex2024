using System.ComponentModel.DataAnnotations;


namespace IntexGroup3_10.Models
{
    public class ProductRecommendation
    {
        [Key]
        [Required]
        public int Prod_Rec_ID { get; set; }
        public Dictionary<int, string> Model_Output { get; set; }
    }

}
