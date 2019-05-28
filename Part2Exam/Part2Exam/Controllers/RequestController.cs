using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Part2Exam.Data;
using Part2Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Part2Exam.Controllers
{
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RequestController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpPost("")]
        public IActionResult CreateRequest(Menu menu)
        {




            return View();
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}