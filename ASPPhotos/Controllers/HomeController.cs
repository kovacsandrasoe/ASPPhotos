using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPPhotos.Models;
using Microsoft.AspNetCore.Http;
using ASPPhotos.Data;

namespace ASPPhotos.Controllers
{
    public class HomeController : Controller
    {
        BusinessLogic bl;

        //dep.inj tölti be a PhotoContext-et
        public HomeController(PhotoContext context)
        {
            bl = new BusinessLogic(context);
        }

        public IActionResult Index()
        {
            return View(bl.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult Add(PhotoViewModel viewmodel)
        {
            bl.AddPhoto(viewmodel);
            return RedirectToAction("Index");
        }

        public FileContentResult GetImage(int photoid)
        {
            var model = bl.GetPhotoById(photoid);
            return File(model.PhotoData, model.ContentType);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
