using Arabitey.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Arabitey.Repository
{
    public class ImagesRepository : IImagesRepository
    {
        EntityContext context;

        private readonly IWebHostEnvironment _hostEnvironment;


        public ImagesRepository(EntityContext _context, IWebHostEnvironment hostEnvironment)
        {
            context = _context;
            this._hostEnvironment = hostEnvironment;
        }
        public List<Images> GetAll()
        {
            return context.Image.ToList();
        }
        public Images GetById(int id)
        {
            return context.Image.FirstOrDefault(i => i.ID == id);
        }
        //upload images

        public  async Task<int> Insert([Bind("ID","ImageFile")] Images image )
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(image.ImageFile.FileName);
            string extension = Path.GetExtension(image.ImageFile.FileName);
            image.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + @"\images\", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await image.ImageFile.CopyToAsync(fileStream);

            }
            //Insert record
            context.Image.Add(image);
            return await context.SaveChangesAsync();
        }

        public int Update(int id, Images image)
        {
            Images oldimage = context.Image.FirstOrDefault(i => i.ID == id);
            if (oldimage != null)
            {

                oldimage.ID = image.ID;
                oldimage.Image = image.Image;

                return context.SaveChanges();


            }
            return 0;
        }

        public int Delete(int id)
        {
            context.Image.Remove(GetById(id));
            return context.SaveChanges();


        }
    }
}

