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

namespace DenemeWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly You2DataContext _context;
        private readonly IMapper _mapper;
        public OrderDetailsController(You2DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetailsReadDto>>> GetOrderDetails()
        {
            var oDetails = _context.SiparisDetay;
            var readDto = _mapper.Map<IEnumerable<OrderDetailsReadDto>>(oDetails);

            if (readDto == null)
            {
                return NotFound();
            }

            return Ok(readDto);

        }
/*
        // GET: api/Kategoris/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryNewDto>> GetKategori(int id)
        {
            var kat = _context.Kategoris.Include(x => x.Yemeks)
                                       .Where(x => x.Id == id)
                                       .FirstOrDefault();
            var kategori = _mapper.Map<CategoryNewDto>(kat);
            if (_context.Kategoris == null)
            {
                return NotFound();
            }


            if (kategori == null)
            {
                return NotFound();
            }

            return kategori;
        }
        
        // PUT: api/Kategoris/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKategori(int id, Category kategori)
        {
            if (id != kategori.Id)
            {
                return BadRequest();
            }

            _context.Entry(kategori).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KategoriExists(id))
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

        // POST: api/Kategoris
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostKategori(Category kategori)
        {
            if (_context.Kategoris == null)
            {
                return Problem("Entity set 'You2DataContext.Kategoris'  is null.");
            }
            _context.Kategoris.Add(kategori);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KategoriExists(kategori.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKategori", new { id = kategori.Id }, kategori);
        }

        // DELETE: api/Kategoris/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKategori(int id)
        {
            if (_context.Kategoris == null)
            {
                return NotFound();
            }
            var kategori = await _context.Kategoris.FindAsync(id);
            if (kategori == null)
            {
                return NotFound();
            }

            _context.Kategoris.Remove(kategori);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KategoriExists(int id)
        {
            return (_context.Kategoris?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        */
    }
}
