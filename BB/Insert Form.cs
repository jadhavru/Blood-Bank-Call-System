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
    public partial class Insert_Form : Form
    {
        BBParameter bbParam = new BBParameter();
        int NO = 0;



        //CompanyName
        private AutoCompleteStringCollection autoStringPatientName = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection autoStringPatientID = new AutoCompleteStringCollection();
        List<string> lsPatientId = new List<string>();
        List<String> lsPatientName = new List<string>();

        //ProductModel
        private AutoCompleteStringCollection autoStringComponentName = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection autoStringComponentID = new AutoCompleteStringCollection();
        List<string> lsComponentId = new List<string>();
        List<String> lsComponentName = new List<string>();



        public Insert_Form()
        {
            InitializeComponent();

            DateTime dt1 = new DateTime();
            //textBoxCallTime.Text = dt1.ToString("hh:mm tt");


            bbParam.No = SqlBB.GetBBIdNew();
            if (bbParam.No < 0) throw new Exception();


            FillPatientsName();
            FillBloodComponent();
            HospitalNameFill();
            ReceivedByFill();
            CallTypeForFill();

            textBox1CallNo.Text = bbParam.No.ToString();
            comboBoxCallStatus.Text = "OPN";

            textBoxCallTime.Text = DateTime.Now.ToString("HH:mm:ss");
            textBoxCallDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            buttonSave.Visible = true;
        }

        public Insert_Form(int no)
        {
            InitializeComponent();

            FillPatientsName();
            FillBloodComponent();
            HospitalNameFill();
            ReceivedByFill();
            CallTypeForFill();

            this.NO = no;
            buttonUpdate.Visible = true;
            buttonCompoRemove.Visible = false;
            buttonComponentqty.Visible = false;

            // get full detail of this item
            DataSet ds = SqlBB.CallSelectSingle(NO);
            if (ds == null)
            {
                MessageBox.Show("Error at reading PO details");
                this.Close();
                return;
            }

            // fill controls
            FillControls(ds);


            

            //DataRow dr = SqlBB.GetBBCallDetailsByNo(NO);


            //textBox1CallNo.Text = dr["No"].ToString();
            //textBox1CallNo.Enabled = false;


            //textBoxCallTime.Text = dr["CallTime"].ToString();
            //textBoxCallTime.Enabled = false;



            //if (dr != null)
            //{

            //    object ValueNo = dr["No"];
            //    object ValueCollectTime = dr["HRR Staff Collect At Time"];
            //    object ValueReceivedFormLab = dr["Received From Lab Time"];
            //    object ValueIssueTime = dr["HRR Staff Issue At Time"];
            //    object ValueDeliveryTime = dr["Hospital Delivery At Time"];
            //    object ValueSystemTime = dr["System Time"];

            //   // groupBoxPatient.Enabled = false;

            //    if (ValueNo == "")
            //    {
            //        groupBoxCollectBB.Enabled = false;
            //        groupBoxDeliveryBB.Enabled = false;
            //        groupBoxIssueBB.Enabled = false;
            //        groupBoxReceivedSampleFromLab.Enabled = false;
            //        bbParam.CallClosingTime = "";
            //        bbParam.ReceivedFromLabTime = "";
            //    }
            //    else
            //    {
            //        if (ValueCollectTime == "")
            //        {
            //            textBoxCollectTime.Text = DateTime.Now.ToShortTimeString().ToString();
            //        }
            //        else
            //        {
            //            textBoxCollectTime.Text = dr["HRR Staff Collect At Time"].ToString();
            //        }
            //        groupBoxCollectBB.Enabled = true;
            //        bbParam.CallClosingTime = "";
            //        bbParam.ReceivedFromLabTime = "";
            //    }

            //    if (ValueCollectTime == "")
            //    {
            //        groupBoxIssueBB.Enabled = false;
            //        groupBoxDeliveryBB.Enabled = false;
            //        groupBoxReceivedSampleFromLab.Enabled = false;
            //        bbParam.CallClosingTime = "";
            //        bbParam.ReceivedFromLabTime = "";
            //    }
            //    else
            //    {
            //        if (ValueReceivedFormLab == "")
            //        {
            //            textBoxReceivedFromlabtime.Text = DateTime.Now.ToShortTimeString().ToString();
            //        }
            //        else
            //        {
            //            textBoxReceivedFromlabtime.Text = dr["Received From Lab Time"].ToString();

            //        }

            //        groupBoxReceivedSampleFromLab.Enabled = true;
                   
            //        bbParam.CallClosingTime = "";


                   
            //    }

            //    if (ValueReceivedFormLab=="")
            //    {
            //        groupBoxIssueBB.Enabled = false;
            //        groupBoxDeliveryBB.Enabled = false;
                     
            //        bbParam.CallClosingTime = "";
            //    }
            //    else
            //    {

            //        if (ValueIssueTime == "")
            //        {
            //            textBoxIssueTime.Text = DateTime.Now.ToShortTimeString().ToString();
            //        }
            //        else
            //        {
            //            textBoxIssueTime.Text = dr["HRR Staff Issue At Time"].ToString();

            //        }

            //        groupBoxIssueBB.Enabled = true;
                    
            //        bbParam.CallClosingTime = "";

            //    }

            //    if (ValueIssueTime == "")
            //    {
            //        groupBoxDeliveryBB.Enabled = false;
            //        bbParam.CallClosingTime = "";
            //    }
            //    else
            //    {
            //        groupBoxDeliveryBB.Enabled = true;

            //        if (ValueSystemTime=="")
            //        {
            //            textBoxSystemTime.Text = DateTime.Now.ToShortTimeString().ToString();
            //        }
            //        else
            //        {
            //            textBoxSystemTime.Text = dr["System Time"].ToString();
                        
            //        }

            //        //if delivery time empty or not
            //        if (ValueDeliveryTime=="")

            //        {
            //            textBoxDeliveryatTime.Text = DateTime.Now.ToShortTimeString().ToString();

            //            DateTime CallTime = DateTime.ParseExact(textBoxCallTime.Text, "HH:mm:ss",
            //                   CultureInfo.InvariantCulture);

            //            DateTime DeliveryAtTime = DateTime.ParseExact(textBoxDeliveryatTime.Text, "HH:mm:ss",
            //                            CultureInfo.InvariantCulture);

            //            TimeSpan ts = DeliveryAtTime.Subtract(CallTime);

            //            bbParam.DeliveryAtTime = textBoxDeliveryatTime.Text;

            //            //call time diffrence
            //            bbParam.CallClosingTime = ts.ToString();

                        
            //        }
            //        else
            //        {
            //            textBoxDeliveryatTime.Text = dr["Hospital Delivery At Time"].ToString();

            //            bbParam.CallClosingTime = dr["Call Closing Time"].ToString();
            //        }

                   

            //        //if (ValueDeliveryTime == "")
            //        //{
            //        //    textBoxSystemTime.Text = DateTime.Now.ToShortTimeString().ToString();

            //        //    DateTime CallTime = DateTime.ParseExact(textBoxCallTime.Text, "HH:mm:ss",
            //        //                    CultureInfo.InvariantCulture);

            //        //    DateTime DeliveryAtTime = DateTime.ParseExact(textBoxDeliveryatTime.Text, "HH:mm:ss",
            //        //                    CultureInfo.InvariantCulture);

            //        //    TimeSpan ts = DeliveryAtTime.Subtract(CallTime);

            //        //    bbParam.CallClosingTime = ts.ToString();

            //        //}
            //        //else
            //        //{
            //        //    textBoxSystemTime.Text = dr["System Time"].ToString();

            //        //    bbParam.CallClosingTime = dr["Call Closing Time"].ToString();

            //        //}


                    
            //    }



            //    comboBoxPatientName.Text = dr["Patient Name"].ToString();
            //    comboBoxComponentName.Text = dr["Component Name"].ToString();

            //    textBoxCallDate.Text = dr["CallDate"].ToString();
            //    textBoxReceivedBy.Text = dr["ReceivedBy"].ToString();
            //    textBoxHospitalName.Text = dr["HospitalName"].ToString();
            //    textBoxHospitalArea.Text = dr["Area"].ToString();
            //    //textBoxPatientName.Text = dr["PatientName"].ToString();
            //    comboBoxCalledBy.Text = dr["CalledBy"].ToString();
            //    textBoxCalledByName.Text = dr["CalledByName"].ToString();
            //    textBoxMobileNo.Text = dr["MobileNo"].ToString();
            //    textBoxWardNo.Text = dr["WardNo"].ToString();
            //    comboBoxCalltypeFor.Text = dr["CallType"].ToString();

            //    textBoxDiagno.Text = dr["Diagnosis"].ToString();
            //    textBoxTransfu.Text = dr["Transfusion"].ToString();
            //    textBoxHb.Text = dr["Hb"].ToString();

            //    textBoxHrrStaffCollectName.Text = dr["HRR Staff Collect By Name"].ToString();
            //    //
            //    textBoxHrrStaffIssueName.Text = dr["HRR Staff Issue By Name"].ToString();
            //    //
 
            //}

        }

        private void Insert_Form_Load(object sender, EventArgs e)
        {
            
        }







        #region Fill Data
        
        private void FillPatientsName()
        {

            lsPatientId.Clear();
            lsPatientName.Clear();
            comboBoxPatientName.Items.Clear();
            autoStringPatientID.Clear();
            autoStringPatientName.Clear();

            SqlBB.SelectPatientName(lsPatientName, lsPatientId);

            comboBoxPatientName.Items.AddRange(lsPatientName.ToArray());
            //
            autoStringPatientName.AddRange(lsPatientName.ToArray());
            autoStringPatientID.AddRange(lsPatientId.ToArray());


            comboBoxPatientName.Items.Insert(0, "<New>");
            autoStringPatientName.Insert(0, "<New>");
            autoStringPatientID.Insert(0, "0");
            //
            lsPatientName.Insert(0, "<New>");
            lsPatientId.Insert(0, "0");
            //

            comboBoxPatientName.Items.Add("<Edit>");


            lsPatientId.Add("0");
            lsPatientName.Add("Edit");

            comboBoxPatientName.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxPatientName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxPatientName.AutoCompleteCustomSource = autoStringPatientName;



        }

        private void FillBloodComponent()
        {

            lsComponentId.Clear();
            lsComponentName.Clear();
            comboBoxComponentName.Items.Clear();
            autoStringComponentID.Clear();
            autoStringComponentName.Clear();

            SqlBB.SelectComponentName(lsComponentName, lsComponentId);

            comboBoxComponentName.Items.AddRange(lsComponentName.ToArray());
            //
            autoStringComponentName.AddRange(lsComponentName.ToArray());
            autoStringComponentID.AddRange(lsComponentId.ToArray());


            comboBoxComponentName.Items.Insert(0, "<New>");
            autoStringComponentName.Insert(0, "<New>");
            autoStringComponentID.Insert(0, "0");
            //
            lsComponentName.Insert(0, "<New>");
            lsComponentId.Insert(0, "0");
            //

            comboBoxComponentName.Items.Add("<Edit>");


            lsComponentId.Add("0");
            lsComponentName.Add("Edit");

            comboBoxComponentName.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxComponentName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxComponentName.AutoCompleteCustomSource = autoStringComponentName;




        }

        private void HospitalNameFill()
        {
            textBoxHospitalName.Clear();
            List<string> HospitalName = new List<string>();
            SqlBB.GetHospitalName(HospitalName);
            string[] arr = HospitalName.ToArray();
            AutoCompleteStringCollection instcol = new AutoCompleteStringCollection();
            instcol.AddRange(arr);
            textBoxHospitalName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxHospitalName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxHospitalName.AutoCompleteCustomSource = instcol;

        }

        private void ReceivedByFill()
        {
            textBoxReceivedBy.Clear();
            List<string> ReceivedBy = new List<string>();
            SqlBB.GetReceivedBy(ReceivedBy);
            string[] arr = ReceivedBy.ToArray();
            AutoCompleteStringCollection instcol = new AutoCompleteStringCollection();
            instcol.AddRange(arr);
            textBoxReceivedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxReceivedBy.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxReceivedBy.AutoCompleteCustomSource = instcol;

        }

        private void CallTypeForFill()
        {
            textBoxCalltypeFor.Clear();
            List<string> calltypeFor = new List<string>();
            SqlBB.GetCallTypeFory(calltypeFor);
            string[] arr = calltypeFor.ToArray();
            AutoCompleteStringCollection instcol = new AutoCompleteStringCollection();
            instcol.AddRange(arr);
            textBoxCalltypeFor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxCalltypeFor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxCalltypeFor.AutoCompleteCustomSource = instcol;

        }

        #endregion





        private void buttonSave_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBoxHospitalName.Text) || string.IsNullOrEmpty(comboBoxCallStatus.Text) || string.IsNullOrEmpty(comboBoxPatientName.Text) || string.IsNullOrEmpty(comboBoxCalledBy.Text) || string.IsNullOrEmpty(textBoxWardNo.Text) || dataGridViewComponents.Rows.Count == 0)
            {
                MessageBox.Show("Something Messing...!");
            }
            else
            {

                bbParam.CallStatus = comboBoxCallStatus.Text;
                bbParam.CallTime = textBoxCallTime.Text;
                bbParam.Date = textBoxCallDate.Text;
                bbParam.ReceivedBy = textBoxReceivedBy.Text.ToUpper();

                //
                bbParam.HospitalName = textBoxHospitalName.Text.ToUpper();
                bbParam.Area = textBoxHospitalArea.Text.ToUpper();
                //
                
                //

                int PID = 0;
                if (comboBoxPatientName.SelectedIndex >= 0)
                {
                    string custname = comboBoxPatientName.SelectedItem.ToString();
                    int index3 = comboBoxPatientName.SelectedIndex;
                    PID = int.Parse(lsPatientId[index3]);
                    bbParam.PatientID = PID.ToString();
                    bbParam.ifNewPatient = false;
                }

                bbParam.P_Name = comboBoxPatientName.Text.ToString().ToUpper();
                bbParam.P_MobileNo = textBoxMobileNo.Text.ToString().ToUpper();
                bbParam.P_Age = textBoxP_Age.Text.ToString().ToUpper();
                bbParam.P_Sex = comboBoxP_Sex.Text.ToString().ToUpper();
                bbParam.P_BL_Group = textBoxP_BlGroup.Text.ToString().ToUpper();

                bbParam.P_Address = richTextBoxP_Address.Text.ToString().ToUpper();
                bbParam.P_City = textBoxP_City.Text.ToString().ToUpper();

                bbParam.Diagnosis = textBoxDiagno.Text.ToString().ToUpper();
                bbParam.Transfusion = textBoxTransfu.Text.ToString().ToUpper();
                bbParam.HB = textBoxHb.Text.ToString().ToUpper();

                //

                //string Component = comboBoxComponentName.SelectedItem.ToString();
                //int index2 = comboBoxComponentName.SelectedIndex;
                //int CompoID = int.Parse(lsComponentId[index2]);

                //bbParam.ComponentID = CompoID.ToString();



                bbParam.CalledBy = comboBoxCalledBy.Text.ToUpper();
                bbParam.MobileNo = textBoxMobileNo.Text;
                bbParam.CalledByName = textBoxCalledByName.Text.ToString().ToUpper();
               
                bbParam.WardNo = textBoxWardNo.Text.ToUpper();
                bbParam.CallType = textBoxCalltypeFor.Text.ToUpper();


                ////
                //bbParam.HRRStaffCollectByName = textBoxHrrStaffCollectName.Text.ToUpper();
                //bbParam.HRRStaffCollectAtTime = textBoxCollectTime.Text.ToUpper();

                //bbParam.ReceivedFromLabTime = textBoxReceivedFromlabtime.Text.ToUpper();

                //bbParam.HRRStaffIssueByName = textBoxHrrStaffIssueName.Text.ToUpper();
                //bbParam.HRRStaffIssueAtTime = textBoxIssueTime.Text.ToUpper();
                //bbParam.SystemDeliveryTime = textBoxSystemTime.Text.ToUpper();
                //bbParam.DeliveryAtTime = textBoxDeliveryatTime.Text.ToUpper();
                //



                int count = SqlBB.BBCallDetailsInsert(bbParam);
                //  
                if (count > 0)
                    MessageBox.Show("Call Saved Successfully ");


            }






        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(comboBoxCallStatus.Text))
            {
                MessageBox.Show("Something Messing...!");
            }
            else
            {
                bbParam.CallStatus = comboBoxCallStatus.Text;
                bbParam.CallTime = textBoxCallTime.Text;
                bbParam.Date = textBoxCallDate.Text;
                bbParam.ReceivedBy = textBoxReceivedBy.Text.ToUpper();

                //
                bbParam.HospitalName = textBoxHospitalName.Text.ToUpper();
                bbParam.Area = textBoxHospitalArea.Text.ToUpper();
                //

                //

                int PID = 0;
                 
                    string custname = comboBoxPatientName.SelectedItem.ToString();
                    int index3 = comboBoxPatientName.SelectedIndex;
                    PID = int.Parse(lsPatientId[index3]);
                    bbParam.PatientID = PID.ToString();
                    
                

                bbParam.P_Name = comboBoxPatientName.Text.ToString().ToUpper();
                bbParam.P_MobileNo = textBoxMobileNo.Text.ToString().ToUpper();
                bbParam.P_Age = textBoxP_Age.Text.ToString().ToUpper();
                bbParam.P_Sex = comboBoxP_Sex.Text.ToString().ToUpper();
                bbParam.P_BL_Group = textBoxP_BlGroup.Text.ToString().ToUpper();

                bbParam.P_Address = richTextBoxP_Address.Text.ToString().ToUpper();
                bbParam.P_City = textBoxP_City.Text.ToString().ToUpper();

                bbParam.Diagnosis = textBoxDiagno.Text.ToString().ToUpper();
                bbParam.Transfusion = textBoxTransfu.Text.ToString().ToUpper();
                bbParam.HB = textBoxHb.Text.ToString().ToUpper();

                ////

                //string Component = comboBoxComponentName.SelectedItem.ToString();
                //int index2 = comboBoxComponentName.SelectedIndex;
                //int CompoID = int.Parse(lsComponentId[index2]);

                //bbParam.ComponentID = CompoID.ToString();



                bbParam.CalledBy = comboBoxCalledBy.Text.ToUpper();
                bbParam.MobileNo = textBoxMobileNo.Text;
                bbParam.CalledByName = textBoxCalledByName.Text.ToString().ToUpper();

                bbParam.WardNo = textBoxWardNo.Text.ToUpper();
                bbParam.CallType = textBoxCalltypeFor.Text.ToUpper();


                ////
                //bbParam.HRRStaffCollectByName = textBoxHrrStaffCollectName.Text.ToUpper();
                //bbParam.HRRStaffCollectAtTime = textBoxCollectTime.Text.ToUpper();

                //bbParam.ReceivedFromLabTime = textBoxReceivedFromlabtime.Text.ToUpper();

                //bbParam.HRRStaffIssueByName = textBoxHrrStaffIssueName.Text.ToUpper();
                //bbParam.HRRStaffIssueAtTime = textBoxIssueTime.Text.ToUpper();
                //bbParam.SystemDeliveryTime = textBoxSystemTime.Text.ToUpper();
                //bbParam.DeliveryAtTime = textBoxDeliveryatTime.Text.ToUpper();


                int count = SqlBB.BBCallDetailsUpdate(bbParam, NO);
                //  
                if (count > 0)
                    MessageBox.Show("Record Update Successfully ");


            }

        }

        private void comboBoxPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatientName.SelectedIndex >= 0)
            {

                //comboBoxProductName.Text = "";

                //comboBoxProductModelName.Text = "";
                //comboBoxCustTrailModelTran.Text = "";
                //textBoxTrialConductBy.Text = "";
                //richTextBoxRemarks.Text = "";

                //       linkLabelBackInsert.Visible = true;
                string companyname = comboBoxPatientName.SelectedItem.ToString();
                // if add new item code
                if (companyname == "<New>")
                {
                    Insert_Patient_Details cv = new Insert_Patient_Details();
                    if (cv.ShowDialog() == DialogResult.OK)
                    {
                        FillPatientsName();
                    }
                }
                else if (companyname == "<Edit>")
                {
                    // call window

                    string type = "Patient";
                    Update_Delete_Insert_Patient_Details ED = new Update_Delete_Insert_Patient_Details(type);
                    if (ED.ShowDialog() == DialogResult.OK)
                    {
                        FillPatientsName();
                    }

                }// if edit

                else
                {
                    //linkLabelTrialRepoertByCustomer.Visible = true;
                    //linkLabelBack.Visible = true;
                    int index = comboBoxPatientName.SelectedIndex;
                    //get company id from index
                    string patientid = autoStringPatientID[index];

                    bbParam.ifNewPatient = false;
                    DataRow dr = SqlBB.PatientDetailByID(patientid);
                    if (dr != null)
                    {

                        textBoxP_MobileNo.Text = dr["MobileNo"].ToString().ToUpper();
                         textBoxP_Age.Text = dr["Age"].ToString().ToUpper();
                         comboBoxP_Sex.Text = dr["Sex"].ToString().ToUpper();
                         textBoxP_BlGroup.Text = dr["BLGroup"].ToString().ToUpper();

                         richTextBoxP_Address.Text = dr["Patient Address"].ToString().ToUpper();
                         textBoxP_City.Text = dr["City"].ToString().ToUpper();
                             


                    }//if


                }



            }

            else
            {
                bbParam.ifNewPatient = true;
            }
        }

        private void comboBoxComponentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxComponentName.SelectedIndex < 0) return;
                // get selected item
                string codename = comboBoxComponentName.SelectedItem.ToString();




                // if add new item code
                if (codename == "<New>")
                {
                    // add new item code
                    WindowsInputInsertBox ip = new WindowsInputInsertBox("Enter Blood Component ", " ", "Insert Component");
                    if (ip.ShowDialog() == DialogResult.OK)
                    {
                        string componentName = ip.Result1;
                        if (string.IsNullOrEmpty(componentName))
                        {
                            MessageBox.Show("Either Blood Component or  Component is empty", "Invalid  Blood Component input",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }// if empty
                        else
                        {
                            string componentID = "";
                            int rows = SqlBB.BloodComponentInsert(componentName, out componentID);
                            if (rows > 0)
                            {


                                MessageBox.Show("Blood Component inserted successfully");
                                lsComponentName.Add(componentName);
                                lsComponentId.Add(componentID);
                                //
                                autoStringComponentID.Add(componentID);
                                autoStringComponentName.Add(componentName);
                                //
                                comboBoxComponentName.Items.Add(componentName);
                                comboBoxComponentName.SelectedIndex = comboBoxComponentName.Items.Count - 1;
                            }
                            else
                                MessageBox.Show("Blood Component insertioan fail", "Invalid Blood Component",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }// if dialog ok
                    else
                        comboBoxComponentName.SelectedIndex = -1;



                }// if new
                // else if edit list
                else if (codename == "<Edit>")
                {
                    string type = "Blood Component";
                    ////// call window
                     Update_Delete_Insert_Patient_Details ED = new  Update_Delete_Insert_Patient_Details(type);
                     if (ED.ShowDialog() == DialogResult.OK)
                     {
                         FillBloodComponent();
                     }

                }// if edit



                else
                {

                }

            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxPatientName_Leave(object sender, EventArgs e)
        {
            if (comboBoxPatientName.SelectedIndex < 0)
            {
                //EnableCompanyControls();
                bbParam.ifNewPatient = true;
            }
            else
            {
                bbParam.ifNewPatient = false;
            }
        }

        private void textBoxDeliveryatTime_Leave(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(textBoxDeliveryatTime.Text))
            //{
            //}
            //else
            //{

            //    DateTime CallTime = DateTime.ParseExact(textBoxCallTime.Text, "HH:mm:ss",
            //                    CultureInfo.InvariantCulture);

            //    DateTime DeliveryAtTime = DateTime.ParseExact(textBoxDeliveryatTime.Text, "HH:mm:ss",
            //                    CultureInfo.InvariantCulture);

            //    TimeSpan ts = DeliveryAtTime.Subtract(CallTime);

            //    bbParam.DeliveryAtTime = textBoxDeliveryatTime.Text;

            //    //call time diffrence
            //    bbParam.CallClosingTime = ts.ToString();

            //}


        }

        private void buttonComponentqty_Click(object sender, EventArgs e)
        {
            if (comboBoxComponentName.SelectedIndex >= 0 && textBoxCompoQty.Text != "")
            {
                int index = comboBoxComponentName.SelectedIndex;
                string compoid = lsComponentId[index];

                BBParameter p = new BBParameter();


                // if already exist return
                if (bbParam.ComponentList.Exists(cmd => cmd.ComponentID == compoid)) return;

                p.ComponentName = comboBoxComponentName.Text;
                p.ComponentID = compoid.ToString();
                p.ComponentQuantity = double.Parse(textBoxCompoQty.Text.ToString());
                p.PendingQuantity = p.ComponentQuantity;
                // add to list
                bbParam.ComponentList.Add(p);
                FillComponentGrid();
                comboBoxComponentName.SelectedIndex = -1;
                textBoxCompoQty.Text = "";



            }
        }

        public void FillComponentGrid()
        {
            try
            {
                dataGridViewComponents.Rows.Clear();
                int i = 0;
                for (int j = 0; j < bbParam.ComponentList.Count; j++)
                {
                    BBParameter p = bbParam.ComponentList[j];

                    dataGridViewComponents.Rows.Add();

                    dataGridViewComponents[ColumnSrNo.Name, i].Value = i + 1;
                    dataGridViewComponents[ColumnComponentID.Name, i].Value = p.ComponentID;
                    dataGridViewComponents[ColumnComponentName.Name, i].Value = p.ComponentName;
                    dataGridViewComponents[ColumnQty.Name, i].Value = p.ComponentQuantity;
                    



 

                    i++;
                }


         


            }//try
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "=Fn:Fill product grids");
            }

        }

        private void dataGridViewComponents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isedit = false;
            string[] itmGrid = { ColumnQty.Name };

            switch (Array.IndexOf(itmGrid, dataGridViewComponents.Columns[e.ColumnIndex].Name))
            {
                case 0: // dataGridTextColQty
                    try
                    {
                        // get change quantity
                        double qty = double.Parse(dataGridViewComponents[e.ColumnIndex, e.RowIndex].Value.ToString());

                        // select item
                        BBParameter P = bbParam.ComponentList.Single(
                            cmd => cmd.ComponentID == dataGridViewComponents[ColumnComponentID.Name, e.RowIndex].Value.ToString());

                        // get index
                        int index = bbParam.ComponentList.IndexOf(P);


                        if (qty > P.ComponentQuantity)
                        {
                          
                            double newAddqty = qty - P.ComponentQuantity;
                            P.ComponentQuantity = qty;
                            P.PendingQuantity = P.PendingQuantity + newAddqty;
                        }
                        else if (qty < P.ComponentQuantity)
                        {
                            
                            double newLessQty = P.ComponentQuantity - qty;
                            P.ComponentQuantity = qty;
                            P.PendingQuantity = P.PendingQuantity - newLessQty;
                        }

                        else if (qty == 0)
                        {
                            P.ComponentQuantity = P.ComponentQuantity-P.PendingQuantity;
                            P.PendingQuantity = 0;
                        }
                        else
                        {
                            // set quantity
                            P.ComponentQuantity = qty;
                            P.PendingQuantity = P.ComponentQuantity;

                        }
                       
                        

                        // set item
                        bbParam.ComponentList[index] = P;

                        

                        isedit = true;
                    }
                    catch (InvalidCastException)
                    {
                        // select product
                        BBParameter P = bbParam.ComponentList.Single(
                            cmd => cmd.ComponentID == dataGridViewComponents[ColumnComponentID.Name, e.RowIndex].Value.ToString());

                        // set quantity
                        dataGridViewComponents[e.ColumnIndex, e.RowIndex].Value = P.ComponentQuantity;

                         

                       
                    }

                    break;

            }

        }


        private void FillControls(DataSet ds)
        {
            try
            {
                /*
                * get PO header details
                */
                DataTable CallDetails = ds.Tables["CallDetails"];
                if (CallDetails == null || CallDetails.Rows.Count <= 0)
                    throw new Exception("Exception at reading PO details");

                bbParam.CallStatus = CallDetails.Rows[0]["CallStatus"].ToString();
                bbParam.No = int.Parse(CallDetails.Rows[0]["No"].ToString());
                bbParam.CallTime = CallDetails.Rows[0]["CallTime"].ToString();
                bbParam.Date = CallDetails.Rows[0]["CallDate"].ToString();
                bbParam.ReceivedBy = CallDetails.Rows[0]["ReceivedBy"].ToString();

                bbParam.HospitalName = CallDetails.Rows[0]["HospitalName"].ToString();
                bbParam.Area = CallDetails.Rows[0]["Area"].ToString();

                comboBoxPatientName.Text = CallDetails.Rows[0]["Patient Name"].ToString();


                bbParam.WardNo = CallDetails.Rows[0]["WardNo"].ToString();
                bbParam.Diagnosis = CallDetails.Rows[0]["Diagnosis"].ToString();
                bbParam.Transfusion = CallDetails.Rows[0]["Transfusion"].ToString();
                bbParam.HB = CallDetails.Rows[0]["Hb"].ToString();

                bbParam.CalledBy = CallDetails.Rows[0]["CalledBy"].ToString();
                bbParam.CalledByName = CallDetails.Rows[0]["CalledByName"].ToString();
                bbParam.MobileNo = CallDetails.Rows[0]["MobileNo"].ToString();

                bbParam.CallType = CallDetails.Rows[0]["CallType"].ToString();





                DataTable dtComponentsDetail = ds.Tables["ComponentsDetails"];
                if (dtComponentsDetail == null || dtComponentsDetail.Rows.Count <= 0)
                    throw new Exception("Exception at reading PO details");

                // get products
                bbParam.ComponentList.Clear();

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
                    bbParam.ComponentList.Add(itm);

                }// foreach

                double compoQtytotal = bbParam.ComponentList.Sum(x => x.ComponentQuantity);
                double pendingtotal = bbParam.ComponentList.Sum(x => x.PendingQuantity);
                if (pendingtotal == 0)
                {
                    comboBoxCallStatus.Text = "CLS";
                }
                else if (pendingtotal < compoQtytotal)
                {
                    comboBoxCallStatus.Text = "INP";
                }
                else
                {
                    comboBoxCallStatus.Text = "OPN";
 
                }


                FillAlltext();
                FillComponentGrid();


            }// try
            catch (Exception ex)
            {
                throw ex;
            }

        }// FillPOParameters


        private void FillAlltext()
        {

           
             textBox1CallNo.Text=bbParam.No.ToString();
            textBoxCallTime.Text=bbParam.CallTime;


            textBoxCallDate.Text = bbParam.Date;
            textBoxReceivedBy.Text = bbParam.ReceivedBy;
            textBoxHospitalName.Text =bbParam.HospitalName;
            textBoxHospitalArea.Text = bbParam.Area;
            //textBoxPatientName.Text = dr["PatientName"].ToString();
            comboBoxCalledBy.Text = bbParam.CalledBy;
            textBoxCalledByName.Text = bbParam.CalledByName;
            textBoxMobileNo.Text = bbParam.MobileNo;
            textBoxWardNo.Text = bbParam.WardNo;
            textBoxCalltypeFor.Text = bbParam.CallType;


            textBoxDiagno.Text = bbParam.Diagnosis;
            textBoxTransfu.Text = bbParam.Transfusion;
            textBoxHb.Text = bbParam.HB;
        }

        private void buttonCompoRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewComponents.SelectedCells.Count > 0)
            {
                int rowindex = dataGridViewComponents.SelectedCells[0].RowIndex;
                bbParam.ComponentList.RemoveAt(rowindex);
                //invparam.Terms.PurchaseTaxes.RemoveAt(rowindex);
                dataGridViewComponents.Rows.RemoveAt(rowindex);
                 
            }
        }


        #region Validation of text 

        private void textBoxMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMobileNo.Text, "[^0-9]") || textBoxMobileNo.Text.Length > 10)
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxMobileNo.Text = textBoxMobileNo.Text.Remove(textBoxMobileNo.Text.Length - 1);
            }
        }

        private void textBoxP_MobileNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxP_MobileNo.Text, "[^0-9]") || textBoxP_MobileNo.Text.Length > 10)
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxP_MobileNo.Text = textBoxP_MobileNo.Text.Remove(textBoxP_MobileNo.Text.Length - 1);
            }
        }

        private void textBoxP_Age_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxP_Age.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxP_Age.Text = textBoxP_Age.Text.Remove(textBoxP_Age.Text.Length - 1);
            }
        }

        private void textBoxCompoQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCompoQty.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxCompoQty.Text = textBoxCompoQty.Text.Remove(textBoxCompoQty.Text.Length - 1);
            }
        }

        #endregion

       

        #region other coode

        //////ON Leave

    //     Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
    //if (pattern.IsMatch(myTextBox.Text))
    //{
    //    MessageBox.Show("OK");
    //}
    //else
    //{
    //    MessageBox.Show("Invalid phone number");
    //}

        #endregion
    }
}
