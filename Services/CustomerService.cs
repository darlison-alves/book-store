using System.Collections.Generic;
using BookApi.Domain.Customer.Models;
using BookApi.Domain.Customer.Repositories;
using BookApi.Models;

namespace BookApi.Services
{
    public class CustomerService
    {
        public readonly CustomerRepository _customerRepository;

        public CustomerService(CustomerRepository repository)
        {
            this._customerRepository = repository;
        }

        public List<Customer> GetList() => this._customerRepository.GetList();

        public Customer Create(Customer customer)
        {
            return this._customerRepository.Create(customer);
        }

        public Customer addCredit(string id, decimal amount)
        {
            var customer = this._customerRepository.FindById(id);
            customer.addAmount(amount);
            this._customerRepository.Update(id, customer);
            return customer;
        }
    }
}