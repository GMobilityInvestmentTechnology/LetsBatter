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
    [PrimaryKey("Id")]
    public class Analytics
    {
        [Key]
        public int Id { get; set; }
        public string ActionType { get; set; } = string.Empty;
        [ForeignKey("Product")]
        public int ProductID { get; set;}
        public Product? Product { get; set; }
        public int CookieID { get; set; }
        public string BrowserFingerprint { get; set; } = string.Empty;
        public string ReferrerUrl { get; set; } = string.Empty;
        public string OfferType { get; set; } = string.Empty;
        public DateTime TimeStamp { get; set; }

    }
}
