namespace Airplane
{
    partial class frmTicket
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
            System.Windows.Forms.Label copon_codeLabel;
            System.Windows.Forms.Label tiket_costLabel;
            System.Windows.Forms.Label line_codeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnPassenger = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.line_codeTextBox = new System.Windows.Forms.TextBox();
            this.tiket_costTextBox = new System.Windows.Forms.TextBox();
            this.copon_codeTextBox = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtLine = new System.Windows.Forms.TextBox();
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            copon_codeLabel = new System.Windows.Forms.Label();
            tiket_costLabel = new System.Windows.Forms.Label();
            line_codeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
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
            // copon_codeLabel
            // 
            copon_codeLabel.AutoSize = true;
            copon_codeLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            copon_codeLabel.Location = new System.Drawing.Point(632, 135);
            copon_codeLabel.Name = "copon_codeLabel";
            copon_codeLabel.Size = new System.Drawing.Size(53, 26);
            copon_codeLabel.TabIndex = 9;
            copon_codeLabel.Text = "کد کپن";
            // 
            // tiket_costLabel
            // 
            tiket_costLabel.AutoSize = true;
            tiket_costLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            tiket_costLabel.Location = new System.Drawing.Point(635, 176);
            tiket_costLabel.Name = "tiket_costLabel";
            tiket_costLabel.Size = new System.Drawing.Size(50, 26);
            tiket_costLabel.TabIndex = 10;
            tiket_costLabel.Text = "کد خط";
            // 
            // line_codeLabel
            // 
            line_codeLabel.AutoSize = true;
            line_codeLabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            line_codeLabel.Location = new System.Drawing.Point(641, 219);
            line_codeLabel.Name = "line_codeLabel";
            line_codeLabel.Size = new System.Drawing.Size(44, 26);
            line_codeLabel.TabIndex = 11;
            line_codeLabel.Text = "هزینه";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.Location = new System.Drawing.Point(648, 150);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 26);
            label1.TabIndex = 16;
            label1.Text = "هزینه";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.Location = new System.Drawing.Point(642, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 26);
            label2.TabIndex = 15;
            label2.Text = "کد خط";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label5.Location = new System.Drawing.Point(632, 100);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 26);
            label5.TabIndex = 9;
            label5.Text = "کد بلیط";
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
            this.btnTicket.Enabled = false;
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
            this.btnPassenger.Location = new System.Drawing.Point(11, 129);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(234, 74);
            this.btnPassenger.TabIndex = 0;
            this.btnPassenger.Text = "Passenger";
            this.btnPassenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassenger.UseVisualStyleBackColor = false;
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(727, 518);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageEdit);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(line_codeLabel);
            this.tabPageAdd.Controls.Add(this.line_codeTextBox);
            this.tabPageAdd.Controls.Add(tiket_costLabel);
            this.tabPageAdd.Controls.Add(this.tiket_costTextBox);
            this.tabPageAdd.Controls.Add(label5);
            this.tabPageAdd.Controls.Add(copon_codeLabel);
            this.tabPageAdd.Controls.Add(this.copon_codeTextBox);
            this.tabPageAdd.Controls.Add(this.txtDate);
            this.tabPageAdd.Controls.Add(this.btnCancle);
            this.tabPageAdd.Controls.Add(this.btnRegister);
            this.tabPageAdd.Controls.Add(this.txtCode);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 28);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(719, 475);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // line_codeTextBox
            // 
            this.line_codeTextBox.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.line_codeTextBox.Location = new System.Drawing.Point(45, 176);
            this.line_codeTextBox.Name = "line_codeTextBox";
            this.line_codeTextBox.Size = new System.Drawing.Size(568, 31);
            this.line_codeTextBox.TabIndex = 3;
            // 
            // tiket_costTextBox
            // 
            this.tiket_costTextBox.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tiket_costTextBox.Location = new System.Drawing.Point(45, 217);
            this.tiket_costTextBox.Name = "tiket_costTextBox";
            this.tiket_costTextBox.Size = new System.Drawing.Size(568, 31);
            this.tiket_costTextBox.TabIndex = 4;
            // 
            // copon_codeTextBox
            // 
            this.copon_codeTextBox.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.copon_codeTextBox.Location = new System.Drawing.Point(45, 137);
            this.copon_codeTextBox.Name = "copon_codeTextBox";
            this.copon_codeTextBox.Size = new System.Drawing.Size(568, 31);
            this.copon_codeTextBox.TabIndex = 2;
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
            this.btnCancle.Location = new System.Drawing.Point(45, 401);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(642, 41);
            this.btnCancle.TabIndex = 6;
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
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCode.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCode.Location = new System.Drawing.Point(45, 98);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(568, 31);
            this.txtCode.TabIndex = 1;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.btnExit);
            this.tabPageEdit.Controls.Add(this.btnAdd);
            this.tabPageEdit.Controls.Add(this.btnOk);
            this.tabPageEdit.Controls.Add(label1);
            this.tabPageEdit.Controls.Add(this.txtCost);
            this.tabPageEdit.Controls.Add(label2);
            this.tabPageEdit.Controls.Add(this.txtLine);
            this.tabPageEdit.Controls.Add(this.txtDateE);
            this.tabPageEdit.Controls.Add(this.btnDelete);
            this.tabPageEdit.Controls.Add(this.btnEdit);
            this.tabPageEdit.Controls.Add(this.txtCodeE);
            this.tabPageEdit.Controls.Add(this.label4);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 28);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(719, 475);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Edit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(400, 27);
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
            this.btnAdd.Location = new System.Drawing.Point(310, 27);
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
            this.btnOk.Location = new System.Drawing.Point(220, 27);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 62);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCost.Location = new System.Drawing.Point(48, 148);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(578, 31);
            this.txtCost.TabIndex = 6;
            // 
            // txtLine
            // 
            this.txtLine.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLine.Location = new System.Drawing.Point(48, 107);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(578, 31);
            this.txtLine.TabIndex = 5;
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
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
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
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtCodeE
            // 
            this.txtCodeE.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeE.Location = new System.Drawing.Point(48, 54);
            this.txtCodeE.Name = "txtCodeE";
            this.txtCodeE.Size = new System.Drawing.Size(151, 31);
            this.txtCodeE.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(88, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "کد بلیط را وارد کنید";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.groupBox3);
            this.tabPageSearch.Controls.Add(this.dataGridView1);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.txtSearch);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 28);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(719, 475);
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
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbName.Location = new System.Drawing.Point(504, 9);
            this.rdbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(62, 30);
            this.rdbName.TabIndex = 1;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "هزینه";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbLast
            // 
            this.rdbLast.AutoSize = true;
            this.rdbLast.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbLast.Location = new System.Drawing.Point(572, 9);
            this.rdbLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbLast.Name = "rdbLast";
            this.rdbLast.Size = new System.Drawing.Size(90, 30);
            this.rdbLast.TabIndex = 0;
            this.rdbLast.TabStop = true;
            this.rdbLast.Text = "شماره کپن";
            this.rdbLast.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 173);
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
            this.btnSearch.Location = new System.Drawing.Point(603, 51);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(21, 52);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(576, 39);
            this.txtSearch.TabIndex = 0;
            // 
            // frmTicket
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
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بلیط";
            this.Load += new System.EventHandler(this.frmTicket_Load);
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
        private System.Windows.Forms.TextBox line_codeTextBox;
        private System.Windows.Forms.TextBox tiket_costTextBox;
        private System.Windows.Forms.TextBox copon_codeTextBox;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbLast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip toolTip1;




    }
}

