using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sheila_Inventory_Monitoring_System
{
    public partial class Main : Form
    {
        string selectedItemPrice;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getItemList();
            getOwnerList();
            getSlot();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.btnAdd.Visible = true;
            item.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.btnAdd.Visible = true;
            owner.Show();
        }

        private void getItemList()
        {
            dbClass db = new dbClass();
            System.Data.DataTable items = db.dbSelect("SELECT id as 'uid', name as 'Item Name', price as 'Price', owner as 'Owner', quantity as 'Quantity', slot as 'Slot Number' FROM Items");
            dataGridViewItems.DataSource = items;
            dataGridViewItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewItems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewItems.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewItems.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewItems.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void getOwnerList()
        {
            dbClass db = new dbClass();
            System.Data.DataTable owners = db.dbSelect("SELECT id as 'uid', name as 'Owner Name', contact as 'Contact Number' FROM Owners");
            dataGridViewOwners.DataSource = owners;
            dataGridViewOwners.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOwners.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOwners.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            getItemList();
            MessageBox.Show("Item List Updated!");
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // this.uid = dataGridViewItems.CurrentRow.Cells[0].Value.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Delete {dataGridViewItems.CurrentRow.Cells[1].Value.ToString()}?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                dbClass db = new dbClass();
                db.dbDelete("DELETE FROM Items WHERE id='" + dataGridViewItems.CurrentRow.Cells[0].Value.ToString() + "'");
                getItemList();
                MessageBox.Show("Item Deleted");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.btnUpdate.Visible = true;
            item.uid = dataGridViewItems.CurrentRow.Cells[0].Value.ToString();
            item.txtItemName.Text = dataGridViewItems.CurrentRow.Cells[1].Value.ToString();
            item.txtItemPrice.Text = dataGridViewItems.CurrentRow.Cells[2].Value.ToString();
            item.cmbItemOwner.Text = dataGridViewItems.CurrentRow.Cells[3].Value.ToString();
            item.numItemQuantity.Value = Convert.ToInt32(dataGridViewItems.CurrentRow.Cells[4].Value);
            item.txtItemSlot.Text = dataGridViewItems.CurrentRow.Cells[5].Value.ToString();
            item.Show();
        }

        private void dataGridViewOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.owner_uid = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            getOwnerList();
            MessageBox.Show("Owner list Updated!");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Delete {dataGridViewOwners.CurrentRow.Cells[1].Value.ToString()}?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                dbClass db = new dbClass();
                db.dbDelete($"DELETE FROM Owners WHERE id='{dataGridViewOwners.CurrentRow.Cells[0].Value.ToString()}'");
                getOwnerList();
                MessageBox.Show($"Owner deleted");
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.btnUpdate.Visible = true;
            owner.uid = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
            owner.txtOwner.Text = dataGridViewOwners.CurrentRow.Cells[1].Value.ToString();
            owner.txtContact.Text = dataGridViewOwners.CurrentRow.Cells[2].Value.ToString();
            owner.Show();
        }

        private void getOwners()
        {
            cmbOwner.Items.Clear();
            try
            {
                dbClass db = new dbClass();
                System.Data.DataTable dt = db.dbSelect($"Select DISTINCT owner FROM Items WHERE slot='{cmbSlot.Text}'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbOwner.Items.Add(dt.Rows[i][0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSlot()
        {
            try
            {
                dbClass db = new dbClass();
                System.Data.DataTable dt = db.dbSelect($"Select * FROM Items");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbSlot.Items.Add(dt.Rows[i]["slot"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getItems()
        {
            cmbItem.Items.Clear();
            try
            {
                dbClass db = new dbClass();
                System.Data.DataTable dt = db.dbSelect($"Select * FROM Items WHERE slot='{cmbSlot.Text}' AND owner='{cmbOwner.Text}'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbItem.Items.Add(dt.Rows[i]["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            getItems();
        }

        private void cmbSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            getOwners();
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            System.Data.DataTable dt = db.dbSelect($"Select * FROM Items WHERE slot='{cmbSlot.Text}' AND owner='{cmbOwner.Text}' AND name='{cmbItem.Text}'");
            this.selectedItemPrice = dt.Rows[0][2].ToString();
            lblAvailable.Text = dt.Rows[0][4].ToString();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblAvailable.Text) < numQuantity.Value)
            {
                numQuantity.Value = numQuantity.Value - 1;
                MessageBox.Show("Item limit exceed!");
            }
            else
            {
                lblTotal.Text = (Convert.ToDecimal(this.selectedItemPrice) * Convert.ToDecimal(numQuantity.Value)).ToString();
            }
        }
    }
}
