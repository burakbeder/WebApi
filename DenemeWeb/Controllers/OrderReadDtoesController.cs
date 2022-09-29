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
    public class OrderReadDtoesController : ControllerBase
    {
        private readonly You2DataContext _context;
        private readonly IMapper _mapper;
        public OrderReadDtoesController(You2DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/OrderReadDtoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderReadDto>>> GetOrderReadDto()
        {
            var oDetails = _context.Siparis;
            var readDto = _mapper.Map<IEnumerable<OrderReadDto>>(oDetails);

            if (readDto == null)
            {
                return NotFound();
            }

            return Ok(readDto);
        }
 /*
        // GET: api/OrderReadDtoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderReadDto>> GetOrderReadDto(int id)
        {
          if (_context.OrderReadDto == null)
          {
              return NotFound();
          }
            var orderReadDto = await _context.OrderReadDto.FindAsync(id);

            if (orderReadDto == null)
            {
                return NotFound();
            }

            return orderReadDto;
        }
       
        // PUT: api/OrderReadDtoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderReadDto(int id, OrderReadDto orderReadDto)
        {
            if (id != orderReadDto.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderReadDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderReadDtoExists(id))
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

        // POST: api/OrderReadDtoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderReadDto>> PostOrderReadDto(OrderReadDto orderReadDto)
        {
          if (_context.OrderReadDto == null)
          {
              return Problem("Entity set 'You2DataContext.OrderReadDto'  is null.");
          }
            _context.OrderReadDto.Add(orderReadDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderReadDto", new { id = orderReadDto.Id }, orderReadDto);
        }

        // DELETE: api/OrderReadDtoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderReadDto(int id)
        {
            if (_context.OrderReadDto == null)
            {
                return NotFound();
            }
            var orderReadDto = await _context.OrderReadDto.FindAsync(id);
            if (orderReadDto == null)
            {
                return NotFound();
            }

            _context.OrderReadDto.Remove(orderReadDto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderReadDtoExists(int id)
        {
            return (_context.OrderReadDto?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/
    }
}
