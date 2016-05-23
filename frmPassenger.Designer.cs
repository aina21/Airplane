namespace Airplane
{
    partial class frmPassenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label person_nameLabel1;
            System.Windows.Forms.Label person_lastNameLabel;
            System.Windows.Forms.Label person_mellicodeLabel;
            System.Windows.Forms.Label person_telLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassenger));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnPassenger = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.person_telTextBox = new System.Windows.Forms.TextBox();
            this.person_nameTextBox1 = new System.Windows.Forms.TextBox();
            this.person_lastNameTextBox = new System.Windows.Forms.TextBox();
            this.person_mellicodeTextBox = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMelli = new System.Windows.Forms.TextBox();
            this.txtDateE = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtCodeE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbLast = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            person_nameLabel1 = new System.Windows.Forms.Label();
            person_lastNameLabel = new System.Windows.Forms.Label();
            person_mellicodeLabel = new System.Windows.Forms.Label();
            person_telLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // person_nameLabel1
            // 
            person_nameLabel1.AutoSize = true;
            person_nameLabel1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            person_nameLabel1.Location = new System.Drawing.Point(622, 92);
            person_nameLabel1.Name = "person_nameLabel1";
            person_nameLabel1.Size = new System.Drawing.Size(65, 26);
            person_nameLabel1.TabIndex = 12;
            person_nameLabel1.Text = "نام مسافر";
            // 
            // person_lastNameLabel
            // 
            person_lastNameLabel.AutoSize = true;
            person_lastNameLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            person_lastNameLabel.Location = new System.Drawing.Point(607, 138);
            person_lastNameLabel.Name = "person_lastNameLabel";
            person_lastNameLabel.Size = new System.Drawing.Size(82, 26);
            person_lastNameLabel.TabIndex = 14;
            person_lastNameLabel.Text = "نام خانوادگی";
            // 
            // person_mellicodeLabel
            // 
            person_mellicodeLabel.AutoSize = true;
            person_mellicodeLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            person_mellicodeLabel.Location = new System.Drawing.Point(637, 179);
            person_mellicodeLabel.Name = "person_mellicodeLabel";
            person_mellicodeLabel.Size = new System.Drawing.Size(52, 26);
            person_mellicodeLabel.TabIndex = 16;
            person_mellicodeLabel.Text = "کد ملی";
            // 
            // person_telLabel
            // 
            person_telLabel.AutoSize = true;
            person_telLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            person_telLabel.Location = new System.Drawing.Point(609, 223);
            person_telLabel.Name = "person_telLabel";
            person_telLabel.Size = new System.Drawing.Size(80, 26);
            person_telLabel.TabIndex = 17;
            person_telLabel.Text = "شماره تماس";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.Location = new System.Drawing.Point(611, 255);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 26);
            label1.TabIndex = 25;
            label1.Text = "شماره تماس";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.Location = new System.Drawing.Point(627, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 26);
            label2.TabIndex = 19;
            label2.Text = "نام مسافر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label3.Location = new System.Drawing.Point(612, 166);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 26);
            label3.TabIndex = 21;
            label3.Text = "نام خانوادگی";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label5.Location = new System.Drawing.Point(643, 210);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 26);
            label5.TabIndex = 23;
            label5.Text = "کد ملی";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnTicket);
            this.groupBox1.Controls.Add(this.btnPassenger);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTicket.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnTicket.Image")));
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTicket.Location = new System.Drawing.Point(11, 233);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(234, 74);
            this.btnTicket.TabIndex = 0;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnPassenger
            // 
            this.btnPassenger.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPassenger.Enabled = false;
            this.btnPassenger.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassenger.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassenger.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPassenger.Image = ((System.Drawing.Image)(resources.GetObject("btnPassenger.Image")));
            this.btnPassenger.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPassenger.Location = new System.Drawing.Point(11, 129);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(234, 74);
            this.btnPassenger.TabIndex = 0;
            this.btnPassenger.Text = "Passenger";
            this.btnPassenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassenger.UseVisualStyleBackColor = false;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLine.Image = global::Airplane.Properties.Resources.white2;
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLine.Location = new System.Drawing.Point(11, 25);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(234, 74);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(258, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(727, 506);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageEdit);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(person_telLabel);
            this.tabPageAdd.Controls.Add(this.person_telTextBox);
            this.tabPageAdd.Controls.Add(person_nameLabel1);
            this.tabPageAdd.Controls.Add(this.person_nameTextBox1);
            this.tabPageAdd.Controls.Add(person_lastNameLabel);
            this.tabPageAdd.Controls.Add(this.person_lastNameTextBox);
            this.tabPageAdd.Controls.Add(person_mellicodeLabel);
            this.tabPageAdd.Controls.Add(this.person_mellicodeTextBox);
            this.tabPageAdd.Controls.Add(this.txtDate);
            this.tabPageAdd.Controls.Add(this.btnCancle);
            this.tabPageAdd.Controls.Add(this.btnRegister);
            this.tabPageAdd.Controls.Add(this.txtCode);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 33);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(719, 459);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // person_telTextBox
            // 
            this.person_telTextBox.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.person_telTextBox.Location = new System.Drawing.Point(46, 218);
            this.person_telTextBox.Name = "person_telTextBox";
            this.person_telTextBox.Size = new System.Drawing.Size(556, 31);
            this.person_telTextBox.TabIndex = 5;
            // 
            // person_nameTextBox1
            // 
            this.person_nameTextBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.person_nameTextBox1.Location = new System.Drawing.Point(46, 90);
            this.person_nameTextBox1.Name = "person_nameTextBox1";
            this.person_nameTextBox1.Size = new System.Drawing.Size(556, 31);
            this.person_nameTextBox1.TabIndex = 2;
            // 
            // person_lastNameTextBox
            // 
            this.person_lastNameTextBox.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.person_lastNameTextBox.Location = new System.Drawing.Point(46, 133);
            this.person_lastNameTextBox.Name = "person_lastNameTextBox";
            this.person_lastNameTextBox.Size = new System.Drawing.Size(556, 31);
            this.person_lastNameTextBox.TabIndex = 3;
            // 
            // person_mellicodeTextBox
            // 
            this.person_mellicodeTextBox.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.person_mellicodeTextBox.Location = new System.Drawing.Point(46, 177);
            this.person_mellicodeTextBox.Name = "person_mellicodeTextBox";
            this.person_mellicodeTextBox.Size = new System.Drawing.Size(556, 31);
            this.person_mellicodeTextBox.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.Location = new System.Drawing.Point(587, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 31);
            this.txtDate.TabIndex = 0;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancle.FlatAppearance.BorderSize = 2;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancle.Location = new System.Drawing.Point(45, 400);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(642, 39);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "خروج";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(45, 355);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(642, 39);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "ثبت ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCode.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCode.Location = new System.Drawing.Point(47, 27);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 31);
            this.txtCode.TabIndex = 1;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.btnExit);
            this.tabPageEdit.Controls.Add(this.btnAdd);
            this.tabPageEdit.Controls.Add(this.btnOk);
            this.tabPageEdit.Controls.Add(label1);
            this.tabPageEdit.Controls.Add(this.txtTel);
            this.tabPageEdit.Controls.Add(label2);
            this.tabPageEdit.Controls.Add(this.txtName);
            this.tabPageEdit.Controls.Add(label3);
            this.tabPageEdit.Controls.Add(this.txtLast);
            this.tabPageEdit.Controls.Add(label5);
            this.tabPageEdit.Controls.Add(this.txtMelli);
            this.tabPageEdit.Controls.Add(this.txtDateE);
            this.tabPageEdit.Controls.Add(this.btnDelete);
            this.tabPageEdit.Controls.Add(this.btnEdit);
            this.tabPageEdit.Controls.Add(this.txtCodeE);
            this.tabPageEdit.Controls.Add(this.label4);
            this.tabPageEdit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPageEdit.Location = new System.Drawing.Point(4, 33);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(719, 459);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Edit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(370, 31);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(280, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 62);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(190, 31);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 62);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTel.Location = new System.Drawing.Point(46, 248);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(556, 31);
            this.txtTel.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(46, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(556, 31);
            this.txtName.TabIndex = 5;
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLast.Location = new System.Drawing.Point(46, 163);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(556, 31);
            this.txtLast.TabIndex = 6;
            // 
            // txtMelli
            // 
            this.txtMelli.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMelli.Location = new System.Drawing.Point(46, 207);
            this.txtMelli.Name = "txtMelli";
            this.txtMelli.Size = new System.Drawing.Size(556, 31);
            this.txtMelli.TabIndex = 7;
            // 
            // txtDateE
            // 
            this.txtDateE.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDateE.Location = new System.Drawing.Point(587, 34);
            this.txtDateE.Name = "txtDateE";
            this.txtDateE.ReadOnly = true;
            this.txtDateE.Size = new System.Drawing.Size(100, 31);
            this.txtDateE.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(45, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(642, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(45, 355);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(642, 39);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtCodeE
            // 
            this.txtCodeE.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeE.Location = new System.Drawing.Point(45, 53);
            this.txtCodeE.Name = "txtCodeE";
            this.txtCodeE.Size = new System.Drawing.Size(127, 31);
            this.txtCodeE.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "کد مسافر را وارد کنید";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.groupBox3);
            this.tabPageSearch.Controls.Add(this.dataGridView1);
            this.tabPageSearch.Controls.Add(this.button1);
            this.tabPageSearch.Controls.Add(this.txtSearch);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 33);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(719, 459);
            this.tabPageSearch.TabIndex = 2;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbName);
            this.groupBox3.Controls.Add(this.rdbLast);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(21, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(676, 44);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbName.Location = new System.Drawing.Point(626, 9);
            this.rdbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(46, 30);
            this.rdbName.TabIndex = 0;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "نام";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbLast
            // 
            this.rdbLast.AutoSize = true;
            this.rdbLast.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbLast.Location = new System.Drawing.Point(520, 9);
            this.rdbLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbLast.Name = "rdbLast";
            this.rdbLast.Size = new System.Drawing.Size(100, 30);
            this.rdbLast.TabIndex = 1;
            this.rdbLast.TabStop = true;
            this.rdbLast.Text = "نام خانوادگی";
            this.rdbLast.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 253);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(603, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(26, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(571, 39);
            this.txtSearch.TabIndex = 0;
            // 
            // frmPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(987, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPassenger";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مسافران";
            this.Load += new System.EventHandler(this.frmPassenger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnPassenger;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtCodeE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDateE;
        private System.Windows.Forms.TextBox person_nameTextBox1;
        private System.Windows.Forms.TextBox person_lastNameTextBox;
        private System.Windows.Forms.TextBox person_mellicodeTextBox;
        private System.Windows.Forms.TextBox person_telTextBox;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtMelli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbLast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;




    }
}

