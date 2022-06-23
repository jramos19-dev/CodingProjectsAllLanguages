using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Packt.Shared
{
    public class Category
    {
        public int CategoryID{get;set;}

        [Required]
        [StringLength(15)]
        public string CategoryName{get;set;}

        public string description{get; set;}
    }
}