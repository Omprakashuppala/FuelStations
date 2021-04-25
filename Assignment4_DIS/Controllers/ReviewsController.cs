using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4_DIS.Models;
using Assignment4_DIS.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Assignment4_DIS.Controllers
{
    public class ReviewsController : Controller
    {[HttpGet]
        public IActionResult Reviews()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            
            optionsBuilder.UseSqlServer(ApplicationDbContext.GetConnectionString());
            using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
            {
                var reviewrecords = dbContext.Reviews.ToList();
                var reviews = new Reviews();
                reviews.reviewRecords = reviewrecords;
                return View(reviews);
            }
        }

        [HttpPost]
        public IActionResult DeleteReview(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(ApplicationDbContext.GetConnectionString());
            using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
            {
                var review = new ReviewRecord() { Id = id };
                dbContext.Reviews.Remove(review);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Reviews");
        }

        [HttpPost]
        public IActionResult AddReview(string name, string address, string customerName, string email, string Review)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(ApplicationDbContext.GetConnectionString());
            using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
            {
                var review = new ReviewRecord();
                review.FuelStation_Name = name;
                review.FuelSTation_Address = address;
                review.CustomerName = customerName;
                review.Customer_Email = email;
                review.Review = Review;
                //Adding to DB
                dbContext.Reviews.Add(review);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Reviews");
        }

       
    }
}
