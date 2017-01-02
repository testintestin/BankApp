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
    public partial class EditAccountForm : Form
    {
        int row_id;
        List<Client> clientList = new List<Client>();

        public EditAccountForm(List<Client> _clientList)
        {
            InitializeComponent();
            clientList = _clientList;

            dgvClientList.DataSource = clientList;
            dgvClientList.ClearSelection();

            dgvAccountList.ColumnCount = 4;
            dgvAccountList.Columns[0].Name = "Account ID";
            dgvAccountList.Columns[1].Name = "Interest rate";
            dgvAccountList.Columns[2].Name = "Credit";
            dgvAccountList.Columns[3].Name = "Balance";

            for (int i = 0; i < dgvAccountList.ColumnCount; i++)
            {
                dgvAccountList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void refillDataGridView()
        {
            dgvAccountList.Rows.Clear();

            for (int i = 0; i < clientList.Count(); i++)
            {
                if (clientList[i].persnr == dgvClientList.CurrentRow.Cells[3].Value.ToString())
                {
                    for (int j = 0; j < clientList[i].accountList.Count(); j++)
                    {
                        dgvAccountList.Rows.Add(clientList[i].accountList[j].accountid, clientList[i].accountList[j].interestRate, clientList[i].accountList[j].credit, clientList[i].accountList[j].balance);
                    }
                }
            }
        }

        private void dgvClientList_MouseClick(object sender, MouseEventArgs e)
        {
            refillDataGridView();
        }

        private void dgvAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                row_id = e.RowIndex + 1;
            }

            DataGridViewRow row = dgvAccountList.Rows[row_id];

            boxAccountID.Text = row.Cells[0].Value.ToString();
            boxInterestRate.Text = row.Cells[1].Value.ToString();
            boxCredit.Text = row.Cells[2].Value.ToString();
            boxBalance.Text = row.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAccountList.Rows[row_id];

            if (MessageBox.Show("Really update?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                row.Cells[0].Value = int.Parse(boxAccountID.Text);
                row.Cells[1].Value = double.Parse(boxInterestRate.Text);
                row.Cells[2].Value = double.Parse(boxCredit.Text);
                row.Cells[3].Value = double.Parse(boxBalance.Text);

                for (int i = 0; i < clientList.Count(); i++)
                {
                    if (clientList[i].persnr == dgvClientList.CurrentRow.Cells[3].Value.ToString())
                    {
                        for (int j = 0; j < clientList[i].accountList.Count(); j++)
                        {
                            if (clientList[i].accountList[j].accountid == int.Parse(boxAccountID.Text))
                            {
                                clientList[i].accountList[j].accountid = int.Parse(boxAccountID.Text);
                                clientList[i].accountList[j].interestRate = double.Parse(boxInterestRate.Text);
                                clientList[i].accountList[j].credit = double.Parse(boxCredit.Text);
                                clientList[i].accountList[j].balance = double.Parse(boxBalance.Text);
                            }
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAccountList.Rows[row_id];

            if (MessageBox.Show("Really delete row?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < clientList.Count(); i++)
                {
                    if (clientList[i].persnr == dgvClientList.CurrentRow.Cells[3].Value.ToString())
                    {
                        for (int j = 0; j < clientList[i].accountList.Count(); j++)
                        {
                            if (clientList[i].accountList[j].accountid == int.Parse(row.Cells[0].Value.ToString()))
                            {
                                clientList[i].delAccount(j);
                            }
                        }
                    }
                }
                refillDataGridView();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really cancel and close form?", "Cancel?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
