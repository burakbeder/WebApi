using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DenemeWeb.Models
{
    public partial class Customer
    {
        public Customer()
        {
           
            Siparis = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? Sifre { get; set; }


        public virtual ICollection<Order> Siparis { get; set; }
    }
}
