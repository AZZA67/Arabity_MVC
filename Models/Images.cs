using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Arabitey.Models
{
    public class Images
    {
        public int ID { get; set; }
        //[Required(ErrorMessage = "Image is required")]
        
        public string Image { get; set; }

        [ForeignKey("car")]
        public int car_ID { get; set; }

        //public virtual Post post { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public virtual Car car { get; set; }
    }
}
