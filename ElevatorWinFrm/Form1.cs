using ElevatorLibrary;
using ElevatorWinFrm.Model;
using ButtonState = ElevatorLibrary.ButtonState;

namespace ElevatorWinFrm {
    public partial class frmElevator : Form {
        Elevator elevator;
        List<DisplayFloorSet> floorSets;
        public frmElevator() {
            InitializeComponent();
            elevator = new Elevator();
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e) {
            //Manual or Auto
            tmrAuto.Enabled = chkAuto.Checked;
            btnNextMove.Enabled = !chkAuto.Checked;
        }

        private void btnNextMove_Click(object sender, EventArgs e) {
            ElevatorMove();
        }

        private void tmrAuto_Tick(object sender, EventArgs e) {
            ElevatorMove();
        }

        private void ElevatorMove() {
            //Next step simulator and refresh screen
            elevator.Move();
            ElevatorStatusRefresh(elevator);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            //Add new user to waiting pipe and refresh screen
            int origin = cbxOrigin.SelectedIndex;
            int destiny = cbxDestiny.SelectedIndex;
            User usr = new User() {
                DestinationFloor = destiny,
                Name = txtUserName.Text
            };

            elevator.AddUserToWaithingQueue(origin, usr);
            DisplayFloorStatus(elevator, origin, floorSets[origin]);
        }



        private void ElevatorStatusRefresh(Elevator elevator) {
            //Refresh all screen
            DisplayDirection(elevator, btnDisplayUp, btnDisplayDown);
            DisplayCurrentFloor(elevator, lblCurrentFloor);
            DisplayCurrentPassengers(elevator, lstElevator);
            DisplayAllFloorStatus(elevator, floorSets);
        }

        private void DisplayAllFloorStatus(Elevator elevator, List<DisplayFloorSet> floorSets) {
            //Refresh all waiting pipe
            for (int i = Elevator.MinFloor; i <= Elevator.MaxFloor; i++) {
                DisplayFloorStatus(elevator, i, floorSets[i]);
            }
        }

        private void DisplayFloorStatus(Elevator elevator, int i, DisplayFloorSet floorSet) {
            //Refresh a floor waiting pipe
            DisplayFloorStatus(elevator,
                                i,
                                floorSet.btnUp,
                                floorSet.btnDown,
                                floorSet.lstUsers,
                                floorSet.chkFloor,
                                floorSet.lblFloor);
        }

        private void DisplayFloorStatus(Elevator elevator, int indexfloor, System.Windows.Forms.Button btnUp, System.Windows.Forms.Button btnDown, ListBox lstUsers, CheckBox chk, Label lblStatus) {
            //Refresh a floor status screen
            Floor floor = elevator.Floors[indexfloor];
            chk.Checked = elevator.IsFloorButtonPressed(indexfloor);
            DisplayLabelStatus(lblStatus, elevator.CurrentFloor == indexfloor);
            ListResetDataSource(lstUsers, floor.WaitingQueue);
            if (btnUp != null)
                DisplayButtonStatus(btnUp, floor.ButtonUp.IsPressed);
            if (btnDown != null)
                DisplayButtonStatus(btnDown, floor.ButtonDown.IsPressed);
        }

        private void DisplayCurrentPassengers(Elevator elevator, ListBox lstElevator) {
            //Show current passenger
            ListResetDataSource(lstElevator, elevator.Passengers);
        }

        private void ListResetDataSource(ListBox lstUsers, List<User> waitingQueue) {
            //Update passengers list
            lstUsers.DataSource = null;
            lstUsers.Items.Clear();
            lstUsers.DisplayMember = "Name";
            lstUsers.DataSource = waitingQueue;
        }

        private void DisplayButtonStatus(System.Windows.Forms.Button btn, bool isPressed) {
            //Display active current button
            btn.BackColor = isPressed ? Color.Lime : Color.LightGray;
        }

        private void DisplayLabelStatus(System.Windows.Forms.Label lblStatus, bool isPressed) {
            //Display active current floor
            lblStatus.BackColor = isPressed ? Color.Lime : Color.LightGray;
        }

