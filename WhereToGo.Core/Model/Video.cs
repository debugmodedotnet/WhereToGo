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
    public class Video :Entity<int>
    {


        [MaxLength(128)]

        public string VideoID { get; protected set; }
        
        [Required]
        public string SUrl { get; set; }

        public string UserID { get; set; }

        [Required]
        public virtual Restaurant Restaurant { get; set; }

        [Required]
        public virtual AppUser AppUser { get; set; }

    }
}
