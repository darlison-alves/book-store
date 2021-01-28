using System.Collections.Generic;
using BookApi.Domain.Customer.Models;
using BookApi.Models;
using MongoDB.Driver;

namespace BookApi.Domain.Customer.Repositories
{
    public class CustomerRepository
    {
        private readonly IMongoCollection<Customer> _customer;
        public CustomerRepository(IBookStoreDatabaseSettings settings)
        {
            var cli = new MongoClient(settings.connectionString);
            var db = cli.GetDatabase(settings.databaseName);
            _customer = db.GetCollection<Customer>("Customers");
        }

        public List<Customer> GetList() => this._customer.Find(book => true).ToList();

        public Customer Create(Customer customer)
        {
            this._customer.InsertOne(customer);
            return customer;
        }

        public void Update(string id, Customer customer) 
        {
            this._customer.ReplaceOne(customer => customer.Id == id, customer );
        }

        public Customer FindById(string id)
        {
            return this._customer.Find<Customer>(book => book.Id == id).FirstOrDefault();
        }
    }
}