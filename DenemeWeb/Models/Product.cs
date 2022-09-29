
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DenemeWeb.Models
{
    public partial class Product
    {
        public Product()
        {
            SiparisDetay = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public string? Ad { get; set; }
        public int? Fiyat { get; set; }

        public int KategoriId { get; set; }   

        public virtual Category Kategori { get; set; } = null!;
        
        public virtual ICollection<OrderDetails> SiparisDetay { get; set; }
    }
}
