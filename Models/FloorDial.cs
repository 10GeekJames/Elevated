namespace Elevated.Models
{
    public class FloorDial
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public bool CanUp { get; set; }
        public bool CanDown { get; set; }

        public bool UpIsPressed { get; set; }
        public bool DownIsPressed { get; set; }

        public void PressDown() { }
        public void PressUp() { }

        public void ClearUp() { }
        public void ClearDown() { }


        public bool CanReachAllFloors { get; set; }
        public string AccessibleFloors { get; set; }

    }
}