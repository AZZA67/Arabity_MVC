using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arabitey.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string National_ID { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Post> posts { get; set; }
    }
}
