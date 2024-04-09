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
using WindowsFormsApp7.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp7.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            products = model.Product.ToList();
        }

        private Model1 model = new Model1();
        private List<Product> products = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductType> producttypes = model.ProductType.ToList();
            producttypes.Add(new ProductType(6, "Все типы"));
            productTypeBindingSource.DataSource = producttypes;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 5;
            FillPanel();

        }
        private void FillPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Product prod in products)
            {
                UserControl1 userControl1 = new UserControl1(prod);
                flowLayoutPanel1.Controls.Add(userControl1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }
        private void FiltrAndSorting()
        {
            Filtr();
            Sort();
        }
        private void Sort()
        {
            if (comboBox1.SelectedItem.ToString() == "ID")
            {
                products = products.OrderBy(x => x.ID).ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "Title")
            {
                products = products.OrderBy(x => x.Title).ToList();

            }
            if (comboBox1.SelectedItem.ToString() == "MinCostForAgent")
            {
                products = products.OrderBy(x => x.MinCostForAgent).ToList();

            }
            FillPanel();
        }

        private void Filtr()
        {
            if (comboBox2.SelectedItem == null)
                return;
            

            if (String.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                products = model.Product.ToList();
            }
            else
            {
                products = model.Product.Where(x => x.Title.ToLower().Replace(" ", "").Contains(textBoxSearch.Text.ToLower().Replace(" ", ""))).ToList();
            }

            if ((comboBox2.SelectedItem as ProductType).Title != "Все типы")
            {
                products = products.Where(x => x.ProductType.ID == (comboBox2.SelectedItem as ProductType).ID).ToList();
            }

            if (products.Count == 0)
            {
                labelProduct.Visible = true;
            }
            else
            {
                labelProduct.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }
    }
}
