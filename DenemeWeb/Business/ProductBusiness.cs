using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using DenemeWeb.Models;
using AutoMapper;
using DenemeWeb.Dto;

namespace DenemeWeb.Business
{
    
    public class ProductBusiness 
    {
        private readonly You2DataContext _context;
        private readonly IMapper _mapper;
        public ProductBusiness(You2DataContext context, IMapper mapper)
        {
          _context = context;
          _mapper = mapper;
        }
        public IList<CategorytoFoodReadDto> GetYemek()
        {
            var yemek = _context.Yemeks.Include(x => x.Kategori);
            var yemekreadDto = _mapper.Map<IEnumerable<CategorytoFoodReadDto>>(yemek);
            return (IList<CategorytoFoodReadDto>)yemekreadDto;
            

        }
        public CategorytoFoodReadDto GetYemekbyId(int id)
        {
            var yemek = _context.Yemeks.Include(x => x.Kategori)
                                       .Where(x => x.Id == id)
                                       .FirstOrDefault();

            var yemekreadDto = _mapper.Map<CategorytoFoodReadDto>(yemek);
            return (CategorytoFoodReadDto)yemekreadDto;


        }
        public CategorytoFoodReadDto GetYemekbyName(string name)
        {
            var yemek = _context.Yemeks.Include(x => x.Kategori)
                                       .Where(x => x.Ad == name)
                                       .FirstOrDefault();

            var yemekreadDto = _mapper.Map<CategorytoFoodReadDto>(yemek);
            return (CategorytoFoodReadDto)yemekreadDto;


        }     
       
        public  Product PostYemek(ProductPostDto yemekk)

        { 
           
            var yemek= _mapper.Map<Product>(yemekk);

            return yemek;
           
        }
        public Product PutYemek( ProductPostDto yemekk)
        {
            var yemek = _mapper.Map<Product>(yemekk);
            return yemek;

        }

        /*
        public async Task<IActionResult> DeleteYemek(int id)
        {

            if (_context.Yemeks == null)
            {
                return NotFound();
            }

            var yemek = await _context.Yemeks.FindAsync(id);
            if (yemek == null)
            {
                return NotFound();
            }

            _context.Yemeks.Remove(yemek);
            await _context.SaveChangesAsync();

            return NoContent();
        }
       */
        private bool YemekExists(int id)
        {
            return (_context.Yemeks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
