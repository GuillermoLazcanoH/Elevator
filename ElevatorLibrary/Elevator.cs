using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLibrary {
    public class Elevator {
        public const int MaxFloor = 4;
        public const int MinFloor = 0;
        public int CurrentFloor { get; set; }
        public Direction CurrentDirection { get; set; }
        
        public List<User> Passengers { get; set; }

        /// <summary>
        /// Information about the available floors in the elevator.
        /// </summary>
        public Floor[] Floors { get; set; }

        /// <summary>
        /// Elevator cabin buttons.
        /// </summary>
        public Button[] InsideButtons { get; set; }

        public Elevator() {
            InsideButtons = new Button[MaxFloor + 1];
            Floors = new Floor[MaxFloor + 1];
            for (int i = MinFloor; i <= MaxFloor; i++) {
                InsideButtons[i] = new Button();
                switch (i) {
                    case MaxFloor:
                        Floors[i] = new Floor(i + 1, null, new Button());
                        break;
                    case MinFloor:
                        Floors[i] = new Floor(i + 1, new Button(), null);
                        break;
                    default:
                        Floors[i] = new Floor(i + 1, new Button(), new Button());
                        break;
                }
            }
            CurrentFloor = MinFloor;
            CurrentDirection = Direction.Idle;

            Passengers = new List<User>();
        }

        
        /// <summary>
        /// Execute a movement step within the simulation model.
        /// </summary>
        public void Move() {
            if (AvailabeMoveUp() && ExistRequestMoveUp()) {
                MoveUp();
                return;
            }
            if (AvailabeMoveDown() && ExistRequestMoveDown()) {
                MoveDown();
                return;
            }
            CurrentDirection = Direction.Idle;
            ResetAllMoveRequest(CurrentFloor);
            UploadPassengers(CurrentFloor, CurrentDirection);
            DownloadPassengers(CurrentFloor);
        }

        /// <summary>
        /// Release all buttons for the currently requested floor.
        /// </summary>
        /// <param name="currentFloor"></param>
        private void ResetAllMoveRequest(int currentFloor) {
            Floor floor = Floors[currentFloor];
            InsideButtons[currentFloor].State = ButtonState.Released;
            if (floor.ButtonUp != null)
                floor.ButtonUp.State = ButtonState.Released;
            if (floor.ButtonDown != null)
                floor.ButtonDown.State = ButtonState.Released;
        }

        /// <summary>
        /// Board all passengers from the waiting list for the current floor into the cabin, giving preference to the elevator's direction of travel
        /// </summary>
        /// <param name="currentFloor"></param>
        /// <param name="direction"></param>
        public void UploadPassengers(int currentFloor, Direction direction) {
            List<User> users = new List<User>();
            switch (direction) {
                case Direction.Down:
                    users.AddRange( Floors[currentFloor].WaitingQueue.Where(usr => usr.DestinationFloor < currentFloor));
                    Floors[currentFloor].WaitingQueue.RemoveAll(usr => usr.DestinationFloor < currentFloor);
                    break;
                case Direction.Idle:
                    users.AddRange( Floors[currentFloor].WaitingQueue);
                    Floors[currentFloor].WaitingQueue.Clear();
                    break;
                case Direction.Up:
                    users.AddRange( Floors[currentFloor].WaitingQueue.Where(usr => usr.DestinationFloor > currentFloor));
                    Floors[currentFloor].WaitingQueue.RemoveAll(usr => usr.DestinationFloor > currentFloor);
                    break;
                default:
                    return;
            }
            //Add passengers' destinations to the elevator's destination list.
            if (users.Any()) {
                Passengers.AddRange(users);
                PressInternalButtons(users.Select(usr => usr.DestinationFloor).ToArray());
            }
            
        }

        /// <summary>
        /// Add specific destinations to the elevator's destination list.
        /// </summary>
        /// <param name="ids"></param>
        public void PressInternalButtons(params int[] ids) {
            foreach (var id in ids.Where(id => id != CurrentFloor && id >= MinFloor && id<= MaxFloor)) {
                InsideButtons[id].State = ButtonState.Pressed;
            }
        }

        /// <summary>
        /// Remove passengers from the list who have reached their destination
        /// </summary>
        /// <param name="currentFloor"></param>
        private void DownloadPassengers(int currentFloor) {
            this.Passengers.RemoveAll(usr => usr.DestinationFloor == currentFloor);
        }

        /// <summary>
        /// Execute a downward movement of the elevator.
        /// </summary>
        private void MoveDown() {
            if (CurrentFloor > MinFloor) {
                CurrentFloor--;
                CurrentDirection = Direction.Down;
                var button = Floors[CurrentFloor].ButtonDown;
                if (button != null)
                    button.State = ButtonState.Released;
            } else {
                CurrentDirection = Direction.Idle;
                Floors[CurrentFloor].ButtonUp.State = ButtonState.Released;
            }
            InsideButtons[CurrentFloor].State = ButtonState.Released;
            DownloadPassengers(CurrentFloor);
            UploadPassengers(CurrentFloor, CurrentDirection);
        }

        /// <summary>
        /// Execute an upward movement of the elevator.
        /// </summary>
        private void MoveUp() {
            if (CurrentFloor < MaxFloor) {
                CurrentFloor++;
                CurrentDirection = Direction.Up;
                var button = Floors[CurrentFloor].ButtonUp;
                if (button != null)
                    button.State = ButtonState.Released;
            } else {
                CurrentDirection = Direction.Idle;
                Floors[CurrentFloor].ButtonDown.State = ButtonState.Released;
            }
            InsideButtons[CurrentFloor].State = ButtonState.Released;
            DownloadPassengers(CurrentFloor);
            UploadPassengers(CurrentFloor, CurrentDirection);
        }

        /// <summary>
        /// Check if the elevator is stopped or moving upwards.
        /// </summary>
        /// <returns></returns>
        private bool AvailabeMoveUp() {
            return CurrentDirection == Direction.Idle ||
                CurrentDirection == Direction.Up;

        }

        /// <summary>
        /// Check if the elevator is stopped or moving downwards.
        /// </summary>
        /// <returns></returns>
        private bool AvailabeMoveDown() {
            return CurrentDirection == Direction.Idle ||
            CurrentDirection == Direction.Down;
        }

        /// <summary>
        /// Check for a request to move upwards.
        /// </summary>
        /// <returns></returns>
        private bool ExistRequestMoveUp() {
            for (int i = CurrentFloor + 1; i <= MaxFloor; i++) {
                if (InsideButtons[i].IsPressed ||
                    (Floors[i].ButtonUp != null && Floors[i].ButtonUp.IsPressed) ||
                    (Floors[i].ButtonDown != null && Floors[i].ButtonDown.IsPressed)) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check for a request to move downwards.
        /// </summary>
        /// <returns></returns>
        private bool ExistRequestMoveDown() {
            for (int i = CurrentFloor - 1; i >= MinFloor; i--) {
                if (InsideButtons[i].IsPressed ||
                    (Floors[i].ButtonUp != null && Floors[i].ButtonUp.IsPressed) ||
                    (Floors[i].ButtonDown != null && Floors[i].ButtonDown.IsPressed)) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Add a user to the waiting list on the requested floor, and call the elevator in the required direction.
        /// </summary>
        /// <param name="floor"></param>
        /// <param name="usr"></param>
        public void AddUserToWaithingQueue(int floor, User usr) {
            Floors[floor].WaitingQueue.Add(usr);
            if (floor > usr.DestinationFloor) {
                PressDownButton(floor);
            } else {
                PressUpButton(floor);
            }
        }

        /// <summary>
        /// Request the elevator on a floor to go downward.
        /// </summary>
        /// <param name="floor"></param>
        public void PressDownButton(int floor) {
            Floors[floor].ButtonDown.State = ButtonState.Pressed;
        }

        /// <summary>
        /// Request the elevator on a floor to go upward.
        /// </summary>
        /// <param name="floor"></param>
        public void PressUpButton(int floor) {
            Floors[floor].ButtonUp.State = ButtonState.Pressed;
        }

        /// <summary>
        /// Request the elevator to go to a specific floor.
        /// </summary>
        /// <param name="floor"></param>
        public void PressFloorButton(int floor) {
            if (CurrentFloor != floor) {
                InsideButtons[floor].State = ButtonState.Pressed;
            }
        }

        /// <summary>
        /// Check if a specific floor is in the destination list.
        /// </summary>
        /// <param name="floor"></param>
        /// <returns></returns>
        public bool IsFloorButtonPressed(int floor) {
            return InsideButtons[floor].IsPressed;
        }
    }
}