        private void DisplayCurrentFloor(Elevator elevator, Label lblCurrentFloor) {
            //Display floor number
            lblCurrentFloor.Text = elevator.Floors[elevator.CurrentFloor].Id.ToString();
        }

        private void DisplayDirection(Elevator elevator, System.Windows.Forms.Button btnDisplayUp, System.Windows.Forms.Button btnDisplayDown) {
            //Indicate if the elevator is in motion and direction
            switch (elevator.CurrentDirection) {
                case Direction.Up:
                    btnDisplayUp.BackColor = Color.Lime;
                    btnDisplayDown.BackColor = Color.LightGray;
                    break;
                case Direction.Down:
                    btnDisplayUp.BackColor = Color.LightGray;
                    btnDisplayDown.BackColor = Color.Lime;
                    break;
                default:
                    btnDisplayUp.BackColor = Color.LightGray;
                    btnDisplayDown.BackColor = Color.LightGray;
                    break;
            }

        }

        private void btnDown_Click(object sender, EventArgs e) {
            PressDownButton(sender);
        }

        private void PressDownButton(object sender) {
            //Request the elevator to pick up a passenger to go upward and refresh screen status.
            var btn = sender as System.Windows.Forms.Button;
            int floor = int.Parse(btn.Tag.ToString());
            elevator.PressDownButton(floor-1);
            
            DisplayButtonStatus(btn, true);
        }

        private void PressUpButton(object sender) {
            //Request the elevator to pick up a passenger to go downward and refresh screen
            var btn = sender as System.Windows.Forms.Button;
            int floor = int.Parse(btn.Tag.ToString());
            elevator.PressUpButton(floor-1);
            DisplayButtonStatus(btn, true);
        }

        private void btnUp_Click(object sender, EventArgs e) {
            PressUpButton(sender);

        }

        private void chkFlr_Click(object sender, EventArgs e) {
            PressInternalButton(sender);
        }

        private void PressInternalButton(object sender) {
            //Request the elevator to go to a specific floor.
            var chk = sender as System.Windows.Forms.CheckBox;
            int floor = int.Parse(chk.Tag.ToString());
            elevator.PressFloorButton(floor);
            chk.Checked = elevator.IsFloorButtonPressed(floor); 
        }

        private void Elevator_Load(object sender, EventArgs e) {
            //Prepare specific screen elements for each floor to be displayed.
            floorSets = new List<DisplayFloorSet> {
                new DisplayFloorSet() {btnUp = btnF1Up,
                                       lstUsers = lstF1Users,
                                        chkFloor = chkFlr1,
                                        lblFloor = lblFloor1},
                new DisplayFloorSet() {btnUp = btnF2Up,
                                        btnDown = btnF2Down,
                                       lstUsers = lstF2Users,
                                        chkFloor = chkFlr2,
                                        lblFloor = lblFloor2},
                new DisplayFloorSet() {btnUp = btnF3Up,
                                        btnDown = btnF3Down,
                                       lstUsers = lstF3Users,
                                        chkFloor = chkFlr3,
                                        lblFloor = lblFloor3},
                new DisplayFloorSet() {btnUp = btnF4Up,
                                        btnDown = btnF4Down,
                                       lstUsers = lstF4Users,
                                        chkFloor = chkFlr4,
                                        lblFloor = lblFloor4},
                new DisplayFloorSet() {btnDown = btnF5Down,
                                       lstUsers = lstF5Users,
                                        chkFloor = chkFlr5,
                                        lblFloor = lblFloor5}
            };
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e) {
            //Validate all fields before adding a new user to the waiting list.
            //Requesting the elevator to go to the same floor where it currently is located is an option to be validated. It sometimes occurs in real life.
            btnAdd.Enabled = //(cbxDestiny.SelectedIndex != cbxOrigin.SelectedIndex) &&
                                cbxDestiny.SelectedIndex >= 0  &&
                                cbxOrigin.SelectedIndex >= 0 &&
                                !string.IsNullOrWhiteSpace(txtUserName.Text);
        }
    }
}
