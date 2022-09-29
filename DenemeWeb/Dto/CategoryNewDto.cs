using DenemeWeb.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DenemeWeb.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DenemeWeb.Dto
{
    public partial class CategoryNewDto
    {


       public CategoryNewDto()
        {
            Yemeks = new HashSet<CategorytoFoodReadDto>();
        }

        public int Id { get; set; }

        
        public string? Kategori1 { get; set; }

     public virtual ICollection<CategorytoFoodReadDto> Yemeks { get; set; }







    }
}
