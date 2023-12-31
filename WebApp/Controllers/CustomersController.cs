using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class CustomersController : Controller
    {    
        // GET: Customers/Details
        public ActionResult Details()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Francis"},
                new Customer {Id = 2, Name = "Aurelie"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };
            return View(viewModel);         
        }
        public ActionResult New() 
        {

            //Implementation needed
            // ItemFromDB = _context.___.Tolist();
          
            return View();
        }
        [HttpPost]
        public ActionResult Save(Customer customer) 
        {
            if(customer.Id == 0 ) 
            _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.Birthdate;
                customerInDb.IsEligible = customer.IsEligible;
            }
            _context.SaveChange();
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id) 
        {
            var customer = _context.Customes.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var
                viewMole = new CustomerFormViewModel



                {
                    Customer = customer
                };

            return View("CustomerForm", viewMole);
        }

    }
}