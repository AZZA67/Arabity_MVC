using Arabitey.Models;
using System.Collections.Generic;

namespace Arabitey.Repository
{
    public interface ICarBrandRepository
    {
        int Delete(int id);
        List<CarBrand> GetAll();
        List<Car> GetByBrandId(int brand_id);
        CarBrand GetById(int id);
        int Insert(CarBrand carbrand);
        int Update(int id, CarBrand carbrand);
    }
}