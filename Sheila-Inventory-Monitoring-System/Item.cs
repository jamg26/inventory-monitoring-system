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
    public partial class Item : Form
    {
        public string uid;
        public Item()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            db.dbInsert("INSERT INTO items (name,price,owner,quantity,slot) VALUES ('" + txtItemName.Text + "', " + txtItemPrice.Text + ", '" +cmbItemOwner.Text + "', " + numItemQuantity.Value +", '" + txtItemSlot.Text + "')");
            this.Close();
            MessageBox.Show("Item added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            db.dbUpdate("UPDATE items SET name='" + txtItemName.Text + "', price=" + txtItemPrice.Text + ", owner='" + cmbItemOwner.Text + "', quantity=" + numItemQuantity.Value + ", slot='" + txtItemSlot.Text + "' WHERE id='" + this.uid + "'");
            this.Close();
            MessageBox.Show("Item Updated with uid: " + this.uid);
        }

        private void Item_Load(object sender, EventArgs e)
        {
            getOwners();
        }

        private void getOwners()
        {
            try
            {
                dbClass db = new dbClass();
                System.Data.DataTable dt = db.dbSelect("Select * FROM Owners");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbItemOwner.Items.Add(dt.Rows[i]["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
