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
    public partial class ClientForm : Form
    {
        List<Client> clientList = new List<Client>();
        public ClientForm(List<Client> _clientList)
        {
            InitializeComponent();
            clientList = _clientList;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            int _id;

            if (clientList.Count() == 0)
                _id = 1;
            else
                _id = clientList[clientList.Count - 1].id + 1;

            Client c = new Client(_id, boxFirstName.Text, boxLastName.Text, boxPersnr.Text, boxStreet.Text, boxZip.Text, boxCity.Text, boxPhone.Text, boxMobile.Text);
            clientList.Add(c);

            boxFirstName.Clear();
            boxLastName.Clear();
            boxPersnr.Clear();
            boxStreet.Clear();
            boxZip.Clear();
            boxCity.Clear();
            boxPhone.Clear();
            boxMobile.Clear();
        }

        private void btnCancelClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really cancel and close form?", "Cancel?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
