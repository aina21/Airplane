namespace Airplane
{
    partial class frmLine
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
            System.Windows.Forms.Label line_dateWentLabel;
            System.Windows.Forms.Label line_dateReturnLabel;
            System.Windows.Forms.Label line_clockWentLabel;
            System.Windows.Forms.Label line_clockReturnLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLine));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnPassenger = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.line_clockReturnTextBox = new System.Windows.Forms.TextBox();
            this.line_clockWentTextBox = new System.Windows.Forms.TextBox();
            this.line_dateReturnTextBox = new System.Windows.Forms.TextBox();
            this.line_dateWentTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbDis = new System.Windows.Forms.ComboBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.txtCRE = new System.Windows.Forms.TextBox();
            this.txtCWE = new System.Windows.Forms.TextBox();
            this.txtDRE = new System.Windows.Forms.TextBox();
            this.txtDWE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDisE = new System.Windows.Forms.ComboBox();
            this.cmbSourceE = new System.Windows.Forms.ComboBox();
            this.txtDateE = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtCodeE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDR = new System.Windows.Forms.RadioButton();
            this.rdbDW = new System.Windows.Forms.RadioButton();
            this.rdbCR = new System.Windows.Forms.RadioButton();
            this.rdbSource = new System.Windows.Forms.RadioButton();
            this.rdbDis = new System.Windows.Forms.RadioButton();
            this.rdbCW = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            line_dateWentLabel = new System.Windows.Forms.Label();
            line_dateReturnLabel = new System.Windows.Forms.Label();
            line_clockWentLabel = new System.Windows.Forms.Label();
            line_clockReturnLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
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
            // line_dateWentLabel
            // 
            line_dateWentLabel.AutoSize = true;
            line_dateWentLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            line_dateWentLabel.Location = new System.Drawing.Point(628, 206);
            line_dateWentLabel.Name = "line_dateWentLabel";
            line_dateWentLabel.Size = new System.Drawing.Size(69, 26);
            line_dateWentLabel.TabIndex = 12;
            line_dateWentLabel.Text = "تاریخ رفت";
            // 
            // line_dateReturnLabel
            // 
            line_dateReturnLabel.AutoSize = true;
            line_dateReturnLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            line_dateReturnLabel.Location = new System.Drawing.Point(612, 245);
            line_dateReturnLabel.Name = "line_dateReturnLabel";
            line_dateReturnLabel.Size = new System.Drawing.Size(85, 26);
            line_dateReturnLabel.TabIndex = 14;
            line_dateReturnLabel.Text = "تاریخ برگشت";
            // 
            // line_clockWentLabel
            // 
            line_clockWentLabel.AutoSize = true;
            line_clockWentLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            line_clockWentLabel.Location = new System.Drawing.Point(295, 201);
            line_clockWentLabel.Name = "line_clockWentLabel";
            line_clockWentLabel.Size = new System.Drawing.Size(74, 26);
            line_clockWentLabel.TabIndex = 16;
            line_clockWentLabel.Text = "ساعت رفت";
            // 
            // line_clockReturnLabel
            // 
            line_clockReturnLabel.AutoSize = true;
            line_clockReturnLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            line_clockReturnLabel.Location = new System.Drawing.Point(280, 247);
            line_clockReturnLabel.Name = "line_clockReturnLabel";
            line_clockReturnLabel.Size = new System.Drawing.Size(90, 26);
            line_clockReturnLabel.TabIndex = 18;
            line_clockReturnLabel.Text = "ساعت برگشت";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.Location = new System.Drawing.Point(203, 255);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 26);
            label1.TabIndex = 30;
            label1.Text = "ساعت برگشت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.Location = new System.Drawing.Point(218, 209);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 26);
            label2.TabIndex = 28;
            label2.Text = "ساعت رفت";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label5.Location = new System.Drawing.Point(611, 251);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 26);
            label5.TabIndex = 26;
            label5.Text = "تاریخ برگشت";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label6.Location = new System.Drawing.Point(627, 212);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 26);
            label6.TabIndex = 24;
            label6.Text = "تاریخ رفت";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnTicket);
            this.groupBox1.Controls.Add(this.btnPassenger);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnTicket.Location = new System.Drawing.Point(12, 294);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(233, 93);
            this.btnTicket.TabIndex = 0;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnPassenger
            // 
            this.btnPassenger.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPassenger.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassenger.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassenger.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPassenger.Image = ((System.Drawing.Image)(resources.GetObject("btnPassenger.Image")));
            this.btnPassenger.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPassenger.Location = new System.Drawing.Point(12, 163);
            this.btnPassenger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(233, 93);
            this.btnPassenger.TabIndex = 0;
            this.btnPassenger.Text = "Passenger";
            this.btnPassenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassenger.UseVisualStyleBackColor = false;
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLine.Enabled = false;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLine.Image = global::Airplane.Properties.Resources.white2;
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLine.Location = new System.Drawing.Point(12, 32);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(233, 93);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLine.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(258, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(727, 507);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageEdit);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.AutoScroll = true;
            this.tabPageAdd.Controls.Add(line_clockReturnLabel);
            this.tabPageAdd.Controls.Add(this.line_clockReturnTextBox);
            this.tabPageAdd.Controls.Add(line_clockWentLabel);
            this.tabPageAdd.Controls.Add(this.line_clockWentTextBox);
            this.tabPageAdd.Controls.Add(line_dateReturnLabel);
            this.tabPageAdd.Controls.Add(this.line_dateReturnTextBox);
            this.tabPageAdd.Controls.Add(line_dateWentLabel);
            this.tabPageAdd.Controls.Add(this.line_dateWentTextBox);
            this.tabPageAdd.Controls.Add(this.label8);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.btnRemove);
            this.tabPageAdd.Controls.Add(this.btnAddCity);
            this.tabPageAdd.Controls.Add(this.txtDate);
            this.tabPageAdd.Controls.Add(this.cmbDis);
            this.tabPageAdd.Controls.Add(this.cmbSource);
            this.tabPageAdd.Controls.Add(this.btnCancle);
            this.tabPageAdd.Controls.Add(this.btnRegister);
            this.tabPageAdd.Controls.Add(this.txtCode);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 33);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAdd.Size = new System.Drawing.Size(719, 459);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // line_clockReturnTextBox
            // 
            this.line_clockReturnTextBox.Location = new System.Drawing.Point(129, 243);
            this.line_clockReturnTextBox.Name = "line_clockReturnTextBox";
            this.line_clockReturnTextBox.Size = new System.Drawing.Size(150, 31);
            this.line_clockReturnTextBox.TabIndex = 7;
            // 
            // line_clockWentTextBox
            // 
            this.line_clockWentTextBox.Location = new System.Drawing.Point(129, 201);
            this.line_clockWentTextBox.Name = "line_clockWentTextBox";
            this.line_clockWentTextBox.Size = new System.Drawing.Size(150, 31);
            this.line_clockWentTextBox.TabIndex = 5;
            // 
            // line_dateReturnTextBox
            // 
            this.line_dateReturnTextBox.Location = new System.Drawing.Point(456, 243);
            this.line_dateReturnTextBox.Name = "line_dateReturnTextBox";
            this.line_dateReturnTextBox.Size = new System.Drawing.Size(150, 31);
            this.line_dateReturnTextBox.TabIndex = 6;
            // 
            // line_dateWentTextBox
            // 
            this.line_dateWentTextBox.Location = new System.Drawing.Point(456, 201);
            this.line_dateWentTextBox.Name = "line_dateWentTextBox";
            this.line_dateWentTextBox.Size = new System.Drawing.Size(150, 31);
            this.line_dateWentTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(628, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "مقصد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(628, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "مبدا";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::Airplane.Properties.Resources.Delete_02__1_;
            this.btnRemove.Location = new System.Drawing.Point(45, 108);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 39);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCity.Image = global::Airplane.Properties.Resources.Add_02__1_;
            this.btnAddCity.Location = new System.Drawing.Point(79, 108);
            this.btnAddCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(43, 39);
            this.btnAddCity.TabIndex = 9;
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(599, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 31);
            this.txtDate.TabIndex = 0;
            // 
            // cmbDis
            // 
            this.cmbDis.FormattingEnabled = true;
            this.cmbDis.Location = new System.Drawing.Point(128, 157);
            this.cmbDis.Name = "cmbDis";
            this.cmbDis.Size = new System.Drawing.Size(478, 32);
            this.cmbDis.TabIndex = 3;
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(128, 112);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(478, 32);
            this.cmbSource.TabIndex = 2;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancle.FlatAppearance.BorderSize = 2;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancle.Location = new System.Drawing.Point(45, 401);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(642, 41);
            this.btnCancle.TabIndex = 9;
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
            this.btnRegister.Location = new System.Drawing.Point(45, 356);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(642, 41);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCode.Location = new System.Drawing.Point(45, 34);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(111, 31);
            this.txtCode.TabIndex = 1;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(label1);
            this.tabPageEdit.Controls.Add(this.txtCRE);
            this.tabPageEdit.Controls.Add(label2);
            this.tabPageEdit.Controls.Add(this.txtCWE);
            this.tabPageEdit.Controls.Add(label5);
            this.tabPageEdit.Controls.Add(this.txtDRE);
            this.tabPageEdit.Controls.Add(label6);
            this.tabPageEdit.Controls.Add(this.txtDWE);
            this.tabPageEdit.Controls.Add(this.label7);
            this.tabPageEdit.Controls.Add(this.label9);
            this.tabPageEdit.Controls.Add(this.cmbDisE);
            this.tabPageEdit.Controls.Add(this.cmbSourceE);
            this.tabPageEdit.Controls.Add(this.txtDateE);
            this.tabPageEdit.Controls.Add(this.btnDelete);
            this.tabPageEdit.Controls.Add(this.btnEdit);
            this.tabPageEdit.Controls.Add(this.txtCodeE);
            this.tabPageEdit.Controls.Add(this.label4);
            this.tabPageEdit.Controls.Add(this.btnExit);
            this.tabPageEdit.Controls.Add(this.btnAdd);
            this.tabPageEdit.Controls.Add(this.btnOk);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 33);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEdit.Size = new System.Drawing.Size(719, 459);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Edit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // txtCRE
            // 
            this.txtCRE.Location = new System.Drawing.Point(52, 251);
            this.txtCRE.Name = "txtCRE";
            this.txtCRE.Size = new System.Drawing.Size(150, 31);
            this.txtCRE.TabIndex = 10;
            // 
            // txtCWE
            // 
            this.txtCWE.Location = new System.Drawing.Point(52, 209);
            this.txtCWE.Name = "txtCWE";
            this.txtCWE.Size = new System.Drawing.Size(150, 31);
            this.txtCWE.TabIndex = 8;
            // 
            // txtDRE
            // 
            this.txtDRE.Location = new System.Drawing.Point(455, 249);
            this.txtDRE.Name = "txtDRE";
            this.txtDRE.Size = new System.Drawing.Size(150, 31);
            this.txtDRE.TabIndex = 9;
            // 
            // txtDWE
            // 
            this.txtDWE.Location = new System.Drawing.Point(455, 207);
            this.txtDWE.Name = "txtDWE";
            this.txtDWE.Size = new System.Drawing.Size(150, 31);
            this.txtDWE.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(627, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "مقصد";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(627, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "مبدا";
            // 
            // cmbDisE
            // 
            this.cmbDisE.FormattingEnabled = true;
            this.cmbDisE.Location = new System.Drawing.Point(52, 163);
            this.cmbDisE.Name = "cmbDisE";
            this.cmbDisE.Size = new System.Drawing.Size(553, 32);
            this.cmbDisE.TabIndex = 6;
            // 
            // cmbSourceE
            // 
            this.cmbSourceE.FormattingEnabled = true;
            this.cmbSourceE.Location = new System.Drawing.Point(52, 118);
            this.cmbSourceE.Name = "cmbSourceE";
            this.cmbSourceE.Size = new System.Drawing.Size(553, 32);
            this.cmbSourceE.TabIndex = 5;
            // 
            // txtDateE
            // 
            this.txtDateE.Location = new System.Drawing.Point(599, 34);
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
            this.btnDelete.Location = new System.Drawing.Point(45, 401);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(642, 41);
            this.btnDelete.TabIndex = 12;
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
            this.btnEdit.Location = new System.Drawing.Point(45, 356);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(642, 41);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtCodeE
            // 
            this.txtCodeE.Location = new System.Drawing.Point(52, 62);
            this.txtCodeE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodeE.Name = "txtCodeE";
            this.txtCodeE.Size = new System.Drawing.Size(121, 31);
            this.txtCodeE.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "کد خط را وارد کنید";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(372, 42);
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
            this.btnAdd.Location = new System.Drawing.Point(282, 42);
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
            this.btnOk.Location = new System.Drawing.Point(192, 42);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 62);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.groupBox3);
            this.tabPageSearch.Controls.Add(this.dataGridView1);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.txtSearch);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 33);
            this.tabPageSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSearch.Size = new System.Drawing.Size(719, 459);
            this.tabPageSearch.TabIndex = 2;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDR);
            this.groupBox3.Controls.Add(this.rdbDW);
            this.groupBox3.Controls.Add(this.rdbCR);
            this.groupBox3.Controls.Add(this.rdbSource);
            this.groupBox3.Controls.Add(this.rdbDis);
            this.groupBox3.Controls.Add(this.rdbCW);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(25, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(676, 44);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // rdbDR
            // 
            this.rdbDR.AutoSize = true;
            this.rdbDR.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbDR.Location = new System.Drawing.Point(568, 13);
            this.rdbDR.Name = "rdbDR";
            this.rdbDR.Size = new System.Drawing.Size(103, 30);
            this.rdbDR.TabIndex = 0;
            this.rdbDR.TabStop = true;
            this.rdbDR.Text = "تاریخ برگشت";
            this.rdbDR.UseVisualStyleBackColor = true;
            // 
            // rdbDW
            // 
            this.rdbDW.AutoSize = true;
            this.rdbDW.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbDW.Location = new System.Drawing.Point(475, 13);
            this.rdbDW.Name = "rdbDW";
            this.rdbDW.Size = new System.Drawing.Size(87, 30);
            this.rdbDW.TabIndex = 1;
            this.rdbDW.TabStop = true;
            this.rdbDW.Text = "تاریخ رفت";
            this.rdbDW.UseVisualStyleBackColor = true;
            // 
            // rdbCR
            // 
            this.rdbCR.AutoSize = true;
            this.rdbCR.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbCR.Location = new System.Drawing.Point(361, 13);
            this.rdbCR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCR.Name = "rdbCR";
            this.rdbCR.Size = new System.Drawing.Size(108, 30);
            this.rdbCR.TabIndex = 2;
            this.rdbCR.TabStop = true;
            this.rdbCR.Text = "ساعت برگشت";
            this.rdbCR.UseVisualStyleBackColor = true;
            // 
            // rdbSource
            // 
            this.rdbSource.AutoSize = true;
            this.rdbSource.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbSource.Location = new System.Drawing.Point(135, 13);
            this.rdbSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSource.Name = "rdbSource";
            this.rdbSource.Size = new System.Drawing.Size(54, 30);
            this.rdbSource.TabIndex = 5;
            this.rdbSource.TabStop = true;
            this.rdbSource.Text = "مبدا";
            this.rdbSource.UseVisualStyleBackColor = true;
            // 
            // rdbDis
            // 
            this.rdbDis.AutoSize = true;
            this.rdbDis.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbDis.Location = new System.Drawing.Point(195, 13);
            this.rdbDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDis.Name = "rdbDis";
            this.rdbDis.Size = new System.Drawing.Size(62, 30);
            this.rdbDis.TabIndex = 4;
            this.rdbDis.TabStop = true;
            this.rdbDis.Text = "مقصد";
            this.rdbDis.UseVisualStyleBackColor = true;
            // 
            // rdbCW
            // 
            this.rdbCW.AutoSize = true;
            this.rdbCW.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbCW.Location = new System.Drawing.Point(263, 13);
            this.rdbCW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCW.Name = "rdbCW";
            this.rdbCW.Size = new System.Drawing.Size(92, 30);
            this.rdbCW.TabIndex = 3;
            this.rdbCW.TabStop = true;
            this.rdbCW.Text = "ساعت رفت";
            this.rdbCW.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 253);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(602, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(25, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(571, 39);
            this.txtSearch.TabIndex = 0;
            // 
            // frmLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(987, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خطوط پرواز";
            this.Load += new System.EventHandler(this.frmLine_Load);
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rdbCW;
        private System.Windows.Forms.RadioButton rdbDis;
        private System.Windows.Forms.RadioButton rdbSource;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbDis;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDateE;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox line_clockReturnTextBox;
        private System.Windows.Forms.TextBox line_clockWentTextBox;
        private System.Windows.Forms.TextBox line_dateReturnTextBox;
        private System.Windows.Forms.TextBox line_dateWentTextBox;
        private System.Windows.Forms.TextBox txtCRE;
        private System.Windows.Forms.TextBox txtCWE;
        private System.Windows.Forms.TextBox txtDRE;
        private System.Windows.Forms.TextBox txtDWE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDisE;
        private System.Windows.Forms.ComboBox cmbSourceE;
        private System.Windows.Forms.RadioButton rdbCR;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDR;
        private System.Windows.Forms.RadioButton rdbDW;
        private System.Windows.Forms.ToolTip toolTip1;




    }
}

