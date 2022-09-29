using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DenemeWeb.Models;
using AutoMapper;
using DenemeWeb.Dto;
using DenemeWeb.Business;

namespace DenemeWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly You2DataContext _context;
        private readonly IMapper _mapper;
        public ProductsController(You2DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

     
        // GET: api/Yemeks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategorytoFoodReadDto>>> GetYemeks()
        {
             ProductBusiness yemek = new ProductBusiness( _context, _mapper);
            
            return Ok(yemek.GetYemek());

        }

        // GET: api/Yemeks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategorytoFoodReadDto>> GetYemeks(int id)
        {
         
            ProductBusiness yemek = new ProductBusiness(_context, _mapper);
            var deneme = yemek.GetYemekbyId(id);
            return Ok(deneme);

        }
        // GET: api/Yemeks/5
        [HttpGet("getyemekbyname/{name}")]
        public async Task<ActionResult<CategorytoFoodReadDto>> GetYemekName(string name)
        {

            ProductBusiness yemek = new ProductBusiness(_context, _mapper);

            return Ok(yemek.GetYemekbyName(name));

        }
        // PUT: api/Yemeks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{name}")]
        public async Task<IActionResult> PutYemek(string name, ProductPostDto yemekk)
        {
            
            ProductBusiness deneme = new ProductBusiness(_context, _mapper);
            var yemek = deneme.PutYemek(yemekk);

            if (name != yemek.Ad)
            {
                return BadRequest();
            }
            _context.Entry(yemek).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YemekExists(name))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
            
        }

        // POST: api/Yemeks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductPostDto>> PostYemek(ProductPostDto yemekk)

        {
            if (_context.Yemeks == null)
            {
                return Problem("Entity set 'You2DataContext.Yemeks'  is null.");
            }
            ProductBusiness yemek = new ProductBusiness(_context, _mapper);
            var deneme = yemek.PostYemek(yemekk);
            
            
            _context.Yemeks.Add(deneme);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (YemekExists(deneme.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetYemeks", new { id = deneme.Id }, deneme);
        }

        // DELETE: api/Yemeks/5
        [HttpDelete("{id}")]
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

        private bool YemekExists(int id)
        {
            return (_context.Yemeks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        private bool YemekExists(string name)
        {
            return (_context.Yemeks?.Any(e => e.Ad == name)).GetValueOrDefault();
        }
    }
}
