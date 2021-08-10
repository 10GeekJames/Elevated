using System.ComponentModel.DataAnnotations;

namespace Elevated.Models
{
    public class Patron
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }
        public int Influence { get; set; }
        public int Weight { get; set; }

        public int ApproxAge { get; set; }
        public int Height { get; set; }
        public int Species { get; set; }
        public int Sex { get; set; }

        public long CurrentFloorNumber { get; set; }
        public long DesiredFloorNumber { get; set; }

        public long? LastWaitTime { get; set; }
        public long? CurrentWaitTime { get; set; }
    }
}