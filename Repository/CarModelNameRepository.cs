using Arabitey.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Arabitey.Repository
{
    public class CarModelNameRepository : ICarModelNameRepository
    {
        EntityContext context;
        public CarModelNameRepository(EntityContext _context)
        {
            context = _context;
        }
        public List<CarModelName> GetAll()
        {
            return context.Modelname.Include(n => n.carBrand).ToList();

        }
        public CarModelName GetById(int id)
        {
            return context.Modelname.Include(n => n.carBrand).FirstOrDefault(c => c.ID == id);
        }
        public List<CarModelName> GetAllinBrandid(int id)
        {
            List<CarModelName> modelnamelist = context.Modelname.Include(m=>m.carBrand).Where(m => m.BrandId == id).ToList();
            return modelnamelist;
        }
        public int Insertbasedonbrandid(int brandid, CarModelName n)
        {
            CarModelName Name = new CarModelName();
            Name.BrandId = brandid;
            Name.ModelName = n.ModelName;
            context.Modelname.Add(Name);
            int raws = context.SaveChanges();
            return raws;
        }

        public int Update(int id, CarModelName ModelName)
        {
            CarModelName oldModelName = GetById(id);
            if (oldModelName != null)
            {


                oldModelName.ModelName = ModelName.ModelName;
                oldModelName.cars = ModelName.cars;

                int raws = context.SaveChanges();
                return raws;

            }
            return 0;
        }
        public List<CarModelName> GetModelsBasedOnBrand(int brandid)
        {
            return context.Modelname.Where(m => m.BrandId == brandid).ToList();
        }
        public int getbrandidformodelname(int id)
        {
            CarModelName n = context.Modelname.FirstOrDefault(m => m.ID == id);
            int brandid = n.BrandId;


            return brandid;
        }

        public int Delete(int id)
        {
            context.Modelname.Remove(GetById(id));
            int raws = context.SaveChanges();

            return raws;
        }
        public int DeleteB(int id)
        {
            foreach (var item in context.Modelname.Where(c => c.BrandId == id))
            { context.Modelname.Remove(item); }
            int raws = context.SaveChanges();

            return raws;
        }
    }
}
