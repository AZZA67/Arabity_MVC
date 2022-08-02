using Arabitey.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Arabitey.Repository
{
    public class CarRepository : ICarRepository
    {
        EntityContext context;
        IImagesRepository I;
        public CarRepository(EntityContext _context, IImagesRepository I)
        {
            context = _context;
            this.I = I;
        }
        public List<Car> GetAll()
        {
            return context.car.Include(b => b.carbrand).Include(m => m.carModelName)
                .Include(y => y.carmodelyear).ToList();
        }
        public Car GetById(int id)
        {
           return context.car.Include(b => b.carbrand).
                Include(m => m.carModelName).Include(y => y.carmodelyear).Include(c=>c.image).FirstOrDefault(c => c.ID == id);
      
        }
        public int Insert(Car car)
        {

            context.car.Add(car);
            int raws = context.SaveChanges();
            return raws;
        }
        public int Update(int id, Car car)
        {
            Car oldcar = context.car.Include(b => b.carbrand).Include(m => m.carModelName).Include(y => y.carmodelyear).FirstOrDefault(c => c.ID == id);
            if (oldcar != null)
            {
                oldcar.Name = car.Name;
                oldcar.Color = car.Color;
                oldcar.Price = car.Price;
                oldcar.Car_Type = car.Car_Type;
                oldcar.Motion_vector = car.Motion_vector;
                oldcar.Distance = car.Distance;
                oldcar.Car_Number = car.Car_Number;
                // oldcar.Photos = car.Photos;
                oldcar.carbrand.BrandName = car.carbrand.BrandName;
                oldcar.carModelName.ModelName = car.carModelName.ModelName;
                oldcar.carmodelyear.ModelYear = car.carmodelyear.ModelYear;


                int raws = context.SaveChanges();
                return raws;

            }
            return 0;
        }
        public List<Car> GetByBrandId(int brand_id)
        {

            List<Car> cars = context.car.Include(b => b.carbrand).
                Include(m => m.carModelName).Include(y => y.carmodelyear).Include(c => c.image).Where(c => c.BrandId == brand_id).ToList();
            return cars;
        }


        public int Delete(int id)
        {
            context.car.Remove(GetById(id));
            int raws = context.SaveChanges();

            return raws;
        }


        public List<Car> GetByModelName(int brand_id)
        {
            List<Car> cars =
                context.car.Where(M => M.carModName_id == brand_id).ToList();
            return cars;
        }

       
        public int DeleteC(int id)
        {
            foreach (var item in context.car.Where(c => c.BrandId == id))
            { context.car.Remove(item); }

            int raws = context.SaveChanges();

            return raws;
        }
    }
}
