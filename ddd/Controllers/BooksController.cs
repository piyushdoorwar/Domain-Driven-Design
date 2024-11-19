using DDD.Application;
using DDD.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace DDD.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController(LibraryDbContext context, BorrowBookHandler borrowBookHandler) : ControllerBase
{
    private readonly LibraryDbContext _context = context;
    private readonly BorrowBookHandler _borrowBookHandler = borrowBookHandler;

    [HttpGet]
    public IActionResult GetBooks()
    {
        var books = _context.Books.ToList();
        return Ok(books);
    }

    [HttpPost("{id}/borrow")]
    public IActionResult BorrowBook(Guid id)
    {
        try
        {
            _borrowBookHandler.Handle(id);
            return Ok(new { Message = "Book borrowed successfully." });
        }
        catch (ArgumentException ex)
        {
            return NotFound(new { ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}
