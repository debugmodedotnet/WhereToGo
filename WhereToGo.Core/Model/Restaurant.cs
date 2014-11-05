using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereToGo.Core.Shared;

namespace WhereToGo.Core.Model
{
    public class Restaurant : Entity<int>
    {
        [MaxLength(128)]
        [Required]
        public string RestaurantID { get; set; }
        [MaxLength(500)]
        [Required]
        public string RName { get; set; }
        public double RRating { get; set; }
        public double RStar { get; set; }

        public virtual Address RAddress { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ICollection<Comment> RComments { get; private set; }
        public ICollection<Snaps> RSnaps { get; private set; }
        public ICollection<Video> RVideos { get; private set; }

        public Restaurant()
        {
            RComments = new List<Comment>();
            RSnaps = new List<Snaps>();
            RVideos = new List<Video>();

        }

    }
}
