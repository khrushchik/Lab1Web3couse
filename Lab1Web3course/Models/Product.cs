using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1Web3course.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int ProducerId { get; set; }
        public string Info { get; set; }

        public virtual Category Category { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
