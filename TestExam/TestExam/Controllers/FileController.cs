using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestExam.Models;


namespace TestExam.Controllers
{
    public class FileController : Controller
    {
        private ApplicationDbContext _context;
        IHostingEnvironment _appEnvironment;
        public FileController(ApplicationDbContext context, IHostingEnvironment appEnvironment)
        {

            _context = context;
            _appEnvironment = appEnvironment;
            
        }

        public IActionResult Files()
        {
            List<Models.File> model = new List<Models.File>();
            foreach (var file in _context.Files)
                model.Add(new Models.File { Id = file.Id, Name = file.Name, ShortDescription = file.ShortDescription });
            return View(model.AsEnumerable());
        }

        public IActionResult AddFile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(FileViewModel file)
        {
            if (file.UploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + file.UploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await file.UploadedFile.CopyToAsync(fileStream);
                }

                Models.File newFile = new Models.File{ Name = file.UploadedFile.FileName, Path = path, ShortDescription = file.ShortDescription, Description = file.Description };
                _context.Files.Add(newFile);
                _context.SaveChanges();
            }
           return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Download(int id)
        {
            var file = _context.Files.First(x => x.Id == id);
            return PhysicalFile(_appEnvironment.WebRootPath + file.Path, file.Name);
        }

        private IActionResult PhysicalFile(string v, object type, string name)
        {
            throw new NotImplementedException();
        }
    }

}