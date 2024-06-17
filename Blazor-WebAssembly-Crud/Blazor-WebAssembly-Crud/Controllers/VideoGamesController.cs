using Blazor_WebAssembly_Crud.Data;
using Blazor_WebAssembly_Crud.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazo_WebAssembly_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly DataContext _context;

        public VideoGamesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGamesAsync()
        {
            var videoGames = await _context.VideoGames.ToListAsync();
            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetGameByIdAsync(int id)
        {
            var videoGame = await _context.VideoGames.FindAsync(id);
            return Ok(videoGame);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<VideoGame>> DeleteGameAsync(int id)
        {
            var videoGame = await _context.VideoGames.FindAsync(id);

            await _context.SaveChangesAsync();

            return Ok(videoGame);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VideoGame>> UpdateGameAsync(int id, VideoGame update)
        {
            var videoGames = await _context.VideoGames.FindAsync(id);

            videoGames.Title = update.Title;
            videoGames.ReleaseYear = update.ReleaseYear;
            videoGames.Publisher = update.Publisher;

            await _context.SaveChangesAsync();

            return Ok(videoGames);
        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddGameAsync( VideoGame game)
        {
           _context.VideoGames.Add(game);

            await _context.SaveChangesAsync();

            return Ok(game);
        }
    }
}
