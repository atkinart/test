using System.ComponentModel.DataAnnotations;

namespace TestRest.Models
{
    public class Product
    {
        public int id { get; set; }
        
        [Required(ErrorMessage = "WTF")]
        public string name { get; set; }
    }
}