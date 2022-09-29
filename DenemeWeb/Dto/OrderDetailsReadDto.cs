using DenemeWeb.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace DenemeWeb.Dto
{
    public partial class OrderDetailsReadDto
    {
        public int Id { get; set; }

        public int? SiparisId { get; set; }
        public int? YemekId { get; set; }

        public int Adet { get; set; }

        public int? Tutar { get; set; }
        //public virtual CategorytoFoodReadDto Yemeks { get; set; } = null!;
    }
}
