using MongoDB.Driver;
using BookApi.Models;
using System.Collections.Generic;

namespace BookApi.Services
{
    public class BookService
    {
        private readonly IMongoCollection<Book> _books;

        public BookService(IBookStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.connectionString);
            var database = client.GetDatabase(settings.databaseName);
            this._books = database.GetCollection<Book>(settings.collectionName);
        }

        public List<Book> GetList() => this._books.Find(book => true).ToList();

        public Book Create(Book book)
        {
            this._books.InsertOne(book);
            return book;
        }

        public Book FindById(string id) {
            return this._books.Find<Book>(book => book.Id == id).FirstOrDefault();
        }
    }
}