using Arabitey.Models;
using System.Collections.Generic;

namespace Arabitey.Repository
{
    public interface ICarRepository
    {
        int Delete(int id);
        int DeleteC(int id);
        List<Car> GetAll();
        List<Car> GetByBrandId(int brand_id);
        Car GetById(int id);
        List<Car> GetByModelName(int brand_id);
        int Insert(Car car);
        int Update(int id, Car car);
    }
}