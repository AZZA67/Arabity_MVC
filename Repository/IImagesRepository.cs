using Arabitey.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arabitey.Repository
{
    public interface IImagesRepository
    {
        int Delete(int id);
        List<Images> GetAll();
        Images GetById(int id);
        Task<int> Insert(Images image);
        int Update(int id, Images image);
    }
}