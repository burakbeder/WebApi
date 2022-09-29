using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DenemeWeb.Dto;
using DenemeWeb.Models;
using AutoMapper;

namespace DenemeWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly You2DataContext _context;
        private readonly IMapper _mapper;
        public CustomersController(You2DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/CustomerReadDtoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerReadDto>>> GetCustomerReadDto()
        {
            var oDetails = _context.Musteris;
            var readDto = _mapper.Map<IEnumerable<CustomerReadDto>>(oDetails);

            if (readDto == null)
            {
                return NotFound();
            }

            return Ok(readDto);
        }
        /*
        // GET: api/CustomerReadDtoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerReadDto>> GetCustomerReadDto(int id)
        {
          if (_context.CustomerReadDto == null)
          {
              return NotFound();
          }
            var customerReadDto = await _context.CustomerReadDto.FindAsync(id);

            if (customerReadDto == null)
            {
                return NotFound();
            }

            return customerReadDto;
        }

        // PUT: api/CustomerReadDtoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerReadDto(int id, CustomerReadDto customerReadDto)
        {
            if (id != customerReadDto.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerReadDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerReadDtoExists(id))
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

        // POST: api/CustomerReadDtoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerReadDto>> PostCustomerReadDto(CustomerReadDto customerReadDto)
        {
          if (_context.CustomerReadDto == null)
          {
              return Problem("Entity set 'You2DataContext.CustomerReadDto'  is null.");
          }
            _context.CustomerReadDto.Add(customerReadDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerReadDto", new { id = customerReadDto.Id }, customerReadDto);
        }

        // DELETE: api/CustomerReadDtoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerReadDto(int id)
        {
            if (_context.CustomerReadDto == null)
            {
                return NotFound();
            }
            var customerReadDto = await _context.CustomerReadDto.FindAsync(id);
            if (customerReadDto == null)
            {
                return NotFound();
            }

            _context.CustomerReadDto.Remove(customerReadDto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerReadDtoExists(int id)
        {
            return (_context.CustomerReadDto?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/
    }
}
