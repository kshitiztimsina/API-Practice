using APIProject.Data.Models;
using APIProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace APIProject.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
                _context = context;
        }
        public void Add(BookDto book)
        {
            var _book = new Book()
            {
                title = book.title,
                description = book.description,
                is_read = book.is_read,
                date_read = book.is_read ? book.date_read.Value : null,
                rate = book.is_read ? book.rate.Value : null,
                genre = book.genre,
                cover_url = book.cover_url,
                author = book.author,
                date_added = System.DateTime.Now
            };
            _context.books.Add(_book);
            _context.SaveChanges();

        }
        public List<Book> GetAllBooks() => _context.books.ToList();
        public Book GetBookById(int bookId) => _context.books.FirstOrDefault(a => a.Id == bookId);
        public Book UpdateBook(int id, BookDto book)
        {
            var _book = _context.books.FirstOrDefault(a => a.Id == id);
            if(_book != null)
            {
                _book.title = book.title;
                _book.description = book.description;
                _book.is_read = book.is_read;
                _book.date_read = book.is_read ? book.date_read.Value : null;
                _book.rate = book.is_read ? book.rate.Value : null;
                _book.genre = book.genre;
                _book.cover_url = book.cover_url;
                _book.author = book.author;
                _context.SaveChanges();
            }
            return _book;
        }
        public void DeleteBook(int id)
        {
            var _book = _context.books.FirstOrDefault(a => a.Id == id);
            if(_book != null)
            {
                _context.books.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
