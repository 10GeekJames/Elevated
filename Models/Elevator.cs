using System.ComponentModel.DataAnnotations;

namespace Elevated.Models
{
    public class Elevator
    {
        [Key]
        public long Id { get; set; }
        public int ElevatorId { get; set; }

        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxLoad { get; set; }
        public int MaxOccupancy { get; set; }

        public int CurrentFloor { get; set; }
        public int LastFloor { get; set; }
        public int DesiredFloor { get; set; }
        public int CurrentLoad { get; set; }
        public int CurrentOccupancy { get; set; }
        public string Color { get; set; }

        public long ElevatorDialId { get; set; }
        public virtual ElevatorDial ElevatorDial { get; set; }
    }
}