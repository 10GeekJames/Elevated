using System.ComponentModel.DataAnnotations;

namespace Elevated.Models
{
    public class ElevatorDial
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string LevelsPressed { get; set; }

        public void PressLevel(int level)
        {

        }
        public void UnpressLevel(int level)
        {

        }
    }
}