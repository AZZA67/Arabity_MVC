using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arabitey.Models;
using Arabitey.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Arabitey.Repository
{
    public class PostRepository : IPostRepository
    {
        EntityContext context;
        SellingPostViewModel Svm;
        RentalPostViewModel Rvm;
        ICarRepository ic;
        public PostRepository(EntityContext _context)
        {
            context = _context;
        }
        public List<Post> GetAll() //home_page
        {

            return context.post.AsSplitQuery()
             .Include(a => a.car)
             .ThenInclude(c => c.carbrand)
             .Include(a => a.car)
             .ThenInclude(c => c.carModelName)
             .Include(a => a.car)
             .ThenInclude(c => c.carmodelyear)
             .ToList();
            //return context.post.ToList();
        }
        public Post GetById(int id)
        {
            return context.post.AsSplitQuery()
             .Include(a => a.car)
             .ThenInclude(c => c.carbrand)
             .Include(a => a.car)
             .ThenInclude(c => c.carModelName)
             .Include(a => a.car)
             .ThenInclude(c => c.carmodelyear)
             .Include(c=>c.car)
             .ThenInclude(i=>i.image)
             .Include(p=>p.Comments)
             .FirstOrDefault(c => c.ID == id);
        }
        public async Task<int> Insert(Post p)
        {
            context.post.Add(p);
            return await context.SaveChangesAsync();
        }
        //public int Update(int id, Post p)
        ////مننساش نتشيك عشان لو غير الايجار خلاه بيع دي محتاجه نتشيك ع حوار التواريخ 
        //{

        //    //Post oldpost= context.post.AsSplitQuery()
        //    //      .Include(p=>p.car)
        //    //      .ThenInclude(p => p.carbrand).
        //    //      Include(p => p.).FirstOrDefault(p => p.ID == id);

        //    //vio question about this query
        //    Post oldpost = context.post.AsSplitQuery()
        //     .Include(a => a.car)
        //     .ThenInclude(c => c.carbrand)
        //     .Include(a => a.car)
        //     .ThenInclude(c => c.carModelName)
        //     .Include(a => a.car)
        //     .ThenInclude(c => c.carmodelyear)
        //     .FirstOrDefault(p => p.ID == id);
        //    // Post oldpos=  context.post.Include(x => x.car.Include(y => y.model).Include(z => z.Brand));
        //    if (oldpost != null)
        //    {
        //        oldpost.Name = p.Name;
        //        oldpost.Rental_Start_DT = p.Rental_Start_DT;
        //        oldpost.Rental_End_DT = p.Rental_End_DT;
        //        oldpost.Description = p.Description;
        //        oldpost.adv_type = p.adv_type;
        //        oldpost.car.Car_Number = p.car.Car_Number;
        //        oldpost.car.Color = p.car.Color;
        //        oldpost.car.Price = p.car.Price;
        //        oldpost.car.Motion_vector = p.car.Motion_vector;
        //        oldpost.car.Distance = p.car.Distance;
        //        oldpost.car.carbrand.BrandName = p.car.carbrand.BrandName;
        //        oldpost.car.carModelName.ModelName = p.car.carModelName.ModelName;
        //        return context.SaveChanges();
        //    }
        //    return 0;
        //}
        public int Update(int id, Post p)
        {
            Post oldpost = context.post.AsSplitQuery()
             .Include(a => a.car)
             .ThenInclude(c => c.carbrand)
             .Include(a => a.car)
             .ThenInclude(c => c.carModelName)
             .Include(a => a.car)
             .ThenInclude(c => c.carmodelyear)
             .FirstOrDefault(p => p.ID == id);
            if (p != null)
            {

                oldpost.Name = p.Name;
                oldpost.Rental_Start_DT = p.Rental_Start_DT;
                oldpost.Rental_End_DT = p.Rental_End_DT;
                oldpost.Description = p.Description;
                oldpost.adv_type = p.adv_type;
                oldpost.car.Car_Number = p.car.Car_Number;
                oldpost.car.Color = p.car.Color;
                oldpost.car.Price = p.car.Price;
              //  oldpost.car.Motion_vector = p.car.Motion_vector;
                oldpost.car.Distance = p.car.Distance;
               // oldpost.car.carbrand.BrandName = p.car.carbrand.BrandName;
               // oldpost.car.carModelName.ModelName = p.car.carModelName.ModelName;
                return context.SaveChanges();
            }
            return 0;
        }
        public int Delete(int id) // featue to delete post by the user 
        {
            Post p = context.post.Include(c=>c.Comments).FirstOrDefault(p => p.ID == id);
            context.post.Remove(p);
            return context.SaveChanges();

        }
        public List<Post> GetByUserID(string userid) //user profile page
        {
            List<Post> posts =
                context.post.Where(p => p.userID == userid).ToList();
            return posts;
        }

    }
}
