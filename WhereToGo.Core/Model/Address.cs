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
    public class Address :Entity<int>
    {
   
        [Required]
        public string  AddressID { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Longitude { get; set; }

        [Required]
        public string Latitude { get; set; }

        [Required]
        public string LocalAdddress { get; set; }
        [Required]
        public virtual Restaurant Restaurant { get; set; }
      
    }
}
