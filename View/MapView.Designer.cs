
namespace View
{
    partial class MapView
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
            this.showOptionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showOptionsButton
            // 
            this.showOptionsButton.Location = new System.Drawing.Point(12, 12);
            this.showOptionsButton.Name = "showOptionsButton";
            this.showOptionsButton.Size = new System.Drawing.Size(110, 35);
            this.showOptionsButton.TabIndex = 0;
            this.showOptionsButton.Text = "Show Options";
            this.showOptionsButton.UseVisualStyleBackColor = true;
            this.showOptionsButton.Click += new System.EventHandler(this.showOptionsButton_Click);
            // 
            // MapBillboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.showOptionsButton);
            this.Name = "MapBillboardForm";
            this.Text = "Map Billboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserBillboard_FormClosing);
            this.Load += new System.EventHandler(this.UserBillboard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserBillboard_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapBillboardForm_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MapBillboardForm_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapBillboardForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapBillboardForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapBillboardForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showOptionsButton;
    }
}