using System.Globalization;
using Elevated.Models;
namespace Elevated.Services
{
    public class PlayerSettingsService
    {
        public PlayerSettingsService() {
            Settings = new Settings {
                FloorCount = 10,
                ElevatorCount = 10
            };
        }
        public Settings Settings { get; set; }
    }
}