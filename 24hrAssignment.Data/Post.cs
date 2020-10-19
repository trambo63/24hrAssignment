using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24hrAssignment.Data
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [ForeignKey(nameof(UserID))]
        public virtual User UserID { get; set; }
        public User Author { get; set; }
    }
}
