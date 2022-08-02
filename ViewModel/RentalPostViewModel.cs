using Arabitey.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arabitey.ViewModel
{
    public class RentalPostViewModel
    {
        [Required(ErrorMessage = "post_date is required")]
        public DateTime post_date { get; set; }
        [Required(ErrorMessage = "Tittle of post is required")]
        [MinLength(7, ErrorMessage = "Tittle of post must be more than 7 characters")]
      
        public string Name { get; set; } //view
        [Required(ErrorMessage = "Name Of Brand is required")]
        [MinLength(3, ErrorMessage = "Name Of Brand must be more than 3 characters")]
        [MaxLength(10, ErrorMessage = "Name Of Brand  must be less than 10 characters")]

      
        public string BrandName { get; set; }
        [Required(ErrorMessage = "Name Of ModelName  is required")]
        [MaxLength(10, ErrorMessage = "ModelName  must be less than 10 characters")]
        [MinLength(3, ErrorMessage = " ModelName  must be more than 3 characters")]
    
        public string ModelName { get; set; }
        [Required(ErrorMessage = "Model Year  is required")]
        //[MinLength(4, ErrorMessage = "Model Year  must be  4 digit")]
        //[MaxLength(4, ErrorMessage = "Model Year  must be  4 digit")]
   
        public int ModelYear { get; set; }
        [Required(ErrorMessage = "Car_Type is required")]
        [MinLength(5, ErrorMessage = " Car_Type  must be more than 3 characters")]
        [MaxLength(20, ErrorMessage = " Car_Type  must be less than 20 characters")]
        public string Car_Type { get; set; }
        [Remote(action: "CheckstartdateandePostdate", controller: "Post", AdditionalFields = "post_date", ErrorMessage = "Post date must be less than the Start time of rental car")]  //  customvalidator Clientside
        public DateTime Rental_Start_DT { get; set; }

        [ForeignKey("carbrand")]
        public int brandnameid { get; set; }
        [ForeignKey("carmodelyear")]
        public int carmoodyear { get; set; }
        [ForeignKey("carModelName")]
        public int carModName_id { get; set; }
        public virtual CarBrand carbrand { get; set; }
        public virtual CarModelYear carmodelyear { get; set; }
        public virtual CarModelName carModelName { get; set; }
        [Remote(action: "CheckstartandeEndtime", controller: "Post", AdditionalFields = "Rental_Start_DT", ErrorMessage = "Start Time of rental car must be less than the End time of rental car")]  //  customvalidator Clientside
        public DateTime Rental_End_DT { get; set; }
        [MinLength(10, ErrorMessage = "Description must be more than 3 characters")]
        [MaxLength(2000, ErrorMessage = "Description must be less than 2000 characters")]
        public string Description { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Color is required")]
        [MinLength(3, ErrorMessage = " Color  must be more than 3 characters")]
        [MaxLength(20, ErrorMessage = " Color  must be less than 20 characters")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Motion_vector is required")]
        [MinLength(5, ErrorMessage = " Motion_vector must be more than 3 characters")]
        [MaxLength(20, ErrorMessage = "Motion_vector must be less than 20 characters")]
        public string Motion_vector { get; set; }
        [Required(ErrorMessage = "Distance is required")]
        public float Distance { get; set; }
        [Required(ErrorMessage = "Car_Number is required")]
        [MinLength(5, ErrorMessage = " Car_Number must be more than 4 characters")]
        [MaxLength(20, ErrorMessage = "Car_Number must be less than 8 characters")]

        public string Car_Number { get; set; }
    }
}
