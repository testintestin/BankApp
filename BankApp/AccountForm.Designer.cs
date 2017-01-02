namespace BankApp
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxAddAccountAccountID = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lblAddAccountAccountID = new System.Windows.Forms.Label();
            this.lblAddAccountType = new System.Windows.Forms.Label();
            this.boxAddAccountBalance = new System.Windows.Forms.TextBox();
            this.lblAddAccountSaldo = new System.Windows.Forms.Label();
            this.lblAddAccountPersnr = new System.Windows.Forms.Label();
            this.cboxClientList = new System.Windows.Forms.ComboBox();
            this.cboxAccountType = new System.Windows.Forms.ComboBox();
            this.boxAddAccountCredit = new System.Windows.Forms.TextBox();
            this.lblAddAccountCredit = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanelAccount = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxAddAccountAccountID
            // 
            this.boxAddAccountAccountID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxAddAccountAccountID.Location = new System.Drawing.Point(3, 65);
            this.boxAddAccountAccountID.Name = "boxAddAccountAccountID";
            this.boxAddAccountAccountID.ReadOnly = true;
            this.boxAddAccountAccountID.Size = new System.Drawing.Size(100, 20);
            this.boxAddAccountAccountID.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddAccount.Location = new System.Drawing.Point(3, 177);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "OK";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lblAddAccountAccountID
            // 
            this.lblAddAccountAccountID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddAccountAccountID.AutoSize = true;
            this.lblAddAccountAccountID.Location = new System.Drawing.Point(3, 46);
            this.lblAddAccountAccountID.Name = "lblAddAccountAccountID";
            this.lblAddAccountAccountID.Size = new System.Drawing.Size(61, 13);
            this.lblAddAccountAccountID.TabIndex = 2;
            this.lblAddAccountAccountID.Text = "Account ID";
            // 
            // lblAddAccountType
            // 
            this.lblAddAccountType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddAccountType.AutoSize = true;
            this.lblAddAccountType.Location = new System.Drawing.Point(3, 89);
            this.lblAddAccountType.Name = "lblAddAccountType";
            this.lblAddAccountType.Size = new System.Drawing.Size(70, 13);
            this.lblAddAccountType.TabIndex = 4;
            this.lblAddAccountType.Text = "Account type";
            // 
            // boxAddAccountBalance
            // 
            this.boxAddAccountBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxAddAccountBalance.Location = new System.Drawing.Point(3, 152);
            this.boxAddAccountBalance.Name = "boxAddAccountBalance";
            this.boxAddAccountBalance.Size = new System.Drawing.Size(100, 20);
            this.boxAddAccountBalance.TabIndex = 3;
            // 
            // lblAddAccountSaldo
            // 
            this.lblAddAccountSaldo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddAccountSaldo.AutoSize = true;
            this.lblAddAccountSaldo.Location = new System.Drawing.Point(3, 133);
            this.lblAddAccountSaldo.Name = "lblAddAccountSaldo";
            this.lblAddAccountSaldo.Size = new System.Drawing.Size(46, 13);
            this.lblAddAccountSaldo.TabIndex = 6;
            this.lblAddAccountSaldo.Text = "Balance";
            // 
            // lblAddAccountPersnr
            // 
            this.lblAddAccountPersnr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddAccountPersnr.AutoSize = true;
            this.lblAddAccountPersnr.Location = new System.Drawing.Point(3, 2);
            this.lblAddAccountPersnr.Name = "lblAddAccountPersnr";
            this.lblAddAccountPersnr.Size = new System.Drawing.Size(33, 13);
            this.lblAddAccountPersnr.TabIndex = 9;
            this.lblAddAccountPersnr.Text = "Client";
            // 
            // cboxClientList
            // 
            this.cboxClientList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxClientList.FormattingEnabled = true;
            this.cboxClientList.Location = new System.Drawing.Point(3, 21);
            this.cboxClientList.Name = "cboxClientList";
            this.cboxClientList.Size = new System.Drawing.Size(121, 21);
            this.cboxClientList.TabIndex = 0;
            this.cboxClientList.SelectedIndexChanged += new System.EventHandler(this.cboxClientList_SelectedIndexChanged);
            this.cboxClientList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboxClientList_Format);
            // 
            // cboxAccountType
            // 
            this.cboxAccountType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboxAccountType.FormattingEnabled = true;
            this.cboxAccountType.Location = new System.Drawing.Point(3, 108);
            this.cboxAccountType.Name = "cboxAccountType";
            this.cboxAccountType.Size = new System.Drawing.Size(121, 21);
            this.cboxAccountType.TabIndex = 1;
            this.cboxAccountType.SelectedIndexChanged += new System.EventHandler(this.cboxAccountType_SelectedIndexChanged);
            // 
            // boxAddAccountCredit
            // 
            this.boxAddAccountCredit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxAddAccountCredit.Location = new System.Drawing.Point(130, 108);
            this.boxAddAccountCredit.Name = "boxAddAccountCredit";
            this.boxAddAccountCredit.Size = new System.Drawing.Size(100, 20);
            this.boxAddAccountCredit.TabIndex = 2;
            this.boxAddAccountCredit.Visible = false;
            // 
            // lblAddAccountCredit
            // 
            this.lblAddAccountCredit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddAccountCredit.AutoSize = true;
            this.lblAddAccountCredit.Location = new System.Drawing.Point(130, 89);
            this.lblAddAccountCredit.Name = "lblAddAccountCredit";
            this.lblAddAccountCredit.Size = new System.Drawing.Size(34, 13);
            this.lblAddAccountCredit.TabIndex = 13;
            this.lblAddAccountCredit.Text = "Credit";
            this.lblAddAccountCredit.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExit.Location = new System.Drawing.Point(130, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanelAccount
            // 
            this.tableLayoutPanelAccount.AutoSize = true;
            this.tableLayoutPanelAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelAccount.ColumnCount = 2;
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAccount.Controls.Add(this.lblAddAccountPersnr, 0, 0);
            this.tableLayoutPanelAccount.Controls.Add(this.btnExit, 1, 8);
            this.tableLayoutPanelAccount.Controls.Add(this.cboxClientList, 0, 1);
            this.tableLayoutPanelAccount.Controls.Add(this.btnAddAccount, 0, 8);
            this.tableLayoutPanelAccount.Controls.Add(this.boxAddAccountBalance, 0, 7);
            this.tableLayoutPanelAccount.Controls.Add(this.lblAddAccountSaldo, 0, 6);
            this.tableLayoutPanelAccount.Controls.Add(this.boxAddAccountCredit, 1, 5);
            this.tableLayoutPanelAccount.Controls.Add(this.lblAddAccountCredit, 1, 4);
            this.tableLayoutPanelAccount.Controls.Add(this.lblAddAccountAccountID, 0, 2);
            this.tableLayoutPanelAccount.Controls.Add(this.boxAddAccountAccountID, 0, 3);
            this.tableLayoutPanelAccount.Controls.Add(this.cboxAccountType, 0, 5);
            this.tableLayoutPanelAccount.Controls.Add(this.lblAddAccountType, 0, 4);
            this.tableLayoutPanelAccount.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelAccount.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelAccount.Name = "tableLayoutPanelAccount";
            this.tableLayoutPanelAccount.RowCount = 9;
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAccount.Size = new System.Drawing.Size(254, 204);
            this.tableLayoutPanelAccount.TabIndex = 14;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 379);
            this.Controls.Add(this.tableLayoutPanelAccount);
            this.Name = "AccountForm";
            this.Text = "Create Account";
            this.tableLayoutPanelAccount.ResumeLayout(false);
            this.tableLayoutPanelAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxAddAccountAccountID;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lblAddAccountAccountID;
        private System.Windows.Forms.Label lblAddAccountType;
        private System.Windows.Forms.TextBox boxAddAccountBalance;
        private System.Windows.Forms.Label lblAddAccountSaldo;
        private System.Windows.Forms.Label lblAddAccountPersnr;
        private System.Windows.Forms.ComboBox cboxClientList;
        private System.Windows.Forms.ComboBox cboxAccountType;
        private System.Windows.Forms.TextBox boxAddAccountCredit;
        private System.Windows.Forms.Label lblAddAccountCredit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAccount;
    }
}