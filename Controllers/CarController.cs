using Arabitey.Models;
using Arabitey.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Arabitey.Controllers
{
    public class CarController : Controller
    {
        EntityContext context = new EntityContext();

        private readonly IWebHostEnvironment _webhost;

        ICarRepository Car_Repository;
        ICarBrandRepository Brand_Repository;
        ICarModelNameRepository Model_Repository;
        ICarModelYearRepository Year_Repository;

        IImagesRepository I;

        public CarController(ICarRepository carrepository, ICarBrandRepository brandrepository, ICarModelNameRepository modelrepository, ICarModelYearRepository yearrepository, IWebHostEnvironment webhost, IImagesRepository I)
        {
            Car_Repository = carrepository;
            Brand_Repository = brandrepository;
            Model_Repository = modelrepository;
            Year_Repository = yearrepository;
            this.I = I;
            _webhost = webhost;

        }
        public IActionResult New()
        {
            List<CarBrand> brandlist = Brand_Repository.GetAll();
            ViewData["brands"] = brandlist;

            List<CarModelName> modellist = Model_Repository.GetAll();
            ViewData["models"] = modellist;
            List<CarModelYear> yearlist = Year_Repository.GetAll();
            ViewData["years"] = yearlist;
            return View(new Car());
        }

      
        public IActionResult SaveNew(Car car)
        {
            if (car.Name !=null)
            {
                Car_Repository.Insert(car);
            
         
                return RedirectToAction("Index","Home");
            }


            return View("New",car);
        }

        public IActionResult Edit(int id)
        {
            Car car = Car_Repository.GetById(id);
            List<CarBrand> brandlist = Brand_Repository.GetAll();
            ViewData["brands"] = brandlist;



            List<CarModelName> modellist = Model_Repository.GetAll();
            ViewData["models"] = modellist;
            List<CarModelYear> yearlist = Year_Repository.GetAll();
            ViewData["years"] = yearlist;
            return View("Edit", car);
        }




        public IActionResult SaveEdit([FromRoute] int id, Car NewCar)
        {
            if (NewCar.Name != null)
            {
                Car_Repository.Update(id, NewCar);
                return RedirectToAction("Index", "Home");
            }
            //not saved
            return View("Edit", NewCar);
        }

        
public IActionResult GetAllCarsbyBrandId(int Id)
        {
            List<Car> cars = Car_Repository.GetByBrandId(Id);
            return View("GetAllCarsbyBrandId", cars);
        }

     





        public IActionResult GetDetails(int Id)
{
    List<Car> instModel = Car_Repository.GetAll();
    Car car = Car_Repository.GetById(Id);
    return View("GetDetails", car);
}
        [Authorize(Roles = "Admin")]
        public IActionResult Remove(int id)
     {
            Car_Repository.Delete(id);
            return View("");
        }

    }


}
