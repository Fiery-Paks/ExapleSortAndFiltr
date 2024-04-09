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
using WindowsFormsApp7.Forms;

namespace WindowsFormsApp7.UserControls
{
    public partial class UserControl1 : UserControl
    {
        private Product _product;
        public UserControl1(Product product)
        {
            InitializeComponent();
            Fill(product);
        }

        private void Fill(Product product)
        {
            _product = product;
            iDLabel1.Text = product.ID.ToString();
            titleLabel1.Text = product.Title.ToString();
            minCostForAgentLabel1.Text = product.MinCostForAgent.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(product.Image);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.no_image_1300x760;
            }
        }


        private void UserControl1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_product);
            form2.ShowDialog();
        }
    }
}
