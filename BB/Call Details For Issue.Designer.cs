namespace BB
{
    partial class Call_Details_For_Issue
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
            this.dataGridViewCallDetailsForIssue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCallDetailsForIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCallDetailsForIssue
            // 
            this.dataGridViewCallDetailsForIssue.AllowUserToAddRows = false;
            this.dataGridViewCallDetailsForIssue.AllowUserToDeleteRows = false;
            this.dataGridViewCallDetailsForIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCallDetailsForIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCallDetailsForIssue.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCallDetailsForIssue.Name = "dataGridViewCallDetailsForIssue";
            this.dataGridViewCallDetailsForIssue.ReadOnly = true;
            this.dataGridViewCallDetailsForIssue.RowHeadersVisible = false;
            this.dataGridViewCallDetailsForIssue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCallDetailsForIssue.Size = new System.Drawing.Size(1215, 375);
            this.dataGridViewCallDetailsForIssue.TabIndex = 0;
            this.dataGridViewCallDetailsForIssue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCallDetailsForIssue_CellDoubleClick);
            // 
            // Call_Details_For_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 375);
            this.Controls.Add(this.dataGridViewCallDetailsForIssue);
            this.Name = "Call_Details_For_Issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call_Details_For_Issue";
            this.Load += new System.EventHandler(this.Call_Details_For_Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCallDetailsForIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCallDetailsForIssue;
    }
}