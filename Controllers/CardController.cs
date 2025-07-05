using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonCardsAPI.Data;
using PokemonCardsAPI.Models;

namespace PokemonCardsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // A rota será: api/card
    public class CardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CardController(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 GET: api/card → lista todos os cards com dados relacionados
        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var cards = await _context.Cards
                .Include(c => c.Type)
                .Include(c => c.Stage)
                .Include(c => c.Collection)
                .ToListAsync();

            return Ok(cards);
        }

        // 🔹 GET: api/card/5 → busca card por id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCardById(int id)
        {
            var card = await _context.Cards
                .Include(c => c.Type)
                .Include(c => c.Stage)
                .Include(c => c.Collection)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (card == null)
                return NotFound($"Card com ID {id} não encontrado.");

            return Ok(card);
        }

        // 🔹 POST: api/card → adiciona novo card
        [HttpPost]
        public async Task<IActionResult> AddCard(Card newCard)
        {
            _context.Cards.Add(newCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCardById), new { id = newCard.Id }, newCard);
        }

        // 🔹 PUT: api/card/5 → atualiza card existente
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCard(int id, Card updatedCard)
        {
            if (id != updatedCard.Id)
                return BadRequest("IDs não conferem.");

            var cardExistente = await _context.Cards.FindAsync(id);
            if (cardExistente == null)
                return NotFound($"Card com ID {id} não encontrado.");

            // Atualiza campos
            _context.Entry(cardExistente).CurrentValues.SetValues(updatedCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // 🔹 DELETE: api/card/5 → remove card
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null)
                return NotFound($"Card com ID {id} não encontrado.");

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}