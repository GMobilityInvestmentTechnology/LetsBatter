using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LetsBatter.Shared.Models
{
    [PrimaryKey("Id")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; } = "";
        public String? Description { get; set; } = "";
        public bool? Condition { get; set; } // 1=BrandNew 2=Used
        public String? Type { get; set; } = "";
        public DateTime? DateCreated { get; set; }
        public int Price { get; set; }
        [ForeignKey("ProductImages")]
        public int? PhotoID { get; set; }
        public ProductImages? Images { get; set; }
        [ForeignKey("Publisher")]
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        [ForeignKey("ProductCategory")]
        public int? ProductCategoryID { get; set; }
        public ProductCategory? Category { get; set; }

    }
}
