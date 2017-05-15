using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.Common;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.IO;
using System.Net;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using System.Text;

namespace tryout
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Database db;
        JavaScriptSerializer json = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };

        public WebService1()
        {
            db = DatabaseFactory.CreateDatabase();

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetComputerDetail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select name,Description from Computer_Detail ");
          
            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }






        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetContactus()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select Address,Email,Phone_No,Website from ContactUs_Detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }




        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetClassRoomDetail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select Name,Description from Class_Room ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }





        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetDance_Detail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select Name,Description from Dance_Detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetMgt_Detail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select Name,Description,Image from Mgt_Detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }




        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetGalary_detail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select YearID,CID,Image from Galary_detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { Image = rows }));
        }





        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetNotice_Detail    ()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select Name,Description,Image from Notice_Detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }




        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetPrincipal()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select Name,Description,Image from Principal ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetStaff_detail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select  D_Id,Name,Qualification,Image from Staff_detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }






        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetDeg_detail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select  D_Id,Position from Desg_detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }






        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetVideo_detail()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select YearID,CID,Video from Video_detail ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetCalender_Events()
        {
            DbCommand objCommand = db.GetSqlStringCommand("Select  Convert(varchar(20),Event_Date,105),Event_Name from Calender_Events ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetHoliday_Master()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select Holiday_Name,Date from Holiday_Master ");

            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetLession_master()
        {
            DbCommand objCommand = db.GetSqlStringCommand("select St_Id,Div_Id,Lession,Date from Lession_master ");
            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { ContactList = rows }));
        }


        //[WebMethod]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public AndroidFCMPushNotificationStatus SendNotification(string serverApiKey, string senderId, string deviceId, string message)
        //{
        //    AndroidFCMPushNotificationStatus result = new AndroidFCMPushNotificationStatus();

        //    try
        //    {
        //        result.Successful = false;
        //        result.Error = null;

        //        var value = message;
        //        WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
        //        tRequest.Method = "post";
        //        tRequest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
        //        tRequest.Headers.Add(string.Format("Authorization: key={0}", serverApiKey));
        //        tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));

        //        string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" + deviceId + "";

        //        Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        //        tRequest.ContentLength = byteArray.Length;

        //        using (Stream dataStream = tRequest.GetRequestStream())
        //        {
        //            dataStream.Write(byteArray, 0, byteArray.Length);

        //            using (WebResponse tResponse = tRequest.GetResponse())
        //            {
        //                using (Stream dataStreamResponse = tResponse.GetResponseStream())
        //                {
        //                    using (StreamReader tReader = new StreamReader(dataStreamResponse))
        //                    {
        //                        String sResponseFromServer = tReader.ReadToEnd();
        //                        result.Response = sResponseFromServer;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Successful = false;
        //        result.Response = null;
        //        result.Error = ex;
        //    }

        //    return result;
        //}


        //public class AndroidFCMPushNotificationStatus
        //{
        //    public bool Successful
        //    {
        //        get;
        //        set;
        //    }

        //    public string Response
        //    {
        //        get;
        //        set;
        //    }
        //    public Exception Error
        //    {
        //        get;
        //        set;
        //    }
        //}

        //public  void SendPushNotification()
        //{

        //    try
        //    {

        //        string applicationID = "AIzaSyAM2TY3TxogdteKRG4m6b7rcV-iBLj1puw";

        //        string senderId = "135813780001";

        //        string deviceId = "eZw1ggzlaG8:APA91bFxfU5KpWu_YFDL6epHXKPk_b4XytXrVjSW-bZayNk8mCqsSgNSnJ6jYxWWDTlueEco0QeEQDfEUrmOmx7s55e9zAfX3cEl3m7l9jOeCFB0UMn5f7MawD7Lb4HbDqGgZbLB-Twz";

        //        WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
        //        tRequest.Method = "post";
        //        tRequest.ContentType = "application/json";
        //        var data = new
        //        {
        //            to = deviceId,
        //            notification = new
        //            {
        //                body = "Osama",
        //                title = "AlBaami",
        //                sound = "Enabled"

        //            }
        //        };
        //        var serializer = new JavaScriptSerializer();
        //        var json = serializer.Serialize(data);
        //        Byte[] byteArray = Encoding.UTF8.GetBytes(json);
        //        tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
        //        tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
        //        tRequest.ContentLength = byteArray.Length;
        //        using (Stream dataStream = tRequest.GetRequestStream())
        //        {
        //            dataStream.Write(byteArray, 0, byteArray.Length);
        //            using (WebResponse tResponse = tRequest.GetResponse())
        //            {
        //                using (Stream dataStreamResponse = tResponse.GetResponseStream())
        //                {
        //                    using (StreamReader tReader = new StreamReader(dataStreamResponse))
        //                    {
        //                        String sResponseFromServer = tReader.ReadToEnd();
        //                        string str = sResponseFromServer;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string str = ex.Message;
        //    }
        //}
        //public string SendNotification(string deviceId, string message, string type)
        //{
        //    string GoogleAppID = "AIzaSyAM2TY3TxogdteKRG4m6b7rcV-iBLj1puw";
        //    var SENDER_ID = "135813780001";
        //    var value = message;
        //    WebRequest tRequest;
        //    tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
        //    tRequest.Method = "post";
        //    // tRequest.ContentType = "application/json";
        //    tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
        //    tRequest.Headers.Add(string.Format("Authorization: key={0}", GoogleAppID));
        //    tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));
        //    //string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.time=" +
        //    // System.DateTime.Now.ToString() + "®istration_id=" + deviceId + "";
        //    string postData =
        //      "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message="
        //       + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" +
        //          deviceId + "&data.type=" + type + "";
        //    Console.WriteLine(postData);
        //    Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        //    tRequest.ContentLength = byteArray.Length;
        //    Stream dataStream = tRequest.GetRequestStream();
        //    dataStream.Write(byteArray, 0, byteArray.Length);
        //    dataStream.Close();
        //    WebResponse tResponse = tRequest.GetResponse();
        //    dataStream = tResponse.GetResponseStream();
        //    StreamReader tReader = new StreamReader(dataStream);
        //    String sResponseFromServer = tReader.ReadToEnd();
        //    tReader.Close();
        //    dataStream.Close();
        //    tResponse.Close();
        //    return sResponseFromServer;
        //}

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SendNotification(string deviceId, string message, string type)
        {
            string GoogleAppID = "AIzaSyAM2TY3TxogdteKRG4m6b7rcV-iBLj1puw";
            var SENDER_ID = "135813780001";
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            // tRequest.ContentType = "application/json";
            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", GoogleAppID));
            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));
            //string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.time=" +
            // System.DateTime.Now.ToString() + "®istration_id=" + deviceId + "";
            string postData =
              "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message="
               + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" +
                  deviceId + "&data.type=" + type + "";
            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;
            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse tResponse = tRequest.GetResponse();
            dataStream = tResponse.GetResponseStream();
            StreamReader tReader = new StreamReader(dataStream);
            String sResponseFromServer = tReader.ReadToEnd();
            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;
        }





            [WebMethod]
            [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
            public string NiravSendNotification(string deviceRegIds, string message, string title, long id)
            {

                string SERVER_API_KEY = "AAAAH58h0iE:APA91bHQm2whcIwwES-vlJVHY9zCEjxhq-ccjGbz1mvtFQCOvWiCMmY6k-jn8nIKp02xAy3JdV3VeVOU10zD-RaNSOpqogL3uj7uSvxdJCawnb5JnjQddQmrKA3POuNfWC6l7iogISVS";
                var SENDER_ID = "135813780001";
                string regIds = string.Join("\",\"", deviceRegIds);
                string Title=title;
                string Message=message;
                long ItemId=id;

            //NotificationMessage nm = new NotificationMessage();
            //    nm.Title = title;
            //    nm.Message = message;
            //    nm.ItemId = id;

                var value = new JavaScriptSerializer().Serialize(Title+Message+ItemId);
            String sResponseFromServer="";
            try
            {
                WebRequest tRequest;
                tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

                tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

                string postData = "{\"collapse_key\":\"score_update\",\"time_to_live\":108,\"delay_while_idle\":true,\"data\": { \"message\" : " + value + ",\"time\": " + "\"" + System.DateTime.Now.ToString() + "\"},\"registration_ids\":[\"" + regIds + "\"]}";

                Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                tRequest.ContentLength = byteArray.Length;

                Stream dataStream = tRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse tResponse = tRequest.GetResponse();

                dataStream = tResponse.GetResponseStream();

                StreamReader tReader = new StreamReader(dataStream);

                 sResponseFromServer = tReader.ReadToEnd();
                tReader.Close();
                dataStream.Close();
                tResponse.Close();
            }
            catch (Exception e)
            {
                sResponseFromServer= e.Message.ToString();
            }

            
                return sResponseFromServer;
            }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetLogIn(string UserName, string Pass)
        {
            DbCommand objCommand = db.GetSqlStringCommand("select username from Login where username = @username and password =@password");
            db.AddInParameter(objCommand, "@username", DbType.String, UserName);
            db.AddInParameter(objCommand, "@password", DbType.String, Pass);
            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            string abc;
            List<Dictionary<string, object>> rowss = new List<Dictionary<string, object>>(); ;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
                string user = objDs.Tables[0].Rows[0][0].ToString();

                if (user == UserName)
                {

                    DbCommand objCommands = db.GetSqlStringCommand("select username,gcmkey from gcm ");
                    DataSet objDss = db.ExecuteDataSet(objCommands);
                  
                    Dictionary<string, object> roww = null;
                    foreach (DataRow rss in objDss.Tables[0].Rows)
                    {
                        roww = new Dictionary<string, object>();
                        foreach (DataColumn col in objDss.Tables[0].Columns)
                        {
                            roww.Add(col.ColumnName, rss[col]);
                        }
                        rowss.Add(roww);

                        abc = objDss.Tables[0].Rows[0][0].ToString();
                    }

                  
                }
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { UserId = rowss }));
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void TestInsert(int id, string Name)
        {

            DbCommand objCommand = db.GetSqlStringCommand("insert into tblLineUp values (@id, @name)");
            db.AddInParameter(objCommand, "@id", DbType.Int32, id);
            db.AddInParameter(objCommand, "@name", DbType.String, Name);
            //db.AddInParameter(objCommand, "@AdharDoc", DbType.String, AdharName);
            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = new Dictionary<string, object>();

            row.Add("success", true);
            rows.Add(row);


            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { Message = row }));
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetLog(string UserName, string Pass, string gcmKey)
        {
            DbCommand objCommand = db.GetStoredProcCommand("spGetNotification");//cId =@CastId and 
            db.AddInParameter(objCommand, "@uName", DbType.String, UserName);
            db.AddInParameter(objCommand, "@Pass", DbType.String, Pass);
            db.AddInParameter(objCommand, "@gcmKey", DbType.String, gcmKey);
            DataSet objDs = db.ExecuteDataSet(objCommand);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;
            foreach (DataRow rs in objDs.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in objDs.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, rs[col]);
                }
                rows.Add(row);
            }
            this.Context.Response.ContentType = "application/json; charset=utf-8";
            this.Context.Response.Write(json.Serialize(new { PersonalProfile = rows }));
        }
    }
}
