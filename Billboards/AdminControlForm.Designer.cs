
namespace Billboards
{
    partial class AdminControlForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.addDeleteBillboardButton = new System.Windows.Forms.Button();
            this.addDeleteUserButton = new System.Windows.Forms.Button();
            this.showLogsButton = new System.Windows.Forms.Button();
            this.showStatusBarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(89, 446);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(191, 53);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addDeleteBillboardButton
            // 
            this.addDeleteBillboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDeleteBillboardButton.Location = new System.Drawing.Point(89, 354);
            this.addDeleteBillboardButton.Name = "addDeleteBillboardButton";
            this.addDeleteBillboardButton.Size = new System.Drawing.Size(191, 53);
            this.addDeleteBillboardButton.TabIndex = 6;
            this.addDeleteBillboardButton.Text = "Add/Delete Billboard";
            this.addDeleteBillboardButton.UseVisualStyleBackColor = true;
            // 
            // addDeleteUserButton
            // 
            this.addDeleteUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDeleteUserButton.Location = new System.Drawing.Point(89, 259);
            this.addDeleteUserButton.Name = "addDeleteUserButton";
            this.addDeleteUserButton.Size = new System.Drawing.Size(191, 53);
            this.addDeleteUserButton.TabIndex = 7;
            this.addDeleteUserButton.Text = "Add/Delete User";
            this.addDeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // showLogsButton
            // 
            this.showLogsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showLogsButton.Location = new System.Drawing.Point(89, 166);
            this.showLogsButton.Name = "showLogsButton";
            this.showLogsButton.Size = new System.Drawing.Size(191, 53);
            this.showLogsButton.TabIndex = 8;
            this.showLogsButton.Text = "Show Logs";
            this.showLogsButton.UseVisualStyleBackColor = true;
            // 
            // showStatusBarButton
            // 
            this.showStatusBarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showStatusBarButton.Location = new System.Drawing.Point(89, 71);
            this.showStatusBarButton.Name = "showStatusBarButton";
            this.showStatusBarButton.Size = new System.Drawing.Size(191, 53);
            this.showStatusBarButton.TabIndex = 9;
            this.showStatusBarButton.Text = "Show Status Bar";
            this.showStatusBarButton.UseVisualStyleBackColor = true;
            // 
            // AdminControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 753);
            this.Controls.Add(this.showStatusBarButton);
            this.Controls.Add(this.showLogsButton);
            this.Controls.Add(this.addDeleteUserButton);
            this.Controls.Add(this.addDeleteBillboardButton);
            this.Controls.Add(this.exitButton);
            this.Name = "AdminControlForm";
            this.Text = "AdminControlForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminControlForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addDeleteBillboardButton;
        private System.Windows.Forms.Button addDeleteUserButton;
        private System.Windows.Forms.Button showLogsButton;
        private System.Windows.Forms.Button showStatusBarButton;
    }
}