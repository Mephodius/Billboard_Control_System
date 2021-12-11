
namespace View
{
    partial class DeviceSheduleView
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
            this.deviceTable = new System.Windows.Forms.DataGridView();
            this.videoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceTable
            // 
            this.deviceTable.AllowUserToAddRows = false;
            this.deviceTable.AllowUserToDeleteRows = false;
            this.deviceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deviceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoID,
            this.videoName,
            this.queue,
            this.size,
            this.adStatus});
            this.deviceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceTable.Location = new System.Drawing.Point(0, 0);
            this.deviceTable.Name = "deviceTable";
            this.deviceTable.ReadOnly = true;
            this.deviceTable.RowHeadersWidth = 51;
            this.deviceTable.RowTemplate.Height = 24;
            this.deviceTable.Size = new System.Drawing.Size(800, 450);
            this.deviceTable.TabIndex = 1;
            this.deviceTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // videoID
            // 
            this.videoID.HeaderText = "Video ID";
            this.videoID.MinimumWidth = 6;
            this.videoID.Name = "videoID";
            this.videoID.ReadOnly = true;
            // 
            // videoName
            // 
            this.videoName.HeaderText = "Video Name";
            this.videoName.MinimumWidth = 6;
            this.videoName.Name = "videoName";
            this.videoName.ReadOnly = true;
            // 
            // queue
            // 
            this.queue.HeaderText = "Queue";
            this.queue.MinimumWidth = 6;
            this.queue.Name = "queue";
            this.queue.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // adStatus
            // 
            this.adStatus.HeaderText = "Status";
            this.adStatus.MinimumWidth = 6;
            this.adStatus.Name = "adStatus";
            this.adStatus.ReadOnly = true;
            // 
            // DeviceSheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deviceTable);
            this.Name = "DeviceSheduleView";
            this.Text = "DeviceSheduleView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SheduleTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deviceTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn queue;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn adStatus;
    }
}