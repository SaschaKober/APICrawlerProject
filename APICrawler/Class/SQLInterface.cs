using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace APICrawlerCall.Class
{
    class SQLInterface
    {


        protected string getConnectionString()
        {
            string strConnect = "";

            try
            {

                AppSettings AppSetts;

                using (StreamReader r = new StreamReader("appsettings.json"))
                {
                    string json = r.ReadToEnd();
                    AppSetts = JsonConvert.DeserializeObject<AppSettings>(json);
                }

                strConnect = AppSetts.ConnectionStrings.DefaultConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Process.GetCurrentProcess().Kill();
                throw;
            }

         

            return strConnect;

        }

            //Herstellen der Verbindung zur DB
            public SqlConnection getConnection()
        {


      

            try
            {
                SqlConnection conn = new SqlConnection(getConnectionString());
                conn.Open();

                return conn;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Process.GetCurrentProcess().Kill();
                throw;
            }
        }

        //Schließen der Verbindung zur DB
        public SqlConnection closeConnection()
        {


            SqlConnection conn = new SqlConnection(getConnectionString());
            conn.Close();

            return conn;
        }
    }
}
