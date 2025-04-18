using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Review
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public Product product { get; set; }

        public User user { get; set; }

        public byte Rating { get; set; }

        [MaxLength(100)]
        public string Comment { get; set; }
        
        public DateTime CreatedAt { get; set; }

    }
}
