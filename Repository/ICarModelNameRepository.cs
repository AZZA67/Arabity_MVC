using Arabitey.Models;
using System.Collections.Generic;

namespace Arabitey.Repository
{
    public interface ICarModelNameRepository
    {
        int Delete(int id);
        int DeleteB(int id);
        List<CarModelName> GetAll();
        List<CarModelName> GetAllinBrandid(int id);
        int getbrandidformodelname(int id);
        CarModelName GetById(int id);
        List<CarModelName> GetModelsBasedOnBrand(int brandid);
        int Insertbasedonbrandid(int brandid, CarModelName n);
        int Update(int id, CarModelName ModelName);
    }
}