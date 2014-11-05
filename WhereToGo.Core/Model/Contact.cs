using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereToGo.Core.Shared;

namespace WhereToGo.Core.Model
{
    public class Contact : Entity<int>
    {
        [Required]
        public string ContactID { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public ICollection<string> PhoneNumbers { get; private set; }
        [Required]
        public string Email { get; set; }
        [Required] 
        public virtual Restaurant Resturant { get; set; }

        public Contact()
        {
            PhoneNumbers = new List<string>();
        }

    }
}
