using APIProject.Data.Services;
using APIProject.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;  
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]BookDto dto)
        {
            _booksService.Add(dto);
            return Ok();
        }
        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var allBooks = _booksService.GetBookById(id);
            return Ok(allBooks);
        }
        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _booksService.GetAllBooks();
            return Ok(allBooks);
        }
        [HttpPut("update-book-by-id/{id}")]
        public IActionResult Update(int id, [FromBody] BookDto dto)
        {
            var updatedBook = _booksService.UpdateBook(id, dto);
            return Ok(updatedBook);
        }
        [HttpDelete("delete-book/{id}")]
        public IActionResult Delete(int id)
        {
            _booksService.DeleteBook(id);
            return Ok();
        }
    }
}
