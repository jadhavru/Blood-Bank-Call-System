namespace BB
{
    partial class FormBB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBB));
            this.dataGridViewBBCallDetails = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewComponentDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIssuebloodBag = new System.Windows.Forms.Button();
            this.buttonAddCall = new System.Windows.Forms.Button();
            this.buttonIssuebagTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewComponentsIssueDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBBCallDetails)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponentDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponentsIssueDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBBCallDetails
            // 
            this.dataGridViewBBCallDetails.AllowUserToAddRows = false;
            this.dataGridViewBBCallDetails.AllowUserToDeleteRows = false;
            this.dataGridViewBBCallDetails.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewBBCallDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBBCallDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBBCallDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBBCallDetails.Location = new System.Drawing.Point(0, 223);
            this.dataGridViewBBCallDetails.Name = "dataGridViewBBCallDetails";
            this.dataGridViewBBCallDetails.ReadOnly = true;
            this.dataGridViewBBCallDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBBCallDetails.Size = new System.Drawing.Size(1315, 372);
            this.dataGridViewBBCallDetails.TabIndex = 1;
            this.dataGridViewBBCallDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBBCallDetails_CellDoubleClick);
            this.dataGridViewBBCallDetails.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewBBCallDetails_RowPrePaint);
            this.dataGridViewBBCallDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBBCallDetails_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1311, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSignIn,
            this.ToolStripMenuItemSignOut});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(160, 22);
            this.toolStripDropDownButton1.Text = "Blood Bank Call System";
            // 
            // ToolStripMenuItemSignIn
            // 
            this.ToolStripMenuItemSignIn.Name = "ToolStripMenuItemSignIn";
            this.ToolStripMenuItemSignIn.Size = new System.Drawing.Size(128, 22);
            this.ToolStripMenuItemSignIn.Text = "SignInt";
            this.ToolStripMenuItemSignIn.Click += new System.EventHandler(this.ToolStripMenuItemSignIn_Click);
            // 
            // ToolStripMenuItemSignOut
            // 
            this.ToolStripMenuItemSignOut.Name = "ToolStripMenuItemSignOut";
            this.ToolStripMenuItemSignOut.Size = new System.Drawing.Size(128, 22);
            this.ToolStripMenuItemSignOut.Text = "Sign Out";
            this.ToolStripMenuItemSignOut.Click += new System.EventHandler(this.ToolStripMenuItemSignOut_Click);
            // 
            // dataGridViewComponentDetails
            // 
            this.dataGridViewComponentDetails.AllowUserToAddRows = false;
            this.dataGridViewComponentDetails.AllowUserToDeleteRows = false;
            this.dataGridViewComponentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComponentDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewComponentDetails.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewComponentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewComponentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponentDetails.Enabled = false;
            this.dataGridViewComponentDetails.Location = new System.Drawing.Point(259, 58);
            this.dataGridViewComponentDetails.Name = "dataGridViewComponentDetails";
            this.dataGridViewComponentDetails.ReadOnly = true;
            this.dataGridViewComponentDetails.RowHeadersVisible = false;
            this.dataGridViewComponentDetails.Size = new System.Drawing.Size(496, 125);
            this.dataGridViewComponentDetails.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(263, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Components Details";
            // 
            // buttonIssuebloodBag
            // 
            this.buttonIssuebloodBag.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonIssuebloodBag.Enabled = false;
            this.buttonIssuebloodBag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIssuebloodBag.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssuebloodBag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIssuebloodBag.Location = new System.Drawing.Point(115, 189);
            this.buttonIssuebloodBag.Name = "buttonIssuebloodBag";
            this.buttonIssuebloodBag.Size = new System.Drawing.Size(106, 24);
            this.buttonIssuebloodBag.TabIndex = 32;
            this.buttonIssuebloodBag.Text = "ISSUE BAG";
            this.buttonIssuebloodBag.UseVisualStyleBackColor = false;
            this.buttonIssuebloodBag.Click += new System.EventHandler(this.buttonIssuebloodBag_Click);
            // 
            // buttonAddCall
            // 
            this.buttonAddCall.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddCall.Enabled = false;
            this.buttonAddCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCall.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddCall.Location = new System.Drawing.Point(3, 189);
            this.buttonAddCall.Name = "buttonAddCall";
            this.buttonAddCall.Size = new System.Drawing.Size(106, 24);
            this.buttonAddCall.TabIndex = 33;
            this.buttonAddCall.Text = "ADD CALL";
            this.buttonAddCall.UseVisualStyleBackColor = false;
            this.buttonAddCall.Click += new System.EventHandler(this.buttonAddCall_Click);
            // 
            // buttonIssuebagTable
            // 
            this.buttonIssuebagTable.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonIssuebagTable.Enabled = false;
            this.buttonIssuebagTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIssuebagTable.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssuebagTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIssuebagTable.Location = new System.Drawing.Point(227, 189);
            this.buttonIssuebagTable.Name = "buttonIssuebagTable";
            this.buttonIssuebagTable.Size = new System.Drawing.Size(115, 24);
            this.buttonIssuebagTable.TabIndex = 34;
            this.buttonIssuebagTable.Text = "ISSUE BAG TABLE";
            this.buttonIssuebagTable.UseVisualStyleBackColor = false;
            this.buttonIssuebagTable.Click += new System.EventHandler(this.buttonIssuebagTable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewComponentsIssueDetails);
            this.panel1.Controls.Add(this.buttonIssuebagTable);
            this.panel1.Controls.Add(this.buttonAddCall);
            this.panel1.Controls.Add(this.buttonIssuebloodBag);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewComponentDetails);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 223);
            this.panel1.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExport.Enabled = false;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExport.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExport.Location = new System.Drawing.Point(10, 31);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(106, 24);
            this.buttonExport.TabIndex = 39;
            this.buttonExport.Text = "EXPORT";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(3, 149);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(242, 23);
            this.textBoxSearch.TabIndex = 37;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(760, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Components Issue Details";
            // 
            // dataGridViewComponentsIssueDetails
            // 
            this.dataGridViewComponentsIssueDetails.AllowUserToAddRows = false;
            this.dataGridViewComponentsIssueDetails.AllowUserToDeleteRows = false;
            this.dataGridViewComponentsIssueDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComponentsIssueDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewComponentsIssueDetails.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewComponentsIssueDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewComponentsIssueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponentsIssueDetails.Enabled = false;
            this.dataGridViewComponentsIssueDetails.Location = new System.Drawing.Point(764, 58);
            this.dataGridViewComponentsIssueDetails.Name = "dataGridViewComponentsIssueDetails";
            this.dataGridViewComponentsIssueDetails.ReadOnly = true;
            this.dataGridViewComponentsIssueDetails.RowHeadersVisible = false;
            this.dataGridViewComponentsIssueDetails.Size = new System.Drawing.Size(496, 125);
            this.dataGridViewComponentsIssueDetails.TabIndex = 35;
            // 
            // FormBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1315, 595);
            this.Controls.Add(this.dataGridViewBBCallDetails);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Call System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBBCallDetails)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponentDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponentsIssueDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBBCallDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSignIn;
        private System.Windows.Forms.DataGridView dataGridViewComponentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIssuebloodBag;
        private System.Windows.Forms.Button buttonAddCall;
        private System.Windows.Forms.Button buttonIssuebagTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewComponentsIssueDetails;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSignOut;
    }
}

