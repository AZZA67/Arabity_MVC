using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arabitey.Models
{
    public class CarModelYear
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Model Year  is required")]
        //[MinLength(4, ErrorMessage = "Model Year  must be  4 digit")]
        //[MaxLength(4, ErrorMessage = "Model Year  must be  4 digit")]
      
        public int ModelYear { get; set; }
        public virtual ICollection<Car> cars { get; set; }

       
       


    }
}
