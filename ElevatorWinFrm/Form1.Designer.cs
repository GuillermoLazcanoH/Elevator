namespace ElevatorWinFrm {
    partial class frmElevator {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cbxDestiny = new ComboBox();
            label1 = new Label();
            cbxOrigin = new ComboBox();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            lblFloor2 = new Label();
            lstF2Users = new ListBox();
            btnF2Down = new Button();
            btnF2Up = new Button();
            tmrAuto = new System.Windows.Forms.Timer(components);
            groupBox3 = new GroupBox();
            lblFloor3 = new Label();
            lstF3Users = new ListBox();
            btnF3Down = new Button();
            btnF3Up = new Button();
            groupBox4 = new GroupBox();
            lblFloor4 = new Label();
            lstF4Users = new ListBox();
            btnF4Down = new Button();
            btnF4Up = new Button();
            groupBox5 = new GroupBox();
            lblFloor5 = new Label();
            lstF5Users = new ListBox();
            btnF5Down = new Button();
            groupBox6 = new GroupBox();
            lblFloor1 = new Label();
            lstF1Users = new ListBox();
            btnF1Up = new Button();
            groupBox7 = new GroupBox();
            chkFlr1 = new CheckBox();
            chkFlr2 = new CheckBox();
            chkFlr3 = new CheckBox();
            chkFlr4 = new CheckBox();
            chkFlr5 = new CheckBox();
            lblCurrentFloor = new Label();
            lstElevator = new ListBox();
            btnDisplayDown = new Button();
            btnDisplayUp = new Button();
            chkAuto = new CheckBox();
            btnNextMove = new Button();
            groupBox8 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbxDestiny);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbxOrigin);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(20, 21);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(354, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Passenger";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(82, 36);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(232, 29);
            txtUserName.TabIndex = 6;
            txtUserName.TextChanged += cbx_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 4;
            label2.Text = "Destiny:";
            // 
            // cbxDestiny
            // 
            cbxDestiny.DisplayMember = "1";
            cbxDestiny.FormattingEnabled = true;
            cbxDestiny.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbxDestiny.Location = new Point(81, 121);
            cbxDestiny.Margin = new Padding(4, 5, 4, 5);
            cbxDestiny.Name = "cbxDestiny";
            cbxDestiny.Size = new Size(68, 29);
            cbxDestiny.TabIndex = 3;
            cbxDestiny.ValueMember = "1,2,3,4,5";
            cbxDestiny.SelectedIndexChanged += cbx_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 2;
            label1.Text = "Origin:";
            // 
            // cbxOrigin
            // 
            cbxOrigin.DisplayMember = "1";
            cbxOrigin.FormattingEnabled = true;
            cbxOrigin.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbxOrigin.Location = new Point(81, 78);
            cbxOrigin.Margin = new Padding(4, 5, 4, 5);
            cbxOrigin.Name = "cbxOrigin";
            cbxOrigin.Size = new Size(68, 29);
            cbxOrigin.TabIndex = 1;
            cbxOrigin.ValueMember = "1,2,3,4,5";
            cbxOrigin.SelectedIndexChanged += cbx_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(202, 113);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 37);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblFloor2);
            groupBox2.Controls.Add(lstF2Users);
            groupBox2.Controls.Add(btnF2Down);
            groupBox2.Controls.Add(btnF2Up);
            groupBox2.Location = new Point(412, 391);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(328, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Tag = "0";
            groupBox2.Text = "Floor 2";
            // 
            // lblFloor2
            // 
            lblFloor2.BackColor = Color.Silver;
            lblFloor2.Location = new Point(9, 31);
            lblFloor2.Margin = new Padding(4, 0, 4, 0);
            lblFloor2.Name = "lblFloor2";
            lblFloor2.Size = new Size(21, 67);
            lblFloor2.TabIndex = 4;
            // 
            // lstF2Users
            // 
            lstF2Users.FormattingEnabled = true;
            lstF2Users.ItemHeight = 21;
            lstF2Users.Location = new Point(28, 31);
            lstF2Users.Margin = new Padding(4, 5, 4, 5);
            lstF2Users.Name = "lstF2Users";
            lstF2Users.Size = new Size(178, 67);
            lstF2Users.TabIndex = 3;
            // 
            // btnF2Down
            // 
            btnF2Down.BackColor = Color.FromArgb(224, 224, 224);
            btnF2Down.Location = new Point(218, 66);
            btnF2Down.Margin = new Padding(4, 5, 4, 5);
            btnF2Down.Name = "btnF2Down";
            btnF2Down.Size = new Size(102, 32);
            btnF2Down.TabIndex = 2;
            btnF2Down.Tag = "2";
            btnF2Down.Text = "Down";
            btnF2Down.UseVisualStyleBackColor = false;
            btnF2Down.Click += btnDown_Click;
            // 
            // btnF2Up
            // 
            btnF2Up.BackColor = Color.FromArgb(224, 224, 224);
            btnF2Up.Location = new Point(218, 31);
            btnF2Up.Margin = new Padding(4, 5, 4, 5);
            btnF2Up.Name = "btnF2Up";
            btnF2Up.Size = new Size(102, 32);
            btnF2Up.TabIndex = 1;
            btnF2Up.Tag = "2";
            btnF2Up.Text = "Up";
            btnF2Up.UseVisualStyleBackColor = false;
            btnF2Up.Click += btnUp_Click;
            // 
            // tmrAuto
            // 
            tmrAuto.Enabled = true;
            tmrAuto.Interval = 1500;
            tmrAuto.Tick += tmrAuto_Tick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblFloor3);
            groupBox3.Controls.Add(lstF3Users);
            groupBox3.Controls.Add(btnF3Down);
            groupBox3.Controls.Add(btnF3Up);
            groupBox3.Location = new Point(412, 262);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(328, 117);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Tag = "0";
            groupBox3.Text = "Floor 3";
            // 
            // lblFloor3
            // 
            lblFloor3.BackColor = Color.Silver;
            lblFloor3.Location = new Point(9, 29);
            lblFloor3.Margin = new Padding(4, 0, 4, 0);
            lblFloor3.Name = "lblFloor3";
            lblFloor3.Size = new Size(21, 67);
            lblFloor3.TabIndex = 5;
            // 
            // lstF3Users
            // 
            lstF3Users.FormattingEnabled = true;
            lstF3Users.ItemHeight = 21;
            lstF3Users.Location = new Point(28, 29);
            lstF3Users.Margin = new Padding(4, 5, 4, 5);
            lstF3Users.Name = "lstF3Users";
            lstF3Users.Size = new Size(178, 67);
            lstF3Users.TabIndex = 4;
            // 
            // btnF3Down
            // 
            btnF3Down.BackColor = Color.FromArgb(224, 224, 224);
            btnF3Down.Location = new Point(218, 64);
            btnF3Down.Margin = new Padding(4, 5, 4, 5);
            btnF3Down.Name = "btnF3Down";
            btnF3Down.Size = new Size(102, 32);
            btnF3Down.TabIndex = 2;
            btnF3Down.Tag = "3";
            btnF3Down.Text = "Down";
            btnF3Down.UseVisualStyleBackColor = false;
            btnF3Down.Click += btnDown_Click;
            // 
            // btnF3Up
            // 
            btnF3Up.BackColor = Color.FromArgb(224, 224, 224);
            btnF3Up.Location = new Point(218, 29);
            btnF3Up.Margin = new Padding(4, 5, 4, 5);
            btnF3Up.Name = "btnF3Up";
            btnF3Up.Size = new Size(102, 32);
            btnF3Up.TabIndex = 1;
            btnF3Up.Tag = "3";
            btnF3Up.Text = "Up";
            btnF3Up.UseVisualStyleBackColor = false;
            btnF3Up.Click += btnUp_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblFloor4);
            groupBox4.Controls.Add(lstF4Users);
            groupBox4.Controls.Add(btnF4Down);
            groupBox4.Controls.Add(btnF4Up);
            groupBox4.Location = new Point(412, 139);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(328, 112);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Tag = "0";
            groupBox4.Text = "Floor 4";
            // 
            // lblFloor4
            // 
            lblFloor4.BackColor = Color.Silver;
            lblFloor4.Location = new Point(8, 31);
            lblFloor4.Margin = new Padding(4, 0, 4, 0);
            lblFloor4.Name = "lblFloor4";
            lblFloor4.Size = new Size(21, 67);
            lblFloor4.TabIndex = 6;
            // 
            // lstF4Users
            // 
            lstF4Users.FormattingEnabled = true;
            lstF4Users.ItemHeight = 21;
            lstF4Users.Location = new Point(28, 31);
            lstF4Users.Margin = new Padding(4, 5, 4, 5);
            lstF4Users.Name = "lstF4Users";
            lstF4Users.Size = new Size(178, 67);
            lstF4Users.TabIndex = 5;
            // 
            // btnF4Down
            // 
            btnF4Down.BackColor = Color.FromArgb(224, 224, 224);
            btnF4Down.Location = new Point(218, 66);
            btnF4Down.Margin = new Padding(4, 5, 4, 5);
            btnF4Down.Name = "btnF4Down";
            btnF4Down.Size = new Size(102, 32);
            btnF4Down.TabIndex = 2;
            btnF4Down.Tag = "4";
            btnF4Down.Text = "Down";
            btnF4Down.UseVisualStyleBackColor = false;
            btnF4Down.Click += btnDown_Click;
            // 
            // btnF4Up
            // 
            btnF4Up.BackColor = Color.FromArgb(224, 224, 224);
            btnF4Up.Location = new Point(218, 31);
            btnF4Up.Margin = new Padding(4, 5, 4, 5);
            btnF4Up.Name = "btnF4Up";
            btnF4Up.Size = new Size(102, 32);
            btnF4Up.TabIndex = 1;
            btnF4Up.Tag = "4";
            btnF4Up.Text = "Up";
            btnF4Up.UseVisualStyleBackColor = false;
            btnF4Up.Click += btnUp_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblFloor5);
            groupBox5.Controls.Add(lstF5Users);
            groupBox5.Controls.Add(btnF5Down);
            groupBox5.Location = new Point(412, 21);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(328, 111);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Tag = "0";
            groupBox5.Text = "Floor 5";
            // 
            // lblFloor5
            // 
            lblFloor5.BackColor = Color.Silver;
            lblFloor5.Location = new Point(9, 31);
            lblFloor5.Margin = new Padding(4, 0, 4, 0);
            lblFloor5.Name = "lblFloor5";
            lblFloor5.Size = new Size(21, 67);
            lblFloor5.TabIndex = 7;
            // 
            // lstF5Users
            // 
            lstF5Users.FormattingEnabled = true;
            lstF5Users.ItemHeight = 21;
            lstF5Users.Location = new Point(28, 31);
            lstF5Users.Margin = new Padding(4, 5, 4, 5);
            lstF5Users.Name = "lstF5Users";
            lstF5Users.Size = new Size(178, 67);
            lstF5Users.TabIndex = 6;
            // 
            // btnF5Down
            // 
            btnF5Down.BackColor = Color.FromArgb(224, 224, 224);
            btnF5Down.Location = new Point(218, 33);
            btnF5Down.Margin = new Padding(4, 5, 4, 5);
            btnF5Down.Name = "btnF5Down";
            btnF5Down.Size = new Size(102, 32);
            btnF5Down.TabIndex = 2;
            btnF5Down.Tag = "5";
            btnF5Down.Text = "Down";
            btnF5Down.UseVisualStyleBackColor = false;
            btnF5Down.Click += btnDown_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblFloor1);
            groupBox6.Controls.Add(lstF1Users);
            groupBox6.Controls.Add(btnF1Up);
            groupBox6.Location = new Point(412, 514);
            groupBox6.Margin = new Padding(4, 5, 4, 5);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 5, 4, 5);
            groupBox6.Size = new Size(328, 118);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Tag = "0";
            groupBox6.Text = "Floor 1";
            // 
            // lblFloor1
            // 
            lblFloor1.BackColor = Color.Lime;
            lblFloor1.Location = new Point(8, 31);
            lblFloor1.Margin = new Padding(4, 0, 4, 0);
            lblFloor1.Name = "lblFloor1";
            lblFloor1.Size = new Size(21, 67);
            lblFloor1.TabIndex = 3;
            // 
            // lstF1Users
            // 
            lstF1Users.FormattingEnabled = true;
            lstF1Users.ItemHeight = 21;
            lstF1Users.Location = new Point(28, 31);
            lstF1Users.Margin = new Padding(4, 5, 4, 5);
            lstF1Users.Name = "lstF1Users";
            lstF1Users.Size = new Size(178, 67);
            lstF1Users.TabIndex = 2;
            // 
            // btnF1Up
            // 
            btnF1Up.BackColor = Color.FromArgb(224, 224, 224);
            btnF1Up.Location = new Point(218, 31);
            btnF1Up.Margin = new Padding(4, 5, 4, 5);
            btnF1Up.Name = "btnF1Up";
            btnF1Up.Size = new Size(102, 32);
            btnF1Up.TabIndex = 1;
            btnF1Up.Tag = "1";
            btnF1Up.Text = "Up";
            btnF1Up.UseVisualStyleBackColor = false;
            btnF1Up.Click += btnUp_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(chkFlr1);
            groupBox7.Controls.Add(chkFlr2);
            groupBox7.Controls.Add(chkFlr3);
            groupBox7.Controls.Add(chkFlr4);
            groupBox7.Controls.Add(chkFlr5);
            groupBox7.Controls.Add(lblCurrentFloor);
            groupBox7.Controls.Add(lstElevator);
            groupBox7.Controls.Add(btnDisplayDown);
            groupBox7.Controls.Add(btnDisplayUp);
            groupBox7.Location = new Point(20, 209);
            groupBox7.Margin = new Padding(4, 5, 4, 5);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4, 5, 4, 5);
            groupBox7.Size = new Size(354, 321);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Elevator";
            // 
            // chkFlr1
            // 
            chkFlr1.AutoSize = true;
            chkFlr1.BackColor = Color.Silver;
            chkFlr1.Location = new Point(276, 241);
            chkFlr1.Margin = new Padding(4, 5, 4, 5);
            chkFlr1.Name = "chkFlr1";
            chkFlr1.Size = new Size(38, 25);
            chkFlr1.TabIndex = 11;
            chkFlr1.Tag = "0";
            chkFlr1.Text = "1";
            chkFlr1.UseVisualStyleBackColor = false;
            chkFlr1.Click += chkFlr_Click;
            // 
            // chkFlr2
            // 
            chkFlr2.AutoSize = true;
            chkFlr2.BackColor = Color.Silver;
            chkFlr2.Location = new Point(276, 204);
            chkFlr2.Margin = new Padding(4, 5, 4, 5);
            chkFlr2.Name = "chkFlr2";
            chkFlr2.Size = new Size(38, 25);
            chkFlr2.TabIndex = 10;
            chkFlr2.Tag = "1";
            chkFlr2.Text = "2";
            chkFlr2.UseVisualStyleBackColor = false;
            chkFlr2.Click += chkFlr_Click;
            // 
            // chkFlr3
            // 
            chkFlr3.AutoSize = true;
            chkFlr3.BackColor = Color.Silver;
            chkFlr3.Location = new Point(276, 166);
            chkFlr3.Margin = new Padding(4, 5, 4, 5);
            chkFlr3.Name = "chkFlr3";
            chkFlr3.Size = new Size(38, 25);
            chkFlr3.TabIndex = 9;
            chkFlr3.Tag = "2";
            chkFlr3.Text = "3";
            chkFlr3.UseVisualStyleBackColor = false;
            chkFlr3.Click += chkFlr_Click;
            // 
            // chkFlr4
            // 
            chkFlr4.AutoSize = true;
            chkFlr4.BackColor = Color.Silver;
            chkFlr4.Location = new Point(276, 129);
            chkFlr4.Margin = new Padding(4, 5, 4, 5);
            chkFlr4.Name = "chkFlr4";
            chkFlr4.Size = new Size(38, 25);
            chkFlr4.TabIndex = 8;
            chkFlr4.Tag = "3";
            chkFlr4.Text = "4";
            chkFlr4.UseVisualStyleBackColor = false;
            chkFlr4.Click += chkFlr_Click;
            // 
            // chkFlr5
            // 
            chkFlr5.AutoSize = true;
            chkFlr5.BackColor = Color.Silver;
            chkFlr5.FlatAppearance.BorderColor = Color.White;
            chkFlr5.ForeColor = Color.Black;
            chkFlr5.Location = new Point(276, 89);
            chkFlr5.Margin = new Padding(4, 5, 4, 5);
            chkFlr5.Name = "chkFlr5";
            chkFlr5.Size = new Size(38, 25);
            chkFlr5.TabIndex = 7;
            chkFlr5.Tag = "4";
            chkFlr5.Text = "5";
            chkFlr5.UseVisualStyleBackColor = false;
            chkFlr5.Click += chkFlr_Click;
            // 
            // lblCurrentFloor
            // 
            lblCurrentFloor.BackColor = SystemColors.Window;
            lblCurrentFloor.BorderStyle = BorderStyle.Fixed3D;
            lblCurrentFloor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentFloor.ForeColor = Color.Green;
            lblCurrentFloor.Location = new Point(109, 37);
            lblCurrentFloor.Margin = new Padding(4, 0, 4, 0);
            lblCurrentFloor.Name = "lblCurrentFloor";
            lblCurrentFloor.Size = new Size(42, 34);
            lblCurrentFloor.TabIndex = 6;
            lblCurrentFloor.Text = "1";
            lblCurrentFloor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstElevator
            // 
            lstElevator.FormattingEnabled = true;
            lstElevator.ItemHeight = 21;
            lstElevator.Location = new Point(15, 89);
            lstElevator.Margin = new Padding(4, 5, 4, 5);
            lstElevator.Name = "lstElevator";
            lstElevator.Size = new Size(231, 214);
            lstElevator.TabIndex = 5;
            // 
            // btnDisplayDown
            // 
            btnDisplayDown.BackColor = Color.FromArgb(224, 224, 224);
            btnDisplayDown.Location = new Point(160, 37);
            btnDisplayDown.Margin = new Padding(4, 5, 4, 5);
            btnDisplayDown.Name = "btnDisplayDown";
            btnDisplayDown.Size = new Size(86, 32);
            btnDisplayDown.TabIndex = 4;
            btnDisplayDown.Text = "Down";
            btnDisplayDown.UseVisualStyleBackColor = false;
            // 
            // btnDisplayUp
            // 
            btnDisplayUp.BackColor = Color.FromArgb(224, 224, 224);
            btnDisplayUp.Location = new Point(15, 36);
            btnDisplayUp.Margin = new Padding(4, 5, 4, 5);
            btnDisplayUp.Name = "btnDisplayUp";
            btnDisplayUp.Size = new Size(86, 32);
            btnDisplayUp.TabIndex = 3;
            btnDisplayUp.Text = "Up";
            btnDisplayUp.UseVisualStyleBackColor = false;
            // 
            // chkAuto
            // 
            chkAuto.AutoSize = true;
            chkAuto.Checked = true;
            chkAuto.CheckState = CheckState.Checked;
            chkAuto.Location = new Point(10, 30);
            chkAuto.Margin = new Padding(4, 5, 4, 5);
            chkAuto.Name = "chkAuto";
            chkAuto.Size = new Size(62, 25);
            chkAuto.TabIndex = 5;
            chkAuto.Text = "Auto";
            chkAuto.UseVisualStyleBackColor = true;
            chkAuto.CheckedChanged += chkAuto_CheckedChanged;
            // 
            // btnNextMove
            // 
            btnNextMove.Enabled = false;
            btnNextMove.Location = new Point(218, 23);
            btnNextMove.Margin = new Padding(4, 5, 4, 5);
            btnNextMove.Name = "btnNextMove";
            btnNextMove.Size = new Size(112, 37);
            btnNextMove.TabIndex = 6;
            btnNextMove.Text = "Next >>";
            btnNextMove.UseVisualStyleBackColor = true;
            btnNextMove.Click += btnNextMove_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnNextMove);
            groupBox8.Controls.Add(chkAuto);
            groupBox8.Location = new Point(20, 553);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(354, 79);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            groupBox8.Text = "Run Mode";
            // 
            // frmElevator
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 643);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmElevator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elevator";
            Load += Elevator_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxOrigin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDestiny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnF2Down;
        private System.Windows.Forms.Button btnF2Up;
        private System.Windows.Forms.Timer tmrAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnF3Down;
        private System.Windows.Forms.Button btnF3Up;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnF4Down;
        private System.Windows.Forms.Button btnF4Up;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnF5Down;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnF1Up;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lstElevator;
        private System.Windows.Forms.Button btnDisplayDown;
        private System.Windows.Forms.Button btnDisplayUp;
        private System.Windows.Forms.ListBox lstF1Users;
        private System.Windows.Forms.ListBox lstF2Users;
        private System.Windows.Forms.ListBox lstF3Users;
        private System.Windows.Forms.ListBox lstF4Users;
        private System.Windows.Forms.ListBox lstF5Users;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.Button btnNextMove;
        private System.Windows.Forms.Label lblCurrentFloor;
        private System.Windows.Forms.CheckBox chkFlr1;
        private System.Windows.Forms.CheckBox chkFlr2;
        private System.Windows.Forms.CheckBox chkFlr3;
        private System.Windows.Forms.CheckBox chkFlr4;
        private System.Windows.Forms.CheckBox chkFlr5;
        private System.Windows.Forms.Label lblFloor2;
        private System.Windows.Forms.Label lblFloor3;
        private System.Windows.Forms.Label lblFloor4;
        private System.Windows.Forms.Label lblFloor5;
        private System.Windows.Forms.Label lblFloor1;
        private GroupBox groupBox8;
    }
}
