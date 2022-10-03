using FirstRepositoryPatternApi.Interfaces;
using FirstRepositoryPatternApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRepositoryPatternApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _books;
        public BookController(IBookRepository books)
        {
            _books = books;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _books.GetAllBooksAsync());
        }

        [Route("id")]
        [HttpGet]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = _books.GetBookAsync(id);
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            return Ok(await _books.CreateBookAsync(book));
        }
    }
}
