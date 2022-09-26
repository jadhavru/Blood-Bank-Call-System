using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB
{
    class BBParameter
    {
        private string _callstatus = string.Empty;
        private string _calltime = string.Empty;
        private string _date = string.Empty;

        private string _issuetime = string.Empty;
        private string _issuedate = string.Empty;

        private string _receivedby = string.Empty;

        private string _hospitalname = string.Empty;
        private string _hospitalarea = string.Empty;




        public List<BBParameter> ComponentList = new List<BBParameter>();
        /// <summary>
        /// Get or set item qunatity required
        /// </summary>
        public double ComponentQuantity { get; set; }

        /// <summary>
        /// Get or set item qunatity required
        /// </summary>
        public double PendingQuantity { get; set; }

        /// <summary>
        /// Get or set item qunatity required
        /// </summary>
        public double BagIssueQuantity { get; set; }
       

#region time

        private string _hrrstaffcollectname = string.Empty;
        private string _hrrstaffcollecttime = string.Empty;

        private string _hrrstaffissuename = string.Empty;
        private string _hrrstaffissuetime = string.Empty;

        private string _receivedfromlabtime = string.Empty;

        private string _deliveryattime = string.Empty;
        private string _systemdeliveryattime = string.Empty;
        private string _callclosingtine = string.Empty;

        public string HRRStaffCollectByName
        {
            set { _hrrstaffcollectname = value; }
            get { return _hrrstaffcollectname; }
        }

        public string HRRStaffCollectAtTime
        {
            set { _hrrstaffcollecttime = value; }
            get { return _hrrstaffcollecttime; }
        }

        public string ReceivedFromLabTime
        {
            set { _receivedfromlabtime = value; }
            get { return _receivedfromlabtime; }
        }

        public string HRRStaffIssueByName
        {
            set { _hrrstaffissuename = value; }
            get { return _hrrstaffissuename; }
        }

        public string HRRStaffIssueAtTime
        {
            set { _hrrstaffissuetime = value; }
            get { return _hrrstaffissuetime; }
        }


        public string SystemDeliveryTime
        {
            set { _systemdeliveryattime = value; }
            get { return _systemdeliveryattime; }
        }
        public string DeliveryAtTime
        {
            set { _deliveryattime = value; }
            get { return _deliveryattime; }
        }

        public string CallClosingTime
        {
            set { _callclosingtine = value; }
            get { return _callclosingtine; }
        }

        #endregion

       



        


#region Patient

        //---------------------------

        public string PatientID
        {
            set;
            get;
        }

        private string _Pname = string.Empty;
        private string _Pmobileno = string.Empty;
        private string _Page = string.Empty;
        private string _Psex = string.Empty;
        private string _Paddress = string.Empty;
        private string _Pcity = string.Empty;
        private string _Pblgroup = string.Empty;

        public string P_Name
        {
            set { _Pname = value; }
            get { return _Pname; }
        }
        public string P_MobileNo
        {
            set { _Pmobileno = value; }
            get { return _Pmobileno; }
        }
        public string P_Age
        {
            set { _Page = value; }
            get { return _Page; }
        }
        public string P_Sex
        {
            set { _Psex = value; }
            get { return _Psex; }
        }
        public string P_Address
        {
            set { _Paddress = value; }
            get { return _Paddress; }
        }
        public string P_City
        {
            set { _Pcity = value; }
            get { return _Pcity; }
        }

        public string P_BL_Group
        {
            set { _Pblgroup = value; }
            get { return _Pblgroup; }
        }

        //-------------------

#endregion
       

        public bool ifNewPatient = false;

        public int No
        {
            set;
            get;
        }

        public int BagIssueID
        {
            set;
            get;
        }

        public int CallIssueTranID
        {
            set;
            get;
        }

        public string CallStatus
        {
            set { _callstatus = value; }
            get { return _callstatus; }
        }

        public string CallTime
        {
            set { _calltime = value; }
            get { return _calltime; }
        }

        public string Date
        {
            set { _date = value; }
            get { return _date; }
        }


        public string IssueTime
        {
            set { _issuetime = value; }
            get { return _issuetime; }
        }

        public string IssueDate
        {
            set { _issuedate = value; }
            get { return _issuedate; }
        }


        public string ReceivedBy
        {
            set { _receivedby = value; }
            get { return _receivedby; }
        }

        public string HospitalName
        {
            set { _hospitalname = value; }
            get { return _hospitalname; }
        }

        public string Area
        {
            set { _hospitalarea = value; }
            get { return _hospitalarea; }
        }



        #region CalledAttn Details

        private string _calledby = string.Empty;
        private string _calledbyname = string.Empty;
        private string _mobileno = string.Empty;
        private string _calltype = string.Empty;

        public string CalledBy
        {
            set { _calledby = value; }
            get { return _calledby; }
        }

        public string CalledByName
        {
            set { _calledbyname = value; }
            get { return _calledbyname; }
        }

        public string MobileNo
        {
            set { _mobileno = value; }
            get { return _mobileno; }
        }

        public string CallType
        {
            set { _calltype = value; }
            get { return _calltype; }
        }

        #endregion
      


        #region Patient Other Details

        public string ComponentID
        {
            set;
            get;
        }

        private string _wardno = string.Empty;
        private string _component = string.Empty;
        private string _diagno = string.Empty;
        private string _transfu = string.Empty;
        private string _hb = string.Empty;

        public string WardNo
        {
            set { _wardno = value; }
            get { return _wardno; }
        }

        public string ComponentName
        {
            set { _component = value; }
            get { return _component; }
        }

        public string Diagnosis
        {
            set { _diagno = value; }
            get { return _diagno; }
        }

        public string Transfusion
        {
            set { _transfu = value; }
            get { return _transfu; }
        }

        public string HB
        {
            set { _hb = value; }
            get { return _hb; }
        }

        #endregion
       

       
    }
}
