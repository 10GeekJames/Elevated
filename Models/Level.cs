using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Elevated.Models
{
    public class Level
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dialog1 { get; set; }
        public string Dialog2 { get; set; }
        public string Dialog3 { get; set; }
        public string Dialog4 { get; set; }
        public string Dialog5 { get; set; }

        public virtual Settings Settings { get; set; }

        public virtual ICollection<Patron> Patrons { get; set; }

        public void Resize(int width, int height)
        {

        }
    }
}