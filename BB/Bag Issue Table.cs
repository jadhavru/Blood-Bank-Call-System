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
    public partial class Bag_Issue_Table : Form
    {
        public Bag_Issue_Table()
        {
            InitializeComponent();
        }

        private void Bag_Issue_Table_Load(object sender, EventArgs e)
        {
            DataTable BagIssueDetails = SqlBB.SelectBagIssueDetails();

            if (BagIssueDetails == null)
            { dataGridViewBagIssueTable.DataSource = null; }
            else
            {
                FillBagIssueHeaderDetailsGrid(BagIssueDetails);

                dataGridViewBagIssueTable.Columns["IssueTime"].Frozen = true;
            }

        }

        private void FillBagIssueHeaderDetailsGrid(DataTable dt)//Fill All EQN Data
        {
            //this.Cursor = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(300);
            //this.Cursor = Cursors.Default;

            // redesign grid
            dataGridViewBagIssueTable.AutoGenerateColumns = false;
            dataGridViewBagIssueTable.Columns.Clear();

            dataGridViewBagIssueTable.EnableHeadersVisualStyles = false;

            dataGridViewBagIssueTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBagIssueTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBagIssueTable.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);
            // dataGridEnqStat.DefaultCellStyle.Font = new Font("Cambria",10, FontStyle.Regular);
            dataGridViewBagIssueTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

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



                    case "IssueTime":
                    case "IssueDate":
                    case "CallTime":
                    case "CallDate":



                        DataGridViewColumn dc11 = new DataGridViewTextBoxColumn();
                        dc11.Name = dc.ColumnName;
                        dc11.HeaderText = dc.ColumnName;
                        dc11.DataPropertyName = dc.ColumnName;
                        dc11.DefaultCellStyle.Format = "dd-MM-yyyy";
                        dc11.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        // dc11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridViewBagIssueTable.Columns.Add(dc11);
                        break;
                    case "No":
                    case "BagIssueID":
                    case "IssueBy":
                    case "HRR Staff Collect By Name":
                    case "HRR Staff Collect At Time":
                    case "HRR Staff Issue By Name":
                    case "HRR Staff Issue At Time":
                    case "Hospital Delivery At Time":
                    case "System Time":
                    
                    case "Call Closing Time":
                    case "Received From Lab Time":
                        DataGridViewColumn dc1 = new DataGridViewTextBoxColumn();
                        dc1.Name = dc.ColumnName;
                        dc1.HeaderText = dc.ColumnName;
                        dc1.DataPropertyName = dc.ColumnName;
                        dc1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                        dataGridViewBagIssueTable.Columns.Add(dc1);
                        break;






                }// switch

            }// foreach columns

            // bind datasource

            dataGridViewBagIssueTable.DataSource = dt;

            dataGridViewBagIssueTable.ClearSelection();


            // dataGridViewBBCallDetails.Columns["FilesFolder"].DisplayIndex = 17;

            //add row number in row header
            //foreach (DataGridViewRow dgr in dataGridViewBBCallDetails.Rows)
            //  dgr.Cells["Indx"].Value = (dgr.Index + 1).ToString();

            //change column back color
            string[] colGr1 = { "HRR Staff Collect By Name", "HRR Staff Collect At Time", "Received From Lab Time" };
            string[] colGr2 = { "HRR Staff Issue By Name", "HRR Staff Issue At Time" };
            string[] colGr3 = { "Hospital Delivery At Time", "System Time", "Call Closing Time" };

            foreach (DataGridViewColumn dc in dataGridViewBagIssueTable.Columns)
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

        private void FillBagIssueDetailsGrid(DataTable dt)//Fill All EQN Data
        {
            //this.Cursor = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(300);
            //this.Cursor = Cursors.Default;

            // redesign grid
            dataGridViewBagIssueDetails.AutoGenerateColumns = false;
            dataGridViewBagIssueDetails.Columns.Clear();

            dataGridViewBagIssueDetails.EnableHeadersVisualStyles = false;

            dataGridViewBagIssueDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBagIssueDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBagIssueDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);
            // dataGridEnqStat.DefaultCellStyle.Font = new Font("Cambria",10, FontStyle.Regular);
            dataGridViewBagIssueDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

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
                        DataGridViewColumn dc1 = new DataGridViewTextBoxColumn();
                        dc1.Name = dc.ColumnName;
                        dc1.HeaderText = dc.ColumnName;
                        dc1.DataPropertyName = dc.ColumnName;
                        dc1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                        dataGridViewBagIssueDetails.Columns.Add(dc1);
                        break;






                }// switch

            }// foreach columns

            // bind datasource

            dataGridViewBagIssueDetails.DataSource = dt;

            dataGridViewBagIssueDetails.ClearSelection();


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

        private void dataGridViewBagIssueTable_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                if (dataGridViewBagIssueTable.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridViewBagIssueTable.SelectedRows[0];
                    //dataGridViewBBCallDetails.SelectedRows[0].Selected = false;

                    // get selected GRR id
                    int No = int.Parse(dr.Cells["No"].Value.ToString());
                    int BagIssueID = int.Parse(dr.Cells["BagIssueID"].Value.ToString());

                    Issue_Blood_From_CallNo ibfcn = new Issue_Blood_From_CallNo(No, BagIssueID);
                    ibfcn.ShowDialog();



                    DataTable BagIssueDetails = SqlBB.SelectBagIssueDetails();

                    if (BagIssueDetails == null)
                    { dataGridViewBagIssueTable.DataSource = null; }
                    else
                    {
                        FillBagIssueHeaderDetailsGrid(BagIssueDetails);

                        dataGridViewBagIssueTable.Columns["IssueTime"].Frozen = true;
                    }


                    //DataTable BagIssueDetails = SqlBB.SelectAllBagIssueDetailsByCallNoAndIssueID(No, BagIssueID);

                    //if (BagIssueDetails == null)
                    //{ dataGridViewBagIssueTable.DataSource = null; }
                    //else
                    //{
                    //    FillBagIssueDetailsGrid(BagIssueDetails);

                    //    // dataGridViewBBCallDetails.Columns["Patient Name"].Frozen = true;
                    //}



                }//
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BB CALL View", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            
           
        }

        private void dataGridViewBagIssueTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewBagIssueTable.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridViewBagIssueTable.SelectedRows[0];
                    //dataGridViewBBCallDetails.SelectedRows[0].Selected = false;

                    // get selected GRR id
                    int No = int.Parse(dr.Cells["No"].Value.ToString());
                    int BagIssueID = int.Parse(dr.Cells["BagIssueID"].Value.ToString());



                    DataTable BagIssueDetails = SqlBB.SelectAllBagIssueDetailsByCallNoAndIssueID(No, BagIssueID);

                    if (BagIssueDetails == null)
                    { dataGridViewBagIssueTable.DataSource = null; }
                    else
                    {
                        FillBagIssueDetailsGrid(BagIssueDetails);

                        // dataGridViewBBCallDetails.Columns["Patient Name"].Frozen = true;
                    }



                }//
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BB CALL View", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewBagIssueTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridViewBagIssueTable["Call Closing Time", e.RowIndex].Value.ToString()))
            {
                dataGridViewBagIssueTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;

            }
            else
            {
                dataGridViewBagIssueTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
    }
}
