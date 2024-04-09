using System.ComponentModel.DataAnnotations;


namespace IntexGroup3_10.Models
{
    public class CustomerRecommendation
    {
        [Key]
        [Required]
        public int Cust_Rec_ID { get; set; }
        public Dictionary<int, string> Model_Output { get; set; }
    }
}
