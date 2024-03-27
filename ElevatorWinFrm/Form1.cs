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
            elevator.Move();
            ElevatorStatusRefresh(elevator);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            int origin = cbxOrigin.SelectedIndex;
            int destiny = cbxDestiny.SelectedIndex;
            User usr = new User() {
                DestinationFloor = destiny,
                Name = txtUserName.Text
            };

            elevator.NewUserToWaithingQueue(origin, usr);
            if (origin > destiny) {
                elevator.Floors[origin].ButtonDown.State = ButtonState.Pressed;
            } else {
                elevator.Floors[origin].ButtonUp.State = ButtonState.Pressed;
            }
            DisplayFloorStatus(elevator, origin, floorSets[origin]);
        }



        private void ElevatorStatusRefresh(Elevator elevator) {
            DisplayDirection(elevator, btnDisplayUp, btnDisplayDown);
            DisplayCurrentFloor(elevator, lblCurrentFloor);
            DisplayCurrentPassengers(elevator, lstElevator);
            DisplayAllFloorStatus(elevator, floorSets);
        }

        private void DisplayAllFloorStatus(Elevator elevator, List<DisplayFloorSet> floorSets) {
            for (int i = Elevator.MinFloor; i <= Elevator.MaxFloor; i++) {
                DisplayFloorStatus(elevator, i, floorSets[i]);
            }
        }

        private void DisplayFloorStatus(Elevator elevator, int i, DisplayFloorSet floorSet) {
            DisplayFloorStatus(elevator,
                                i,
                                floorSet.btnUp,
                                floorSet.btnDown,
                                floorSet.lstUsers,
                                floorSet.chkFloor,
                                floorSet.lblFloor);
        }

        private void DisplayFloorStatus(Elevator elevator, int indexfloor, System.Windows.Forms.Button btnUp, System.Windows.Forms.Button btnDown, ListBox lstUsers, CheckBox chk, Label lblStatus) {
            Floor floor = elevator.Floors[indexfloor];
            chk.Checked = elevator.InsideButtons[indexfloor].IsPressed;
            DisplayLabelStatus(lblStatus, elevator.CurrentFloor == indexfloor);
            ListResetDataSource(lstUsers, floor.WaitingQueue);
            if (btnUp != null)
                DisplayButtonStatus(btnUp, floor.ButtonUp.IsPressed);
            if (btnDown != null)
                DisplayButtonStatus(btnDown, floor.ButtonDown.IsPressed);
        }

        private void DisplayCurrentPassengers(Elevator elevator, ListBox lstElevator) {
            ListResetDataSource(lstElevator, elevator.Passengers);
        }

        private void ListResetDataSource(ListBox lstUsers, List<User> waitingQueue) {
            lstUsers.DataSource = null;
            lstUsers.Items.Clear();
            lstUsers.DisplayMember = "Name";
            lstUsers.DataSource = waitingQueue;
        }

        private void DisplayButtonStatus(System.Windows.Forms.Button btn, bool isPressed) {
            btn.BackColor = isPressed ? Color.Lime : Color.LightGray;
        }

        private void DisplayLabelStatus(System.Windows.Forms.Label lblStatus, bool isPressed) {
            lblStatus.BackColor = isPressed ? Color.Lime : Color.LightGray;
        }

        private void DisplayCurrentFloor(Elevator elevator, Label lblCurrentFloor) {
            lblCurrentFloor.Text = elevator.Floors[elevator.CurrentFloor].Id.ToString();
        }

        private void DisplayDirection(Elevator elevator, System.Windows.Forms.Button btnDisplayUp, System.Windows.Forms.Button btnDisplayDown) {
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
            var btn = sender as System.Windows.Forms.Button;
            int floor = int.Parse(btn.Tag.ToString());
            elevator.Floors[floor - 1].ButtonDown.State = ButtonState.Pressed;
            DisplayButtonStatus(btn, true);
        }

        private void PressUpButton(object sender) {
            var btn = sender as System.Windows.Forms.Button;
            int floor = int.Parse(btn.Tag.ToString());
            elevator.Floors[floor - 1].ButtonUp.State = ButtonState.Pressed;
            DisplayButtonStatus(btn, true);
        }

        private void btnUp_Click(object sender, EventArgs e) {
            PressUpButton(sender);

        }

        private void chkFlr_Click(object sender, EventArgs e) {
            PressInternalButton(sender);
        }

        private void PressInternalButton(object sender) {
            var chk = sender as System.Windows.Forms.CheckBox;
            int floor = int.Parse(chk.Tag.ToString());
            if (elevator.CurrentFloor != floor ) {
                elevator.InsideButtons[floor].State = ButtonState.Pressed;
                chk.Checked = true;
            } else {
                elevator.InsideButtons[floor].State = ButtonState.Released;
                chk.Checked = false;
            }
            
        }

        private void Elevator_Load(object sender, EventArgs e) {
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
            btnAdd.Enabled = (cbxDestiny.SelectedIndex != cbxOrigin.SelectedIndex) &&
                                cbxDestiny.SelectedIndex >= 0  &&
                                cbxOrigin.SelectedIndex >= 0 &&
                                !string.IsNullOrWhiteSpace(txtUserName.Text);
        }
    }
}
