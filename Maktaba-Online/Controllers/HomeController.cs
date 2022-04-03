using Maktaba_Online.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Maktaba_Online.Controllers
{
    public class HomeController : Controller
    {
        MaktabaContext db = new MaktabaContext();



        public IActionResult Index()
        {
            var depts = db.Departments.ToList();
            ViewBag.Books = db.Books.ToList();
            return View(depts);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Departments()
        {
            var depts = db.Departments.ToList();

            return View(depts);
        }
        public IActionResult Books(int id)
        {
            
            var Books = db.Books.Where(x=>x.Deptid == id).ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}