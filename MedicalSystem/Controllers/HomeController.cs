using System.Diagnostics;
using System.Linq;
using MedicalSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystem.Controllers
{
    public class HomeController : Controller
    {



        public HomeController()
        {
        }

        public IActionResult Index(string filterString)
        {
            if(string.IsNullOrEmpty(filterString))
            {
                return View(TestDataBasePleaseDelete.Doctors);
            }

            return View(TestDataBasePleaseDelete.Doctors.Where(x=> x.Name.Contains(filterString)).ToList());
            
        }

        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction("Index", "Prescription", new { indexOfDoctor = indexOfDoctor});
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DoctorViewModel doctorVm)
        {
            TestDataBasePleaseDelete.Doctors.Add(doctorVm);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int indexOfDoctor)
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
