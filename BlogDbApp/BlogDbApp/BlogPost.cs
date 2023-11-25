using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDbApp
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }

        public List<Picture> Pictures { get; set; } = new List<Picture>();

        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
