namespace Blockchain_wpf_client.Views
{
    partial class main
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
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walletPanel = new System.Windows.Forms.Panel();
            this.walletButton = new System.Windows.Forms.Button();
            this.walletDataGridView = new System.Windows.Forms.DataGridView();
            this.walletLabel = new System.Windows.Forms.Label();
            this.transactionPanel = new System.Windows.Forms.Panel();
            this.transactionButton = new System.Windows.Forms.Button();
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.populateProfile = new System.Windows.Forms.Button();
            this.profileDataGridView = new System.Windows.Forms.DataGridView();
            this.profileLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.walletPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletDataGridView)).BeginInit();
            this.transactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walletsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.profileToolStripMenuItem,
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
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.profileToolStripMenuItem.Text = "Profiles";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logoutToolStripMenuItem.Text = "Log Out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // walletPanel
            // 
            this.walletPanel.Controls.Add(this.walletButton);
            this.walletPanel.Controls.Add(this.walletDataGridView);
            this.walletPanel.Controls.Add(this.walletLabel);
            this.walletPanel.Location = new System.Drawing.Point(0, 27);
            this.walletPanel.Name = "walletPanel";
            this.walletPanel.Size = new System.Drawing.Size(464, 444);
            this.walletPanel.TabIndex = 1;
            // 
            // walletButton
            // 
            this.walletButton.Location = new System.Drawing.Point(21, 68);
            this.walletButton.Name = "walletButton";
            this.walletButton.Size = new System.Drawing.Size(83, 23);
            this.walletButton.TabIndex = 2;
            this.walletButton.Text = "Update";
            this.walletButton.UseVisualStyleBackColor = true;
            this.walletButton.Click += new System.EventHandler(this.WalletButton_ClickAsync);
            // 
            // walletDataGridView
            // 
            this.walletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.walletDataGridView.Location = new System.Drawing.Point(21, 121);
            this.walletDataGridView.Name = "walletDataGridView";
            this.walletDataGridView.Size = new System.Drawing.Size(431, 296);
            this.walletDataGridView.TabIndex = 1;
            this.walletDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WalletDataGridView_CellContentClick);
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.walletLabel.Location = new System.Drawing.Point(12, 17);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(111, 31);
            this.walletLabel.TabIndex = 0;
            this.walletLabel.Text = "Wallets:";
            this.walletLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // transactionPanel
            // 
            this.transactionPanel.Controls.Add(this.transactionButton);
            this.transactionPanel.Controls.Add(this.transactionsDataGridView);
            this.transactionPanel.Controls.Add(this.transactionLabel);
            this.transactionPanel.Location = new System.Drawing.Point(3, 27);
            this.transactionPanel.Name = "transactionPanel";
            this.transactionPanel.Size = new System.Drawing.Size(461, 444);
            this.transactionPanel.TabIndex = 2;
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(18, 68);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(83, 23);
            this.transactionButton.TabIndex = 2;
            this.transactionButton.Text = "Update";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGridView.Location = new System.Drawing.Point(18, 151);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.Size = new System.Drawing.Size(431, 266);
            this.transactionsDataGridView.TabIndex = 1;
            this.transactionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionsDataGridView_CellContentClick);
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.transactionLabel.Location = new System.Drawing.Point(12, 17);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(179, 31);
            this.transactionLabel.TabIndex = 0;
            this.transactionLabel.Text = "Transactions:";
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.populateProfile);
            this.profilePanel.Controls.Add(this.profileDataGridView);
            this.profilePanel.Controls.Add(this.profileLabel);
            this.profilePanel.Location = new System.Drawing.Point(0, 27);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(464, 444);
            this.profilePanel.TabIndex = 3;
            // 
            // populateProfile
            // 
            this.populateProfile.Location = new System.Drawing.Point(18, 68);
            this.populateProfile.Name = "populateProfile";
            this.populateProfile.Size = new System.Drawing.Size(86, 23);
            this.populateProfile.TabIndex = 2;
            this.populateProfile.Text = "Update";
            this.populateProfile.UseVisualStyleBackColor = true;
            this.populateProfile.Click += new System.EventHandler(this.populateButton_Click);
            // 
            // profileDataGridView
            // 
            this.profileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileDataGridView.Location = new System.Drawing.Point(21, 151);
            this.profileDataGridView.Name = "profileDataGridView";
            this.profileDataGridView.Size = new System.Drawing.Size(431, 266);
            this.profileDataGridView.TabIndex = 1;
            this.profileDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profileLabel.Location = new System.Drawing.Point(15, 17);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(113, 31);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Profiles:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 468);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.walletPanel);
            this.Controls.Add(this.transactionPanel);
            this.Controls.Add(this.profilePanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.walletPanel.ResumeLayout(false);
            this.walletPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletDataGridView)).EndInit();
            this.transactionPanel.ResumeLayout(false);
            this.transactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem walletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel walletPanel;
        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.DataGridView walletDataGridView;
        private System.Windows.Forms.Panel transactionPanel;
        private System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.DataGridView profileDataGridView;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Button populateProfile;
        private System.Windows.Forms.Button walletButton;
        private System.Windows.Forms.Button transactionButton;
    }
}