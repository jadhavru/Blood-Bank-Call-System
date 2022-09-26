using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB
{
    public partial class FormBB : Form
    {
        DataTable BBCallDetails = new DataTable();

        public FormBB()
        {
            InitializeComponent();

        }

        private void FormBB_Load(object sender, EventArgs e)
        {

            LoginCallSystem();





        }


        private void LoginCallSystem()
        {
            Login_Call_System login = new Login_Call_System();
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {

                toolStripDropDownButton1.Text = BB.Properties.UserLogin.Default.StaffName;

                dataGridViewComponentDetails.Enabled = true;
                dataGridViewComponentsIssueDetails.Enabled = true;
                textBoxSearch.Enabled = true;
                buttonAddCall.Enabled = true;
                buttonIssuebloodBag.Enabled = true;
                buttonIssuebagTable.Enabled = true;
                buttonExport.Enabled = true;


                BBCallDetails = SqlBB.SelectAllBBCallDetails();

                if (BBCallDetails == null)
                { dataGridViewBBCallDetails.DataSource = null; }
                else
                {
                    FillBBCallDetailsGrid(BBCallDetails);

                    dataGridViewBBCallDetails.Columns["CallDate"].Frozen = true;
                }
            }
            else
            {
                dataGridViewComponentDetails.Enabled = false;
                dataGridViewComponentsIssueDetails.Enabled = false;
                textBoxSearch.Enabled = false;
                buttonAddCall.Enabled = false;
                buttonIssuebloodBag.Enabled = false;
                buttonIssuebagTable.Enabled = false;
                buttonExport.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Insert_Form inf = new Insert_Form();
            inf.ShowDialog();

            BBCallDetails = SqlBB.SelectAllBBCallDetails();

            if (BBCallDetails == null)
            { dataGridViewBBCallDetails.DataSource = null; }
            else
            {
                FillBBCallDetailsGrid(BBCallDetails);

                dataGridViewBBCallDetails.Columns["CallDate"].Frozen = true;
            }


        }




        private void FillBBCallDetailsGrid(DataTable dt)//Fill All EQN Data
        {
            //this.Cursor = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(300);
            //this.Cursor = Cursors.Default;

            // redesign grid
            dataGridViewBBCallDetails.AutoGenerateColumns = false;
            dataGridViewBBCallDetails.Columns.Clear();

            dataGridViewBBCallDetails.EnableHeadersVisualStyles = false;

            dataGridViewBBCallDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBBCallDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBBCallDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);
            // dataGridEnqStat.DefaultCellStyle.Font = new Font("Cambria",10, FontStyle.Regular);
            dataGridViewBBCallDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            //DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            //CheckBox chk = new CheckBox();
            ////CheckboxColumn.Width = 20;
            //CheckboxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewBBCallDetails.Columns.Add(CheckboxColumn);

            ////dt.Columns.Add("Note");
            //dt.Columns.Add("FilesFolder");

            // add columns /*case "SaleCompanyComplID": case "SaleCompanyTransID": */
            foreach (DataColumn dc in dt.Columns)
            {
                switch (dc.ColumnName)
                {



                    case "CallTime":
                    case "CallDate":




                        DataGridViewColumn dc11 = new DataGridViewTextBoxColumn();
                        dc11.Name = dc.ColumnName;
                        dc11.HeaderText = dc.ColumnName;
                        dc11.DataPropertyName = dc.ColumnName;
                        dc11.DefaultCellStyle.Format = "dd-MM-yyyy";
                        dc11.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        // dc11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridViewBBCallDetails.Columns.Add(dc11);
                        break;
                    case "No":
                    case "CallStatus":
                    case "ReceivedBy":
                    case "HospitalName":
                    case "Area":
                    case "CallAddedBy":
                    case "CalledBy":
                    case "CalledByName":
                    case "MobileNo":
                    case "WardNo":
                    case "CallType":
                    case "HRR Staff Collect By Name":
                    case "HRR Staff Collect At Time":
                    case "HRR Staff Issue By Name":
                    case "HRR Staff Issue At Time":
                    case "Hospital Delivery At Time":
                    case "System Time":
                    case "Component Name":
                    case "Patient Name":
                    case "Diagnosis":
                    case "Transfusion":
                    case "Hb":
                    case "Call Closing Time":
                    case "Received From Lab Time":
                        DataGridViewColumn dc1 = new DataGridViewTextBoxColumn();
                        dc1.Name = dc.ColumnName;
                        dc1.HeaderText = dc.ColumnName;
                        dc1.DataPropertyName = dc.ColumnName;
                        dc1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                        dataGridViewBBCallDetails.Columns.Add(dc1);
                        break;






                }// switch

            }// foreach columns

            // bind datasource

            dataGridViewBBCallDetails.DataSource = dt;

            dataGridViewBBCallDetails.ClearSelection();


            // dataGridViewBBCallDetails.Columns["FilesFolder"].DisplayIndex = 17;

            //add row number in row header
            //foreach (DataGridViewRow dgr in dataGridViewBBCallDetails.Rows)
            //  dgr.Cells["Indx"].Value = (dgr.Index + 1).ToString();

            //change column back color
            string[] colGr1 = { "No", "CallTime", "CallDate", "Patient Name", "CallStatus" };
            string[] colGr2 = { "HRR Staff Issue By Name", "HRR Staff Issue At Time" };
            string[] colGr3 = { "Hospital Delivery At Time", "System Time", "Call Closing Time" };

            foreach (DataGridViewColumn dc in dataGridViewBBCallDetails.Columns)
            {
                if (colGr1.Contains(dc.HeaderText))
                    dc.HeaderCell.Style.BackColor = Color.YellowGreen;
                else if (colGr2.Contains(dc.HeaderText))
                    dc.HeaderCell.Style.BackColor = Color.LightSkyBlue;
                else if (colGr3.Contains(dc.HeaderText))
                    dc.HeaderCell.Style.BackColor = Color.LightGreen;

            }// end foreach column

            // change visibility of some columns
            //dataGridViewBBCallDetails.Columns["MOMID"].Visible = false;
            //dataGridViewInstrumentDetails.Columns["SalesEnquiryTypeID"].Visible = false;
            //dgEnqStat.Columns["City"].Visible = false;
            //dataGridViewBBCallDetails.UseWaitCursor = false;
        }// end fill grid

        private void FillComponentsDetailsGrid(DataTable dt)//Fill All EQN Data
        {
            //this.Cursor = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(300);
            //this.Cursor = Cursors.Default;

            // redesign grid
            dataGridViewComponentDetails.AutoGenerateColumns = false;
            dataGridViewComponentDetails.Columns.Clear();

            dataGridViewComponentDetails.EnableHeadersVisualStyles = false;

            dataGridViewComponentDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComponentDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewComponentDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);
            // dataGridEnqStat.DefaultCellStyle.Font = new Font("Cambria",10, FontStyle.Regular);
            dataGridViewComponentDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            //DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            //CheckBox chk = new CheckBox();
            ////CheckboxColumn.Width = 20;
            //CheckboxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewBBCallDetails.Columns.Add(CheckboxColumn);

            ////dt.Columns.Add("Note");
            //dt.Columns.Add("FilesFolder");

            // add columns /*case "SaleCompanyComplID": case "SaleCompanyTransID": */
            foreach (DataColumn dc in dt.Columns)
            {
                switch (dc.ColumnName)
                {


                    // [No] ,[] ,[Component Name],[OrderQty] ,[PendingQty]

                    case "No":
                    case "BBComponentID":
                    case "Component Name":
                    case "OrderQty":
                    case "PendingQty":


                        DataGridViewColumn dc1 = new DataGridViewTextBoxColumn();
                        dc1.Name = dc.ColumnName;
                        dc1.HeaderText = dc.ColumnName;
                        dc1.DataPropertyName = dc.ColumnName;
                        dc1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                        dataGridViewComponentDetails.Columns.Add(dc1);
                        break;






                }// switch

            }// foreach columns

            // bind datasource

            dataGridViewComponentDetails.DataSource = dt;

            dataGridViewComponentDetails.ClearSelection();


            // dataGridViewBBCallDetails.Columns["FilesFolder"].DisplayIndex = 17;

            //add row number in row header
            //foreach (DataGridViewRow dgr in dataGridViewBBCallDetails.Rows)
            //  dgr.Cells["Indx"].Value = (dgr.Index + 1).ToString();

            ////change column back color
            //string[] colGr1 = { "HRR Staff Collect By Name", "HRR Staff Collect At Time", "Received From Lab Time" };
            //string[] colGr2 = { "HRR Staff Issue By Name", "HRR Staff Issue At Time" };
            //string[] colGr3 = { "Hospital Delivery At Time", "System Time", "Call Closing Time" };

            //foreach (DataGridViewColumn dc in dataGridViewBBCallDetails.Columns)
            //{
            //    if (colGr1.Contains(dc.HeaderText))
            //        dc.HeaderCell.Style.BackColor = Color.YellowGreen;
            //    else if (colGr2.Contains(dc.HeaderText))
            //        dc.HeaderCell.Style.BackColor = Color.LightSkyBlue;
            //    else if (colGr3.Contains(dc.HeaderText))
            //        dc.HeaderCell.Style.BackColor = Color.LightGreen;

            //}// end foreach column

            // change visibility of some columns
            //dataGridViewBBCallDetails.Columns["MOMID"].Visible = false;
            //dataGridViewInstrumentDetails.Columns["SalesEnquiryTypeID"].Visible = false;
            //dgEnqStat.Columns["City"].Visible = false;
            //dataGridViewBBCallDetails.UseWaitCursor = false;
        }// end fill grid

        private void FillBagIssueDetailsGrid(DataTable dt)//Fill All EQN Data
        {
            //this.Cursor = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(300);
            //this.Cursor = Cursors.Default;

            // redesign grid
            dataGridViewComponentsIssueDetails.AutoGenerateColumns = false;
            dataGridViewComponentsIssueDetails.Columns.Clear();

            dataGridViewComponentsIssueDetails.EnableHeadersVisualStyles = false;

            dataGridViewComponentsIssueDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComponentsIssueDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewComponentsIssueDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);
            // dataGridEnqStat.DefaultCellStyle.Font = new Font("Cambria",10, FontStyle.Regular);
            dataGridViewComponentsIssueDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            //DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            //CheckBox chk = new CheckBox();
            ////CheckboxColumn.Width = 20;
            //CheckboxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridViewBBCallDetails.Columns.Add(CheckboxColumn);

            ////dt.Columns.Add("Note");
            //dt.Columns.Add("FilesFolder");

            // add columns /*case "SaleCompanyComplID": case "SaleCompanyTransID": */
            foreach (DataColumn dc in dt.Columns)
            {
                switch (dc.ColumnName)
                {


                    // [No] ,[] ,[Component Name],[OrderQty] ,[PendingQty]

                    case "No":
                    case "ComponentID":
                    case "Component Name":
                    case "ReceivedQty":
                    case "PendingQty":
                    case "BagIssueID":
                        DataGridViewColumn dc1 = new DataGridViewTextBoxColumn();
                        dc1.Name = dc.ColumnName;
                        dc1.HeaderText = dc.ColumnName;
                        dc1.DataPropertyName = dc.ColumnName;
                        dc1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                        dataGridViewComponentsIssueDetails.Columns.Add(dc1);
                        break;






                }// switch

            }// foreach columns

            // bind datasource

            dataGridViewComponentsIssueDetails.DataSource = dt;

            dataGridViewComponentsIssueDetails.ClearSelection();


            // dataGridViewBBCallDetails.Columns["FilesFolder"].DisplayIndex = 17;

            //add row number in row header
            //foreach (DataGridViewRow dgr in dataGridViewBBCallDetails.Rows)
            //  dgr.Cells["Indx"].Value = (dgr.Index + 1).ToString();

            ////change column back color
            //string[] colGr1 = { "HRR Staff Collect By Name", "HRR Staff Collect At Time", "Received From Lab Time" };
            //string[] colGr2 = { "HRR Staff Issue By Name", "HRR Staff Issue At Time" };
            //string[] colGr3 = { "Hospital Delivery At Time", "System Time", "Call Closing Time" };

            //foreach (DataGridViewColumn dc in dataGridViewBBCallDetails.Columns)
            //{
            //    if (colGr1.Contains(dc.HeaderText))
            //        dc.HeaderCell.Style.BackColor = Color.YellowGreen;
            //    else if (colGr2.Contains(dc.HeaderText))
            //        dc.HeaderCell.Style.BackColor = Color.LightSkyBlue;
            //    else if (colGr3.Contains(dc.HeaderText))
            //        dc.HeaderCell.Style.BackColor = Color.LightGreen;

            //}// end foreach column

            // change visibility of some columns
            //dataGridViewBBCallDetails.Columns["MOMID"].Visible = false;
            //dataGridViewInstrumentDetails.Columns["SalesEnquiryTypeID"].Visible = false;
            //dgEnqStat.Columns["City"].Visible = false;
            //dataGridViewBBCallDetails.UseWaitCursor = false;
        }// end fill grid



        private void dataGridViewBBCallDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewBBCallDetails.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridViewBBCallDetails.SelectedRows[0];
                    //dataGridViewBBCallDetails.SelectedRows[0].Selected = false;

                    // get selected GRR id
                    int No = int.Parse(dr.Cells["No"].Value.ToString());

                    // call GRR view
                    Insert_Form insert = new Insert_Form(No);
                    insert.ShowDialog();


                    DataTable BBCallDetails = SqlBB.SelectAllBBCallDetails();

                    if (BBCallDetails == null)
                    { dataGridViewBBCallDetails.DataSource = null; }
                    else
                    {
                        FillBBCallDetailsGrid(BBCallDetails);

                        dataGridViewBBCallDetails.Columns["CallDate"].Frozen = true;
                    }



                }//
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BB CALL View", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBB.ExportToExel(dataGridViewBBCallDetails);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }



        private void eXPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBB.ExportToExel(dataGridViewBBCallDetails);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        private void dataGridViewBBCallDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewBBCallDetails.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridViewBBCallDetails.SelectedRows[0];
                    //dataGridViewBBCallDetails.SelectedRows[0].Selected = false;

                    // get selected GRR id
                    int No = int.Parse(dr.Cells["No"].Value.ToString());


                    // Call Component Details

                    DataTable CompoDetails = SqlBB.SelectAllComponentDetailsByCallNo(No);

                    if (CompoDetails == null)
                    { dataGridViewComponentDetails.DataSource = null; }
                    else
                    {
                        FillComponentsDetailsGrid(CompoDetails);


                    }


                    // Bag Issue Component Details
                    DataTable BagIssueDetails = SqlBB.SelectAllBagIssueDetailsByCallNo(No);

                    if (BagIssueDetails == null)
                    { dataGridViewComponentsIssueDetails.DataSource = null; }
                    else
                    {
                        FillBagIssueDetailsGrid(BagIssueDetails);


                    }


                }//
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BB CALL View", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonIssuebloodBag_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBBCallDetails.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridViewBBCallDetails.SelectedRows[0];

                    // get selected GRR id
                    int No = int.Parse(dr.Cells["No"].Value.ToString());




                    Issue_Blood_From_CallNo ibfcn = new Issue_Blood_From_CallNo(No);
                    ibfcn.ShowDialog();

                }//
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BB CALL View", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddCall_Click(object sender, EventArgs e)
        {
            Insert_Form inf = new Insert_Form();
            inf.ShowDialog();

            BBCallDetails = SqlBB.SelectAllBBCallDetails();

            if (BBCallDetails == null)
            { dataGridViewBBCallDetails.DataSource = null; }
            else
            {
                FillBBCallDetailsGrid(BBCallDetails);

                dataGridViewBBCallDetails.Columns["CallDate"].Frozen = true;
            }
        }

        private void buttonIssuebagTable_Click(object sender, EventArgs e)
        {
            Bag_Issue_Table bit = new Bag_Issue_Table();
            bit.ShowDialog();
        }

        private void dataGridViewBBCallDetails_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridViewBBCallDetails["CallStatus", e.RowIndex].Value.ToString() == "INP")
            {
                dataGridViewBBCallDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;

            }
            else if (dataGridViewBBCallDetails["CallStatus", e.RowIndex].Value.ToString() == "CLS")
            {
                dataGridViewBBCallDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;

            }

            else
            {
                dataGridViewBBCallDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<DataRow> v = null;


            v = from n in BBCallDetails.AsEnumerable()
                where n.Field<string>("HospitalName").ToString().ToLower().ToUpper().StartsWith(textBoxSearch.Text.ToLower().ToUpper())
                || n.Field<string>("Patient Name").ToString().ToLower().ToUpper().StartsWith(textBoxSearch.Text.ToLower().ToUpper())

                select n;

            if (v != null && v.Count() > 0)
            {

                FillBBCallDetailsGrid(v.CopyToDataTable<DataRow>());

                dataGridViewBBCallDetails.Columns["CallDate"].Frozen = true;
            }//
            else
                MessageBox.Show("Search not found on filter keyword - " + textBoxSearch.Text);
        }

        private void buttonExport_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlBB.ExportToExel(dataGridViewBBCallDetails);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        private void ToolStripMenuItemSignIn_Click(object sender, EventArgs e)
        {
            LoginCallSystem();
        }

        private void ToolStripMenuItemSignOut_Click(object sender, EventArgs e)
        {

            toolStripDropDownButton1.Text = "Blood Bank Call System";

            BB.Properties.UserLogin.Default.StaffName = "";
            BB.Properties.UserLogin.Default.UserName = "";
            BB.Properties.UserLogin.Default.Password = "";

            dataGridViewComponentDetails.Enabled = false;
            dataGridViewComponentsIssueDetails.Enabled = false;
            textBoxSearch.Enabled = false;
            buttonAddCall.Enabled = false;
            buttonIssuebloodBag.Enabled = false;
            buttonIssuebagTable.Enabled = false;
            buttonExport.Enabled = false;


            LoginCallSystem();
        }
    }
}
