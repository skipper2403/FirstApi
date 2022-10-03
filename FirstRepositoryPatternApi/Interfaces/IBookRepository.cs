using FirstRepositoryPatternApi.Models;

namespace FirstRepositoryPatternApi.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookAsync(int id);
        Task<Book> CreateBookAsync(Book book);
    }
}
