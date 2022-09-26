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
    public partial class Call_Details_For_Issue : Form
    {
        BBParameter bbparam = new BBParameter();

        public Call_Details_For_Issue()
        {
            InitializeComponent();
        }

        private void Call_Details_For_Issue_Load(object sender, EventArgs e)
        {
            DataTable BBCallDetails = SqlBB.SelectAllBBCallDetails();

            if (BBCallDetails == null)
            { dataGridViewCallDetailsForIssue.DataSource = null; }
            else
            {
                FillBBCallDetailsGrid(BBCallDetails);

                dataGridViewCallDetailsForIssue.Columns["Patient Name"].Frozen = true;
            }
        }

        private void FillBBCallDetailsGrid(DataTable dt)//Fill All EQN Data
        {
            //this.Cursor = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(300);
            //this.Cursor = Cursors.Default;

            // redesign grid
            dataGridViewCallDetailsForIssue.AutoGenerateColumns = false;
            dataGridViewCallDetailsForIssue.Columns.Clear();

            dataGridViewCallDetailsForIssue.EnableHeadersVisualStyles = false;

            dataGridViewCallDetailsForIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCallDetailsForIssue.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewCallDetailsForIssue.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);
            // dataGridEnqStat.DefaultCellStyle.Font = new Font("Cambria",10, FontStyle.Regular);
            dataGridViewCallDetailsForIssue.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

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
                        dataGridViewCallDetailsForIssue.Columns.Add(dc11);
                        break;
                    case "No":
                    case "ReceivedBy":
                    case "HospitalName":
                    case "Area":

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

                        dataGridViewCallDetailsForIssue.Columns.Add(dc1);
                        break;






                }// switch

            }// foreach columns

            // bind datasource

            dataGridViewCallDetailsForIssue.DataSource = dt;

            dataGridViewCallDetailsForIssue.ClearSelection();


            // dataGridViewBBCallDetails.Columns["FilesFolder"].DisplayIndex = 17;

            //add row number in row header
            //foreach (DataGridViewRow dgr in dataGridViewBBCallDetails.Rows)
            //  dgr.Cells["Indx"].Value = (dgr.Index + 1).ToString();

            ////change column back color
            //string[] colGr1 = { "HRR Staff Collect By Name", "HRR Staff Collect At Time", "Received From Lab Time" };
            //string[] colGr2 = { "HRR Staff Issue By Name", "HRR Staff Issue At Time" };
            //string[] colGr3 = { "Hospital Delivery At Time", "System Time", "Call Closing Time" };

            //foreach (DataGridViewColumn dc in dataGridViewCallDetailsForIssue.Columns)
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
        }

        private void dataGridViewCallDetailsForIssue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                if (dataGridViewCallDetailsForIssue.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridViewCallDetailsForIssue.SelectedRows[0];

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
        }// end fill grid


      


       

    }
}
