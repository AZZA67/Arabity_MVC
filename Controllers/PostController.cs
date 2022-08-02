using Arabitey.Models;
using Arabitey.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arabitey.Controllers
{
    public class PostController : Controller
    {
        IPostRepository ip;
        public PostController(IPostRepository _ip)
        {
            ip = _ip;
        }
        public IActionResult Index()
        {
            ip.GetAll();
            return View();
        }
        public IActionResult New()
        {
            return View(new Post());
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult SaveNew(Post p)
        {

            if (ModelState.IsValid == true)
            {
                ip.Insert(p);
                return RedirectToAction("Index");
            }
            return View("New", p);
        }
        public IActionResult CheckstartandeEndtime(DateTime Rental_Start_DT, DateTime Rental_End_DT)
        {
            //if (Rental_Start_DT < Rental_End_DT)

            //{
            //    return Json(true);
            //}
            //else
            //{
            //    return Json(false);
            //}
            return Json(true);

        }

        public IActionResult CheckstartdateandePostdate(DateTime Rental_Start_DT, DateTime post_date)
        {
            //if (Rental_Start_DT > post_date)

            //{
            //    return Json(true);
            //}
            //else
            //{
            //    return Json(false);
            //}
            return Json(true);

        }



    }
}
