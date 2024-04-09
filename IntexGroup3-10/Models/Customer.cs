using System.ComponentModel.DataAnnotations;

namespace IntexGroup3_10.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int Customer_ID { get; set; }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public DateTime Birth_Date { get; set; }

        public string Country_Of_Residence { get; set; }
        public char Gender {  get; set; }
        public double Age { get; set; }


    }
}
