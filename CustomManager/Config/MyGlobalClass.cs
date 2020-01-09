using CustomManager.DatabaseManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace CustomManager
{
    public class MyGlobalClass
    {
        private static string domen="localhost";
        private static int port=80;

        public static int Port
        {
            get { return port; }
            set { port = value; Host = "http://" + domen + ":" + port + "/"; }
        }

        public static string Domen
        {
            get { return domen; }
            set { domen = value; Host = "http://" + domen + ":" + port + "/"; }
        }
        public static string Host { get; private set; }
        public static Customer Customer { get; set; }

        public static bool CheckInternet()
        {
            try
            {
                Ping myPing = new Ping();
                //String host = "google.com";
                string host = domen;
                //string host = "195.158.24.58";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async static Task<string> GetResponseAsync(string url)
        {
            string jsonString = "";
            try
            {
                if (CheckInternet())
                {
                    Task<string> task = Task.Run(() => GetResponsible(url));
                    jsonString = await task;
                    //jsonString = GetResponsible(url);
                    //Task task = new Task(() => { jsonString = GetResponsible(url); });
                    //task.RunSynchronously();
                    //task.Wait();
                 //   return jsonString;
                }
            }
            catch (Exception) { }
            return jsonString;
        }

        public static bool TryConvert<T>(string jsonString, ref T ob)
        {
            bool answer = true;
            if (!string.IsNullOrEmpty(jsonString))
            {
                try
                {
                    ob = Convert<T>(jsonString);
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    answer = false;
                }
            }
            else
            {
                answer = false;
            }
            return answer;
        }

        private static T Convert<T>(string jsonString)
        {
            System.Diagnostics.Debug.WriteLine("jsonString="+jsonString);
            T ob = JsonConvert.DeserializeObject<T>(jsonString,new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
            return ob;
        }

        public static string GetResponsible(string url)
        {
            string jsonString = "";
            try
            {
                if (CheckInternet())
                {
                    HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(url));
                    
                    WebReq.Method = "GET";

                    HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
                    
                    using (Stream stream = WebResp.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                        jsonString = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception) { }

            return jsonString;

        }

        public static DBManager DBManager { get; set; }
    }
}
