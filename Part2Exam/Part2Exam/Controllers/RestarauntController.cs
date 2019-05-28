using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Part2Exam.Data;
using Part2Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Part2Exam.Controllers
{
    public class RestarauntController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RestarauntController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var restaurants = _db.Restaraunts.ToList();

            return View(restaurants);
        }


        public IActionResult Create(string Name)
        {
            _db.Restaraunts.Add(new Restaraunt { Name = Name });

            _db.SaveChanges();

            return View();
        }


        public IActionResult Put(int id, Restaraunt model)
        {
            var restaurant = _db.Restaraunts.Where(x => x.Id == id).FirstOrDefault();
            restaurant.Name = model.Name;
            _db.SaveChanges();
            return View();
        }


        public IActionResult GetById(int id)
        {
            var restaurant = _db.Restaraunts.Where(x => x.Id == id).FirstOrDefault();

            return View(restaurant);
        }

        public IActionResult Delete(int id)
        {
            var restaurant = _db.Restaraunts.Where(x => x.Id == id).FirstOrDefault();

            _db.Restaraunts.Remove(restaurant);

            return View();
        }

    }
}