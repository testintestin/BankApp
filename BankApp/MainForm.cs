using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankApp
{
    public partial class MainForm : Form
    {
        public List<Client> clientList = new List<Client>();
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Bank Application v0.1";
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            // Set default dir to "My Documents"
            string default_dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Open...";
            OpenFileDialog.Filter = "Binary File (*.bin)|*.bin";
            OpenFileDialog.InitialDirectory = default_dir;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream ifstream = new FileStream(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                clientList = (List<Client>)formatter.Deserialize(ifstream);
                ifstream.Close();
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            // Set default dir to "My Documents"
            string default_dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Title = "Save...";
            SaveFileDialog.Filter = "Binary File (*.bin)|*.bin";
            SaveFileDialog.InitialDirectory = default_dir;

            if (SaveFileDialog.FileName != " ")
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream ofstream = new FileStream(SaveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(ofstream, clientList);
                ofstream.Close();
            }
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            // Set default dir to "My Documents"
            string default_dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Title = "Save...";
            SaveFileDialog.Filter = "Binary File (*.bin)|*.bin";
            SaveFileDialog.InitialDirectory = default_dir;

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream ofstream = new FileStream(SaveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(ofstream, clientList);
                ofstream.Close();
            }
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void fileNewClientMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(clientList);
            clientForm.Show();
        }

        private void fileNewAccountMenuItem_Click(object sender, EventArgs e)
        {
            if (clientList.Count() > 0)
            {
                AccountForm accountForm = new AccountForm(clientList);
                accountForm.Show();
            }
            else
            {
                MessageBox.Show("No clients found!\n\nPlease add a client or load a saved\nfile before adding an account.", "No clients found.", MessageBoxButtons.OK);
            }
        }

        private void editClientMenuItem_Click(object sender, EventArgs e)
        {
            EditClientForm editClientForm = new EditClientForm(clientList);
            editClientForm.Show();
        }

        private void accountEditMenuItem_Click(object sender, EventArgs e)
        {
            EditAccountForm editAccountForm = new EditAccountForm(clientList);
            editAccountForm.Show();
        }

        private void viewClientsMenuItem_Click(object sender, EventArgs e)
        {
            //ListClientsForm listClientsForm = new ListClientsForm(clientList);
            //listClientsForm.Show();
        }

        private void viewAccountsMenuItem_Click(object sender, EventArgs e)
        {
            //EditAccountForm listAccountsForm = new EditAccountForm(clientList);
            //listAccountsForm.Show();
        }
    }
}