namespace Airplane
{
    partial class frmCityRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCityRemove));
            this.city_codeLabel = new System.Windows.Forms.Label();
            this.city_nameLabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // city_codeLabel
            // 
            this.city_codeLabel.AutoSize = true;
            this.city_codeLabel.Location = new System.Drawing.Point(336, 9);
            this.city_codeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.city_codeLabel.Name = "city_codeLabel";
            this.city_codeLabel.Size = new System.Drawing.Size(79, 24);
            this.city_codeLabel.TabIndex = 1;
            this.city_codeLabel.Text = "city code:";
            // 
            // city_nameLabel
            // 
            this.city_nameLabel.AutoSize = true;
            this.city_nameLabel.Location = new System.Drawing.Point(331, 59);
            this.city_nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.city_nameLabel.Name = "city_nameLabel";
            this.city_nameLabel.Size = new System.Drawing.Size(84, 24);
            this.city_nameLabel.TabIndex = 3;
            this.city_nameLabel.Text = "city name:";
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
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::Airplane.Properties.Resources.remove_from_database32;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(14, 92);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(294, 42);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmbCode
            // 
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(14, 9);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(294, 32);
            this.cmbCode.TabIndex = 6;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(14, 47);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(294, 32);
            this.cmbName.TabIndex = 6;
            // 
            // frmCityRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(432, 155);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.city_codeLabel);
            this.Controls.Add(this.city_nameLabel);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmCityRemove";
            this.Text = "حذف شهر";
            this.Load += new System.EventHandler(this.frmCityRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label city_codeLabel;
        private System.Windows.Forms.Label city_nameLabel;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.ComboBox cmbName;
    }
}
