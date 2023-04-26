using Microsoft.EntityFrameworkCore;

namespace LetsBatter.Shared.Models
{
    [PrimaryKey(nameof(Id))]
    public class NamePriceTest
    {
        public int Id { get; set; }
        required public string Name { get; set; }
        public int? Price { get; set; }
    }
}
