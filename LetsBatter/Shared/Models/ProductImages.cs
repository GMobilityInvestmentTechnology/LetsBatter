using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBatter.Shared.Models
{
    [PrimaryKey(nameof(Id))]
    public class ProductImages
    {
        [Key]
        public int Id { get; set; }
        required public string Path { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product? Product { get; set; }
    }
}
