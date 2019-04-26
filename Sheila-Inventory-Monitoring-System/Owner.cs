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
    public partial class Owner : Form
    {
        public string uid;
        public Owner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            db.dbInsert($"INSERT INTO Owners(name, contact) VALUES('{txtOwner.Text}', '{txtContact.Text}')");
            this.Close();
            MessageBox.Show($"Owner {txtOwner.Text} added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            db.dbUpdate($"UPDATE Owners SET name='{txtOwner.Text}', contact='{txtContact.Text}' WHERE id='{this.uid}'");
            this.Close();
            MessageBox.Show("Owner Updated!");
        }
    }
}
