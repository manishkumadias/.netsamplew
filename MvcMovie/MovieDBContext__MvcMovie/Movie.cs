using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
 

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime ReleaseDate { get; set; }

       
        public string Genre { get; set; }

        [Required(ErrorMessage = "Price Required")]
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        public decimal Price { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }


    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Project { get; set; }
        public string Skill { get; set; }



        
    }
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}