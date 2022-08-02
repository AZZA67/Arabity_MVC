using Microsoft.AspNetCore.Mvc;
using Arabitey.Repository;
using Arabitey.Models;
using System.Collections.Generic;

namespace Arabitey.Controllers
{
    public class CarModelNameController : Controller
    {
        ICarModelNameRepository carModelNameRepository;
        ICarBrandRepository CarBrandRepository;
        public CarModelNameController(ICarModelNameRepository modelnameRepo, ICarBrandRepository brandrepo)
        {
            carModelNameRepository = modelnameRepo;
            CarBrandRepository = brandrepo;
        }
        public IActionResult GetAllinBrandid(int id)
        {
            List<CarModelName> modelnamelist = carModelNameRepository.GetAllinBrandid(id);
            ViewData["brandiD"] = id;
            return View("GetAllinBrandid", modelnamelist);

        }


        [HttpGet]
        public IActionResult NewModelNameinbrand(int id)
        {
            List<CarModelName> modelnamelist = carModelNameRepository.GetAllinBrandid(id);
            ViewData["BrandID"] = id;
            return View("NewModelName");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNewModelNameinbrand(int id, CarModelName n)
        {

            if (ModelState.IsValid == true)
            {

                carModelNameRepository.Insertbasedonbrandid(id, n);
                return RedirectToAction("GetAllinBrandid",new { Id=id});

            }

            ModelState.AddModelError("ModelName", "Name Must Be Required");
            return View("NewModelName", n);

        }


        public IActionResult EditModelname(int id)
        {
            CarModelName carmodelname = carModelNameRepository.GetById(id);


            return View("EditModelname", carmodelname);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEditModelname(int id, int brandid, CarModelName n)
        {
            if (ModelState.IsValid == true)
            {

                carModelNameRepository.Update(id, n);

                return RedirectToAction("GetAllinBrandid", new { id = brandid });
            }


            return View("EditModelname", n);
        }


        public IActionResult Remove(int id)
        {
            int brandid = carModelNameRepository.getbrandidformodelname(id);
            carModelNameRepository.Delete(id);

            return RedirectToAction("GetAllinBrandid", new { id = brandid });


        }




    }
}
