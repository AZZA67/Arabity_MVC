using Arabitey.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Arabitey.Repository
{
    public class CarModelYearRepository : ICarModelYearRepository
    {

        EntityContext context;
        public CarModelYearRepository(EntityContext _context)
        {
            context = _context;
        }
        public List<CarModelYear> GetAll()
        {
            return context.Modelyear.ToList();

        }
        public CarModelYear GetById(int id)
        {
            return context.Modelyear.FirstOrDefault(c => c.ID == id);
        }
        public int Insert(CarModelYear modelyear)
        {
            context.Modelyear.Add(modelyear);
            int raws = context.SaveChanges();
            return raws;
        }

        public int Update(int id, CarModelYear modelyear)
        {
            CarModelYear oldmodelyear = GetById(id);
            if (oldmodelyear != null)
            {


                oldmodelyear.ModelYear = modelyear.ModelYear;
                oldmodelyear.cars = modelyear.cars;

                int raws = context.SaveChanges();
                return raws;

            }
            return 0;
        }

        public int Delete(int id)
        {
            context.Modelyear.Remove(GetById(id));
            int raws = context.SaveChanges();

            return raws;
        }
    }
}
