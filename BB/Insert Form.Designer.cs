namespace BB
{
    partial class Insert_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCallStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCalltypeFor = new System.Windows.Forms.TextBox();
            this.textBoxHb = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxTransfu = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxDiagno = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxP_MobileNo = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBoxPatientName = new System.Windows.Forms.ComboBox();
            this.textBoxP_City = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxP_Address = new System.Windows.Forms.RichTextBox();
            this.textBoxP_Age = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxP_Sex = new System.Windows.Forms.ComboBox();
            this.textBoxP_BlGroup = new System.Windows.Forms.TextBox();
            this.textBoxHospitalArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCalledByName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCalledBy = new System.Windows.Forms.ComboBox();
            this.textBoxWardNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCalltypeFor = new System.Windows.Forms.ComboBox();
            this.textBoxMobileNo = new System.Windows.Forms.TextBox();
            this.textBoxHospitalName = new System.Windows.Forms.TextBox();
            this.textBoxReceivedBy = new System.Windows.Forms.TextBox();
            this.textBoxCallDate = new System.Windows.Forms.TextBox();
            this.textBoxCallTime = new System.Windows.Forms.TextBox();
            this.textBox1CallNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCompoRemove = new System.Windows.Forms.Button();
            this.dataGridViewComponents = new System.Windows.Forms.DataGridView();
            this.ColumnSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComponentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonComponentqty = new System.Windows.Forms.Button();
            this.textBoxCompoQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxComponentName = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(14, 8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonCompoRemove);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewComponents);
            this.splitContainer1.Panel2.Controls.Add(this.buttonComponentqty);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCompoQty);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label26);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxComponentName);
            this.splitContainer1.Size = new System.Drawing.Size(1155, 555);
            this.splitContainer1.SplitterDistance = 630;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.comboBoxCallStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCalltypeFor);
            this.groupBox1.Controls.Add(this.textBoxHb);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.textBoxTransfu);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.textBoxDiagno);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.groupBoxPatient);
            this.groupBox1.Controls.Add(this.textBoxHospitalArea);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCalledByName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxCalledBy);
            this.groupBox1.Controls.Add(this.textBoxWardNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCalltypeFor);
            this.groupBox1.Controls.Add(this.textBoxMobileNo);
            this.groupBox1.Controls.Add(this.textBoxHospitalName);
            this.groupBox1.Controls.Add(this.textBoxReceivedBy);
            this.groupBox1.Controls.Add(this.textBoxCallDate);
            this.groupBox1.Controls.Add(this.textBoxCallTime);
            this.groupBox1.Controls.Add(this.textBox1CallNo);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Call Details";
            // 
            // comboBoxCallStatus
            // 
            this.comboBoxCallStatus.FormattingEnabled = true;
            this.comboBoxCallStatus.Items.AddRange(new object[] {
            "OPN",
            "CLS",
            "INP"});
            this.comboBoxCallStatus.Location = new System.Drawing.Point(152, 30);
            this.comboBoxCallStatus.Name = "comboBoxCallStatus";
            this.comboBoxCallStatus.Size = new System.Drawing.Size(57, 23);
            this.comboBoxCallStatus.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "CALL STATUS";
            // 
            // textBoxCalltypeFor
            // 
            this.textBoxCalltypeFor.Location = new System.Drawing.Point(469, 510);
            this.textBoxCalltypeFor.Name = "textBoxCalltypeFor";
            this.textBoxCalltypeFor.Size = new System.Drawing.Size(155, 23);
            this.textBoxCalltypeFor.TabIndex = 33;
            // 
            // textBoxHb
            // 
            this.textBoxHb.Location = new System.Drawing.Point(469, 435);
            this.textBoxHb.Name = "textBoxHb";
            this.textBoxHb.Size = new System.Drawing.Size(155, 23);
            this.textBoxHb.TabIndex = 10;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(342, 439);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 15);
            this.label30.TabIndex = 32;
            this.label30.Text = "HB(IN GMS/DL.)";
            // 
            // textBoxTransfu
            // 
            this.textBoxTransfu.Location = new System.Drawing.Point(149, 435);
            this.textBoxTransfu.Name = "textBoxTransfu";
            this.textBoxTransfu.Size = new System.Drawing.Size(184, 23);
            this.textBoxTransfu.TabIndex = 9;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 439);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(94, 15);
            this.label29.TabIndex = 30;
            this.label29.Text = "TRANSFUSION";
            // 
            // textBoxDiagno
            // 
            this.textBoxDiagno.Location = new System.Drawing.Point(149, 402);
            this.textBoxDiagno.Name = "textBoxDiagno";
            this.textBoxDiagno.Size = new System.Drawing.Size(475, 23);
            this.textBoxDiagno.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 402);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 15);
            this.label28.TabIndex = 28;
            this.label28.Text = "DIAGNOSIS";
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxP_MobileNo);
            this.groupBoxPatient.Controls.Add(this.label27);
            this.groupBoxPatient.Controls.Add(this.comboBoxPatientName);
            this.groupBoxPatient.Controls.Add(this.textBoxP_City);
            this.groupBoxPatient.Controls.Add(this.label16);
            this.groupBoxPatient.Controls.Add(this.label24);
            this.groupBoxPatient.Controls.Add(this.label8);
            this.groupBoxPatient.Controls.Add(this.richTextBoxP_Address);
            this.groupBoxPatient.Controls.Add(this.textBoxP_Age);
            this.groupBoxPatient.Controls.Add(this.label21);
            this.groupBoxPatient.Controls.Add(this.label9);
            this.groupBoxPatient.Controls.Add(this.label10);
            this.groupBoxPatient.Controls.Add(this.comboBoxP_Sex);
            this.groupBoxPatient.Controls.Add(this.textBoxP_BlGroup);
            this.groupBoxPatient.ForeColor = System.Drawing.Color.Black;
            this.groupBoxPatient.Location = new System.Drawing.Point(0, 144);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(606, 200);
            this.groupBoxPatient.TabIndex = 25;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient Details";
            // 
            // textBoxP_MobileNo
            // 
            this.textBoxP_MobileNo.Location = new System.Drawing.Point(497, 27);
            this.textBoxP_MobileNo.Name = "textBoxP_MobileNo";
            this.textBoxP_MobileNo.Size = new System.Drawing.Size(103, 23);
            this.textBoxP_MobileNo.TabIndex = 1;
            this.textBoxP_MobileNo.TextChanged += new System.EventHandler(this.textBoxP_MobileNo_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(415, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 15);
            this.label27.TabIndex = 28;
            this.label27.Text = "MOBILE NO";
            // 
            // comboBoxPatientName
            // 
            this.comboBoxPatientName.FormattingEnabled = true;
            this.comboBoxPatientName.Location = new System.Drawing.Point(152, 30);
            this.comboBoxPatientName.Name = "comboBoxPatientName";
            this.comboBoxPatientName.Size = new System.Drawing.Size(251, 23);
            this.comboBoxPatientName.TabIndex = 0;
            this.comboBoxPatientName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatientName_SelectedIndexChanged);
            this.comboBoxPatientName.Leave += new System.EventHandler(this.comboBoxPatientName_Leave);
            // 
            // textBoxP_City
            // 
            this.textBoxP_City.Location = new System.Drawing.Point(497, 109);
            this.textBoxP_City.Name = "textBoxP_City";
            this.textBoxP_City.Size = new System.Drawing.Size(103, 23);
            this.textBoxP_City.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "PATIENT NAME";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(415, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 15);
            this.label24.TabIndex = 23;
            this.label24.Text = "CITY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "AGE";
            // 
            // richTextBoxP_Address
            // 
            this.richTextBoxP_Address.Location = new System.Drawing.Point(149, 109);
            this.richTextBoxP_Address.Name = "richTextBoxP_Address";
            this.richTextBoxP_Address.Size = new System.Drawing.Size(254, 85);
            this.richTextBoxP_Address.TabIndex = 5;
            this.richTextBoxP_Address.Text = "";
            // 
            // textBoxP_Age
            // 
            this.textBoxP_Age.Location = new System.Drawing.Point(349, 71);
            this.textBoxP_Age.Name = "textBoxP_Age";
            this.textBoxP_Age.Size = new System.Drawing.Size(54, 23);
            this.textBoxP_Age.TabIndex = 3;
            this.textBoxP_Age.TextChanged += new System.EventHandler(this.textBoxP_Age_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 15);
            this.label21.TabIndex = 21;
            this.label21.Text = "ADDRESS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "SEX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "BL.GROUP";
            // 
            // comboBoxP_Sex
            // 
            this.comboBoxP_Sex.FormattingEnabled = true;
            this.comboBoxP_Sex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.comboBoxP_Sex.Location = new System.Drawing.Point(497, 66);
            this.comboBoxP_Sex.Name = "comboBoxP_Sex";
            this.comboBoxP_Sex.Size = new System.Drawing.Size(76, 23);
            this.comboBoxP_Sex.TabIndex = 4;
            // 
            // textBoxP_BlGroup
            // 
            this.textBoxP_BlGroup.Location = new System.Drawing.Point(152, 71);
            this.textBoxP_BlGroup.Name = "textBoxP_BlGroup";
            this.textBoxP_BlGroup.Size = new System.Drawing.Size(58, 23);
            this.textBoxP_BlGroup.TabIndex = 2;
            // 
            // textBoxHospitalArea
            // 
            this.textBoxHospitalArea.Location = new System.Drawing.Point(503, 116);
            this.textBoxHospitalArea.Name = "textBoxHospitalArea";
            this.textBoxHospitalArea.Size = new System.Drawing.Size(103, 23);
            this.textBoxHospitalArea.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "AREA";
            // 
            // textBoxCalledByName
            // 
            this.textBoxCalledByName.Location = new System.Drawing.Point(469, 468);
            this.textBoxCalledByName.Name = "textBoxCalledByName";
            this.textBoxCalledByName.Size = new System.Drawing.Size(155, 23);
            this.textBoxCalledByName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "NAME";
            // 
            // comboBoxCalledBy
            // 
            this.comboBoxCalledBy.FormattingEnabled = true;
            this.comboBoxCalledBy.Items.AddRange(new object[] {
            "DOCTER",
            "R.M.O",
            "STAFF"});
            this.comboBoxCalledBy.Location = new System.Drawing.Point(149, 468);
            this.comboBoxCalledBy.Name = "comboBoxCalledBy";
            this.comboBoxCalledBy.Size = new System.Drawing.Size(181, 23);
            this.comboBoxCalledBy.TabIndex = 11;
            // 
            // textBoxWardNo
            // 
            this.textBoxWardNo.Location = new System.Drawing.Point(149, 357);
            this.textBoxWardNo.Name = "textBoxWardNo";
            this.textBoxWardNo.Size = new System.Drawing.Size(155, 23);
            this.textBoxWardNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "WARD NO";
            // 
            // comboBoxCalltypeFor
            // 
            this.comboBoxCalltypeFor.FormattingEnabled = true;
            this.comboBoxCalltypeFor.Items.AddRange(new object[] {
            "NEW SAMPLE",
            "ISSUE"});
            this.comboBoxCalltypeFor.Location = new System.Drawing.Point(386, 471);
            this.comboBoxCalltypeFor.Name = "comboBoxCalltypeFor";
            this.comboBoxCalltypeFor.Size = new System.Drawing.Size(10, 23);
            this.comboBoxCalltypeFor.TabIndex = 14;
            this.comboBoxCalltypeFor.Visible = false;
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.Location = new System.Drawing.Point(149, 513);
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.Size = new System.Drawing.Size(181, 23);
            this.textBoxMobileNo.TabIndex = 13;
            this.textBoxMobileNo.TextChanged += new System.EventHandler(this.textBoxMobileNo_TextChanged);
            // 
            // textBoxHospitalName
            // 
            this.textBoxHospitalName.Location = new System.Drawing.Point(152, 116);
            this.textBoxHospitalName.Name = "textBoxHospitalName";
            this.textBoxHospitalName.Size = new System.Drawing.Size(273, 23);
            this.textBoxHospitalName.TabIndex = 4;
            // 
            // textBoxReceivedBy
            // 
            this.textBoxReceivedBy.Location = new System.Drawing.Point(152, 75);
            this.textBoxReceivedBy.Name = "textBoxReceivedBy";
            this.textBoxReceivedBy.Size = new System.Drawing.Size(181, 23);
            this.textBoxReceivedBy.TabIndex = 3;
            // 
            // textBoxCallDate
            // 
            this.textBoxCallDate.Location = new System.Drawing.Point(509, 29);
            this.textBoxCallDate.Name = "textBoxCallDate";
            this.textBoxCallDate.Size = new System.Drawing.Size(97, 23);
            this.textBoxCallDate.TabIndex = 2;
            // 
            // textBoxCallTime
            // 
            this.textBoxCallTime.Enabled = false;
            this.textBoxCallTime.Location = new System.Drawing.Point(373, 29);
            this.textBoxCallTime.Name = "textBoxCallTime";
            this.textBoxCallTime.Size = new System.Drawing.Size(87, 23);
            this.textBoxCallTime.TabIndex = 1;
            // 
            // textBox1CallNo
            // 
            this.textBox1CallNo.Location = new System.Drawing.Point(246, 29);
            this.textBox1CallNo.Name = "textBox1CallNo";
            this.textBox1CallNo.Size = new System.Drawing.Size(44, 23);
            this.textBox1CallNo.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(351, 516);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "CALL TYPE FOR";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 513);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 15);
            this.label18.TabIndex = 7;
            this.label18.Text = "MOBILE NO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(466, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "DATE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 474);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "CALLED BY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "HOSPITAL NAME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "RECEIVED BY";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "CALL TIME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "NO";
            // 
            // buttonCompoRemove
            // 
            this.buttonCompoRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCompoRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCompoRemove.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompoRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCompoRemove.Location = new System.Drawing.Point(233, 114);
            this.buttonCompoRemove.Name = "buttonCompoRemove";
            this.buttonCompoRemove.Size = new System.Drawing.Size(72, 20);
            this.buttonCompoRemove.TabIndex = 31;
            this.buttonCompoRemove.Text = "REMOVE";
            this.buttonCompoRemove.UseVisualStyleBackColor = false;
            this.buttonCompoRemove.Click += new System.EventHandler(this.buttonCompoRemove_Click);
            // 
            // dataGridViewComponents
            // 
            this.dataGridViewComponents.AllowUserToAddRows = false;
            this.dataGridViewComponents.AllowUserToDeleteRows = false;
            this.dataGridViewComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSrNo,
            this.ColumnComponentID,
            this.ColumnComponentName,
            this.ColumnQty});
            this.dataGridViewComponents.Location = new System.Drawing.Point(155, 145);
            this.dataGridViewComponents.Name = "dataGridViewComponents";
            this.dataGridViewComponents.RowHeadersVisible = false;
            this.dataGridViewComponents.Size = new System.Drawing.Size(362, 150);
            this.dataGridViewComponents.TabIndex = 30;
            this.dataGridViewComponents.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComponents_CellEndEdit);
            // 
            // ColumnSrNo
            // 
            this.ColumnSrNo.HeaderText = "SrNo.";
            this.ColumnSrNo.Name = "ColumnSrNo";
            this.ColumnSrNo.Width = 50;
            // 
            // ColumnComponentID
            // 
            this.ColumnComponentID.HeaderText = "ID";
            this.ColumnComponentID.Name = "ColumnComponentID";
            this.ColumnComponentID.Width = 50;
            // 
            // ColumnComponentName
            // 
            this.ColumnComponentName.HeaderText = "Component Name";
            this.ColumnComponentName.Name = "ColumnComponentName";
            this.ColumnComponentName.Width = 150;
            // 
            // ColumnQty
            // 
            this.ColumnQty.HeaderText = "Qty";
            this.ColumnQty.Name = "ColumnQty";
            // 
            // buttonComponentqty
            // 
            this.buttonComponentqty.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonComponentqty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComponentqty.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComponentqty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonComponentqty.Location = new System.Drawing.Point(155, 114);
            this.buttonComponentqty.Name = "buttonComponentqty";
            this.buttonComponentqty.Size = new System.Drawing.Size(72, 20);
            this.buttonComponentqty.TabIndex = 29;
            this.buttonComponentqty.Text = "ADD";
            this.buttonComponentqty.UseVisualStyleBackColor = false;
            this.buttonComponentqty.Click += new System.EventHandler(this.buttonComponentqty_Click);
            // 
            // textBoxCompoQty
            // 
            this.textBoxCompoQty.Location = new System.Drawing.Point(155, 78);
            this.textBoxCompoQty.Name = "textBoxCompoQty";
            this.textBoxCompoQty.Size = new System.Drawing.Size(103, 22);
            this.textBoxCompoQty.TabIndex = 28;
            this.textBoxCompoQty.TextChanged += new System.EventHandler(this.textBoxCompoQty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "QUANTITY OF UNITS";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(26, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 14);
            this.label26.TabIndex = 26;
            this.label26.Text = "BL COMPONENT";
            // 
            // comboBoxComponentName
            // 
            this.comboBoxComponentName.FormattingEnabled = true;
            this.comboBoxComponentName.Location = new System.Drawing.Point(155, 36);
            this.comboBoxComponentName.Name = "comboBoxComponentName";
            this.comboBoxComponentName.Size = new System.Drawing.Size(215, 22);
            this.comboBoxComponentName.TabIndex = 6;
            this.comboBoxComponentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxComponentName_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(1051, 569);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 33);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(1051, 569);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(118, 33);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 44);
            // 
            // Insert_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 609);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insert_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Collect Or Issue Form";
            this.Load += new System.EventHandler(this.Insert_Form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxCalltypeFor;
        private System.Windows.Forms.TextBox textBoxMobileNo;
        private System.Windows.Forms.TextBox textBoxHospitalName;
        private System.Windows.Forms.TextBox textBoxReceivedBy;
        private System.Windows.Forms.TextBox textBoxCallDate;
        private System.Windows.Forms.TextBox textBoxCallTime;
        private System.Windows.Forms.TextBox textBox1CallNo;
        private System.Windows.Forms.TextBox textBoxWardNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCalledBy;
        private System.Windows.Forms.TextBox textBoxCalledByName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxP_City;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RichTextBox richTextBoxP_Address;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxP_BlGroup;
        private System.Windows.Forms.ComboBox comboBoxP_Sex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxP_Age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHospitalArea;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.ComboBox comboBoxPatientName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxComponentName;
        private System.Windows.Forms.TextBox textBoxP_MobileNo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TextBox textBoxHb;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxTransfu;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxDiagno;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonComponentqty;
        private System.Windows.Forms.TextBox textBoxCompoQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewComponents;
        private System.Windows.Forms.Button buttonCompoRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComponentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.TextBox textBoxCalltypeFor;
        private System.Windows.Forms.ComboBox comboBoxCallStatus;
        private System.Windows.Forms.Label label2;
    }
}