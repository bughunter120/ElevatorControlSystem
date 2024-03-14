using Microsoft.AspNetCore.Mvc;
using ElevatorControlSystem.Models;
using System.Threading.Tasks;

namespace ElevatorControlSystem.Controllers
{
    public class ElevatorController : Controller
    {
        public static Elevator Elevator = new Elevator();

        public IActionResult Index()
        {
            return View(Elevator);
        }

        [HttpPost]
        public async Task<IActionResult> CallElevator(int floor)
        {
            Elevator.CurrentFloor = floor;
            Elevator.DoorsOpen = true; 
            await Task.Delay(3000); // Simulate delay for the elevator moving
            return Json(new { success = true, currentFloor = Elevator.CurrentFloor, doorsOpen = Elevator.DoorsOpen });
        }

        [HttpPost]
        public IActionResult MoveElevator(int targetFloor)
        {

            Elevator.CurrentFloor = targetFloor;
            Elevator.DoorsOpen = false;
            return Json(new { success = true, currentFloor = Elevator.CurrentFloor, doorsOpen = Elevator.DoorsOpen });
        }

        [HttpPost]
        public IActionResult OpenCloseDoors(bool open)
        {
            Elevator.DoorsOpen = open;
            return Json(new { success = true, doorsOpen = Elevator.DoorsOpen });
        }

    }
}
