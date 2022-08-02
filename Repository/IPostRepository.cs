using Arabitey.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arabitey.Repository
{
    public interface IPostRepository
    {
        int Delete(int id);
        List<Post> GetAll();
        Post GetById(int id);
        List<Post> GetByUserID(string userid);
        Task<int>Insert(Post p);
        int Update(int id, Post p);
    }
}