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
    public partial class frmCityAdd : Form
    {
        public frmCityAdd()
        {
            InitializeComponent();
        }

    

        private void frmCity_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            City city = new City(city_codeTextBox.Text, city_nameTextBox.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
