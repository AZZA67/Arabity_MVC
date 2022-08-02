using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Arabitey.Models
{
    public class Car
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name of Car is required")]
        [MinLength(7, ErrorMessage = "Name must be more than 7 characters")]
      
        public string Name { get; set; }
        [Required(ErrorMessage = "Color is required")]
        [MinLength(3, ErrorMessage = " Color  must be more than 3 characters")]
        [MaxLength(20, ErrorMessage = " Color  must be less than 20 characters")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Car_Type is required")]
        [MinLength(5, ErrorMessage = " Car_Type  must be more than 3 characters")]
        [MaxLength(20, ErrorMessage = " Car_Type  must be less than 20 characters")]
        public string Car_Type { get; set; }
        [Required(ErrorMessage = "Motion_vector is required")]
        [MinLength(5, ErrorMessage = " Motion_vector must be more than 3 characters")]
        [MaxLength(20, ErrorMessage = "Motion_vector must be less than 20 characters")]
        public string Motion_vector { get; set; }
        [Required(ErrorMessage = "Distance is required")]
        public float Distance { get; set; }
        [Required(ErrorMessage = "Car_Number is required")]
        [MinLength(5, ErrorMessage = " Car_Number must be more than 4 characters")]
        [MaxLength(20, ErrorMessage = "Car_Number must be less than 8 characters")]

        public  string Car_Number { get; set; }
       // public string image { get; set; }
        
        [ForeignKey("carbrand")]
        public int BrandId { get; set; }
        [ForeignKey("carmodelyear")]
        public int carmoodyear { get; set; }
        [ForeignKey("carModelName")]
        public int carModName_id { get; set; }
        public virtual CarBrand carbrand { get; set; }
        public virtual CarModelYear carmodelyear { get; set; }
        public virtual CarModelName carModelName { get; set; }
        public virtual Post post { get; set; }
     //   public string image { get; set; }
        public virtual Images image{ get; set; }

        // public  List<Images> Photos { get; set; }
        // [FromForm]
        // [NotMapped]
        // public IFormFileCollection Files { get; set; }
    }
}
