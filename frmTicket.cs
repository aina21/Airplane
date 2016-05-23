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
    public partial class frmTicket : Form
    {
        public frmTicket()
        {
            InitializeComponent();
        }

        private void frmTicket_Load(object sender, EventArgs e)
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

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(txtCode.Text, Convert.ToInt32(copon_codeTextBox.Text),
                Convert.ToInt32(line_codeTextBox.Text), Convert.ToDouble(tiket_costTextBox.Text));
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //نمایش اطلاعات به کاربر
                Ticket ticket = new Ticket(txtCodeE.Text);
                ticket.Call(txtCodeE.Text);

                txtLine.Text = ticket.LineCode.ToString();
                txtCost.Text = ticket.Cost.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //ویرایش اطلاعات
            try
            {
                Ticket ticket = new Ticket(txtCodeE.Text);
                ticket.LineCode = Convert.ToInt32( txtLine.Text);
                ticket.Cost = Convert.ToDouble(txtCost.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //جستجو
                Ticket tiket = new Ticket();
                
                //نوع انتخاب شده توسط کاربر
                var checkedButton = groupBox3.Controls.OfType<RadioButton>().Where(r => r.Checked == true).FirstOrDefault();
              
                //جستجو
                tiket.Search(checkedButton.Text, txtSearch.Text);

                //نمایش به کاربر
                dataGridView1.DataSource = tiket.tblTicket;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.AllowDrop = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[0].HeaderText = "کد بلیط";
                dataGridView1.Columns[1].HeaderText = "کد کپن";
                dataGridView1.Columns[2].HeaderText = "هزینه";
                dataGridView1.Columns[3].HeaderText = "کد خط";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       
    }
}
