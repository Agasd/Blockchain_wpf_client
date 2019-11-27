namespace Blockchain_wpf_client.Views
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.walletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walletPanel = new System.Windows.Forms.Panel();
            this.buttonWalletLabel = new System.Windows.Forms.Button();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.walletNameLabel = new System.Windows.Forms.ComboBox();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.confirmPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newEmailLabel = new System.Windows.Forms.Label();
            this.currentEmailLabel = new System.Windows.Forms.Label();
            this.currentEmailTextBox = new System.Windows.Forms.TextBox();
            this.transactionPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.usernameCheckBox = new System.Windows.Forms.CheckBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.textUsernameBox = new System.Windows.Forms.TextBox();
            this.textEmailBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.transactionFundBox = new System.Windows.Forms.TextBox();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.walletPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.transactionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walletsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.editProfileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // walletsToolStripMenuItem
            // 
            this.walletsToolStripMenuItem.Name = "walletsToolStripMenuItem";
            this.walletsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.walletsToolStripMenuItem.Text = "Wallets";
            this.walletsToolStripMenuItem.Click += new System.EventHandler(this.walletsToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.EditProfileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // walletPanel
            // 
            this.walletPanel.Controls.Add(this.buttonWalletLabel);
            this.walletPanel.Controls.Add(this.textBoxLabel);
            this.walletPanel.Controls.Add(this.walletNameLabel);
            this.walletPanel.Location = new System.Drawing.Point(0, 27);
            this.walletPanel.Name = "walletPanel";
            this.walletPanel.Size = new System.Drawing.Size(462, 376);
            this.walletPanel.TabIndex = 1;
            this.walletPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonWalletLabel
            // 
            this.buttonWalletLabel.Location = new System.Drawing.Point(292, 283);
            this.buttonWalletLabel.Name = "buttonWalletLabel";
            this.buttonWalletLabel.Size = new System.Drawing.Size(109, 38);
            this.buttonWalletLabel.TabIndex = 3;
            this.buttonWalletLabel.Text = "Set Main Wallet";
            this.buttonWalletLabel.UseVisualStyleBackColor = true;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(225, 54);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(176, 20);
            this.textBoxLabel.TabIndex = 2;
            // 
            // walletNameLabel
            // 
            this.walletNameLabel.DropDownHeight = 110;
            this.walletNameLabel.FormattingEnabled = true;
            this.walletNameLabel.IntegralHeight = false;
            this.walletNameLabel.ItemHeight = 13;
            this.walletNameLabel.Location = new System.Drawing.Point(34, 54);
            this.walletNameLabel.Name = "walletNameLabel";
            this.walletNameLabel.Size = new System.Drawing.Size(111, 21);
            this.walletNameLabel.TabIndex = 1;
            this.walletNameLabel.Text = "Wallet 1";
            this.walletNameLabel.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.buttonCancel);
            this.profilePanel.Controls.Add(this.confirmButton);
            this.profilePanel.Controls.Add(this.confirmPasswordCheckBox);
            this.profilePanel.Controls.Add(this.confirmPasswordTextBox);
            this.profilePanel.Controls.Add(this.newPasswordTextBox);
            this.profilePanel.Controls.Add(this.textBox1);
            this.profilePanel.Controls.Add(this.confirmPasswordLabel);
            this.profilePanel.Controls.Add(this.newPasswordLabel);
            this.profilePanel.Controls.Add(this.newEmailLabel);
            this.profilePanel.Controls.Add(this.currentEmailLabel);
            this.profilePanel.Controls.Add(this.currentEmailTextBox);
            this.profilePanel.Location = new System.Drawing.Point(0, 27);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(464, 376);
            this.profilePanel.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(50, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(335, 283);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // confirmPasswordCheckBox
            // 
            this.confirmPasswordCheckBox.AutoSize = true;
            this.confirmPasswordCheckBox.Location = new System.Drawing.Point(237, 144);
            this.confirmPasswordCheckBox.Name = "confirmPasswordCheckBox";
            this.confirmPasswordCheckBox.Size = new System.Drawing.Size(15, 14);
            this.confirmPasswordCheckBox.TabIndex = 8;
            this.confirmPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(131, 142);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordTextBox.TabIndex = 7;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(131, 102);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPasswordTextBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(31, 145);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmPasswordLabel.TabIndex = 3;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(31, 105);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.newPasswordLabel.TabIndex = 2;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // newEmailLabel
            // 
            this.newEmailLabel.AutoSize = true;
            this.newEmailLabel.Location = new System.Drawing.Point(31, 71);
            this.newEmailLabel.Name = "newEmailLabel";
            this.newEmailLabel.Size = new System.Drawing.Size(60, 13);
            this.newEmailLabel.TabIndex = 1;
            this.newEmailLabel.Text = "New Email:";
            // 
            // currentEmailLabel
            // 
            this.currentEmailLabel.AutoSize = true;
            this.currentEmailLabel.Location = new System.Drawing.Point(31, 42);
            this.currentEmailLabel.Name = "currentEmailLabel";
            this.currentEmailLabel.Size = new System.Drawing.Size(72, 13);
            this.currentEmailLabel.TabIndex = 0;
            this.currentEmailLabel.Text = "Current Email:";
            this.currentEmailLabel.Click += new System.EventHandler(this.currentEmailLabel_Click);
            // 
            // currentEmailTextBox
            // 
            this.currentEmailTextBox.Location = new System.Drawing.Point(131, 36);
            this.currentEmailTextBox.Name = "currentEmailTextBox";
            this.currentEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentEmailTextBox.TabIndex = 4;
            // 
            // transactionPanel
            // 
            this.transactionPanel.Controls.Add(this.cancelButton);
            this.transactionPanel.Controls.Add(this.usernameCheckBox);
            this.transactionPanel.Controls.Add(this.sendButton);
            this.transactionPanel.Controls.Add(this.emailCheckBox);
            this.transactionPanel.Controls.Add(this.textUsernameBox);
            this.transactionPanel.Controls.Add(this.textEmailBox);
            this.transactionPanel.Controls.Add(this.usernameLabel);
            this.transactionPanel.Controls.Add(this.emailLabel);
            this.transactionPanel.Controls.Add(this.transactionFundBox);
            this.transactionPanel.Controls.Add(this.transactionsLabel);
            this.transactionPanel.Controls.Add(this.label2);
            this.transactionPanel.Location = new System.Drawing.Point(0, 27);
            this.transactionPanel.Name = "transactionPanel";
            this.transactionPanel.Size = new System.Drawing.Size(462, 376);
            this.transactionPanel.TabIndex = 1;
            this.transactionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TransactionPanel_Paint);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(92, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // usernameCheckBox
            // 
            this.usernameCheckBox.AutoSize = true;
            this.usernameCheckBox.Location = new System.Drawing.Point(204, 113);
            this.usernameCheckBox.Name = "usernameCheckBox";
            this.usernameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.usernameCheckBox.TabIndex = 10;
            this.usernameCheckBox.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(335, 291);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(204, 74);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(15, 14);
            this.emailCheckBox.TabIndex = 8;
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // textUsernameBox
            // 
            this.textUsernameBox.Location = new System.Drawing.Point(92, 111);
            this.textUsernameBox.Name = "textUsernameBox";
            this.textUsernameBox.Size = new System.Drawing.Size(100, 20);
            this.textUsernameBox.TabIndex = 7;
            // 
            // textEmailBox
            // 
            this.textEmailBox.Location = new System.Drawing.Point(92, 71);
            this.textEmailBox.Name = "textEmailBox";
            this.textEmailBox.Size = new System.Drawing.Size(100, 20);
            this.textEmailBox.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(31, 118);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(31, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            this.emailLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // transactionFundBox
            // 
            this.transactionFundBox.Location = new System.Drawing.Point(92, 38);
            this.transactionFundBox.Name = "transactionFundBox";
            this.transactionFundBox.Size = new System.Drawing.Size(100, 20);
            this.transactionFundBox.TabIndex = 3;
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.Location = new System.Drawing.Point(31, 38);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(40, 13);
            this.transactionsLabel.TabIndex = 2;
            this.transactionsLabel.Text = "Wallet ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 404);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.transactionPanel);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.walletPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.walletPanel.ResumeLayout(false);
            this.walletPanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.transactionPanel.ResumeLayout(false);
            this.transactionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem walletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Panel walletPanel;
        private System.Windows.Forms.Panel transactionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ComboBox walletNameLabel;
        private System.Windows.Forms.Button buttonWalletLabel;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textUsernameBox;
        private System.Windows.Forms.TextBox textEmailBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox transactionFundBox;
        private System.Windows.Forms.Label transactionsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox usernameCheckBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.CheckBox confirmPasswordCheckBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox currentEmailTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label newEmailLabel;
        private System.Windows.Forms.Label currentEmailLabel;
    }
}