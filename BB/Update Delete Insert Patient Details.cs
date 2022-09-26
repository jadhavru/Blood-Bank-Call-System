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
    public partial class Update_Delete_Insert_Patient_Details : Form
    {
        string UpdateTypeIs = "";

        DataTable dc = new DataTable();

        public Update_Delete_Insert_Patient_Details()
        {
            InitializeComponent();
        }


        public Update_Delete_Insert_Patient_Details(string updateType)
        {
            InitializeComponent();
            this.UpdateTypeIs = updateType;
        }

        private void Update_Delete_Insert_Patient_Details_Load(object sender, EventArgs e)
        {
            if (UpdateTypeIs == "Patient")
            {
                labeltype.Text = "All Show Patient";

                dc = SqlBB.GetAllPatientDetailsForEDIT();
                if (dc == null)
                {
                    MessageBox.Show("Error at Reading Data Table");
                }
                FillGrid();

            }
            else if (UpdateTypeIs == "Blood Component")
            {
                labeltype.Text = "All Show Blood Component";

                dc = SqlBB.GetAllBloodComponentDetailsForEDIT();
                if (dc == null)
                {
                    MessageBox.Show("Error at Reading Data Table");
                }
                FillGrid();

            }
        }

        private void FillGrid()
        {
            dataGridView.DataSource = dc;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (UpdateTypeIs == "Patient")
            {

                Insert_Patient_Details cv = new Insert_Patient_Details();
                if (cv.ShowDialog() == DialogResult.OK)
                {
                    RefreshAll();
                }

            }
            else if (UpdateTypeIs == "Blood Component")
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
                            RefreshAll();
 
                        }
                        else
                            MessageBox.Show("Blood Component insertioan fail", "Invalid Blood Component",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }// if dialog ok
                



            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (UpdateTypeIs == "Patient")
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridView.SelectedRows[0];
                    dataGridView.SelectedRows[0].Selected = false;

                    int id = int.Parse(dr.Cells["PatientID"].Value.ToString());
                    // delete
                    int rows = SqlBB.DetailsDelete(id, UpdateTypeIs);

                    if (rows > 0)
                    {
                        MessageBox.Show(" Patient Details Deleted Successfully ");
                        RefreshAll();
                    }

                }//

            }
            else if (UpdateTypeIs == "Blood Component")
            {

                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridView.SelectedRows[0];
                    dataGridView.SelectedRows[0].Selected = false;

                    int id = int.Parse(dr.Cells["BBComponentID"].Value.ToString());
                    // delete
                    int rows = SqlBB.DetailsDelete(id, UpdateTypeIs);

                    if (rows > 0)
                    {
                        MessageBox.Show(" Component Details Deleted Successfully ");
                        RefreshAll();
                    }

                }//

            }

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UpdateTypeIs == "Patient")
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridView.SelectedRows[0];
                    dataGridView.SelectedRows[0].Selected = false;

                    // get selected sale id
                    int Patientid = int.Parse(dr.Cells["PatientID"].Value.ToString());
                    // string PreCat = dr.Cells["CategoryName"].Value.ToString();

                    Insert_Patient_Details cv = new Insert_Patient_Details(Patientid);
                    if (cv.ShowDialog() == DialogResult.OK)
                    {

                        MessageBox.Show("Patient Details Updated successfully");
                        RefreshAll();

                    }
                }

            }
            else if (UpdateTypeIs == "Blood Component")
            {

                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGridView.SelectedRows[0];
                    dataGridView.SelectedRows[0].Selected = false;

                    // get selected sale id
                    int id = int.Parse(dr.Cells["BBComponentID"].Value.ToString());
                    string ComponentName = dr.Cells["Component Name"].Value.ToString();

                    WindowsInputInsertBox ip = new WindowsInputInsertBox("Update Blood Component ", ComponentName, "Update Blood Component Name");
                    if (ip.ShowDialog() == DialogResult.OK)
                    {
                        string NewComponentName = ip.Result1;


                        if (string.IsNullOrEmpty(NewComponentName))
                        {
                            MessageBox.Show("Blood Component is empty", "Invalid Model input",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }// if empty
                        else
                        {
                            int rows = SqlBB.BloodComponentNameUpdate(NewComponentName, id);
                            if (rows > 0)
                            {
                                MessageBox.Show("Blood Component Updated successfully");
                                RefreshAll();
                            }
                            else
                                MessageBox.Show(" Blood Component Updation fail", "Invalid Cate ",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }// if dialog ok
                    
                }

            }
        }


        private void RefreshAll()
        {
            if (UpdateTypeIs == "Patient")
            {
                labeltype.Text = "All Show Patient";

                dc = SqlBB.GetAllPatientDetailsForEDIT();
                if (dc == null)
                {
                    MessageBox.Show("Error at Reading Data Table");
                }
                FillGrid();

            }
            else if (UpdateTypeIs == "Blood Component")
            {
                labeltype.Text = "All Show Blood Component";

                dc = SqlBB.GetAllBloodComponentDetailsForEDIT();
                if (dc == null)
                {
                    MessageBox.Show("Error at Reading Data Table");
                }
                FillGrid();

            }
        }

    }
}
