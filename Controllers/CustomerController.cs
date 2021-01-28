using System.Collections.Generic;
using BookApi.Models;
using BookApi.Models.DTO;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController
    {
        private readonly CustomerService custumerService;
        public CustomerController(CustomerService customerService)
        {
            this.custumerService = customerService;
        }

        [HttpGet]
        public ActionResult<List<Customer>> FindAll()
        {
            return this.custumerService.GetList();
        }

        [HttpPost]
        public ActionResult<Customer> Create(Customer customer){
            return this.custumerService.Create(customer);
        }

        [HttpPatch]
        public ActionResult<Customer> addAmount(CreditDTO creditDTO) {
            return this.custumerService.addCredit(creditDTO.customer_id, creditDTO.amount);
        }
    }
}