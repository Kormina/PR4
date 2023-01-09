using System.ComponentModel.DataAnnotations;

namespace PR4.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }
    }
}