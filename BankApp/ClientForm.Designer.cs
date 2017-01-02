namespace BankApp
{
    partial class ClientForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.boxPersnr = new System.Windows.Forms.TextBox();
            this.boxStreet = new System.Windows.Forms.TextBox();
            this.boxZip = new System.Windows.Forms.TextBox();
            this.boxCity = new System.Windows.Forms.TextBox();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.lblPersnr = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.boxMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.tableLayoutPanelAddClient = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelClient = new System.Windows.Forms.Button();
            this.tableLayoutPanelAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 5);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            // 
            // boxFirstName
            // 
            this.boxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxFirstName.Location = new System.Drawing.Point(3, 21);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(100, 20);
            this.boxFirstName.TabIndex = 0;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddClient.Location = new System.Drawing.Point(3, 218);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 9;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // boxLastName
            // 
            this.boxLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxLastName.Location = new System.Drawing.Point(109, 21);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(100, 20);
            this.boxLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(109, 5);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last name";
            // 
            // boxPersnr
            // 
            this.boxPersnr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxPersnr.Location = new System.Drawing.Point(3, 64);
            this.boxPersnr.MaxLength = 12;
            this.boxPersnr.Name = "boxPersnr";
            this.boxPersnr.Size = new System.Drawing.Size(100, 20);
            this.boxPersnr.TabIndex = 3;
            // 
            // boxStreet
            // 
            this.boxStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxStreet.Location = new System.Drawing.Point(3, 107);
            this.boxStreet.Name = "boxStreet";
            this.boxStreet.Size = new System.Drawing.Size(100, 20);
            this.boxStreet.TabIndex = 4;
            // 
            // boxZip
            // 
            this.boxZip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxZip.Location = new System.Drawing.Point(3, 150);
            this.boxZip.MaxLength = 5;
            this.boxZip.Name = "boxZip";
            this.boxZip.Size = new System.Drawing.Size(58, 20);
            this.boxZip.TabIndex = 5;
            // 
            // boxCity
            // 
            this.boxCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxCity.Location = new System.Drawing.Point(109, 150);
            this.boxCity.Name = "boxCity";
            this.boxCity.Size = new System.Drawing.Size(100, 20);
            this.boxCity.TabIndex = 6;
            // 
            // boxPhone
            // 
            this.boxPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxPhone.Location = new System.Drawing.Point(3, 193);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(100, 20);
            this.boxPhone.TabIndex = 7;
            // 
            // lblPersnr
            // 
            this.lblPersnr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPersnr.AutoSize = true;
            this.lblPersnr.Location = new System.Drawing.Point(3, 48);
            this.lblPersnr.Name = "lblPersnr";
            this.lblPersnr.Size = new System.Drawing.Size(37, 13);
            this.lblPersnr.TabIndex = 11;
            this.lblPersnr.Text = "Persnr";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(3, 91);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 12;
            this.lblStreet.Text = "Street";
            // 
            // lblZip
            // 
            this.lblZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(3, 134);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(49, 13);
            this.lblZip.TabIndex = 13;
            this.lblZip.Text = "Zip code";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(109, 134);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 13);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone #";
            // 
            // boxMobile
            // 
            this.boxMobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxMobile.Location = new System.Drawing.Point(109, 193);
            this.boxMobile.MaxLength = 10;
            this.boxMobile.Name = "boxMobile";
            this.boxMobile.Size = new System.Drawing.Size(100, 20);
            this.boxMobile.TabIndex = 8;
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(109, 177);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(48, 13);
            this.lblMobile.TabIndex = 17;
            this.lblMobile.Text = "Mobile #";
            // 
            // tableLayoutPanelAddClient
            // 
            this.tableLayoutPanelAddClient.AutoSize = true;
            this.tableLayoutPanelAddClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelAddClient.ColumnCount = 2;
            this.tableLayoutPanelAddClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddClient.Controls.Add(this.btnAddClient, 0, 10);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxMobile, 1, 9);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblMobile, 1, 8);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblLastName, 1, 0);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxFirstName, 0, 1);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxPhone, 0, 9);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblPhone, 0, 8);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxLastName, 1, 1);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblCity, 1, 6);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxCity, 1, 7);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblPersnr, 0, 2);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxZip, 0, 7);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblZip, 0, 6);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxPersnr, 0, 3);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblStreet, 0, 4);
            this.tableLayoutPanelAddClient.Controls.Add(this.boxStreet, 0, 5);
            this.tableLayoutPanelAddClient.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanelAddClient.Controls.Add(this.btnCancelClient, 1, 10);
            this.tableLayoutPanelAddClient.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelAddClient.Name = "tableLayoutPanelAddClient";
            this.tableLayoutPanelAddClient.RowCount = 11;
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelAddClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAddClient.Size = new System.Drawing.Size(212, 245);
            this.tableLayoutPanelAddClient.TabIndex = 18;
            // 
            // btnCancelClient
            // 
            this.btnCancelClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelClient.Location = new System.Drawing.Point(109, 218);
            this.btnCancelClient.Name = "btnCancelClient";
            this.btnCancelClient.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClient.TabIndex = 18;
            this.btnCancelClient.Text = "Exit";
            this.btnCancelClient.UseVisualStyleBackColor = true;
            this.btnCancelClient.Click += new System.EventHandler(this.btnCancelClient_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelClient;
            this.ClientSize = new System.Drawing.Size(350, 394);
            this.Controls.Add(this.tableLayoutPanelAddClient);
            this.Name = "ClientForm";
            this.Text = "Add Client";
            this.tableLayoutPanelAddClient.ResumeLayout(false);
            this.tableLayoutPanelAddClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox boxFirstName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox boxPersnr;
        private System.Windows.Forms.TextBox boxStreet;
        private System.Windows.Forms.TextBox boxZip;
        private System.Windows.Forms.TextBox boxCity;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label lblPersnr;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox boxMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddClient;
        private System.Windows.Forms.Button btnCancelClient;
    }
}