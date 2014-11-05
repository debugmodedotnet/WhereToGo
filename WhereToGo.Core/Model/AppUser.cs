using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereToGo.Core.Shared;

namespace WhereToGo.Core.Model
{
    public class AppUser: Entity<int>
    {
  
        [Required]
        public string AppUserID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual ICollection<Snaps> Snaps { get; private set; }

        public virtual ICollection<Video> Videos { get; private set; }
        public AppUser()
        {
            Snaps = new List<Snaps>();
            Videos = new List<Video>();
        }


    }
}
