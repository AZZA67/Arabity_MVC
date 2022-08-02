using Arabitey.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Arabitey.Repository
{
    public class CarBrandRepository : ICarBrandRepository
    {
        EntityContext context;
        public CarBrandRepository(EntityContext _context)
        {
            context = _context;
        }
        public List<CarBrand> GetAll()
        {
            return context.Carbrand.Include(c=>c.carModelName)
                .Include(c=>c.cars).ThenInclude(c=>c.carmodelyear).ToList();

        }
        public CarBrand GetById(int id)
        {
            return context.Carbrand.Include(b => b.carModelName).FirstOrDefault(c => c.ID == id);
        }
        public int Insert(CarBrand carbrand)
        {
            context.Carbrand.Add(carbrand);
            int raws = context.SaveChanges();
            return raws;
        }
        public List<Car> GetByBrandId(int brand_id)
        {
            List<Car> cars =
                context.car.Where(B => B.BrandId == brand_id).ToList();
            return cars;
        }

        public int Update(int id, CarBrand carbrand)
        {
            CarBrand oldbrand = GetById(id);
            if (oldbrand != null)
            {


                oldbrand.BrandName = carbrand.BrandName;
                oldbrand.cars = carbrand.cars;


                int raws = context.SaveChanges();
                return raws;

            }
            return 0;
        }

        public int Delete(int id)
        {
            context.Carbrand.Remove(context.Carbrand.FirstOrDefault(c => c.ID == id));
            int raws = context.SaveChanges();

            return raws;
        }
    }
}
