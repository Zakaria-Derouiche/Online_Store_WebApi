

using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        public List<Product> CategoryProducts { get; set; }
    }
}
