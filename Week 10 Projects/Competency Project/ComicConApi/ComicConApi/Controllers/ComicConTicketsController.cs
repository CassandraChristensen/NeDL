using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComicConApi.Models;

namespace ComicConApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicConTicketsController : ControllerBase
    {
        private readonly ComicConContext _context;

        public ComicConTicketsController(ComicConContext context)
        {
            _context = context;
        }

        // GET: api/ComicConTickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComicConTicket>>> GetComicConTicket()
        {
          if (_context.ComicConTicket == null)
          {
              return NotFound();
          }
            return await _context.ComicConTicket.ToListAsync();
        }

        // GET: api/ComicConTickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComicConTicket>> GetComicConTicket(long id)
        {
          if (_context.ComicConTicket == null)
          {
              return NotFound();
          }
            var comicConTicket = await _context.ComicConTicket.FindAsync(id);

            if (comicConTicket == null)
            {
                return NotFound();
            }

            return comicConTicket;
        }

        // PUT: api/ComicConTickets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComicConTicket(long id, ComicConTicket comicConTicket)
        {
            if (id != comicConTicket.Id)
            {
                return BadRequest();
            }

            _context.Entry(comicConTicket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComicConTicketExists(id))
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

        // POST: api/ComicConTickets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComicConTicket>> PostComicConTicket(ComicConTicket comicConTicket)
        {
          //if (_context.ComicConTicket == null)
          //{
          //    return Problem("Entity set 'ComicConContext.ComicConTicket'  is null.");
          //}
            _context.ComicConTicket.Add(comicConTicket);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetComicConTicket), new { id = comicConTicket.Id }, comicConTicket);
        }

        // DELETE: api/ComicConTickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComicConTicket(long id)
        {
            if (_context.ComicConTicket == null)
            {
                return NotFound();
            }
            var comicConTicket = await _context.ComicConTicket.FindAsync(id);
            if (comicConTicket == null)
            {
                return NotFound();
            }

            _context.ComicConTicket.Remove(comicConTicket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComicConTicketExists(long id)
        {
            return (_context.ComicConTicket?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
