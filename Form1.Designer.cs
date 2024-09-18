namespace AccountsApp
{
    partial class frmAccounts
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.grpAccountForm = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.grpAccountType = new System.Windows.Forms.GroupBox();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAccountForm.SuspendLayout();
            this.grpAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(81, 67);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(109, 16);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account Number:";
            // 
            // grpAccountForm
            // 
            this.grpAccountForm.Controls.Add(this.btnSearch);
            this.grpAccountForm.Controls.Add(this.grpAccountType);
            this.grpAccountForm.Controls.Add(this.txtSearch);
            this.grpAccountForm.Controls.Add(this.txtInterest);
            this.grpAccountForm.Controls.Add(this.txtWithdraw);
            this.grpAccountForm.Controls.Add(this.txtBalance);
            this.grpAccountForm.Controls.Add(this.txtClient);
            this.grpAccountForm.Controls.Add(this.lblSearch);
            this.grpAccountForm.Controls.Add(this.txtAccount);
            this.grpAccountForm.Controls.Add(this.lblInterest);
            this.grpAccountForm.Controls.Add(this.lblWithdraw);
            this.grpAccountForm.Controls.Add(this.lblBalance);
            this.grpAccountForm.Controls.Add(this.lblClient);
            this.grpAccountForm.Controls.Add(this.lblAccount);
            this.grpAccountForm.Location = new System.Drawing.Point(12, 12);
            this.grpAccountForm.Name = "grpAccountForm";
            this.grpAccountForm.Size = new System.Drawing.Size(776, 355);
            this.grpAccountForm.TabIndex = 1;
            this.grpAccountForm.TabStop = false;
            this.grpAccountForm.Text = "Account Details";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(592, 373);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(196, 65);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(235, 64);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 22);
            this.txtAccount.TabIndex = 1;
            // 
            // grpAccountType
            // 
            this.grpAccountType.Controls.Add(this.rbtnSavings);
            this.grpAccountType.Controls.Add(this.rbtnChecking);
            this.grpAccountType.Location = new System.Drawing.Point(525, 41);
            this.grpAccountType.Name = "grpAccountType";
            this.grpAccountType.Size = new System.Drawing.Size(213, 126);
            this.grpAccountType.TabIndex = 2;
            this.grpAccountType.TabStop = false;
            this.grpAccountType.Text = "Type of Account";
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Checked = true;
            this.rbtnChecking.Location = new System.Drawing.Point(9, 38);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(84, 20);
            this.rbtnChecking.TabIndex = 0;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Location = new System.Drawing.Point(9, 78);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(77, 20);
            this.rbtnSavings.TabIndex = 0;
            this.rbtnSavings.Text = "Savings";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(107, 126);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(83, 16);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client Name:";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(235, 120);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(211, 22);
            this.txtClient.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(130, 177);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(60, 16);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(235, 174);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 1;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(61, 228);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(129, 16);
            this.lblWithdraw.TabIndex = 0;
            this.lblWithdraw.Text = "Daily Withdraw Limit:";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(235, 225);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(100, 22);
            this.txtWithdraw.TabIndex = 1;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(105, 281);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(85, 16);
            this.lblInterest.TabIndex = 0;
            this.lblInterest.Text = "Interest Rate:";
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Location = new System.Drawing.Point(235, 278);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 22);
            this.txtInterest.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(490, 215);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(155, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Account Number Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(518, 247);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(651, 203);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 66);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search for Account";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grpAccountForm);
            this.Name = "frmAccounts";
            this.Text = "Accounts";
            this.grpAccountForm.ResumeLayout(false);
            this.grpAccountForm.PerformLayout();
            this.grpAccountType.ResumeLayout(false);
            this.grpAccountType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.GroupBox grpAccountForm;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.GroupBox grpAccountType;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

