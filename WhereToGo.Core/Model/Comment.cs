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
    public class Comment : Entity<int>
    {

        [Required]
        public string CommentID { get; set; }

        [MinLength(50)]
        [Required]
        public string FeedBack { get; set; }

        [Required]
        public int URatings { get; set; }

        public virtual ICollection<Snaps> Photos { get; private set; }

        public virtual ICollection<Video> Videos { get; private set; }

        [Required]
        public virtual Restaurant Restaurant { get; set; }
        [Required]
        public virtual AppUser AppUser { get; set; }

        public Comment()
        {
            Photos = new List<Snaps>();
            Videos = new List<Video>();
        }



    }
}
