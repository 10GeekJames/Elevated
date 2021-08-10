using System.Linq;
using System.Collections.Generic;
using Elevated.Models;
namespace Elevated.Services
{
    public class GameService
    {
        public GameService()
        {
            Levels = new List<Level>()
            {
                new Level
                {
                    Id = 1,
                    Name = "Level 1",
                    Dialog1 = "",
                    Dialog2 = "",
                    Dialog3 = "",
                    Dialog4 = "",
                    Dialog5 = "",

                    Settings = new Settings
                    {
                        FloorCount = 10,
                        ElevatorCount = 10
                    }
                }
            };
            Elevators = new List<Elevator>()
            {
                new Elevator{
                    Id=1,
                    ElevatorId=1,
                    Name="Elevator 1",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#d42414",
                    ElevatorDial = new ElevatorDial {
                        Id=1,
                        Name="Elevator 1 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=2,
                    ElevatorId=2,
                    Name="Elevator 2",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#1424d4",
                    ElevatorDial = new ElevatorDial {
                        Id=2,
                        Name="Elevator 2 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=3,
                    ElevatorId=3,
                    Name="Elevator 3",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#d7c7a7",
                    ElevatorDial = new ElevatorDial {
                        Id=3,
                        Name="Elevator 3 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=4,
                    ElevatorId=4,
                    Name="Elevator 4",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#13c3c3",
                    ElevatorDial = new ElevatorDial {
                        Id=4,
                        Name="Elevator 4 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=5,
                    ElevatorId=5,
                    Name="Elevator 5",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#f535b5",
                    ElevatorDial = new ElevatorDial {
                        Id=5,
                        Name="Elevator 5 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=6,
                    ElevatorId=6,
                    Name="Elevator 6",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#13b313",
                    ElevatorDial = new ElevatorDial {
                        Id=6,
                        Name="Elevator 6 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=7,
                    ElevatorId=7,
                    Name="Elevator 7",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#f6a6a6",
                    ElevatorDial = new ElevatorDial {
                        Id=7,
                        Name="Elevator 7 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=8,
                    ElevatorId=8,
                    Name="Elevator 8",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#a3a3e3",
                    ElevatorDial = new ElevatorDial {
                        Id=8,
                        Name="Elevator 8 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=9,
                    ElevatorId=9,
                    Name="Elevator 9",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#77d777",
                    ElevatorDial = new ElevatorDial {
                        Id=9,
                        Name="Elevator 9 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=10,
                    ElevatorId=10,
                    Name="Elevator 10",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#155555",
                    ElevatorDial = new ElevatorDial {
                        Id=10,
                        Name="Elevator 10 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=11,
                    ElevatorId=11,
                    Name="Elevator 11",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#333313",
                    ElevatorDial = new ElevatorDial {
                        Id=11,
                        Name="Elevator 11 Dial",
                        LevelsPressed = ""
                    }
                 },
                 new Elevator{
                    Id=12,
                    ElevatorId=12,
                    Name="Elevator 12",
                    Health=100,
                    MaxLoad=1200,
                    MaxOccupancy=6,
                    CurrentFloor=1,
                    LastFloor=1,
                    DesiredFloor=1,
                    CurrentLoad=0,
                    CurrentOccupancy=0,
                    Color="#113111",
                    ElevatorDial = new ElevatorDial {
                        Id=12,
                        Name="Elevator 12 Dial",
                        LevelsPressed = ""
                    }
                 }
            };

            Patrons = new List<Patron>(){
                    new Patron {
                        Name="John Barker",
                        Weight=12,
                        ApproxAge=22,
                        Height=44,
                        Species=1,
                        Sex=2,
                        CurrentFloorNumber=1,
                        DesiredFloorNumber=4,
                        Influence=5
                    },
                    new Patron {
                        Name="Elizabeth Tooth",
                        Weight=97,
                        ApproxAge=41,
                        Height=61,
                        Species=1,
                        Sex=2,
                        CurrentFloorNumber=2,
                        DesiredFloorNumber=3,
                        Influence=5
                    },
                    new Patron {
                        Name="Tim Peanut",
                        Weight=215,
                        ApproxAge=27,
                        Height=51,
                        Species=1,
                        Sex=1,
                        CurrentFloorNumber=1,
                        DesiredFloorNumber=5,
                        Influence=3
                    },
                    new Patron {
                        Name="Dr. Nancy Leeroy",
                        Weight=125,
                        ApproxAge=34,
                        Height=46,
                        Species=1,
                        Sex=2,
                        CurrentFloorNumber=4,
                        DesiredFloorNumber=5,
                        Influence=5
                    },
                    new Patron {
                        Name="Sally Sue",
                        Weight=112,
                        ApproxAge=21,
                        Height=54,
                        Species=1,
                        Sex=2,
                        CurrentFloorNumber=2,
                        DesiredFloorNumber=1,
                        Influence=15
                    }
            };
            Floors = new List<Floor>(){
                new Floor(){
                    Id=1,
                    Name="Floor 1",
                    FloorNumber=1
                },
                new Floor(){
                    Id=2,
                    Name="Floor 2",
                    FloorNumber=2
                },
                new Floor(){
                    Id=3,
                    Name="Floor 3",
                    FloorNumber=3
                },
                new Floor(){
                    Id=4,
                    Name="Floor 4",
                    FloorNumber=4
                },
                new Floor(){
                    Id=5,
                    Name="Floor 5",
                    FloorNumber=5
                },
                new Floor(){
                    Id=6,
                    Name="Floor 6",
                    FloorNumber=6
                },
                new Floor(){
                    Id=7,
                    Name="Floor 7",
                    FloorNumber=7
                },
                new Floor(){
                    Id=8,
                    Name="Floor 8",
                    FloorNumber=8
                },
                new Floor(){
                    Id=9,
                    Name="Floor 9",
                    FloorNumber=9
                },
                new Floor(){
                    Id=10,
                    Name="Floor 10",
                    FloorNumber=10
                },
                new Floor(){
                    Id=11,
                    Name="Floor 11",
                    FloorNumber=11
                },
                new Floor(){
                    Id=12,
                    Name="Floor 12",
                    FloorNumber=12
                }
            };
            CurrentLevelId = 1;
            CurrentLevel = Levels.Where(rs => rs.Id == CurrentLevelId).FirstOrDefault();
            Settings = new Settings();
        }
        public long CurrentLevelId { get; set; }
        public virtual Level CurrentLevel { get; set; }

        public virtual ICollection<Level> Levels { get; set; }
        public virtual ICollection<Floor> Floors { get; set; }
        public virtual ICollection<Elevator> Elevators { get; set; }

        public virtual ICollection<Patron> Patrons { get; set; }

        public virtual Settings Settings { get; set; }

        
    }
}