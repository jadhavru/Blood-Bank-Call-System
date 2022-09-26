using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BB
{
    public partial class Insert_Patient_Details : Form
    {

        BBParameter bbParam = new BBParameter();

        string PID = "";

        public Insert_Patient_Details()
        {
            InitializeComponent();
            buttonSave.Visible = true;
        }

        public Insert_Patient_Details(int patientID)
        {
            InitializeComponent();
            buttonUpdate.Visible = true;
            this.PID = patientID.ToString();

            DataRow dr = SqlBB.PatientDetailByID(PID);
            if (dr != null)
            {

                textBoxPatientName.Text = dr["Patient Name"].ToString().ToUpper();
                textBoxMobileNo.Text = dr["MobileNo"].ToString().ToUpper();
                textBoxP_Age.Text = dr["Age"].ToString().ToUpper();
                comboBoxP_Sex.Text = dr["Sex"].ToString().ToUpper();
                textBoxP_BlGroup.Text = dr["BLGroup"].ToString().ToUpper();

                richTextBoxP_Address.Text = dr["Patient Address"].ToString().ToUpper();
                textBoxP_City.Text = dr["City"].ToString().ToUpper();

            }


        }

        private void Insert_Patient_Details_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // save company details
                if (textBoxPatientName.Text == "")
                {
                    MessageBox.Show("Select Company Name");

                }//if

                else
                {
                    bbParam.P_Name = textBoxPatientName.Text.ToString().Trim();
                    bbParam.P_MobileNo = textBoxMobileNo.Text.ToString().Trim();
                    bbParam.P_Age = textBoxP_Age.Text.ToString().Trim();
                    bbParam.P_Sex =comboBoxP_Sex.Text.Trim();
                    bbParam.P_BL_Group = textBoxP_BlGroup.Text.Trim();

                    bbParam.P_Address = richTextBoxP_Address.Text.Trim();
                    bbParam.P_City = textBoxP_City.Text.Trim();

                    Hashtable compData = new Hashtable()
                   {
                       {"patient name",  bbParam.P_Name},
                                      
                       {"patient mobile", bbParam.P_MobileNo},
                                        
                       {"patient age",  bbParam.P_Age},
          
                       {"patient sex",  bbParam.P_Sex},

                       {"patient blgroup",  bbParam.P_BL_Group},

                       {"patient address",bbParam.P_Address},

                       {"patient city", bbParam.P_City},
                       
                      
                                                                              
                   };
                    // insert method
                    int custID = SqlBB.PatientInsert(compData);
                    if (custID >= 0)
                    {
                        MessageBox.Show("Information Inserted Successfully");
                        // Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

            }//try
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Insert company exception");
            }//catch
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // save company details
                if (textBoxPatientName.Text == "")
                {
                    MessageBox.Show("Select Company Name");

                }//if

                else
                {
                    bbParam.P_Name = textBoxPatientName.Text.ToString().Trim();
                    bbParam.P_MobileNo = textBoxMobileNo.Text.ToString().Trim();
                    bbParam.P_Age = textBoxP_Age.Text.ToString().Trim();
                    bbParam.P_Sex = comboBoxP_Sex.Text.Trim();
                    bbParam.P_BL_Group = textBoxP_BlGroup.Text.Trim();

                    bbParam.P_Address = richTextBoxP_Address.Text.Trim();
                    bbParam.P_City = textBoxP_City.Text.Trim();

                    Hashtable compData = new Hashtable()
                   {
                       {"patient name",  bbParam.P_Name},
                                      
                       {"patient mobile", bbParam.P_MobileNo},
                                        
                       {"patient age",  bbParam.P_Age},
          
                       {"patient sex",  bbParam.P_Sex},

                       {"patient blgroup",  bbParam.P_BL_Group},

                       {"patient address",bbParam.P_Address},

                       {"patient city", bbParam.P_City},
                       
                      
                                                                              
                   };


                    // insert method
                    int ID = SqlBB.PatientDetailsUpdate(compData, PID);
                    if (ID >= 0)
                    {
                        MessageBox.Show("Information Updated. Successfully");
                        // Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }

            }//try
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Insert company exception");
            }//catch
        }

        private void textBoxMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMobileNo.Text, "[^0-9]") || textBoxMobileNo.Text.Length > 10)
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxMobileNo.Text = textBoxMobileNo.Text.Remove(textBoxMobileNo.Text.Length - 1);
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
    }
}
