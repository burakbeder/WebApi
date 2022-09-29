using System;
using System.Collections.Generic;

namespace DenemeWeb.Models
{
    public partial class Order
    {
        public Order()
        {
            SiparisDetay = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Adet { get; set; }
        public int? Tutar { get; set; }
       
        public string? Teslimatdurumu { get; set; }
        public int MusteriId { get; set; }
        public int KuryeId { get; set; }

        public virtual Courier Kurye { get; set; } = null!;
        public virtual Customer Musteri { get; set; } = null!;
        public virtual ICollection<OrderDetails> SiparisDetay { get; set; }
    }
}
