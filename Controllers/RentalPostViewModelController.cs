using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arabitey.Repository;
using Arabitey.Models;
using Arabitey.ViewModel;
using Arabitey.Repository;
using Microsoft.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Arabitey.Controllers
{
    public class RentalPostViewModelController : Controller
    {
        EntityContext ec;
        IPostRepository ip;
        ICarRepository ic;
        IImagesRepository Iimage;
        private readonly IWebHostEnvironment _hostEnvironment;
        public RentalPostViewModelController(EntityContext Ec, IPostRepository Ip, ICarRepository Ic, IImagesRepository Iimage, IWebHostEnvironment hostEnvironment)
        {
            ec = Ec;
            ip = Ip;
            ic = Ic;
            this.Iimage = Iimage;
            this._hostEnvironment = hostEnvironment;
        }

        public IActionResult GetAll()
        {
            List<Post> posts = ip.GetAll();
            //List<Course> corModel = ec.course.ToList();
            return View(posts);
        }
        public IActionResult GetByID(int id)
        {
            return View(ip.GetById(id));
        }
        [Authorize]
        public IActionResult New()
        {
            List<CarModelName> models_names = ec.Modelname.ToList();
            List<CarModelYear> models_year = ec.Modelyear.ToList();
            List<CarBrand> brands = ec.Carbrand.ToList();
            ViewData["Models"] = models_names;
            ViewData["Brands"] = brands;
            ViewData["Years"] = models_year;
            return View(new RentalPostViewModel());
        }
        // int counter= 0;
        public IActionResult savenew(RentalPostViewModel vm)
        {
            if (vm.Name !=null)
            {
                Post p = new Post();
                Car c = new Car();
                Images i = new Images();
                c.Color = vm.Color;
                c.Distance = vm.Distance;
                c.Car_Number = vm.Car_Number;
                c.BrandId = vm.brandnameid;
                c.carModName_id = vm.carModName_id;
                c.carmoodyear = vm.carmoodyear;
                c.Price = vm.Price;
                c.Car_Type = vm.Car_Type;
                c.Name = "user";
                c.Motion_vector = vm.Motion_vector;
                ic.Insert(c);
                i.car_ID = c.ID;
                i.ImageFile = vm.ImageFile;
                i.Image = vm.Image;
                Iimage.Insert(i);
                int fk = c.ID;
                p.adv_type = "Rental";
                p.Rental_Start_DT = vm.Rental_Start_DT;
                p.Rental_End_DT = vm.Rental_End_DT;
                p.Name = vm.Name;
                p.post_date = vm.post_date;
                p.Description = vm.Description;
                // p.car = c;
                p.carID = fk;
                p.post_date = DateTime.Now;
                p.userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                // c.post = p;
                ip.Insert(p);
                return RedirectToAction("GetAll", "SellingPostViewModel");
            }
            return View("New", vm);
        }

        public IActionResult Edit(int id)
        {
            Post p = ec.post.Include(p => p.car).FirstOrDefault(p => p.ID == id);

            List<CarModelName> models_names = ec.Modelname.ToList();
            List<CarModelYear> models_year = ec.Modelyear.ToList();
            List<CarBrand> brands = ec.Carbrand.ToList();
            ViewData["Models"] = models_names;
            ViewData["Brands"] = brands;
            ViewData["Years"] = models_year;
            return View("Edit", p);
        }
        [HttpPost]
        public IActionResult saveEdit(int pid, Post p)
        {
            if (p.Name != null)
            {
                Post post = ec.post.FirstOrDefault(p => p.ID == pid);
                // Car c = ec.car.FirstOrDefault(c => c.ID == post.carID);
                // Images i = ec.Image.FirstOrDefault(i => i.car_ID == post.carID);
                ip.Update(p.ID, p);
                //ic.Update(c.ID, c);
                //  Iimage.Insert( i);
                ec.SaveChanges();
                return RedirectToAction("GetAll");
            }

            List<CarModelName> models_names = ec.Modelname.ToList();
            List<CarModelYear> models_year = ec.Modelyear.ToList();
            List<CarBrand> brands = ec.Carbrand.ToList();
            ViewData["Models"] = models_names;
            ViewData["Brands"] = brands;
            ViewData["Years"] = models_year;
            return View("Edit", p);
        }
        public IActionResult Comment()
        {

            return View("New");
        }
        public IActionResult GetmodelnameBybrandname(int bramdid)
        {
            List<CarModelName> cmn =
                ec.Modelname.Where(m => m.BrandId == bramdid).ToList();
            return Json(cmn);
        }

    }
}
