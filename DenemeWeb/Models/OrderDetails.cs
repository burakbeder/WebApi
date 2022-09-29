namespace DenemeWeb.Models
{
    public partial class OrderDetails
    {
        public int Id { get; set; }
       
        public int? SiparisId { get; set; }
        public int? YemekId { get; set; }

        public int Adet { get; set; }

        public int? Tutar { get; set; }
        public virtual Order Siparis { get; set; } = null!;
        public virtual Product Yemeks { get; set; } = null!;
    }
}
