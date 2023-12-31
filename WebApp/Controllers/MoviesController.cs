using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
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

       
      
    }
}