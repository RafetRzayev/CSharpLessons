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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            listViewProducts.View = View.Details;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Storage.Products)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewProducts.Items.Add(listViewItem);
            }

            dataGridView1.DataSource = Storage.Products;  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var productAddForm = new AddProductForm(this);
            productAddForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listViewProducts.Items.Clear();
            foreach (var item in Storage.Products)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewProducts.Items.Add(listViewItem);
            }
        }

        public void Refresh()
        {
            listViewProducts.Items.Clear();
            foreach (var item in Storage.Products)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewProducts.Items.Add(listViewItem);
            }

            
            //dataGridView1.DataSource = Storage.Products;
            //dataGridView1.Refresh();

            // it is not working
        }
    }
}
