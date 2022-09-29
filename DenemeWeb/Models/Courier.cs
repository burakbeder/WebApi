using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DenemeWeb.Models
{
    public partial class Courier
    {
        public Courier()
        {
            Siparis = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? KuryeAd { get; set; }
        public string? KuryeSoyad { get; set; }
        public int? KuryeYas { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order> Siparis { get; set; }
    }
}
