using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.Data.Entities
{
    [Table("CoffeeShops", Schema = "test")]
    public class CoffeeShop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpeningHours { get; set; }
        public string Address { get; set; }
    }
}
