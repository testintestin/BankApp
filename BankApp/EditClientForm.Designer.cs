namespace BankApp
{
    partial class EditClientForm
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
            this.dataGridEditClients = new System.Windows.Forms.DataGridView();
            this.btnEditClientDeleteRow = new System.Windows.Forms.Button();
            this.btnEditClientCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEditClients
            // 
            this.dataGridEditClients.AllowUserToAddRows = false;
            this.dataGridEditClients.AllowUserToResizeColumns = false;
            this.dataGridEditClients.AllowUserToResizeRows = false;
            this.dataGridEditClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEditClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEditClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEditClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridEditClients.Location = new System.Drawing.Point(13, 13);
            this.dataGridEditClients.Name = "dataGridEditClients";
            this.dataGridEditClients.RowHeadersVisible = false;
            this.dataGridEditClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEditClients.Size = new System.Drawing.Size(592, 351);
            this.dataGridEditClients.StandardTab = true;
            this.dataGridEditClients.TabIndex = 0;
            // 
            // btnEditClientDeleteRow
            // 
            this.btnEditClientDeleteRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditClientDeleteRow.Location = new System.Drawing.Point(231, 370);
            this.btnEditClientDeleteRow.Name = "btnEditClientDeleteRow";
            this.btnEditClientDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btnEditClientDeleteRow.TabIndex = 2;
            this.btnEditClientDeleteRow.Text = "Delete";
            this.btnEditClientDeleteRow.UseVisualStyleBackColor = true;
            this.btnEditClientDeleteRow.Click += new System.EventHandler(this.btnEditClientDeleteRow_Click);
            // 
            // btnEditClientCancel
            // 
            this.btnEditClientCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditClientCancel.Location = new System.Drawing.Point(312, 370);
            this.btnEditClientCancel.Name = "btnEditClientCancel";
            this.btnEditClientCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditClientCancel.TabIndex = 3;
            this.btnEditClientCancel.Text = "Exit";
            this.btnEditClientCancel.UseVisualStyleBackColor = true;
            this.btnEditClientCancel.Click += new System.EventHandler(this.btnEditClientCancel_Click);
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 403);
            this.Controls.Add(this.btnEditClientCancel);
            this.Controls.Add(this.btnEditClientDeleteRow);
            this.Controls.Add(this.dataGridEditClients);
            this.Name = "EditClientForm";
            this.Text = "Edit Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEditClients;
        private System.Windows.Forms.Button btnEditClientDeleteRow;
        private System.Windows.Forms.Button btnEditClientCancel;
    }
}