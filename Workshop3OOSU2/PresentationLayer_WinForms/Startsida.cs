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


namespace PresentationLayer_WinForms
{
    public partial class Startsida : Form
    {
        BindingSource BindingSource = new BindingSource();
        BusinessManager businessManager = new BusinessManager();

        public Startsida()
        {
            InitializeComponent();

            BindingSource.DataSource = businessManager.GetProducts();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        private void Startsida_Load(object sender, EventArgs e)
        {

        }
    }
}
