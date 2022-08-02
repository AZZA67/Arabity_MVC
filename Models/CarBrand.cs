using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arabitey.Models
{
    public class CarBrand
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name Of Brand is required")]
        [MinLength(3, ErrorMessage = "Name Of Brand must be more than 3 characters")]
        [MaxLength(10, ErrorMessage = "Name Of Brand  must be less than 10 characters")]
      
        public string BrandName { get; set; }
        public virtual ICollection<Car> cars { get; set; }
        public virtual ICollection<CarModelName> carModelName { get; set; }
        //public virtual Images image { get; set; }
        // public List<Images> Photos { get; set; }
        //[FromForm]
        //[NotMapped]
        // public IFormFileCollection Files { get; set; }

    }
}
