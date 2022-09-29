using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DenemeWeb.Models
{
    public partial class Category
    {
        public Category()
        {
            Yemeks = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Kategori1 { get; set; }
        
        public virtual ICollection<Product> Yemeks { get; set; }
    }
}
