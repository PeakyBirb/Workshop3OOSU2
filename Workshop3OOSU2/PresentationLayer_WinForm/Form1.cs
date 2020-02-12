using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace PresentationLayer_WinForm
{
    public partial class Form1 : Form
    {
        BindingSource BindingSource = new BindingSource();
        BusinessManager businessManager = new BusinessManager();

        public Form1()
        {
            InitializeComponent();

            BindingSource.DataSource = businessManager.GetProductsLINQ();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = businessManager.GetProductsStartingWithA();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = businessManager.GetProductsUnitPrice();
            dataGridView1.DataSource = BindingSource.DataSource;
        }
    }
}
