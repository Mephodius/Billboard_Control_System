
namespace View
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
            this.addBillboardButton = new System.Windows.Forms.Button();
            this.showUsersButton = new System.Windows.Forms.Button();
            this.showLogsButton = new System.Windows.Forms.Button();
            this.showStatusBarButton = new System.Windows.Forms.Button();
            this.deleteBillboardButton = new System.Windows.Forms.Button();
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
            // addBillboardButton
            // 
            this.addBillboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBillboardButton.Location = new System.Drawing.Point(89, 354);
            this.addBillboardButton.Name = "addBillboardButton";
            this.addBillboardButton.Size = new System.Drawing.Size(92, 53);
            this.addBillboardButton.TabIndex = 6;
            this.addBillboardButton.Text = "Add Billboard";
            this.addBillboardButton.UseVisualStyleBackColor = true;
            this.addBillboardButton.Click += new System.EventHandler(this.addBillboardButton_Click);
            // 
            // showUsersButton
            // 
            this.showUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showUsersButton.Location = new System.Drawing.Point(89, 259);
            this.showUsersButton.Name = "showUsersButton";
            this.showUsersButton.Size = new System.Drawing.Size(191, 53);
            this.showUsersButton.TabIndex = 7;
            this.showUsersButton.Text = "Show Users";
            this.showUsersButton.UseVisualStyleBackColor = true;
            this.showUsersButton.Click += new System.EventHandler(this.showUsersButton_Click);
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
            // deleteBillboardButton
            // 
            this.deleteBillboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBillboardButton.Enabled = false;
            this.deleteBillboardButton.Location = new System.Drawing.Point(188, 354);
            this.deleteBillboardButton.Name = "deleteBillboardButton";
            this.deleteBillboardButton.Size = new System.Drawing.Size(92, 53);
            this.deleteBillboardButton.TabIndex = 11;
            this.deleteBillboardButton.Text = "Delete Billboard";
            this.deleteBillboardButton.UseVisualStyleBackColor = true;
            this.deleteBillboardButton.Click += new System.EventHandler(this.deleteBillboardButton_Click);
            // 
            // AdminControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 753);
            this.Controls.Add(this.deleteBillboardButton);
            this.Controls.Add(this.showStatusBarButton);
            this.Controls.Add(this.showLogsButton);
            this.Controls.Add(this.showUsersButton);
            this.Controls.Add(this.addBillboardButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminControlForm";
            this.Text = "AdminControlForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminControlForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addBillboardButton;
        private System.Windows.Forms.Button showUsersButton;
        private System.Windows.Forms.Button showLogsButton;
        private System.Windows.Forms.Button showStatusBarButton;
        private System.Windows.Forms.Button deleteBillboardButton;
    }
}