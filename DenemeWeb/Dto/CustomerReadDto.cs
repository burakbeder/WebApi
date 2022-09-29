using DenemeWeb.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace DenemeWeb.Dto
{
    public class CustomerReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? Sifre { get; set; }

    }
}
