using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLibrary {
    public class Button {
        public ButtonState State { get; set; }

        public bool IsPressed {
            get {
                return State == ButtonState.Pressed;
            }
        }
    }
}
