using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        
        
        public string Name { get; set; }

        
        public DateTime? Birthdate { get; set; }

        public bool IsEligible { get; set; }
    }
}