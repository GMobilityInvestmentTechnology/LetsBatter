using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsBatter.Shared.Models
{
    [PrimaryKey("Id")]
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product? Product { get; set; }
        public IEnumerable<Category>? Categories { get; set; }

    }
}