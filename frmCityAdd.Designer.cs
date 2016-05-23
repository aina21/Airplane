namespace Airplane
{
    partial class frmCityAdd
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
            System.Windows.Forms.Label city_codeLabel;
            System.Windows.Forms.Label city_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCityAdd));
            this.city_codeTextBox = new System.Windows.Forms.TextBox();
            this.city_nameTextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            city_codeLabel = new System.Windows.Forms.Label();
            city_nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // city_codeLabel
            // 
            city_codeLabel.AutoSize = true;
            city_codeLabel.Location = new System.Drawing.Point(336, 9);
            city_codeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            city_codeLabel.Name = "city_codeLabel";
            city_codeLabel.Size = new System.Drawing.Size(79, 24);
            city_codeLabel.TabIndex = 1;
            city_codeLabel.Text = "city code:";
            // 
            // city_nameLabel
            // 
            city_nameLabel.AutoSize = true;
            city_nameLabel.Location = new System.Drawing.Point(331, 59);
            city_nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            city_nameLabel.Name = "city_nameLabel";
            city_nameLabel.Size = new System.Drawing.Size(84, 24);
            city_nameLabel.TabIndex = 3;
            city_nameLabel.Text = "city name:";
            // 
            // city_codeTextBox
            // 
            this.city_codeTextBox.Location = new System.Drawing.Point(14, 9);
            this.city_codeTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.city_codeTextBox.Name = "city_codeTextBox";
            this.city_codeTextBox.Size = new System.Drawing.Size(294, 31);
            this.city_codeTextBox.TabIndex = 2;
            // 
            // city_nameTextBox
            // 
            this.city_nameTextBox.Location = new System.Drawing.Point(14, 52);
            this.city_nameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.city_nameTextBox.Name = "city_nameTextBox";
            this.city_nameTextBox.Size = new System.Drawing.Size(294, 31);
            this.city_nameTextBox.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Airplane.Properties.Resources._20130702011342452_easyicon_net_32;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(340, 92);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 42);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Airplane.Properties.Resources.add_to_database32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(14, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(294, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCityAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(432, 155);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(city_codeLabel);
            this.Controls.Add(this.city_codeTextBox);
            this.Controls.Add(city_nameLabel);
            this.Controls.Add(this.city_nameTextBox);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmCityAdd";
            this.Text = "اضافه کردن شهر";
            this.Load += new System.EventHandler(this.frmCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox city_codeTextBox;
        private System.Windows.Forms.TextBox city_nameTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
    }
}