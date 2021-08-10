using System.Globalization;
namespace Elevated.Models
{
    public class Settings
    {
        public int FloorCount {get;set;}
        public int ElevatorCount {get;set;}

        public Settings() {
            FloorCount = 10;
            ElevatorCount = 10;
        }        
    }
}