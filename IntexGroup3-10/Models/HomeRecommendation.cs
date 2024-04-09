using System.ComponentModel.DataAnnotations;


namespace IntexGroup3_10.Models
{
    public class HomeRecommendation
    {
        [Key]
        [Required]
        public int Home_Rec_ID { get; set; }
        public Dictionary<int, string> Model_Output { get; set; }
    }

}
