namespace Blockchain_wpf_client
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.publicBox = new System.Windows.Forms.TextBox();
            this.privateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.checkFunds = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fundBox = new System.Windows.Forms.TextBox();
            this.fundsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate wallet:";
            // 
            // publicBox
            // 
            this.publicBox.Location = new System.Drawing.Point(97, 62);
            this.publicBox.Name = "publicBox";
            this.publicBox.Size = new System.Drawing.Size(760, 20);
            this.publicBox.TabIndex = 1;
            // 
            // privateBox
            // 
            this.privateBox.Location = new System.Drawing.Point(97, 99);
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(760, 20);
            this.privateBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Public key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Private key:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(25, 148);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // checkFunds
            // 
            this.checkFunds.Location = new System.Drawing.Point(872, 334);
            this.checkFunds.Name = "checkFunds";
            this.checkFunds.Size = new System.Drawing.Size(75, 23);
            this.checkFunds.TabIndex = 6;
            this.checkFunds.Text = "Check funds";
            this.checkFunds.UseVisualStyleBackColor = true;
            this.checkFunds.Click += new System.EventHandler(this.checkFunds_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Public key:";
            // 
            // fundBox
            // 
            this.fundBox.Location = new System.Drawing.Point(97, 334);
            this.fundBox.Name = "fundBox";
            this.fundBox.Size = new System.Drawing.Size(760, 20);
            this.fundBox.TabIndex = 8;
            // 
            // fundsLabel
            // 
            this.fundsLabel.AutoSize = true;
            this.fundsLabel.Location = new System.Drawing.Point(33, 373);
            this.fundsLabel.Name = "fundsLabel";
            this.fundsLabel.Size = new System.Drawing.Size(48, 13);
            this.fundsLabel.TabIndex = 9;
            this.fundsLabel.Text = "Funds: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 413);
            this.Controls.Add(this.fundsLabel);
            this.Controls.Add(this.fundBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkFunds);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.privateBox);
            this.Controls.Add(this.publicBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publicBox;
        private System.Windows.Forms.TextBox privateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button checkFunds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fundBox;
        private System.Windows.Forms.Label fundsLabel;
    }
}

