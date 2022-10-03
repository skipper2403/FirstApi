using FirstRepositoryPatternApi.Interfaces;
using FirstRepositoryPatternApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstRepositoryPatternApi.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly RepoDbContext _dbContext;
        public BookRepository(RepoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
            return book;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {

            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookAsync(int id)
        {
            var book = _dbContext.Books.Where(x => x.Id == id).FirstOrDefault();

            return book;
        }
    }
}
