using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Arabitey.Models
{
    public class EntityContext : IdentityDbContext<ApplicationUser>
    {
        public EntityContext() : base()//onconfigu
        {

        }
        public EntityContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> car { get; set; }
        public DbSet<CarBrand> Carbrand { get; set; }
        public DbSet<CarModelYear> Modelyear { get; set; }
        public DbSet<CarModelName> Modelname { get; set; }

        public DbSet<Images> Image { get; set; }
        public DbSet<Post> post { get; set; }
        public DbSet<ApplicationUser> user{ get; set; }
        public DbSet<Comment> comment { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          

        }


    }
}
