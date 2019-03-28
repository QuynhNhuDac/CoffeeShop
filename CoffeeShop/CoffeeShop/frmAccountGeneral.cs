using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class frmAccountGeneral : Form
    {
        public frmAccountGeneral()
        {
            InitializeComponent();
        }

        private void btProfileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
