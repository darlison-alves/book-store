using BookApi.Models;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController
    {
        private BookService _bookService;
        public BookController( BookService bookService )
        {
            this._bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> GetBook() 
        {
            return this._bookService.GetList();
        }

        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            this._bookService.Create(book);
            return book;
        }

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<Book> findOne(string id)
        {
            var book = this._bookService.FindById(id);

            if(book == null)
                return new NotFoundResult();
            return book;
        }
    }
}