using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Arabitey.Models
{
    public class Post
    {


        //  نسالها علي ازاي خليه ينزل بوست وفي نفس الوقت يحط بيانات الكار والكار سبسيفيكيشن في نفس الفيو  
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tittle of post is required")]
        [MinLength(7, ErrorMessage = "Tittle of post must be more than 7 characters")]
     
        public string Name { get; set; } //view
        [Required(ErrorMessage = "adv_type is required")]
        [MinLength(4, ErrorMessage = "adv_type must be more than 3 characters")]
        [MaxLength(20, ErrorMessage = "adv_type must be less than 10 characters")]
        public string adv_type { get; set; }
        [Required(ErrorMessage = "post_date is required")]
        public DateTime post_date { get; set; }
        [Remote(action: "CheckstartdateandePostdate", controller: "Post", AdditionalFields = "post_date", ErrorMessage = "Post date must be less than the Start time of rental car")]  //  customvalidator Clientside
        public DateTime Rental_Start_DT { get; set; }
        [Remote(action: "CheckstartandeEndtime", controller: "Post", AdditionalFields = "Rental_Start_DT", ErrorMessage = "Start Time of rental car must be less than the End time of rental car")]  //  customvalidator Clientside
        public DateTime Rental_End_DT { get; set; }
        [MinLength(10, ErrorMessage = "Description must be more than 3 characters")]
        [MaxLength(2000, ErrorMessage = "Description must be less than 2000 characters")]
        public string Description { get; set; }
        [ForeignKey("user")]
        public string userID { get; set; }
        [ForeignKey("car")]
        public int carID { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Car car { get; set; }
      //  public virtual ICollection<Images> images { get; set; }
        public virtual ApplicationUser user { get; set; }
    }
}
