using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace BB
{
    public partial class Issue_Blood_From_CallNo : Form
    {

        private BBParameter bbcallparam =new BBParameter();
        int CallNo = 0;
        DataSet ds = new DataSet();
        DataSet dsForUpdate = new DataSet();
        bool iseditBagIssueQty = false;

        public Issue_Blood_From_CallNo()
        {
            InitializeComponent();
        }

        public Issue_Blood_From_CallNo(int  callNo)
        {
            InitializeComponent();

            //get call issue tran no 
            //if call agains bag issue first time call issue tran id is 1
            //else call issue tran + 1
           

            this.CallNo = callNo;

            bbcallparam.CallIssueTranID = SqlBB.GetCallIssueTranIdNew(CallNo);
            if (bbcallparam.CallIssueTranID < 0) throw new Exception();

            // get full detail of this item
             ds = SqlBB.CallSelectSingle(CallNo);
            if (ds == null)
            {
                MessageBox.Show("Error at reading PO details");
                this.Close();
                return;
            }

            // fill controls
            FillNewControls(ds);


            FillComponentGrid();
            buttonIssueBag.Visible = true;
            buttonUpdateIssueBag.Visible = false;
            textBoxCollectTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        public Issue_Blood_From_CallNo(int callNo,int bagissueId)
        {
            InitializeComponent();
            buttonIssueBag.Visible = false;
            buttonUpdateIssueBag.Visible = true;

            // get full detail of this item
            dsForUpdate = SqlBB.BagIssueDetailsSelectSingle(callNo, bagissueId);
            if (ds == null)
            {
                MessageBox.Show("Error at reading PO details");
                this.Close();
                return;
            }

            FillForUpdateControls(dsForUpdate);


            bbcallparam.No = callNo;
            bbcallparam.BagIssueID = bagissueId;

        }

        private void Issue_Blood_From_CallNo_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Fill Controls
        /// </summary>
        private void FillNewControls(DataSet ds)
        {
            try
            {

                DataTable CallDetails = ds.Tables["CallDetails"];
                if (CallDetails == null || CallDetails.Rows.Count <= 0)
                    throw new Exception("Exception at reading PO details");

               
                labelCalNo.Text = CallDetails.Rows[0]["No"].ToString();

                //
                bbcallparam.No = int.Parse(CallDetails.Rows[0]["No"].ToString());
                bbcallparam.CallTime = CallDetails.Rows[0]["CallTime"].ToString();
                bbcallparam.Date = CallDetails.Rows[0]["CallDate"].ToString();


                if (bbcallparam.Date == DateTime.Now.ToShortDateString())
                {
                    labelCallTime.Text = bbcallparam.CallTime;
                    labelCallDate.Text = bbcallparam.Date;

                    bbcallparam.IssueTime = bbcallparam.CallTime;
                    bbcallparam.IssueDate = bbcallparam.Date;

                }
                else
                {
                    labelCallTime.Text = DateTime.Now.ToString("HH:mm:ss");
                    labelCallDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                    bbcallparam.IssueTime = DateTime.Now.ToString("HH:mm:ss");
                    bbcallparam.IssueDate = DateTime.Now.ToString("dd/MM/yyyy");

                }

                


                labelHName.Text = CallDetails.Rows[0]["HospitalName"].ToString();
                 
                labelPName.Text = CallDetails.Rows[0]["Patient Name"].ToString();


                if (bbcallparam.CallIssueTranID==1)
                {

                }
                else
                {

                DataTable BBIssueHeader = ds.Tables["BBIssueHeader"];
                if (BBIssueHeader == null || BBIssueHeader.Rows.Count <= 0)
                    throw new Exception("Exception at reading BB Issue details");


                bbcallparam.HRRStaffCollectByName = BBIssueHeader.Rows[0]["HRR Staff Collect By Name"].ToString();
                bbcallparam.HRRStaffIssueAtTime = BBIssueHeader.Rows[0]["HRR Staff Collect At Time"].ToString();

                textBoxHrrStaffCollectName.Text = bbcallparam.HRRStaffCollectByName;
                textBoxCollectTime.Text = bbcallparam.HRRStaffIssueAtTime;

                }


                DataTable dtComponentsDetail = ds.Tables["ComponentsDetails"];
                if (dtComponentsDetail == null || dtComponentsDetail.Rows.Count <= 0)
                    throw new Exception("Exception at reading Component details");

                // get products
                bbcallparam.ComponentList.Clear();

                foreach (DataRow drw in dtComponentsDetail.Rows)
                {
                    BBParameter itm = new BBParameter();

                    itm.No = int.Parse(drw["No"].ToString());
                    itm.ComponentID = drw["BBComponentID"].ToString();

                    itm.ComponentName = drw["Component Name"].ToString();


                    // quantity actually ordered
                    double ordqty = double.Parse(drw["OrderQty"].ToString());

                    // quantity pending
                    double penqty = double.Parse(drw["PendingQty"].ToString());

                    // quantity ordered for GRR
                    //if (penqty > 0)
                    //    itm.OrderQuantity = penqty;
                    //else
                    //    itm.OrderQuantity = ordqty;


                    itm.ComponentQuantity = ordqty;

                    itm.PendingQuantity = penqty;



                    // add to list
                    bbcallparam.ComponentList.Add(itm);

                }// foreach





            }// try
            catch (Exception ex)
            {
                throw ex;
            }

        }// FillPOParameters
        public void FillComponentGrid()
        {
            try
            {
                dataGridViewComponets.Rows.Clear();
                int i = 0;
                for (int j = 0; j < bbcallparam.ComponentList.Count; j++)
                {
                    BBParameter p = bbcallparam.ComponentList[j];

                    dataGridViewComponets.Rows.Add();

                    dataGridViewComponets[ColumnSrNo.Name, i].Value = i + 1;
                    dataGridViewComponets[ColumnComponentID.Name, i].Value = p.ComponentID;
                    dataGridViewComponets[ColumnComponentName.Name, i].Value = p.ComponentName;
                    dataGridViewComponets[ColumnQty.Name, i].Value = p.ComponentQuantity;
                    dataGridViewComponets[ColumnPendingQty.Name, i].Value = p.PendingQuantity;






                    i++;
                }





            }//try
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "=Fn:Fill product grids");
            }

        }


        private void FillForUpdateControls(DataSet ds)
        {
            try
            {

                DataTable BagIssueDetails = ds.Tables["BagIssueHeader"];
                if (BagIssueDetails == null || BagIssueDetails.Rows.Count <= 0)
                    throw new Exception("Exception at reading PO details");


                labelCalNo.Text = BagIssueDetails.Rows[0]["No"].ToString();
                bbcallparam.No = int.Parse(BagIssueDetails.Rows[0]["No"].ToString());

                bbcallparam.CallTime = BagIssueDetails.Rows[0]["CallTime"].ToString();
                bbcallparam.Date = BagIssueDetails.Rows[0]["CallDate"].ToString();

                bbcallparam.IssueTime = BagIssueDetails.Rows[0]["IssueTime"].ToString();
                bbcallparam.IssueDate = BagIssueDetails.Rows[0]["IssueDate"].ToString();



                object ValueNo = BagIssueDetails.Rows[0]["No"];
                object ValueCollectTime = BagIssueDetails.Rows[0]["HRR Staff Collect At Time"];
                object ValueReceivedFormLab = BagIssueDetails.Rows[0]["Received From Lab Time"];
                object ValueIssueTime = BagIssueDetails.Rows[0]["HRR Staff Issue At Time"];
                object ValueDeliveryTime = BagIssueDetails.Rows[0]["Hospital Delivery At Time"];
                object ValueSystemTime = BagIssueDetails.Rows[0]["System Time"];

                   // groupBoxPatient.Enabled = false;

                    if (ValueNo == "")
                    {
                        groupBoxCollectBB.Enabled = false;
                        groupBoxDeliveryBB.Enabled = false;
                        groupBoxIssueBB.Enabled = false;
                        groupBoxReceivedSampleFromLab.Enabled = false;
                        bbcallparam.CallClosingTime = "";
                        bbcallparam.ReceivedFromLabTime = "";
                    }
                    else
                    {
                        if (ValueCollectTime == "")
                        {
                            textBoxCollectTime.Text = DateTime.Now.ToString("HH:mm:ss");
                        }
                        else
                        {
                            textBoxCollectTime.Text = BagIssueDetails.Rows[0]["HRR Staff Collect At Time"].ToString();
                        }
                        groupBoxCollectBB.Enabled = true;
                        bbcallparam.CallClosingTime = "";
                        bbcallparam.ReceivedFromLabTime = "";
                    }

                    if (ValueCollectTime == "")
                    {
                        groupBoxIssueBB.Enabled = false;
                        groupBoxDeliveryBB.Enabled = false;
                        groupBoxReceivedSampleFromLab.Enabled = false;
                        bbcallparam.CallClosingTime = "";
                        bbcallparam.ReceivedFromLabTime = "";
                    }
                    else
                    {
                        if (ValueReceivedFormLab == "")
                        {
                            textBoxReceivedFromlabtime.Text = DateTime.Now.ToString("HH:mm:ss");
                        }
                        else
                        {
                            textBoxReceivedFromlabtime.Text = BagIssueDetails.Rows[0]["Received From Lab Time"].ToString();

                        }

                        groupBoxReceivedSampleFromLab.Enabled = true;

                        bbcallparam.CallClosingTime = "";



                    }

                    if (ValueReceivedFormLab=="")
                    {
                        groupBoxIssueBB.Enabled = false;
                        groupBoxDeliveryBB.Enabled = false;

                        bbcallparam.CallClosingTime = "";
                    }
                    else
                    {

                        if (ValueIssueTime == "")
                        {
                            textBoxIssueTime.Text = DateTime.Now.ToString("HH:mm:ss");
                        }
                        else
                        {
                            textBoxIssueTime.Text = BagIssueDetails.Rows[0]["HRR Staff Issue At Time"].ToString();

                        }

                        groupBoxIssueBB.Enabled = true;

                        bbcallparam.CallClosingTime = "";

                    }

                    if (ValueIssueTime == "")
                    {
                        groupBoxDeliveryBB.Enabled = false;
                        bbcallparam.CallClosingTime = "";
                    }
                    else
                    {
                        groupBoxDeliveryBB.Enabled = true;

                        if (ValueSystemTime=="")
                        {
                            textBoxSystemTime.Text = DateTime.Now.ToString("HH:mm:ss");
                        }
                        else
                        {
                            textBoxSystemTime.Text = BagIssueDetails.Rows[0]["System Time"].ToString();

                        }

                        //if delivery time empty or not
                        if (ValueDeliveryTime=="")

                        {
                            textBoxDeliveryatTime.Text = DateTime.Now.ToString("HH:mm:ss");

                            DateTime CallTime = DateTime.ParseExact(bbcallparam.IssueTime, "HH:mm:ss",
                                   CultureInfo.InvariantCulture);

                            DateTime DeliveryAtTime = DateTime.ParseExact(textBoxDeliveryatTime.Text, "HH:mm:ss",
                                            CultureInfo.InvariantCulture);

                            TimeSpan ts = DeliveryAtTime.Subtract(CallTime);

                            bbcallparam.DeliveryAtTime = textBoxDeliveryatTime.Text;

                            //call time diffrence
                            bbcallparam.CallClosingTime = ts.ToString();


                        }
                        else
                        {
                            textBoxDeliveryatTime.Text = BagIssueDetails.Rows[0]["Hospital Delivery At Time"].ToString();

                            bbcallparam.CallClosingTime = BagIssueDetails.Rows[0]["Call Closing Time"].ToString();
                        }



                        //if (ValueDeliveryTime == "")
                        //{
                        //    textBoxSystemTime.Text = DateTime.Now.ToShortTimeString().ToString();

                        //    DateTime CallTime = DateTime.ParseExact(textBoxCallTime.Text, "HH:mm:ss",
                        //                    CultureInfo.InvariantCulture);

                        //    DateTime DeliveryAtTime = DateTime.ParseExact(textBoxDeliveryatTime.Text, "HH:mm:ss",
                        //                    CultureInfo.InvariantCulture);

                        //    TimeSpan ts = DeliveryAtTime.Subtract(CallTime);

                        //    bbParam.CallClosingTime = ts.ToString();

                        //}
                        //else
                        //{
                        //    textBoxSystemTime.Text = dr["System Time"].ToString();

                        //    bbParam.CallClosingTime = dr["Call Closing Time"].ToString();

                        //}



                    }



                bbcallparam.HRRStaffCollectByName = BagIssueDetails.Rows[0]["HRR Staff Collect By Name"].ToString();
                bbcallparam.HRRStaffCollectAtTime = BagIssueDetails.Rows[0]["HRR Staff Collect At Time"].ToString();

                textBoxHrrStaffCollectName.Text = bbcallparam.HRRStaffCollectByName;
                textBoxCollectTime.Text = bbcallparam.HRRStaffCollectAtTime;


                bbcallparam.HRRStaffIssueByName = BagIssueDetails.Rows[0]["HRR Staff Issue By Name"].ToString();
                bbcallparam.HRRStaffIssueAtTime = BagIssueDetails.Rows[0]["HRR Staff Issue At Time"].ToString();

                textBoxHrrStaffIssueName.Text = bbcallparam.HRRStaffIssueByName;
                 




                DataTable dtBagDetail = ds.Tables["BagIssueDetails"];
                if (dtBagDetail == null || dtBagDetail.Rows.Count <= 0)
                    throw new Exception("Exception at reading PO details");

                // get products
                bbcallparam.ComponentList.Clear();

                foreach (DataRow drw in dtBagDetail.Rows)
                {
                    BBParameter itm = new BBParameter();

                    itm.No = int.Parse(drw["No"].ToString());
                    itm.ComponentID = drw["ComponentID"].ToString();

                    itm.ComponentName = drw["Component Name"].ToString();


                    // quantity actually ordered
                    double ordqty = double.Parse(drw["ReceivedQty"].ToString());

                     //quantity pending
                    double penqty = double.Parse(drw["PendingQty"].ToString());

                    // quantity ordered for GRR
                    //if (penqty > 0)
                    //    itm.OrderQuantity = penqty;
                    //else
                    //    itm.OrderQuantity = ordqty;

                    itm.BagIssueQuantity = ordqty;

                    //itm.ComponentQuantity = ordqty;

                    itm.PendingQuantity = penqty;



                    // add to list
                    bbcallparam.ComponentList.Add(itm);

                }// foreach


                FillComponentGridForUpdate();


            }// try
            catch (Exception ex)
            {
                throw ex;
            }

        }// FillPOParameters
        public void FillComponentGridForUpdate()
        {
            try
            {
                dataGridViewComponets.Rows.Clear();
                int i = 0;
                for (int j = 0; j < bbcallparam.ComponentList.Count; j++)
                {
                    BBParameter p = bbcallparam.ComponentList[j];

                    dataGridViewComponets.Rows.Add();

                    dataGridViewComponets[ColumnSrNo.Name, i].Value = i + 1;
                    dataGridViewComponets[ColumnComponentID.Name, i].Value = p.ComponentID;
                    dataGridViewComponets[ColumnComponentName.Name, i].Value = p.ComponentName;
                    dataGridViewComponets[ColumnQty.Name, i].Value = p.ComponentQuantity;
                    dataGridViewComponets[ColumnPendingQty.Name, i].Value = p.PendingQuantity;
                    dataGridViewComponets[ColumnIssueBagQty.Name, i].Value = p.BagIssueQuantity;






                    i++;
                }





            }//try
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "=Fn:Fill product grids");
            }

        }
        private void buttonIssueBag_Click(object sender, EventArgs e)
        {
            if (iseditBagIssueQty == true)
            {
                bbcallparam.BagIssueID = SqlBB.GetBagIssueIdNew();
                if (bbcallparam.BagIssueID < 0) throw new Exception();
                 
                bbcallparam.HRRStaffCollectByName = textBoxHrrStaffCollectName.Text.ToUpper();
                bbcallparam.HRRStaffCollectAtTime = textBoxCollectTime.Text.ToUpper();

                bbcallparam.ReceivedFromLabTime = textBoxReceivedFromlabtime.Text.ToUpper();

                bbcallparam.HRRStaffIssueByName = textBoxHrrStaffIssueName.Text.ToUpper();
                bbcallparam.HRRStaffIssueAtTime = textBoxIssueTime.Text.ToUpper();
                bbcallparam.SystemDeliveryTime = textBoxSystemTime.Text.ToUpper();
                bbcallparam.DeliveryAtTime = textBoxDeliveryatTime.Text.ToUpper();


                int count = SqlBB.BagIssueInsert(bbcallparam);
                //  
                if (count > 0)
                    MessageBox.Show("Bag Issue Saved Successfully ");
                
            }
            else
            {
                MessageBox.Show("Enter Bag Issue Qty");
            }
        }

        private void dataGridViewComponets_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            string[] itmGrid = { ColumnIssueBagQty.Name };

            switch (Array.IndexOf(itmGrid, dataGridViewComponets.Columns[e.ColumnIndex].Name))
            {
                case 0: // dataGridTextColQty
                    try
                    {
                        // get change quantity
                        double qty = double.Parse(dataGridViewComponets[e.ColumnIndex, e.RowIndex].Value.ToString());

                        // select item
                        BBParameter P = bbcallparam.ComponentList.Single(
                            cmd => cmd.ComponentID == dataGridViewComponets[ColumnComponentID.Name, e.RowIndex].Value.ToString());

                        // get index
                        int index = bbcallparam.ComponentList.IndexOf(P);
                         // set quantity
                        P.BagIssueQuantity = qty;

                        if (P.BagIssueQuantity <= P.PendingQuantity && P.BagIssueQuantity !=0 && P.PendingQuantity !=0)
                        {
                           // P.PendingQuantity = P.PendingQuantity - P.BagIssueQuantity;

                            // set item
                            bbcallparam.ComponentList[index] = P;



                            iseditBagIssueQty = true;
                        }
                        else
                        {
                            dataGridViewComponets[ColumnIssueBagQty.Name, e.RowIndex].Value = "";
                            P.BagIssueQuantity = 0;
                            MessageBox.Show("Bag Issue Quantity Must Be lessthen Pending Quantity or Not Zero 0 ");
                            return;
                        }

                       

                       
                    }
                    catch (InvalidCastException)
                    {
                        // select product
                        BBParameter P = bbcallparam.ComponentList.Single(
                            cmd => cmd.ComponentID == dataGridViewComponets[ColumnComponentID.Name, e.RowIndex].Value.ToString());

                        // set quantity
                        dataGridViewComponets[e.ColumnIndex, e.RowIndex].Value = P.ComponentQuantity;




                    }

                    break;

            }
        }

        private void buttonUpdateIssueBag_Click(object sender, EventArgs e)
        {
            bbcallparam.HRRStaffCollectByName = textBoxHrrStaffCollectName.Text.ToUpper();
            bbcallparam.HRRStaffCollectAtTime = textBoxCollectTime.Text.ToUpper();

            bbcallparam.ReceivedFromLabTime = textBoxReceivedFromlabtime.Text.ToUpper();

            bbcallparam.HRRStaffIssueByName = textBoxHrrStaffIssueName.Text.ToUpper();
            bbcallparam.HRRStaffIssueAtTime = textBoxIssueTime.Text.ToUpper();

            bbcallparam.SystemDeliveryTime = textBoxSystemTime.Text.ToUpper();
            bbcallparam.DeliveryAtTime = textBoxDeliveryatTime.Text.ToUpper();

            int count = SqlBB.BagIssueDetailsUpdate(bbcallparam,bbcallparam.No,bbcallparam.BagIssueID);
            //  
            if (count > 0)
                MessageBox.Show("Record Update Successfully ");



        }

        private void checkBoxIssueForNextDay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIssueForNextDay.Checked)
            {
            
            labelCallTime.Text = DateTime.Now.ToShortTimeString().ToString();
            labelCallDate.Text = DateTime.Now.ToShortDateString();

            bbcallparam.IssueTime = labelCallTime.Text;
            bbcallparam.IssueDate = labelCallDate.Text;

            }
        }
    }
}
