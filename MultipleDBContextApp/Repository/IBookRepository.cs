using MultipleDBContextApp.Models;

namespace MultipleDBContextApp.Repository
{
    public interface IBookRepository
    {
        void Add(Book entity, string contextName);
        void Update(Book entity, string contextName);
        List<Book> Get(string contextName);
    }
}
