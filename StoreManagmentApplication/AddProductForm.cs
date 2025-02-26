using StoreManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagmentApplication
{
    public partial class AddProductForm : Form
    {
        private AdminForm _adminForm;

        public AddProductForm(AdminForm adminForm)
        {
            InitializeComponent();
            _adminForm = adminForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product(txtName.Text, decimal.Parse(txtPrice.Text));

            Storage.Products.Add(product);
            _adminForm.Refresh();
            this.Close();
        }
    }
}
