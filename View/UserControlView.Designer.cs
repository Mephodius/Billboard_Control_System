
namespace View
{
    partial class UserControlView
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
            this.addAdButton = new System.Windows.Forms.Button();
            this.uniteButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.createScheduleButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAdButton
            // 
            this.addAdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAdButton.Location = new System.Drawing.Point(90, 43);
            this.addAdButton.Name = "addAdButton";
            this.addAdButton.Size = new System.Drawing.Size(191, 53);
            this.addAdButton.TabIndex = 0;
            this.addAdButton.Text = "Add Advertisement";
            this.addAdButton.UseVisualStyleBackColor = true;
            this.addAdButton.Click += new System.EventHandler(this.AddAdButton_Click);
            // 
            // uniteButton
            // 
            this.uniteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uniteButton.Location = new System.Drawing.Point(90, 139);
            this.uniteButton.Name = "uniteButton";
            this.uniteButton.Size = new System.Drawing.Size(191, 53);
            this.uniteButton.TabIndex = 1;
            this.uniteButton.Text = "Unite";
            this.uniteButton.UseVisualStyleBackColor = true;
            this.uniteButton.Click += new System.EventHandler(this.uniteButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showInfoButton.Location = new System.Drawing.Point(90, 246);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(191, 53);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show Info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // createScheduleButton
            // 
            this.createScheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createScheduleButton.Location = new System.Drawing.Point(90, 351);
            this.createScheduleButton.Name = "createScheduleButton";
            this.createScheduleButton.Size = new System.Drawing.Size(191, 53);
            this.createScheduleButton.TabIndex = 3;
            this.createScheduleButton.Text = "CreateSchedule";
            this.createScheduleButton.UseVisualStyleBackColor = true;
            this.createScheduleButton.Click += new System.EventHandler(this.createScheduleButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(90, 455);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(191, 53);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // UserControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 753);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createScheduleButton);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.uniteButton);
            this.Controls.Add(this.addAdButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserControlView";
            this.Text = "UserOptionsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserControlForm_FormClosing);
            this.Load += new System.EventHandler(this.UserControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAdButton;
        private System.Windows.Forms.Button uniteButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Button createScheduleButton;
        private System.Windows.Forms.Button exitButton;
    }
}