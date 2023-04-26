using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LetsBatter.Shared.Models
{
    [PrimaryKey("Id")]
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
    }
}
