namespace BankApp
{
    partial class EditAccountForm
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
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.dgvAccountList = new System.Windows.Forms.DataGridView();
            this.boxAccountID = new System.Windows.Forms.TextBox();
            this.boxInterestRate = new System.Windows.Forms.TextBox();
            this.boxBalance = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.boxCredit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.AllowUserToResizeColumns = false;
            this.dgvClientList.AllowUserToResizeRows = false;
            this.dgvClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Location = new System.Drawing.Point(13, 13);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.ReadOnly = true;
            this.dgvClientList.RowHeadersVisible = false;
            this.dgvClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientList.Size = new System.Drawing.Size(592, 222);
            this.dgvClientList.TabIndex = 4;
            this.dgvClientList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientList_MouseClick);
            // 
            // dgvAccountList
            // 
            this.dgvAccountList.AllowUserToAddRows = false;
            this.dgvAccountList.AllowUserToResizeColumns = false;
            this.dgvAccountList.AllowUserToResizeRows = false;
            this.dgvAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccountList.Location = new System.Drawing.Point(13, 241);
            this.dgvAccountList.MultiSelect = false;
            this.dgvAccountList.Name = "dgvAccountList";
            this.dgvAccountList.RowHeadersVisible = false;
            this.dgvAccountList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountList.Size = new System.Drawing.Size(592, 120);
            this.dgvAccountList.TabIndex = 5;
            this.dgvAccountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountList_CellClick);
            // 
            // boxAccountID
            // 
            this.boxAccountID.Location = new System.Drawing.Point(13, 375);
            this.boxAccountID.Name = "boxAccountID";
            this.boxAccountID.Size = new System.Drawing.Size(154, 20);
            this.boxAccountID.TabIndex = 6;
            // 
            // boxInterestRate
            // 
            this.boxInterestRate.Location = new System.Drawing.Point(173, 375);
            this.boxInterestRate.Name = "boxInterestRate";
            this.boxInterestRate.Size = new System.Drawing.Size(130, 20);
            this.boxInterestRate.TabIndex = 7;
            // 
            // boxBalance
            // 
            this.boxBalance.Location = new System.Drawing.Point(447, 375);
            this.boxBalance.Name = "boxBalance";
            this.boxBalance.Size = new System.Drawing.Size(158, 20);
            this.boxBalance.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(530, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // boxCredit
            // 
            this.boxCredit.Location = new System.Drawing.Point(309, 375);
            this.boxCredit.Name = "boxCredit";
            this.boxCredit.Size = new System.Drawing.Size(132, 20);
            this.boxCredit.TabIndex = 12;
            // 
            // ListAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(618, 434);
            this.Controls.Add(this.boxCredit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.boxBalance);
            this.Controls.Add(this.boxInterestRate);
            this.Controls.Add(this.boxAccountID);
            this.Controls.Add(this.dgvAccountList);
            this.Controls.Add(this.dgvClientList);
            this.Name = "ListAccountsForm";
            this.Text = "List and Manage Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.TextBox boxAccountID;
        private System.Windows.Forms.TextBox boxInterestRate;
        private System.Windows.Forms.TextBox boxBalance;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox boxCredit;
        private System.Windows.Forms.DataGridView dgvAccountList;
    }
}