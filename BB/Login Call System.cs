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
    public partial class Login_Call_System : Form
    {
        public Login_Call_System()
        {
            InitializeComponent();
        }

        private void Login_Call_System_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
            textBoxUsername.Text = BB.Properties.UserLogin.Default.UserName;
            textBoxPassword.Text = BB.Properties.UserLogin.Default.Password;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxRemembr.Checked)
                {
                    BB.Properties.UserLogin.Default.UserName = textBoxUsername.Text;
                    BB.Properties.UserLogin.Default.Password = textBoxPassword.Text;
                    BB.Properties.UserLogin.Default.Save();
                }

                // if username is empty
                if (textBoxUsername.Text == "")
                {
                    textBoxUsername.Select(0, textBoxUsername.Text.Length);
                    errorProvider1.SetError(textBoxUsername, "Enter username");
                    return;
                }//check username

                // if password is empty
                else if (textBoxPassword.Text == "")
                {
                    textBoxPassword.Select(0, textBoxPassword.Text.Length);
                    errorProvider1.SetError(textBoxPassword, "Enter password");
                    return;
                }//check password






                // select all employees
                DataTable staffDataTable = SqlBB.StaffSelectAll();
                if (staffDataTable == null)
                    throw new Exception("Error at reading employee details");



                //// get matching employee details
                //var dataRowCollect = empDataTable.AsEnumerable().Select(cmd => cmd)
                //    .Where(cmd1 => cmd1["Username"].ToString().ToLower().Equals(textBoxUsername.Text.ToLower()) &&
                //        CryptographyManager.Decrypt(cmd1["PasswordHash"].ToString(), cmd1["PasswordSalt"].ToString())
                //            .Equals(textBoxPassword.Text.Trim().ToLower()));
                ///*SimpleHash.VerifyHash(txtPassword.Text, cmd1["PasswordHash"].ToString()));*/


                // get matching employee details
                var dataRowCollect = staffDataTable.AsEnumerable().Select(cmd => cmd)
                    .Where(cmd1 => cmd1["UserName"].ToString().ToLower().Equals(textBoxUsername.Text.ToLower()) &&
                        cmd1["Password"].ToString().ToLower().Equals(textBoxPassword.Text.ToLower()));
                /*SimpleHash.VerifyHash(txtPassword.Text, cmd1["PasswordHash"].ToString()));*/



                // if present
                if (dataRowCollect.Count() > 0)
                {
                    // get detail
                    DataRow dr = dataRowCollect.First();

                    BB.Properties.UserLogin.Default.StaffName = dr["StaffName"].ToString();
                    BB.Properties.UserLogin.Default.UserName = dr["UserName"].ToString();


                    //Settings.Default.EmployeeID = int.Parse(dr["PersonEntityID"].ToString());
                    //Settings.Default.EmplyeeName = dr["FullName"].ToString();
                    //Settings.Default.EmployeeDepartment = dr["DepartmentName"].ToString();
                    //Settings.Default.EmployeeDepartmentKey = dr["DepartmentKey"].ToString();
                    //Settings.Default.EmployeeEmail = dr["Email"].ToString();
                    //Settings.Default.EmployeePhone = dr["Phone"].ToString();
                    //Settings.Default.EmployeeDesignation = dr["JobTitle"].ToString();

                    //// change default password
                    //if (textBoxPassword.Text.ToLower().Equals("emp#123"))
                    //{
                    //    WindowChangePassword chpwd = new WindowChangePassword(Settings.Default.EmployeeID);
                    //    chpwd.ShowDialog();
                    //}

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid password or username", "Login fail",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ///this.DialogResult = DialogResult.Cancel;
                }//else



            }//try

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
