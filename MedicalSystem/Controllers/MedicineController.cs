using System.Diagnostics;
using System.Linq;
using MedicalSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystem.Controllers
{
    public class MedicineController : Controller
    {
        private static int IndexOfDoctor;
        private static int IndexOfPrescription;

        public MedicineController()
        {
        }

        public IActionResult Index(int indexOfDoctor, int indexOfPrescription)
        {
            IndexOfDoctor = indexOfDoctor;
            IndexOfPrescription = indexOfPrescription;
            return View(TestDataBasePleaseDelete.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription));
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(MedicineViewModel medicineVm)
        {
            TestDataBasePleaseDelete.Doctors.ElementAt(IndexOfDoctor).Prescriptions.ElementAt(IndexOfPrescription).Medicines.Add(medicineVm);

            return RedirectToAction("index");
        }

        public IActionResult Delete(int indexOfMedicine)
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
