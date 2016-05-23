using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Airplane
{
    public partial class frmCityRemove : Form
    {
        private DataTable tblCity;

        public frmCityRemove()
        {
            InitializeComponent();
        }

        private void frmCityRemove_Load(object sender, EventArgs e)
        {
            tblCity = Class1.GetData("SELECT tblCity.city_code , tblCity.city_name FROM tblCity");
            cmbCode.DataSource = tblCity;
            cmbCode.DisplayMember = tblCity.Columns[0].ToString();
            cmbCode.ValueMember = tblCity.Columns[0].ToString();

            cmbName.DataSource = tblCity;
            cmbName.DisplayMember = tblCity.Columns[1].ToString();
            cmbName.ValueMember = tblCity.Columns[0].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Delete(cmbCode.Text, cmbName.Text);
        }
    }
}
