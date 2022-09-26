using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BB.Properties;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;

namespace BB
{
    class SqlBB
    {

        public static void SelectPatientName(List<string> patientNames, List<string> patientId)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //cmd.Connection = sqlconn;
                        cmd.CommandText = " Select PatientID,[Patient Name] From " + MySqlSettings.Default.Patient_Master + " ";

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            patientNames.Add(dr["Patient Name"].ToString());
                            patientId.Add(dr["PatientID"].ToString());
                        }
                    }// using command

                }// using connection
            }// end try
            catch (SqlException)
            {

            }
            finally
            {

            }



        }

        public static void SelectComponentName(List<string> componentNames, List<string> componentId)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //cmd.Connection = sqlconn;
                        cmd.CommandText = " Select BBComponentID,[Component Name] From " + MySqlSettings.Default.BB_Component + " ";

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            componentNames.Add(dr["Component Name"].ToString());
                            componentId.Add(dr["BBComponentID"].ToString());
                        }
                    }// using command

                }// using connection
            }// end try
            catch (SqlException)
            {

            }
            finally
            {

            }



        }

        public static void GetHospitalName(List<string> HospitalName)
        {
            try
            {
                HospitalName.Clear();

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //cmd.Connection = con;
                        cmd.CommandText = "SELECT DISTINCT [HospitalName] " +
                            "FROM " + MySqlSettings.Default.BBCallDetails;

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            HospitalName.Add(dr["HospitalName"].ToString().Trim());

                        }

                    }// using command
                }// using connection 
            }// end try            
            catch (Exception)
            { }
        }// 

        public static void GetReceivedBy(List<string> ReceivedBy)
        {
            try
            {
                ReceivedBy.Clear();

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //cmd.Connection = con;
                        cmd.CommandText = "SELECT DISTINCT [ReceivedBy] " +
                            "FROM " + MySqlSettings.Default.BBCallDetails;

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            ReceivedBy.Add(dr["ReceivedBy"].ToString().Trim());

                        }

                    }// using command
                }// using connection 
            }// end try            
            catch (Exception)
            { }
        }// 

        public static void GetCallTypeFory(List<string> CallTypeFor)
        {
            try
            {
                CallTypeFor.Clear();

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //cmd.Connection = con;
                        cmd.CommandText = "SELECT DISTINCT [CallType] " +
                            "FROM " + MySqlSettings.Default.BBCallDetails;

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            CallTypeFor.Add(dr["CallType"].ToString().Trim());

                        }

                    }// using command
                }// using connection 
            }// end try            
            catch (Exception)
            { }
        }// 


        public static DataRow PatientDetailByID(string patientid)
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT  *  FROM " + MySqlSettings.Default.Patient_Master +
                            "WHERE PatientID = " + patientid;





                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt.Rows[0];
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// CompanyDetailsShortById


        public static int PatientDetailsUpdate(Hashtable compData, string PatientID)
        {
            int rows = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        using (SqlCommand command = conn.CreateCommand())
                        {
                            command.Parameters.Clear();
                            command.CommandText =
                                "UPDATE " + MySqlSettings.Default.Patient_Master +
                                " SET  [Patient Name]=@pname,[Age]=@age ,[Sex]=@sex ,[BLGroup]=@blgroup ,[MobileNo]=@mobileno,[Patient Address]=@address ,[City]=@city  " +
                                " WHERE PatientID= @id ";
                            command.Parameters.AddWithValue("@id", PatientID);
                            command.Parameters.AddWithValue("@pname", compData["patient name"].ToString().Trim());
                            command.Parameters.AddWithValue("@age", compData["patient age"].ToString().Trim());

                            command.Parameters.AddWithValue("@sex", compData["patient sex"].ToString());
                            command.Parameters.AddWithValue("@blgroup", compData["patient blgroup"].ToString());


                            command.Parameters.AddWithValue("@mobileno", compData["patient mobile"].ToString());
                            command.Parameters.AddWithValue("@address", compData["patient address"].ToString());
                            command.Parameters.AddWithValue("@city", compData["patient city"].ToString());
                            // execute query
                            rows = command.ExecuteNonQuery();



                        }
                    }
                }
                return rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Customer Details Exception");
                throw ex;
                //return -1;
            }
        }// CustomerInsert

        public static int BloodComponentNameUpdate(string NewComponentName, int id)
        {
            int rows = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    // open new connection
                    conn.Open();

                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText =
                            "UPDATE " + MySqlSettings.Default.BB_Component +
                            " SET [Component Name] = @name " +
                            " WHERE BBComponentID= @id   ";

                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", NewComponentName);



                        // execute query
                        rows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return rows;
        }


        public static int PatientInsert(Hashtable patientData)
        {
            int rows = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.Parameters.Clear();

                        string custID = SqlBB.PatientInsert(cmd, patientData);

                        if (string.IsNullOrEmpty(custID))
                            throw new Exception("Insert Patient Details fail");
                    }
                }
                return rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Customer Details Exception");
                throw ex;
                //return -1;
            }
        }// CustomerInsert
        public static string PatientInsert(SqlCommand cmd, Hashtable data)
        {
            string compid = string.Empty;
            // query
            try
            {
                string patientName = data["patient name"].ToString();


                // clear all parameters
                cmd.Parameters.Clear();

                // get new company id
                int srNO = GetPatientNewId();
                if (srNO < 0) throw new Exception("Get new patient id fail");

                compid = srNO.ToString();


                cmd.CommandText = "INSERT INTO " + MySqlSettings.Default.Patient_Master +
                                    "( [PatientID],[Patient Name] ,[Age],[Sex],[BLGroup] ,[MobileNo],[Patient Address],[City])" +
                                             "VALUES(@id,@patientname,@age,@sex,@blgroup,@mobileno,@address,@city )";






                cmd.Parameters.AddWithValue("@id", srNO);

                cmd.Parameters.AddWithValue("@patientname", data["patient name"].ToString().Trim());
                cmd.Parameters.AddWithValue("@age", data["patient age"].ToString().Trim());

                cmd.Parameters.AddWithValue("@sex", data["patient sex"].ToString());
                cmd.Parameters.AddWithValue("@blgroup", data["patient blgroup"].ToString());

                cmd.Parameters.AddWithValue("@mobileno", data["patient mobile"].ToString());
                cmd.Parameters.AddWithValue("@address", data["patient address"].ToString());
                cmd.Parameters.AddWithValue("@city", data["patient city"].ToString());


                // execute query
                int rows = cmd.ExecuteNonQuery();
                if (rows < 0)
                    throw new Exception("Insert customer fail");

                return compid;
            }// try
            catch (Exception ex)
            {
                compid = string.Empty;

                MessageBox.Show(ex.Message, "Insert company Exception");
                throw ex;
                //return -1;
            }
        }//insert customer details
        private static int GetPatientNewId()
        {
            int count = -1;

            if (count > 0) return count;

            // query
            try
            {
                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //cmd.Connection = con;
                        cmd.CommandText = "SELECT TOP(1) [PatientID] FROM " + MySqlSettings.Default.Patient_Master +
                            " ORDER BY [PatientID] DESC";

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        if (dt.Rows.Count == 0) return 101;

                        // get id
                        int val = int.Parse(dt.Rows[0][0].ToString());
                        count = val + 1;
                    }// using command

                }// using connection
            }// end try
            catch (SqlException)
            { count = -1; }
            catch (Exception)
            { count = -1; }

            return count;
        }


        public static int BloodComponentInsert(string componentName, out string componentID)
        {
            int rows = -1;
            int newcompoID = GetComponentID();
            string ComponentID = newcompoID.ToString();
            componentID = ComponentID;
            try
            {

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {

                    // open new connection
                    conn.Open();

                    using (SqlCommand command = conn.CreateCommand())
                    {

                        // insert command text
                        command.CommandText =
                            "INSERT INTO " + MySqlSettings.Default.BB_Component +
                            " ([BBComponentID],[Component Name]) " +
                            "VALUES (@id, @name)";

                        // add parameters
                        command.Parameters.AddWithValue("@id", ComponentID);
                        command.Parameters.AddWithValue("@name", componentName);


                        // execute query
                        rows = command.ExecuteNonQuery();
                        // Attempt to commit the transaction.

                    }

                }// using sql conn
                return rows;
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                componentID = ComponentID;
            }
        }
        public static int GetComponentID()
        {
            int count = -1;
            if (count > 0) return count;
            try
            {
                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT TOP (1) [BBComponentID] FROM " + MySqlSettings.Default.BB_Component +
                            " ORDER BY BBComponentID DESC ";

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        if (dt.Rows.Count == 0) return 1;

                        // get id
                        int val = int.Parse(dt.Rows[0][0].ToString());
                        count = val + 1;
                        return count;
                    }

                }// using connection                

            }// end try
            catch (SqlException)
            { return -1; }
            catch (Exception)
            { return -1; }

        }



        public static DataTable GetAllPatientDetailsForEDIT()
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT  *  FROM " + MySqlSettings.Default.Patient_Master + " ";







                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// CompanyDetailsShortById


        public static DataTable GetAllBloodComponentDetailsForEDIT()
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT  *  FROM " + MySqlSettings.Default.BB_Component + " ";








                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// CompanyDetailsShortById


        public static int DetailsDelete(int ID, string type)
        {
            int rows = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();

                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.Parameters.Clear();

                        if (type == "Patient")
                        {
                            command.Parameters.Clear();
                            command.CommandText = "DELETE FROM " + MySqlSettings.Default.Patient_Master +
                                     " WHERE [PatientID] = " + ID;

                            rows = command.ExecuteNonQuery();
                        }
                        else if (type == "Blood Component")
                        {

                            command.Parameters.Clear();
                            command.CommandText = "DELETE FROM " + MySqlSettings.Default.BB_Component +
                                     " WHERE [BBComponentID] = " + ID;

                            rows = command.ExecuteNonQuery();
                        }


                    }//try

                }// using sql conn

                return rows;
            }// try
            catch (Exception ex)
            {
                rows = -1;
                MessageBox.Show(ex.Message, "Delete Category Exception");
                return -1;
            }
        } //Category Delete


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetBBIdNew()
        {
            int currentBBID = -1;


            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT TOP(1) [No] FROM " + MySqlSettings.Default.BBCallDetails +
                            " ORDER BY [No] DESC";

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        if (dt != null)
                        {

                            if (dt.Rows.Count == 0) //1st entry in new finantial year.
                            {
                                currentBBID = int.Parse("0001");
                            }
                            else
                            {
                                int val = int.Parse(dt.Rows[0][0].ToString());
                                currentBBID = val + 1;
                            }
                        }
                        else
                        {
                            currentBBID = -1;
                        }

                        return currentBBID;










                    }// using command

                }// using connection
            }// end try
            catch (SqlException)
            { currentBBID = -1; }
            catch (Exception)
            { currentBBID = -1; }

            return currentBBID;
        }// GetPOIdNew

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetBagIssueIdNew()
        {
            int currentBIssueID = -1;


            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT TOP(1) [BagIssueID] FROM " + MySqlSettings.Default.BagIssue_Header +
                            " ORDER BY [BagIssueID] DESC";

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        if (dt != null)
                        {

                            if (dt.Rows.Count == 0) //1st entry in new finantial year.
                            {
                                currentBIssueID = int.Parse("1001");
                            }
                            else
                            {
                                int val = int.Parse(dt.Rows[0][0].ToString());
                                currentBIssueID = val + 1;
                            }
                        }
                        else
                        {
                            currentBIssueID = -1;
                        }

                        return currentBIssueID;










                    }// using command

                }// using connection
            }// end try
            catch (SqlException)
            { currentBIssueID = -1; }
            catch (Exception)
            { currentBIssueID = -1; }

            return currentBIssueID;
        }// GetPOIdNew



        public static int BBCallDetailsInsert(BBParameter BBCall)
        {
            int rows = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        // Start a local transaction.
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            command.Connection = conn;
                            command.Transaction = transaction;
                            try
                            {

                                // add if company is new
                                if (BBCall.ifNewPatient)
                                {
                                    Hashtable compData = new Hashtable()
                                       {
                                          {"patient name",  BBCall.P_Name},
                                      
                                          {"patient mobile", BBCall.P_MobileNo},
                                        
                                          {"patient age",  BBCall.P_Age},
          
                                          {"patient sex",  BBCall.P_Sex},

                                          {"patient blgroup",  BBCall.P_BL_Group},

                                          {"patient address",BBCall.P_Address},

                                          {"patient city", BBCall.P_City},

                                       
                                                                                                  
                                       };
                                    // insert method
                                    string pid = SqlBB.PatientInsert(command, compData);
                                    if (string.IsNullOrEmpty(pid))
                                        throw new Exception();
                                    //get id
                                    BBCall.PatientID = pid.ToString();

                                }// if new




                                command.Parameters.Clear();
                                command.CommandText = "INSERT INTO " + MySqlSettings.Default.BBCallDetails +
                                "( [CallStatus],[No] " +
    " ,[PatientID] " +

    " ,[CallTime] " +
    " ,[CallDate] " +
    " ,[ReceivedBy] " +
    " ,[HospitalName] " +
    " ,[Area] " +
    " ,[CalledBy] " +
    " ,[CalledByName] " +
    " ,[MobileNo] " +
    " ,[WardNo] " +
    " ,[Diagnosis] " +
    " ,[Transfusion] " +
    " ,[Hb]" +
    " ,[CallType],[CallAddedBy] ) " +
    " VALUES (@callstatus, @no, @pid,@time,@date,@rec,@hosp,@area,@callby,@callbyname,@mob,@ward,@diagno,@transfu,@hb,@calltype,@calladdedby)";
                                //" @collectstaffname,@collecttime,@receivedfromlabtime,@issuestaffname,@issuetime,@deliverysystemtime,@hospdeliverytime)";


                                command.Parameters.AddWithValue("@callstatus", BBCall.CallStatus);
                                command.Parameters.AddWithValue("@no", BBCall.No);
                                command.Parameters.AddWithValue("@pid", BBCall.PatientID);
 

                                //command.Parameters.AddWithValue("@cid", BBCall.ComponentID);

                                command.Parameters.AddWithValue("@time", BBCall.CallTime);

                                command.Parameters.AddWithValue("@date", BBCall.Date);

                                command.Parameters.AddWithValue("@rec", BBCall.ReceivedBy);

                                command.Parameters.AddWithValue("@hosp", BBCall.HospitalName);
                                command.Parameters.AddWithValue("@area", BBCall.Area);

                                
                                command.Parameters.AddWithValue("@callby", BBCall.CalledBy);
                                command.Parameters.AddWithValue("@callbyname", BBCall.CalledByName);
                                command.Parameters.AddWithValue("@mob", BBCall.MobileNo);
                                command.Parameters.AddWithValue("@ward", BBCall.WardNo);
                                command.Parameters.AddWithValue("@calltype", BBCall.CallType);

                                command.Parameters.AddWithValue("@diagno", BBCall.Diagnosis);
                                command.Parameters.AddWithValue("@transfu", BBCall.Transfusion);

                                command.Parameters.AddWithValue("@hb", BBCall.HB);
                                command.Parameters.AddWithValue("@calladdedby", BB.Properties.UserLogin.Default.StaffName);


                                //" ,[HRR Staff Collect By Name] " +
                                //" ,[HRR Staff Collect At Time] " +
                                //" ,[Received From Lab Time] " +
                                //" ,[HRR Staff Issue By Name] " +
                                //" ,[HRR Staff Issue At Time] " + 
                                //" ,[System Time] " +
                                //" ,[Hospital Delivery At Time] ) " +

                                //command.Parameters.AddWithValue("@collectstaffname", BBCall.HRRStaffCollectByName);
                                //command.Parameters.AddWithValue("@collecttime", BBCall.HRRStaffCollectAtTime);

                                //command.Parameters.AddWithValue("@receivedfromlabtime", BBCall.ReceivedFromLabTime);


                                //command.Parameters.AddWithValue("@issuestaffname", BBCall.HRRStaffIssueByName);
                                //command.Parameters.AddWithValue("@issuetime", BBCall.HRRStaffIssueAtTime);

                                //command.Parameters.AddWithValue("@deliverysystemtime", BBCall.SystemDeliveryTime);

                                //command.Parameters.AddWithValue("@hospdeliverytime", BBCall.DeliveryAtTime);


                                



                                // command.Parameters.AddWithValue("@department", (int)TrialParam.departmentType);


                                rows = command.ExecuteNonQuery();
                                if (rows < 0)
                                    throw new Exception("Insert fail");


                                // add Components Details details
                                foreach (BBParameter itm in BBCall.ComponentList)
                                {
                                    rows = ComponentDetailInsert(command, itm,BBCall.No);
                                    if (rows < 0) throw new Exception();
                                }






                                // Attempt to commit the transaction.
                                transaction.Commit();
                                Console.WriteLine("records are written to database.");
                            }//try
                            catch (Exception ex)
                            {
                                //rows = -1;

                                //Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                                //Console.WriteLine("  Message: {0}", ex.Message);
                                MessageBox.Show(ex.Message, "Insert BBCALL Commit Exception");

                                // Attempt to roll back the transaction. 
                                try
                                {
                                    transaction.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    // This catch block will handle any errors that may have occurred 
                                    // on the server that would cause the rollback to fail, such as 
                                    // a closed connection.
                                    //Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                    //Console.WriteLine("  Message: {0}", ex2.Message);
                                    MessageBox.Show(ex2.Message, "Insert BBCALL Rollback Exception");
                                }//
                            }//catch
                        }// using trans
                    }// using cmd
                }// using sql conn
                return rows;
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Exception");
                return -1;
            }

        }// TrialParameterInsert  



        private static int ComponentDetailInsert(SqlCommand command, BBParameter itm,int callno)
        {
            int rows = -1;

            try
            {

                

                command.Parameters.Clear();

                command.CommandText = "INSERT INTO " + MySqlSettings.Default.Component_Details +
                    " ([no],[BBComponentID] ,[OrderQty], [PendingQty] )" +
                        
                    "VALUES (@no, @compoid, @ordqty, @pendingqty )";

                command.Parameters.AddWithValue("@no", callno);
                command.Parameters.AddWithValue("@compoid", itm.ComponentID);
                command.Parameters.AddWithValue("@ordqty", itm.ComponentQuantity);
                command.Parameters.AddWithValue("@pendingqty", itm.PendingQuantity);
                 

 

                rows = command.ExecuteNonQuery();
                if (rows < 0)
                    throw new Exception();

                return rows;
            }// try
            catch (Exception ex)
            {
                rows = -1;
                MessageBox.Show(ex.Message, "Insert Component Detail Exception");
                throw ex;
                //return -1;
            }
        }// PODetailInsert


        public static int BBCallDetailsUpdate(BBParameter BBCall, int CallNo)
        {
            int rows = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        // Start a local transaction.
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            command.Connection = conn;
                            command.Transaction = transaction;
                            try
                            {



                                command.Parameters.Clear();
                                command.CommandText = "UPDATE " + MySqlSettings.Default.BBCallDetails +
                                "SET  [PatientID]=@pid ,[CallStatus]=@callstatus" +
     //" ,[ComponentID] =@cid " +
     " ,[CallTime] =@time " +
     " ,[CallDate] =@date " +
     " ,[ReceivedBy] =@rec " +
     " ,[HospitalName] =@hosp " +
     " ,[Area] =@area " +
     " ,[CalledBy] =@callby " +
     " ,[CalledByName] =@callbyname " +
     " ,[MobileNo] =@mob " +
     " ,[WardNo] =@ward " +
     " ,[Diagnosis] =@diagno " +
     " ,[Transfusion] =@transfu " +
     " ,[Hb] =@hb " +
     " ,[CallType] =@calltype " +
                        " where No= " + CallNo;






                                //command.Parameters.AddWithValue("@no", BBCall.No);
                                command.Parameters.AddWithValue("@pid", BBCall.PatientID);
                                //command.Parameters.AddWithValue("@cid", BBCall.ComponentID);
                                command.Parameters.AddWithValue("@callstatus", BBCall.CallStatus);
                                command.Parameters.AddWithValue("@time", BBCall.CallTime);

                                command.Parameters.AddWithValue("@date", BBCall.Date);

                                command.Parameters.AddWithValue("@rec", BBCall.ReceivedBy);

                                command.Parameters.AddWithValue("@hosp", BBCall.HospitalName);
                                command.Parameters.AddWithValue("@area", BBCall.Area);


                                command.Parameters.AddWithValue("@callby", BBCall.CalledBy);
                                command.Parameters.AddWithValue("@callbyname", BBCall.CalledByName);
                                command.Parameters.AddWithValue("@mob", BBCall.MobileNo);
                                command.Parameters.AddWithValue("@ward", BBCall.WardNo);
                                command.Parameters.AddWithValue("@calltype", BBCall.CallType);

                                command.Parameters.AddWithValue("@diagno", BBCall.Diagnosis);
                                command.Parameters.AddWithValue("@transfu", BBCall.Transfusion);

                                command.Parameters.AddWithValue("@hb", BBCall.HB);



                                command.Parameters.AddWithValue("@collectstaffname", BBCall.HRRStaffCollectByName);
                                command.Parameters.AddWithValue("@collecttime", BBCall.HRRStaffCollectAtTime);

                                command.Parameters.AddWithValue("@receivedfromlabtime", BBCall.ReceivedFromLabTime);
                                

                                command.Parameters.AddWithValue("@issuestaffname", BBCall.HRRStaffIssueByName);
                                command.Parameters.AddWithValue("@issuetime", BBCall.HRRStaffIssueAtTime);

                                command.Parameters.AddWithValue("@deliverysystemtime", BBCall.SystemDeliveryTime);

                                command.Parameters.AddWithValue("@hospdeliverytime", BBCall.DeliveryAtTime);

                                command.Parameters.AddWithValue("@callclosetime", BBCall.CallClosingTime);

                               





                                rows = command.ExecuteNonQuery();
                                if (rows < 0)
                                    throw new Exception("Insert fail");


                                // Update Components Details details
                                foreach (BBParameter itm in BBCall.ComponentList)
                                {
                                    rows = ComponentDetailUpdate(command, itm, BBCall.No);
                                    if (rows < 0) throw new Exception();
                                }



                                // Attempt to commit the transaction.
                                transaction.Commit();
                                Console.WriteLine("records are written to database.");
                            }//try
                            catch (Exception ex)
                            {
                                //rows = -1;

                                //Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                                //Console.WriteLine("  Message: {0}", ex.Message);
                                MessageBox.Show(ex.Message, "Insert MOM Commit Exception");

                                // Attempt to roll back the transaction. 
                                try
                                {
                                    transaction.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    // This catch block will handle any errors that may have occurred 
                                    // on the server that would cause the rollback to fail, such as 
                                    // a closed connection.
                                    //Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                    //Console.WriteLine("  Message: {0}", ex2.Message);
                                    MessageBox.Show(ex2.Message, "Insert MOM Rollback Exception");
                                }//
                            }//catch
                        }// using trans
                    }// using cmd
                }// using sql conn
                return rows;
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Exception");
                return -1;
            }

        }// MOM Update   


        private static int ComponentDetailUpdate(SqlCommand command, BBParameter itm, int callno)
        {
            int rows = -1;

            try
            {



                command.Parameters.Clear();

                command.CommandText = "UPDATE " + MySqlSettings.Default.Component_Details +
                    "  SET  [OrderQty]=@ordqty ,[PendingQty]=@pendingqty where No=@no and BBComponentID=@compoid ";

                    

                command.Parameters.AddWithValue("@no", callno);
                command.Parameters.AddWithValue("@compoid", itm.ComponentID);
                command.Parameters.AddWithValue("@ordqty", itm.ComponentQuantity);
                command.Parameters.AddWithValue("@pendingqty", itm.PendingQuantity);




                rows = command.ExecuteNonQuery();
                if (rows < 0)
                    throw new Exception();

                return rows;
            }// try
            catch (Exception ex)
            {
                rows = -1;
                MessageBox.Show(ex.Message, "Insert Component Detail Exception");
                throw ex;
                //return -1;
            }
        }// PODetailInsert

        public static DataRow GetBBCallDetailsByNo(int BBCallNo)
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText =  cmd.CommandText = "SELECT bbcall.[No] " +
      " ,bbcall.[PatientID] " +
       " ,pm.[Patient Name] " +
      " ,bbcall.[ComponentID] " +
       " ,bbcom.[Component Name] " +
      " ,bbcall.[CallTime] " +
      " ,bbcall.[CallDate] " +
      " ,bbcall.[ReceivedBy] " +
      " ,bbcall.[HospitalName] " +
      " ,bbcall.[Area] " +
      " ,bbcall.[CalledBy] " +
      " ,bbcall.[CalledByName] " +
      " ,bbcall.[MobileNo] " +
      " ,bbcall.[WardNo] " +
      " ,bbcall.[Diagnosis] " +
      " ,bbcall.[Transfusion] " +
      " ,bbcall.[Hb] " +
      " ,bbcall.[CallType] " +
      " ,bbcall.[HRR Staff Collect By Name] " +
      " ,bbcall.[HRR Staff Collect At Time] " +
      ",bbcall.[Received From Lab Time]" +
      " ,bbcall.[HRR Staff Issue By Name] " +
      " ,bbcall.[HRR Staff Issue At Time] " +
      " ,bbcall.[Hospital Delivery At Time] " +
      " ,bbcall.[System Time],bbcall.[Call Closing Time] From " + MySqlSettings.Default.BBCallDetails + " bbcall INNER JOIN " + MySqlSettings.Default.Patient_Master + "  pm on bbcall.PatientID= pm.PatientID " +
      "INNER JOIN "+MySqlSettings.Default.BB_Component+" bbcom on bbcall.ComponentID=bbcom.BBComponentID   where [No] = " + BBCallNo;







                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt.Rows[0];
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }//  MOM Deletais by ID


        public static DataTable SelectAllBBCallDetails()
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT bbcall.[CallStatus],bbcall.[No] " +
      " ,bbcall.[PatientID] " +
       " ,pm.[Patient Name] " +
      //" ,bbcall.[ComponentID] " +
      // " ,bbcom.[Component Name] " +
      " ,bbcall.[CallTime] " +
      " ,bbcall.[CallDate] " +
      " ,bbcall.[ReceivedBy] " +
      " ,bbcall.[HospitalName] " +
      " ,bbcall.[Area] " +
      " ,bbcall.[CalledBy] " +
      " ,bbcall.[CalledByName] " +
      " ,bbcall.[MobileNo] " +
      " ,bbcall.[WardNo] " +
      " ,bbcall.[Diagnosis] " +
      " ,bbcall.[Transfusion] " +
      " ,bbcall.[Hb] " +
      " ,bbcall.[CallType] " +
       " ,bbcall.[CallAddedBy] " +
      //" ,bbcall.[HRR Staff Collect By Name] " +
      //" ,bbcall.[HRR Staff Collect At Time] " +
      //" ,bbcall.[Received From Lab Time]" +
      //" ,bbcall.[HRR Staff Issue By Name] " +
      //" ,bbcall.[HRR Staff Issue At Time] " +
      //" ,bbcall.[Hospital Delivery At Time] " +
      //" ,bbcall.[System Time],bbcall.[Call Closing Time] " +
                        " From " + MySqlSettings.Default.BBCallDetails + " bbcall INNER JOIN " + MySqlSettings.Default.Patient_Master + "  pm on bbcall.PatientID= pm.PatientID " +
      //"INNER JOIN "+MySqlSettings.Default.BB_Component+" bbcom on bbcall.ComponentID=bbcom.BBComponentID " +
      " order by No desc ";



                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// 



        public static void ExportToExel(DataGridView dgv)
        {
            // Creating a Excel object. 
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //Microsoft.Office.Interop.Excel.Range rngTableHeading = excel.get_Range("A1", "IV2");
            //rngTableHeading.Font.Name = "Calibri";
            //rngTableHeading.Font.Size = "12";
            //rngTableHeading.Font.Bold = true;
            //rngTableHeading.Interior.ColorIndex = 36;
            //rngTableHeading.Rows.AutoFit();


            try
            {
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";
                int cellRowIndex = 1;
                int cellColumnIndex = 1;


                Microsoft.Office.Interop.Excel.Range range = worksheet.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range;
                range.EntireRow.Font.Name = "Cambria";
                range.EntireRow.Font.Bold = true;
                range.EntireRow.Font.Size = 12;
                range.EntireRow.Font.Underline = 5;





                //Loop through each row and read value from each column. 
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Columns[j].HeaderText;
                        //cellRowIndex++;
                        //worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridChallan.Rows[i].Cells[j].Value.ToString();



                    }
                    cellColumnIndex++;
                }
                cellRowIndex = 2;
                cellColumnIndex = 1;
                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Rows[i].Cells[j].Value.ToString();

                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files(*.xls)|*.xls";//|All files (*.*)|*.*";
                //saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //workbook.SaveAs(saveDialog.FileName);
                    workbook.SaveAs(saveDialog.FileName, Type.Missing, Type.Missing, Type.Missing, ReadOnlyAttribute.No, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    //ToCsV(dgv, saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                    excel.Quit();
                    workbook = null;
                    excel = null;
                    //MainDispForm parent = (MainDispForm)Application.OpenForms["MainDispForm"];
                    //this.Close();
                    //parent.pdel.Invoke("close", parent);

                }
                else
                {
                    excel.Quit();
                    workbook = null;
                    excel = null;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
                MessageBox.Show("StackTrace", ex.StackTrace);
                MessageBox.Show("InnerException", ex.InnerException.Message);
                MessageBox.Show("Source", ex.Source);
                throw ex;

            }
            Cursor.Current = Cursors.Default;
        }

        public static DataTable SelectAllComponentDetailsByCallNo(int callno)
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT cd.[No] ,cd.[BBComponentID] ,bbcom.[Component Name],cd.[OrderQty] ,cd.[PendingQty] from" + MySqlSettings.Default.Component_Details + " cd " +
                            " inner join " + MySqlSettings.Default.BB_Component + " bbcom on cd.BBComponentID=bbcom.BBComponentID where No =" + callno;


                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// 


        /// <summary>
        /// PO Select Single
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="isFinal"></param>
        /// <returns></returns>
        public static DataSet CallSelectSingle(int CallNo)
        {
            try
            {
                DataSet ds = new DataSet();

                SqlDataAdapter adapt = new SqlDataAdapter();

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            /*select PO header*/
                            " SELECT bbcall.[No] ,bbcall.[CallStatus] " +
      " ,bbcall.[PatientID] " +
       " ,pm.[Patient Name] " +
      //" ,bbcall.[ComponentID] " +
      // " ,bbcom.[Component Name] " +
      " ,bbcall.[CallTime] " +
      " ,bbcall.[CallDate] " +
      " ,bbcall.[ReceivedBy] " +
      " ,bbcall.[HospitalName] " +
      " ,bbcall.[Area] " +
      " ,bbcall.[CalledBy] " +
      " ,bbcall.[CalledByName] " +
      " ,bbcall.[MobileNo] " +
      " ,bbcall.[WardNo] " +
      " ,bbcall.[Diagnosis] " +
      " ,bbcall.[Transfusion] " +
      " ,bbcall.[Hb] " +
      " ,bbcall.[CallType] " +
      //" ,bbcall.[HRR Staff Collect By Name] " +
      //" ,bbcall.[HRR Staff Collect At Time] " +
      //" ,bbcall.[Received From Lab Time]" +
      //" ,bbcall.[HRR Staff Issue By Name] " +
      //" ,bbcall.[HRR Staff Issue At Time] " +
      //" ,bbcall.[Hospital Delivery At Time] " +
      //" ,bbcall.[System Time],bbcall.[Call Closing Time] " +
                        " From " + MySqlSettings.Default.BBCallDetails + " bbcall INNER JOIN " + MySqlSettings.Default.Patient_Master + "  pm on bbcall.PatientID= pm.PatientID where No ="+ CallNo + "  ; " +

                            /*select PO details*/
                            " SELECT cd.[No] ,cd.[BBComponentID] ,bbcom.[Component Name],cd.[OrderQty] ,cd.[PendingQty] from" + MySqlSettings.Default.Component_Details + " cd " +
                            " inner join " + MySqlSettings.Default.BB_Component + " bbcom on cd.BBComponentID=bbcom.BBComponentID where No ="+ CallNo +" ; " +

                        /*select PO taxes*/
                        " SELECT * " +
                        "FROM " + MySqlSettings.Default.BagIssue_Header +

                        " WHERE [No] = " + CallNo + " ";

                        //
                        adapt.SelectCommand = cmd;
                        adapt.Fill(ds);

                        ds.Tables[0].TableName = "CallDetails";
                        ds.Tables[1].TableName = "ComponentsDetails";
                        ds.Tables[2].TableName = "BBIssueHeader";
                    }
                }// using conn
                return ds;
            }// try
            catch (Exception) { return null; }

        }// POSelectSingle


        public static int BagIssueInsert(BBParameter BBCall)
        {
            int rows = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        // Start a local transaction.
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            command.Connection = conn;
                            command.Transaction = transaction;
                            try
                            {

                                




                                command.Parameters.Clear();
                                command.CommandText = "INSERT INTO " + MySqlSettings.Default.BagIssue_Header +
                                "( [BagIssueID],[No] " +


    " ,[CallDate] " +
    " ,[CallTime] " +
    " ,[IssueDate]" +
    " ,[IssueTime]" +
                                    " ,[HRR Staff Collect By Name] " +
                                    " ,[HRR Staff Collect At Time] " +
                                    " ,[Received From Lab Time] " +
                                    " ,[HRR Staff Issue By Name] " +
                                    " ,[HRR Staff Issue At Time] " +
                                    " ,[System Time] " +
                                    " ,[Hospital Delivery At Time]  " +
                                    ",[Call Closing Time],[CallIssueTran],[IssueBy] ) " +

    " VALUES (@bagissueId, @no, @calldate,@calltime,@callissuedate,@callissuetime ," +
        " @collectstaffname,@collecttime,@receivedfromlabtime,@issuestaffname,@issuetime,@deliverysystemtime,@hospdeliverytime,@callclosetime,@callissuetran,@issueby )";



                                command.Parameters.AddWithValue("@bagissueId", BBCall.BagIssueID);
                                command.Parameters.AddWithValue("@no", BBCall.No);



                                command.Parameters.AddWithValue("@calldate", BBCall.Date);
                                command.Parameters.AddWithValue("@calltime", BBCall.CallTime);

                                command.Parameters.AddWithValue("@callissuedate", BBCall.IssueDate);
                                command.Parameters.AddWithValue("@callissuetime", BBCall.IssueTime);
                             

                                command.Parameters.AddWithValue("@collectstaffname", BBCall.HRRStaffCollectByName);
                                command.Parameters.AddWithValue("@collecttime", BBCall.HRRStaffCollectAtTime);

                                command.Parameters.AddWithValue("@receivedfromlabtime", BBCall.ReceivedFromLabTime);


                                command.Parameters.AddWithValue("@issuestaffname", BBCall.HRRStaffIssueByName);
                                command.Parameters.AddWithValue("@issuetime", BBCall.HRRStaffIssueAtTime);

                                command.Parameters.AddWithValue("@deliverysystemtime", BBCall.SystemDeliveryTime);

                                command.Parameters.AddWithValue("@hospdeliverytime", BBCall.DeliveryAtTime);
                                command.Parameters.AddWithValue("@callclosetime", BBCall.CallClosingTime);
                                command.Parameters.AddWithValue("@callissuetran", BBCall.CallIssueTranID);

                                command.Parameters.AddWithValue("@issueby", BB.Properties.UserLogin.Default.StaffName);







                                // command.Parameters.AddWithValue("@department", (int)TrialParam.departmentType);


                                rows = command.ExecuteNonQuery();
                                if (rows < 0)
                                    throw new Exception("Insert fail");


                                // add PO details
                                foreach (BBParameter itm in BBCall.ComponentList)
                                {
                                     
                                    
                                    rows = BagIssueDetailInsert(command, itm, BBCall.No,BBCall.BagIssueID);
                                    if (rows < 0) throw new Exception();

                                   

                                }

                                //update pending qty to compoenet details
                                 foreach (BBParameter itm in BBCall.ComponentList)
                                {
                                     int compoId = int.Parse(itm.ComponentID);

                                       rows = ComponentDetailUpdatePendingQty(command, itm, BBCall.No,compoId);
                                    if (rows < 0) throw new Exception();

                                 }





                                // Attempt to commit the transaction.
                                transaction.Commit();
                                Console.WriteLine("records are written to database.");
                            }//try
                            catch (Exception ex)
                            {
                                //rows = -1;

                                //Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                                //Console.WriteLine("  Message: {0}", ex.Message);
                                MessageBox.Show(ex.Message, "Insert BBCALL Commit Exception");

                                // Attempt to roll back the transaction. 
                                try
                                {
                                    transaction.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    // This catch block will handle any errors that may have occurred 
                                    // on the server that would cause the rollback to fail, such as 
                                    // a closed connection.
                                    //Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                    //Console.WriteLine("  Message: {0}", ex2.Message);
                                    MessageBox.Show(ex2.Message, "Insert BBCALL Rollback Exception");
                                }//
                            }//catch
                        }// using trans
                    }// using cmd
                }// using sql conn
                return rows;
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Exception");
                return -1;
            }

        }// TrialParameterInsert


        private static int BagIssueDetailInsert(SqlCommand command, BBParameter itm, int callno,int bagIssueId)
        {
            int rows = -1;

            try
            {

                if (itm.BagIssueQuantity != 0)
                {


                    command.Parameters.Clear();

                    command.CommandText = "INSERT INTO " + MySqlSettings.Default.BagIssue_Details +
                        " ([BagIssueID] " +
         " ,[No] " +
            " ,[ComponentID] " +
         " ,[ReceivedQty] " +
         ",[PendingQty] )" +

                        "VALUES ( @issueid,@no,@compoid,@recqty,@penqty)";

                    command.Parameters.AddWithValue("@issueid", bagIssueId);
                    command.Parameters.AddWithValue("@no", callno);
                    command.Parameters.AddWithValue("@compoid", itm.ComponentID);

                    command.Parameters.AddWithValue("@recqty", itm.BagIssueQuantity);
                    command.Parameters.AddWithValue("@penqty", itm.PendingQuantity);




                    rows = command.ExecuteNonQuery();
                    if (rows < 0)
                        throw new Exception();
                }
                else
                {
                    rows = 1;
                }

                return rows;
            }// try
            catch (Exception ex)
            {
                rows = -1;
                MessageBox.Show(ex.Message, "Insert Component Detail Exception");
                throw ex;
                //return -1;
            }
        }// BagIssue Details insert


        private static int ComponentDetailUpdatePendingQty(SqlCommand command, BBParameter itm, int callno,int compoId)
        {

             int rows = -1;

            try
            {
                if (itm.BagIssueQuantity != 0)
                {

                    command.Parameters.Clear();

                    command.CommandText = "UPDATE " + MySqlSettings.Default.Component_Details +
                        " SET [PendingQty] = [PendingQty] - @bagqty   " +//
                        "WHERE [No] = @no AND [BBComponentID] = @compoid";

                    command.Parameters.AddWithValue("@no", callno);
                    command.Parameters.AddWithValue("@compoid", compoId);

                    command.Parameters.AddWithValue("@bagqty", itm.BagIssueQuantity);





                    rows = command.ExecuteNonQuery();
                    if (rows < 0)
                        throw new Exception();
                }
                else
                {
                    rows = 1;
                }

                return rows;
            }// try
            catch (Exception ex)
            {
                rows = -1;
                MessageBox.Show(ex.Message, "Insert Component Detail Exception");
                throw ex;
                //return -1;
            }
            
        }// ComponentDetailUpdate



        public static DataTable SelectBagIssueDetails()
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT bbcall.BagIssueID, bbcall.[No],bbcall.[CallDate],bbcall.[CallTime] " +
                            " ,bbcall.IssueDate" +
                            " ,bbcall.IssueTime" +

                            " ,bbcall.[HRR Staff Collect By Name] " +
                            " ,bbcall.[HRR Staff Collect At Time] " +
                            " ,bbcall.[Received From Lab Time]" +
                            " ,bbcall.[HRR Staff Issue By Name] " +
                            " ,bbcall.[HRR Staff Issue At Time] " +
                            " ,bbcall.[Hospital Delivery At Time] " +
                            " ,bbcall.[System Time],bbcall.[Call Closing Time],bbcall.[IssueBy] " +
                        " From " + MySqlSettings.Default.BagIssue_Header + " bbcall  " +
                            //"INNER JOIN "+MySqlSettings.Default.BB_Component+" bbcom on bbcall.ComponentID=bbcom.BBComponentID " +
      " order by BagIssueID desc ";



                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// 


        public static DataTable SelectAllBagIssueDetailsByCallNoAndIssueID(int callno,int bagissueID)
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT bh.[No] ,bh.[ComponentID] ,bbcom.[Component Name],bh.[ReceivedQty],bh.[PendingQty]  from" + MySqlSettings.Default.BagIssue_Details + " bh " +
                            " inner join " + MySqlSettings.Default.BB_Component + " bbcom on bh.ComponentID=bbcom.BBComponentID where No =" + callno + " and BagIssueID=" + bagissueID + "";


                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// 


        public static DataSet BagIssueDetailsSelectSingle(int CallNo,int BagIssueID)
        {
            try
            {
                DataSet ds = new DataSet();

                SqlDataAdapter adapt = new SqlDataAdapter();

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            /*select PO header*/
                            " SELECT bbcall.[BagIssueID],bbcall.[No],bbcall.[CallDate],bbcall.[CallTime], " +
                            "bbcall.[IssueDate],bbcall.[IssueTime]" +

                            " ,bbcall.[HRR Staff Collect By Name] " +
                            " ,bbcall.[HRR Staff Collect At Time] " +
                            " ,bbcall.[Received From Lab Time]" +
                            " ,bbcall.[HRR Staff Issue By Name] " +
                            " ,bbcall.[HRR Staff Issue At Time] " +
                            " ,bbcall.[Hospital Delivery At Time] " +
                            " ,bbcall.[System Time],bbcall.[Call Closing Time] " +
                        " From " + MySqlSettings.Default.BagIssue_Header + " bbcall   where No =" + CallNo + " and [BagIssueID]=" + BagIssueID + " ; " +

                            /*select PO details*/
                            " SELECT bd.[No] ,bd.[ComponentID] ,bbcom.[Component Name],bd.ReceivedQty,bd.[PendingQty] from" + MySqlSettings.Default.BagIssue_Details + " bd " +
                            " inner join " + MySqlSettings.Default.BB_Component + " bbcom on bd.ComponentID=bbcom.BBComponentID where No =" + CallNo + " and [BagIssueID]=" + BagIssueID + " ; ";

                        ///*select PO taxes*/
                        //" SELECT tx.TaxRateID, tx.TaxName, tx.TaxRate, tx.TaxType, tx.TaxDescription, " +
                        //    "potx.TaxRateAmount, potx.TaxAmount " +
                        //"FROM " + MySqlSettings.Default.Purchasing_PurchaseOrderTaxes + " potx INNER JOIN " +
                        //    MySqlSettings.Default.ERP_PurchaseTaxRate + " tx ON potx.TaxRateID = tx.TaxRateID " +
                        //" WHERE [POID] = " + poId + ";";

                        //
                        adapt.SelectCommand = cmd;
                        adapt.Fill(ds);

                        ds.Tables[0].TableName = "BagIssueHeader";
                        ds.Tables[1].TableName = "BagIssueDetails";
                        //ds.Tables[2].TableName = "POTaxes";
                    }
                }// using conn
                return ds;
            }// try
            catch (Exception) { return null; }

        }// POSelectSingle




        public static int BagIssueDetailsUpdate(BBParameter BBCall, int CallNo,int BagIssueID)
        {
            int rows = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        // Start a local transaction.
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            // Must assign both transaction object and connection 
                            // to Command object for a pending local transaction
                            command.Connection = conn;
                            command.Transaction = transaction;
                            try
                            {



                                command.Parameters.Clear();
                                command.CommandText = "UPDATE " + MySqlSettings.Default.BagIssue_Header +
                                "SET   " +

                                " [HRR Staff Collect By Name]=@collectstaffname " +
     " ,[HRR Staff Collect At Time]=@collecttime " +
     " ,[Received From Lab Time]=@receivedfromlabtime " +
     " ,[HRR Staff Issue By Name]=@issuestaffname " +
     " ,[HRR Staff Issue At Time]=@issuetime " +
     " ,[System Time]=@deliverysystemtime " +
     " ,[Hospital Delivery At Time]=@hospdeliverytime " +
     " ,[Call Closing Time]=@callclosetime " +
                        " where No= " + CallNo + " and BagIssueID ="+BagIssueID+" ";






                                
                              



                                command.Parameters.AddWithValue("@collectstaffname", BBCall.HRRStaffCollectByName);
                                command.Parameters.AddWithValue("@collecttime", BBCall.HRRStaffCollectAtTime);

                                command.Parameters.AddWithValue("@receivedfromlabtime", BBCall.ReceivedFromLabTime);


                                command.Parameters.AddWithValue("@issuestaffname", BBCall.HRRStaffIssueByName);
                                command.Parameters.AddWithValue("@issuetime", BBCall.HRRStaffIssueAtTime);

                                command.Parameters.AddWithValue("@deliverysystemtime", BBCall.SystemDeliveryTime);

                                command.Parameters.AddWithValue("@hospdeliverytime", BBCall.DeliveryAtTime);

                                command.Parameters.AddWithValue("@callclosetime", BBCall.CallClosingTime);





                                rows = command.ExecuteNonQuery();
                                if (rows < 0)
                                    throw new Exception("Insert fail");



                                // Attempt to commit the transaction.
                                transaction.Commit();
                                Console.WriteLine("records are written to database.");
                            }//try
                            catch (Exception ex)
                            {
                                //rows = -1;

                                //Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                                //Console.WriteLine("  Message: {0}", ex.Message);
                                MessageBox.Show(ex.Message, "Insert MOM Commit Exception");

                                // Attempt to roll back the transaction. 
                                try
                                {
                                    transaction.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    // This catch block will handle any errors that may have occurred 
                                    // on the server that would cause the rollback to fail, such as 
                                    // a closed connection.
                                    //Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                    //Console.WriteLine("  Message: {0}", ex2.Message);
                                    MessageBox.Show(ex2.Message, "Insert MOM Rollback Exception");
                                }//
                            }//catch
                        }// using trans
                    }// using cmd
                }// using sql conn
                return rows;
            }// try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Exception");
                return -1;
            }

        }// MOM Update   



        public static DataTable SelectAllBagIssueDetailsByCallNo(int callno)
        {
            // query
            try
            {
                DataTable dt = null;

                using (SqlConnection con = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT bh.BagIssueID,bh.[No] ,bh.[ComponentID] ,bbcom.[Component Name],bh.[ReceivedQty],bh.[PendingQty]  from" + MySqlSettings.Default.BagIssue_Details + " bh " +
                            " inner join " + MySqlSettings.Default.BB_Component + " bbcom on bh.ComponentID=bbcom.BBComponentID where No =" + callno + " order by bh.BagIssueID ASC ";


                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);
                    }// using command

                }// using connection                

                if (dt.Rows.Count == 0) return null;

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }
        }// 


        public static int GetCallIssueTranIdNew(int callNo)
        {
            int currentCallIssueTranID = -1;


            try
            {
                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT TOP(1) [CallIssueTran] FROM " + MySqlSettings.Default.BagIssue_Header +
                            " where No="+callNo+" ORDER BY [CallIssueTran] DESC";

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);

                        if (dt != null)
                        {

                            if (dt.Rows.Count == 0) //1st entry in new finantial year.
                            {
                                currentCallIssueTranID = int.Parse("1");
                            }
                            else
                            {
                                int val = int.Parse(dt.Rows[0][0].ToString());
                                currentCallIssueTranID = val + 1;
                            }
                        }
                        else
                        {
                            currentCallIssueTranID = -1;
                        }

                        return currentCallIssueTranID;










                    }// using command

                }// using connection
            }// end try
            catch (SqlException)
            { currentCallIssueTranID = -1; }
            catch (Exception)
            { currentCallIssueTranID = -1; }

            return currentCallIssueTranID;
        }// GetPOIdNew


        public static DataTable StaffSelectAll()
        {
            try
            {
                DataTable dt = null;

                using (SqlConnection conn = new SqlConnection(MySqlSettings.Default.SQLCONN))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //cmd.Connection = SqlConn;

                        cmd.CommandText = " SELECT * From "+MySqlSettings.Default.Staff_Login;

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adapt.Fill(dt);

                    }// using command
                }// using conn

                return dt;
            }// end try
            catch (SqlException)
            { return null; }
            catch (Exception)
            { return null; }

        }//Employee_SelectAll

    }
}
