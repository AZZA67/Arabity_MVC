using Arabitey.Models;
using System.Collections.Generic;

namespace Arabitey.Repository
{
    public interface ICarModelYearRepository
    {
        int Delete(int id);
        List<CarModelYear> GetAll();
        CarModelYear GetById(int id);
        int Insert(CarModelYear modelyear);
        int Update(int id, CarModelYear modelyear);
    }
}