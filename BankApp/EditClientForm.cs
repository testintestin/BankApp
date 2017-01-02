using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class EditClientForm : Form
    {
        BindingList<Client> bindingList;
        List<Client> clientList = new List<Client>();
        public EditClientForm(List<Client> _clientList)
        {
            InitializeComponent();
            clientList = _clientList;

            bindingList = new BindingList<Client>(clientList);
            bindingList.AllowRemove = true;
            bindingList.AllowEdit = true;
            bindingList.AllowNew = false;
            bindingList.RaiseListChangedEvents = true;
            dataGridEditClients.DataSource = bindingList;
        }

        private void btnEditClientDeleteRow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bindingList.RemoveAt(0);
            }
        }

        private void btnEditClientCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really cancel and close form?", "Cancel?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
