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

        public Floor[] Floors { get; set; }
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
        }

        private void ResetAllMoveRequest(int currentFloor) {
            Floor floor = Floors[currentFloor];
            InsideButtons[currentFloor].State = ButtonState.Released;
            if (floor.ButtonUp != null)
                floor.ButtonUp.State = ButtonState.Released;
            if (floor.ButtonDown != null)
                floor.ButtonDown.State = ButtonState.Released;
        }

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
            if (users.Any()) {
                Passengers.AddRange(users);
                PressInternalButtons(users.Select(usr => usr.DestinationFloor));
            }
            
        }

        public void PressInternalButtons(IEnumerable<int> ids) {
            foreach (var id in ids) {
                InsideButtons[id].State = ButtonState.Pressed;
            }
        }

        private void DownloadPassengers(int currentFloor) {
            this.Passengers.RemoveAll(usr => usr.DestinationFloor == currentFloor);
        }

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

        private bool AvailabeMoveUp() {
            return CurrentDirection == Direction.Idle ||
                CurrentDirection == Direction.Up;

        }

        private bool AvailabeMoveDown() {
            return CurrentDirection == Direction.Idle ||
            CurrentDirection == Direction.Down;
        }

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

        public void NewUserToWaithingQueue(int floor, User usr) {
            Floors[floor].WaitingQueue.Add(usr);
        }


    }
}

