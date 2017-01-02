using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BankApp
{
    public partial class AccountForm : Form
    {
        List<Client> clientList = new List<Client>();
        int max_id = 0;
        string persnr_key;
        string account_type;
        Account a;

        public AccountForm(List<Client> _clientList)
        {
            InitializeComponent();
            clientList = _clientList;

            for (int i = 0; i < clientList.Count(); i++)
            {
                for (int j = 0; j < clientList[i].accountList.Count(); j++)
                {
                    if (clientList[i].accountList[j].accountid > max_id)
                    {
                        max_id = clientList[i].accountList[j].accountid;
                    }
                }
            }

            boxAddAccountAccountID.Text = (max_id + 1).ToString();
            max_id++;

            List<string> accountTypeList = new List<string>();
            accountTypeList.Add("Private");
            accountTypeList.Add("Future");
            accountTypeList.Add("Service");

            cboxAccountType.DataSource = accountTypeList;

            cboxClientList.DataSource = clientList;
            cboxClientList.DisplayMember = "first_name";
            cboxClientList.ValueMember = "persnr";

            if (cboxClientList.Items.Count > 0)
            {
                cboxClientList.SelectedIndex = 0;
                // Set first entry persnr in Listbox as default since no
                persnr_key = cboxClientList.SelectedValue.ToString();
            }
        }
    
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (account_type == "Private")
            {
                a = new PrivateAccount(int.Parse(boxAddAccountAccountID.Text), double.Parse(boxAddAccountCredit.Text), double.Parse(boxAddAccountBalance.Text));
            }
            if (account_type == "Future")
            {
                a = new FutureAccount(int.Parse(boxAddAccountAccountID.Text), double.Parse(boxAddAccountBalance.Text));
            }
            if (account_type == "Service")
            {
                a = new ServiceAccount(int.Parse(boxAddAccountAccountID.Text), double.Parse(boxAddAccountBalance.Text));
            }

            for (int i = 0; i < clientList.Count(); i++)
            {
                if (clientList[i].persnr == persnr_key)
                {
                    clientList[i].addAccountToList(a);
                }
            }

            boxAddAccountAccountID.Text = (max_id+1).ToString();
            max_id++;
            boxAddAccountBalance.Clear();
        }

        private void cboxClientList_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((Client)e.ListItem).first_name;
            string firstname = ((Client)e.ListItem).last_name;
            e.Value = lastname + " " + firstname;
        }

        private void cboxClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            persnr_key = cboxClientList.SelectedValue.ToString();
        }

        private void cboxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            account_type = cboxAccountType.SelectedItem.ToString();

            if (account_type == "Private")
            {
                lblAddAccountCredit.Visible = true;
                boxAddAccountCredit.Visible = true;
            }
            if (account_type == "Future")
            {
                lblAddAccountCredit.Visible = false;
                boxAddAccountCredit.Visible = false;
            }
            if (account_type == "Service")
            {
                lblAddAccountCredit.Visible = false;
                boxAddAccountCredit.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really cancel and close form?", "Cancel?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
