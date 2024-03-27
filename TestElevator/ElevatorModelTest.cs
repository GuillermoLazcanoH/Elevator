using ElevatorModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace TestElevator {


    [TestClass]
    public class ElevadorModelTests {
        [TestMethod]
        public void AddUserWaitingQueue_ShouldAddUserToWaitingList() {
            // Arrange
            Elevator elevator = new Elevator();
            User user = new User() { Name = "John", DestinationFloor = 2 };

            // Act
            elevator.NewUserToWaithingQueue(1,user);

            // Assert
            CollectionAssert.Contains(elevator.Floors[1].WaitingQueue, user);
        }

        [TestMethod]
        public void AddUser_ShouldAddUserToInsideUsersList() {
            // Arrange
            Elevator elevator = new Elevator();
            User user = new User() {Name = "John",DestinationFloor = 2};

            // Act
            elevator.NewUserToWaithingQueue(1, user);
            elevator.UploadPassengers(1, Direction.Up);

            // Assert
            CollectionAssert.Contains(elevator.Passengers, user);
        }

        [TestMethod]
        public void MoveElevator_ShouldMoveElevatorUp() {
            // Arrange
            Elevator elevator = new Elevator();
            elevator.CurrentFloor = 1;
            elevator.CurrentDirection = Direction.Up;


            // Act
            elevator.PressInternalButtons(new int[] { 5 });
            elevator.Move();

            // Assert
            Assert.AreEqual(2, elevator.CurrentFloor);
        }

        [TestMethod]
        public void MoveElevator_ShouldMoveElevatorDown() {
            // Arrange
            Elevator elevator = new Elevator();
            elevator.CurrentFloor = 3;
            elevator.CurrentDirection = Direction.Down;

            // Act
            elevator.PressInternalButtons(new int[] { 1 });
            elevator.Move();

            // Assert
            Assert.AreEqual(2, elevator.CurrentFloor);
        }
    }

}