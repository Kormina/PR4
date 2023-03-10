using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel.DataAnnotations.Schema;

namespace PR4.Data
{
    public class PriceLog
    {
        [Column(TypeName = "datetime")]
        public DateTime Timer { get; set; }

        public int ShopId { get; set; }

        public int ProductId { get; set; }

        public double Price { get; set; }
    }
}

