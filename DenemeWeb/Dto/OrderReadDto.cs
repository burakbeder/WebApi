using DenemeWeb.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace DenemeWeb.Dto
{
    public partial class OrderReadDto
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Adet { get; set; }
        public int? Tutar { get; set; }
  
        public string? Teslimatdurumu { get; set; }
        public int MusteriId { get; set; }
        public int KuryeId { get; set; }
    }
}
