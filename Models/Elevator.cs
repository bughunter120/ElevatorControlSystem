namespace ElevatorControlSystem.Models
{
    public enum Direction { Up, Down, Stationary }

    public class Elevator
    {
        public int CurrentFloor { get; set; } = 1;
        public bool DoorsOpen { get; set; } = false;
        public Direction Direction { get; set; } = Direction.Stationary;
    }
}
