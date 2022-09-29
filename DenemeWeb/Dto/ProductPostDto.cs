using DenemeWeb.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DenemeWeb.Dto
{
    public partial class ProductPostDto
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public int Fiyat { get; set; }
        public int KategoriId { get; set; }
 

      

    }
}
