using System.Diagnostics;
using System.Linq;
using MedicalSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystem.Controllers
{
    public class PrescriptionController : Controller
    {
        private static int IndexOfDoctor { get; set; }

        public PrescriptionController()
        { 
        }

        public IActionResult Index(int indexOfDoctor)
        {
            IndexOfDoctor = indexOfDoctor;

 

            return View(TestDataBasePleaseDelete.Doctors.ElementAt(indexOfDoctor));
        }

        public IActionResult View(int indexOfPrescription)
        {
            return RedirectToAction("index", "Medicine", new { indexOfDoctor = IndexOfDoctor, indexOfPrescription = indexOfPrescription });
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PrescriptionViewModel prescriptionVm)
        {
            TestDataBasePleaseDelete.Doctors.ElementAt(IndexOfDoctor).Prescriptions.Add(prescriptionVm);

            return RedirectToAction("index");
        }
        public IActionResult Delete(int indexOfPrescription)
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
