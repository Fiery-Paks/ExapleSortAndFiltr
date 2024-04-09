using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.DataModel;

namespace WindowsFormsApp7.Forms
{
    public partial class Form2 : Form
    {
        private Product _product;
        public Form2(Product product)
        {
            InitializeComponent();
            _product = product;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = _product;
        }
    }
}
