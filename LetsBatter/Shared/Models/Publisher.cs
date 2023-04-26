using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LetsBatter.Shared.Models
{
    [PrimaryKey(nameof(Id))]
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
