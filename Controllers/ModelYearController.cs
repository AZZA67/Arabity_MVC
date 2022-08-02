using Arabitey.Models;
using Arabitey.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Arabitey.Controllers
{
    public class ModelYearController : Controller
    {
        ICarModelYearRepository icarmodelyearrepository;
        public ModelYearController(ICarModelYearRepository _icarmodelyearrepository)
        {
            icarmodelyearrepository = _icarmodelyearrepository;
        }
        public IActionResult GetAll()
        {
            List<CarModelYear> ModelYearlist = icarmodelyearrepository.GetAll();
            return View("GetAll", ModelYearlist);
        }
        public IActionResult GetDetails([FromRoute] int id)
        {
            CarModelYear modelyearobj = icarmodelyearrepository.GetById(id);
            return View("GetDetails", modelyearobj);
        }
        [HttpGet]
        public IActionResult NewModelyear()
        {
            List<CarModelYear> ModelYearlist = icarmodelyearrepository.GetAll();

            return View("NewModelyear");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNewModelyear(CarModelYear y)
        {
            if (ModelState.IsValid)

            {
                try
                {
                    int effectedraws = icarmodelyearrepository.Insert(y);
                    return RedirectToAction("GetAll");
                }
                catch
                {
                    return View("NewModelyear", y);
                }
            }
            else
            { return View("NewModelyear", y); }
        }

        [HttpGet]
        public IActionResult Editmodelyear([FromRoute] int id)
        {
            CarModelYear modelyearobj = icarmodelyearrepository.GetById(id);

            return View("Editmodelyear", modelyearobj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEditmodelyear([FromRoute] int id, CarModelYear y)
        {
            if (ModelState.IsValid)

            {
                try
                {
                    int effectedraws = icarmodelyearrepository.Update(id, y);
                    return RedirectToAction("GetAll");
                }
                catch
                {
                    return View("Editmodelyear", y);
                }
            }
            else
            { return View("Editmodelyear", y); }
        }
        public IActionResult Deletemodelyear([FromRoute] int id)
        {
            int effectedraws = icarmodelyearrepository.Delete(id);
            List<CarModelYear> ModelYearlist = icarmodelyearrepository.GetAll();

            return View("GetAll", ModelYearlist);
        }
    }
}
