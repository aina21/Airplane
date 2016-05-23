using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace Airplane
{
    public partial class frmLine : Form
    {
        private DataTable tblCitySource;
        private DataTable tblCityDis; 

        public frmLine()
        {
            InitializeComponent();
        }

        private void frmLine_Load(object sender, EventArgs e)
        {
            //تاریخ فارسی
            PersianCalendar farsidate = new PersianCalendar();
            string fyear, fmonth, fday = null;
            fyear = farsidate.GetYear(System.DateTime.Now).ToString().Substring(2, 2);
            fmonth = farsidate.GetMonth(System.DateTime.Now).ToString();
            fday = farsidate.GetDayOfMonth(System.DateTime.Now).ToString();
            //if (Strings.Len(fmonth) == 1)
            if (fmonth.Length == 1)
                fmonth = "0" + fmonth;
            if (fday.Length == 1)
                fday = "0" + fday;
            txtDate.Text = fyear +"/"+ fmonth+"/" + fday;
            txtDateE.Text = fyear + "/" + fmonth + "/" + fday;

            //نمایش tooltip
            toolTip1.SetToolTip(this.btnAdd, "اضافه کردن خط جدید");
            toolTip1.SetToolTip(this.btnOk, "نمایش اطلاعات");
            toolTip1.SetToolTip(this.btnExit, "خروج");

            //کد خط جدید
            DataTable tblLine = new DataTable();
            tblLine = Class1.GetData("SELECT TOP 1 tblLine.line_code FROM tblLine ORDER BY tblLine.line_code DESC");
            txtCode.Text = (Convert.ToInt32( tblLine.Rows[0][0])+1).ToString();

            //قرار دادن نام شهر مبدا در لیست 
            tblCitySource = Class1.GetData("SELECT tblCity.city_code , tblCity.city_name FROM tblCity");
            cmbSource.DataSource = tblCitySource;
            cmbSource.DisplayMember = tblCitySource.Columns[1].ToString();//اسم شهر میگیرد
            cmbSource.ValueMember = tblCitySource.Columns[0].ToString();//کلید شهر را میگیرد

            //قرار دادن نام شهر در لیست مقصد
            tblCityDis = Class1.GetData("SELECT tblCity.city_code , tblCity.city_name FROM tblCity");
            cmbDis.DataSource = tblCityDis;
            cmbDis.DisplayMember = tblCityDis.Columns[1].ToString();
            cmbDis.ValueMember = tblCityDis.Columns[0].ToString();

            //تب ویرایش
            // قرار دادن نام شهر مبدا در لیست
            cmbSourceE.DataSource = tblCitySource;
            cmbSourceE.DisplayMember = tblCitySource.Columns[1].ToString();
            cmbSourceE.ValueMember = tblCitySource.Columns[0].ToString();

            //قرار دادن نام  شهر مقصد در لیست 
            cmbDisE.DataSource = tblCityDis;
            cmbDisE.DisplayMember = tblCityDis.Columns[1].ToString();
            cmbDisE.ValueMember = tblCityDis.Columns[0].ToString();
          
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            frmLine Line = new frmLine();
            Line.Show();
            this.Close();
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            frmPassenger Passenger = new frmPassenger();
            Passenger.Show();
            this.Close();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            frmTicket Ticket = new frmTicket();
            Ticket.Show();
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            frmCityAdd city = new frmCityAdd();
            city.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmCityRemove city = new frmCityRemove();
            city.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Line line = new Line(txtCode.Text,cmbSource.Text,
                cmbDis.Text,line_dateWentTextBox.Text,
                line_clockWentTextBox.Text,
                line_dateReturnTextBox.Text,
                line_clockReturnTextBox.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //ویرایش
            try
            {
                Line line = new Line(Convert.ToInt32(txtCodeE.Text));
                line.ClockReturn = txtCRE.Text;
                line.ClockWent = txtCWE.Text;
                line.DataReturn = txtDRE.Text;
                line.DataWent = txtDWE.Text;
                line.DestinationCode = cmbDisE.Text;
                line.SourceCode = cmbSourceE.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //حذف 
            try
            {
                Line line = new Line(Convert.ToInt32(txtCodeE.Text));
                line.Delete(Convert.ToInt32(txtCodeE.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //نمایش اطلاعات به کاربر
            try
            {
                Line line = new Line(Convert.ToInt32(txtCodeE.Text));

                line.Call(Convert.ToInt32(txtCodeE.Text));
                cmbSourceE.Text = line.SourceCode;
                cmbDisE.Text = line.DestinationCode;
                txtDWE.Text = line.DataWent;
                txtDRE.Text = line.DataReturn;
                txtCWE.Text = line.ClockWent;
                txtCRE.Text = line.ClockReturn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //جستجو
            try
            {
                Line line = new Line();
                //پیدا کردن نوع انتخاب شده 
                var checkedButton = groupBox3.Controls.OfType<RadioButton>().Where(r => r.Checked == true).FirstOrDefault();

                line.Search(checkedButton.Text, txtSearch.Text);

                //نمایش به کاربر
                dataGridView1.DataSource = line.tblLine;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.AllowDrop = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[0].HeaderText = "کد خط";
                dataGridView1.Columns[1].HeaderText = "مبدا";
                dataGridView1.Columns[2].HeaderText = "مقصد";
                dataGridView1.Columns[3].HeaderText = "تاریخ رفت";
                dataGridView1.Columns[4].HeaderText = "تاریخ برگشت";
                dataGridView1.Columns[5].HeaderText = "ساعت رفت";
                dataGridView1.Columns[6].HeaderText = "ساعت برگشت";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
