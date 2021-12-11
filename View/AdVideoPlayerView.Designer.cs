
namespace View
{
    partial class AdVideoPlayerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdVideoPlayerView));
            this.adWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.adNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.adWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // adWindowsMediaPlayer
            // 
            this.adWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adWindowsMediaPlayer.Enabled = true;
            this.adWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.adWindowsMediaPlayer.Name = "adWindowsMediaPlayer";
            this.adWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("adWindowsMediaPlayer.OcxState")));
            this.adWindowsMediaPlayer.Size = new System.Drawing.Size(282, 253);
            this.adWindowsMediaPlayer.TabIndex = 0;
            this.adWindowsMediaPlayer.Enter += new System.EventHandler(this.adWindowsMediaPlayer_Enter);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox.Location = new System.Drawing.Point(87, 230);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeTextBox.TabIndex = 1;
            // 
            // adNameTextBox
            // 
            this.adNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adNameTextBox.Location = new System.Drawing.Point(87, 0);
            this.adNameTextBox.Name = "adNameTextBox";
            this.adNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.adNameTextBox.TabIndex = 2;
            // 
            // adVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.adNameTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.adWindowsMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adVideoPlayer";
            this.Text = "adVideoPlayer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adVideoPlayer_FormClosing);
            this.Load += new System.EventHandler(this.adVideoPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer adWindowsMediaPlayer;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox adNameTextBox;
    }
}