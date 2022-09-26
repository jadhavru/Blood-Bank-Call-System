namespace BB
{
    partial class Bag_Issue_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bag_Issue_Table));
            this.panelbagissuetable = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBagIssueDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewBagIssueTable = new System.Windows.Forms.DataGridView();
            this.panelbagissuetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagIssueDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagIssueTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbagissuetable
            // 
            this.panelbagissuetable.Controls.Add(this.label1);
            this.panelbagissuetable.Controls.Add(this.dataGridViewBagIssueDetails);
            this.panelbagissuetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbagissuetable.Location = new System.Drawing.Point(0, 0);
            this.panelbagissuetable.Name = "panelbagissuetable";
            this.panelbagissuetable.Size = new System.Drawing.Size(1190, 163);
            this.panelbagissuetable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(490, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bag Issue Details";
            // 
            // dataGridViewBagIssueDetails
            // 
            this.dataGridViewBagIssueDetails.AllowUserToAddRows = false;
            this.dataGridViewBagIssueDetails.AllowUserToDeleteRows = false;
            this.dataGridViewBagIssueDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBagIssueDetails.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewBagIssueDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBagIssueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBagIssueDetails.Location = new System.Drawing.Point(629, 7);
            this.dataGridViewBagIssueDetails.Name = "dataGridViewBagIssueDetails";
            this.dataGridViewBagIssueDetails.ReadOnly = true;
            this.dataGridViewBagIssueDetails.RowHeadersVisible = false;
            this.dataGridViewBagIssueDetails.Size = new System.Drawing.Size(558, 150);
            this.dataGridViewBagIssueDetails.TabIndex = 0;
            // 
            // dataGridViewBagIssueTable
            // 
            this.dataGridViewBagIssueTable.AllowUserToAddRows = false;
            this.dataGridViewBagIssueTable.AllowUserToDeleteRows = false;
            this.dataGridViewBagIssueTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewBagIssueTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBagIssueTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBagIssueTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBagIssueTable.Location = new System.Drawing.Point(0, 163);
            this.dataGridViewBagIssueTable.Name = "dataGridViewBagIssueTable";
            this.dataGridViewBagIssueTable.ReadOnly = true;
            this.dataGridViewBagIssueTable.Size = new System.Drawing.Size(1190, 440);
            this.dataGridViewBagIssueTable.TabIndex = 1;
            this.dataGridViewBagIssueTable.DoubleClick += new System.EventHandler(this.dataGridViewBagIssueTable_DoubleClick);
            this.dataGridViewBagIssueTable.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewBagIssueTable_RowPrePaint);
            this.dataGridViewBagIssueTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBagIssueTable_CellClick);
            // 
            // Bag_Issue_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1190, 603);
            this.Controls.Add(this.dataGridViewBagIssueTable);
            this.Controls.Add(this.panelbagissuetable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bag_Issue_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bag_Issue_Table";
            this.Load += new System.EventHandler(this.Bag_Issue_Table_Load);
            this.panelbagissuetable.ResumeLayout(false);
            this.panelbagissuetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagIssueDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagIssueTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbagissuetable;
        private System.Windows.Forms.DataGridView dataGridViewBagIssueTable;
        private System.Windows.Forms.DataGridView dataGridViewBagIssueDetails;
        private System.Windows.Forms.Label label1;
    }
}