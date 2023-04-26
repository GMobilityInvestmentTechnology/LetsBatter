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
    public class Chat
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product? Product { get; set; }
        [ForeignKey("Admin")]
        public int AdminID { get; set; }
        public Admin? Admin { get; set; }
        public string ClientReferenceNumber { get; set; } = "";
        public String ClientName { get; set; } = "";
        public String ClientEmail { get; set; } = "";
        public int ClientPhoneNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
