using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    // Hinzufügen einer IActionResult Upload() Methode an das Ende des Controllers 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            // Extract file name from whatever was posted by browser
            var fileName = System.IO.Path.GetFileName(file.FileName);
 
        // If file with same name exists delete it
        if(System.IO.File.Exists(fileName))
        {
            System.IO.File.Delete(fileName);
        }
 
        // Create new local file and copy contents of uploaded file
        using(var localFile = System.IO.File.OpenWrite(fileName))
        using(var uploadedFile = file.OpenReadStream())
        {
            uploadedFile.CopyTo(localFile);
        }
        // Die ViewBag wird mit Erfolgsmeldung aktualisiert
        ViewBag.Message = "Datei erfolgreich hochgeladen!";
 
        return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
