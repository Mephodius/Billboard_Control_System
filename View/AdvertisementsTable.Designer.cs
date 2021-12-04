﻿
namespace View
{
    partial class AdvertisementsTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoID,
            this.videoName,
            this.queue,
            this.size,
            this.adStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 1;
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
            // AdvertisementsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdvertisementsTable";
            this.Text = "advertisementsTable";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdvertisementsTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn queue;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn adStatus;
    }
}