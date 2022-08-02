using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arabitey.Models
{
    public class CarModelName
    {
        public int ID { get; set; }
        [Required(ErrorMessage = " ModelName  is required")]
        [MaxLength(10, ErrorMessage = "ModelName  must be less than 10 characters")]
        [MinLength(3, ErrorMessage = " ModelName  must be more than 3 characters")]
     
        public string ModelName { get; set; }
        public virtual ICollection<Car> cars { get; set; }

        [ForeignKey("carBrand")]
        public int BrandId { get; set; }
        public virtual CarBrand carBrand { get; set; }

        //[ForeignKey("carmodelyear")]
        //public int ModelYearID { get; set; }
        //public virtual CarModelYear carmodelyear { get; set; }


    }
}
