using Arabitey.Models;
using Arabitey.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace Arabitey.Controllers
{
    public class BrandController : Controller
    {
        ICarBrandRepository icarbrandrepository;
        ICarModelNameRepository carModelNameRepository;
        ICarRepository Car_Repository;
        private readonly IWebHostEnvironment _webhost;
        public BrandController(ICarBrandRepository _icarbrandrepository, ICarModelNameRepository _carModelNameRepository, ICarRepository _Car_Repository, IWebHostEnvironment webhost)
        {
            icarbrandrepository = _icarbrandrepository;
            carModelNameRepository = _carModelNameRepository;
            Car_Repository = _Car_Repository;
            _webhost = webhost;
        }
        public IActionResult GetAll()
        {
            List<CarBrand> Brandlist = icarbrandrepository.GetAll();
            return View("GetAllwithCars", Brandlist);
        }
        public IActionResult GetAllwithCars()
        {
            List<CarBrand> Brandlist = icarbrandrepository.GetAll();
            return View("GetAllwithCars", Brandlist);
        }
        public IActionResult GetDetails([FromRoute] int id)
        {
            CarBrand Brandobj = icarbrandrepository.GetById(id);
            return View("GetDetails", Brandobj);
        }

        [HttpGet]
      
        public IActionResult NewBrand()
        {
            List<CarBrand> Brandlist = icarbrandrepository.GetAll();

            return View("NewBrand");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNewBrand(CarBrand b)
        {
            if (ModelState.IsValid)

            {
                int effectedraws = icarbrandrepository.Insert(b);


                return RedirectToAction("Index","Home");



            }

            else
            {
                return View("NewBrand", b);
            }

        }

        [HttpGet]
        public IActionResult EditBrand([FromRoute] int id)
        {
            CarBrand Brandobj = icarbrandrepository.GetById(id);

            return View("EditBrand", Brandobj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEditBrand([FromRoute] int id, CarBrand b)
        {
            if (ModelState.IsValid)

            {
                try
                {
                    int effectedraws = icarbrandrepository.Update(id, b);
                    return RedirectToAction("GetAllwithCars");
                }
                catch
                {
                    return View("EditBrand", b);
                }
            }
            else
            { return View("EditBrand", b); }
        }
        public IActionResult DeleteBrand([FromRoute] int id)
        {
            int effectedrawscar = Car_Repository.DeleteC(id);
            int effectedrawsmodelname = carModelNameRepository.DeleteB(id);
            int effectedrawsbrand = icarbrandrepository.Delete(id);


            List<CarBrand> Brandlist = icarbrandrepository.GetAll();

            return RedirectToAction("GetAllwithCars", "Home", Brandlist);
        }
        public IActionResult DisplayCarBrands(int brandid)
        {
            List<Car> CartModel = Car_Repository.GetByBrandId(brandid);
            return View("GetAll", CartModel);
        }
    }
}
