using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Airplane
{
    public partial class frmPassenger : Form
    {
        public frmPassenger()
        {
            InitializeComponent();
        }

        private void frmPassenger_Load(object sender, EventArgs e)
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
            txtDate.Text = fyear + "/" + fmonth + "/" + fday;
            txtDateE.Text = fyear + "/" + fmonth + "/" + fday;

            //نمایش tooltip
            toolTip1.SetToolTip(this.btnAdd, "اضافه کردن خط جدید");
            toolTip1.SetToolTip(this.btnOk, "نمایش اطلاعات");
            toolTip1.SetToolTip(this.btnExit, "خروج");

            //کد خط جدید
            DataTable tblPassenger = new DataTable();
            tblPassenger = Class1.GetData("SELECT TOP 1 tblPerson.person_code FROM tblPerson ORDER BY tblPerson.person_code DESC");
            txtCode.Text = (Convert.ToInt32(tblPassenger.Rows[0][0]) + 1).ToString();

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            frmLine Line = new frmLine();
            Line.Show();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger(txtCode.Text, person_nameTextBox1.Text
                , person_lastNameTextBox.Text, person_mellicodeTextBox.Text
                , person_telTextBox.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger(Convert.ToInt32(txtCodeE.Text));
            passenger.Call(Convert.ToInt32(txtCodeE.Text));
            //نمایش اطلاعات به کاربر
            txtName.Text = passenger.Name;
            txtLast.Text = passenger.LastName;
            txtMelli.Text = passenger.MelliCode;
            txtTel.Text = passenger.Tel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //حذف اطلاعات
                Passenger passenger = new Passenger(Convert.ToInt32(txtCodeE.Text));
                passenger.Delete(Convert.ToInt32(txtCodeE.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //جستجو اطلاعات
                Passenger passenger = new Passenger();
                //کدوم مورد از انواع جستجو انتخاب شده
                var checkedButton = groupBox3.Controls.OfType<RadioButton>().Where(r => r.Checked == true).FirstOrDefault();

                passenger.Search(checkedButton.Text, txtSearch.Text);

                //نمایش اطلاعات جستجو شده به کاربر
                dataGridView1.DataSource = passenger.tblPassenger;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.AllowDrop = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[0].HeaderText = "کد مسافر";
                dataGridView1.Columns[1].HeaderText = "نام مسافر";
                dataGridView1.Columns[2].HeaderText = "نام خانوادگی مسافر";
                dataGridView1.Columns[3].HeaderText = "کد ملی";
                dataGridView1.Columns[4].HeaderText = "شماره تماس";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Passenger passenger = new Passenger(Convert.ToInt32(txtCodeE.Text));
                //ویرایش 
                passenger.Name = txtName.Text;
                passenger.LastName = txtLast.Text;
                passenger.MelliCode = txtMelli.Text;
                passenger.Tel = txtTel.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
