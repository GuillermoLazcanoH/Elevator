using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLibrary {
    public class Floor {
        public int Id { get; set; }
        public List<User> WaitingQueue { get; set; }

        public Button ButtonUp { get; set; }

        public Button ButtonDown  { get; set; }

        public Floor(int id, Button buttonUp, Button buttonDown) {
            Id = id;
            WaitingQueue = new List<User>();
            ButtonUp = buttonUp;
            ButtonDown = buttonDown;
        }
    }
}
