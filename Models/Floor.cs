using System.ComponentModel.DataAnnotations;

namespace Elevated.Models
{
    public class Floor
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public int FloorNumber { get; set; }

        public int UpQueueCount { get; set; }
        public int DownQueueCount { get; set; }

        public long FloorDialId { get; set; }
        public virtual FloorDial FloorDial { get; set; }
    }
}