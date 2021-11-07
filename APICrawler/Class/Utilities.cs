
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Net;
using System.Data;
using System.Configuration;
using RestSharp;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Net.Mail;

namespace APICrawlerCall.Class
{
   static class Utilities
    {
        public static string CurrentEndpoint = "";
        public static string DataBaseNameSpace = "Endpoint";
        public static string CurrentMethod = "";
        public static string SqlTablePrefix = "";
        public static DataSet tmpDataSet = new DataSet("TmpDataSet");
        public static string tempFKID = "";

        public static void SetInfo(string info, long? total = 0, long? returned = 0, long? limit = 0, long? offset = 0)
        {
            string query = "INSERT INTO [API_Calls]([Info],[TotalDatasets],[Returned],[Limit],[Endpoint],[Method],[Offset]) VALUES (Left(@Info,5000),@TotalDatasets,@Returned,@Limit,@Endpoint,@Method,@Offset);";



            SQLInterface con = new SQLInterface();
            using (SqlConnection connection = con.getConnection())
            {
                SqlCommand cmd_Info = new SqlCommand(query, connection);
                cmd_Info.Parameters.AddWithValue("@Info", info ?? "");
                cmd_Info.Parameters.AddWithValue("@TotalDatasets", total ?? 0);
                cmd_Info.Parameters.AddWithValue("@Returned", returned ?? 0);
                cmd_Info.Parameters.AddWithValue("@Limit", limit ?? 0);
                cmd_Info.Parameters.AddWithValue("@Endpoint", CurrentEndpoint);
                cmd_Info.Parameters.AddWithValue("@Method", CurrentMethod);
                cmd_Info.Parameters.AddWithValue("@Offset", offset);
                cmd_Info.CommandTimeout = Convert.ToInt32(TimeSpan.FromMinutes(5).TotalSeconds);
                cmd_Info.ExecuteNonQuery();
            }

            con.closeConnection();


            if (info.Contains("ERROR"))
            {
                Utilities.SentMail(info);
            }
        

        }


        private static void SentMail(string errortext)
        {



            //MailMessage Mail = new MailMessage();
            //SmtpClient SMTP = new SmtpClient("smtp.strato.de");
            //Mail.Subject = "REX API CRAWLER ERROR";
            //Mail.From = new MailAddress("info@cookiesandcoffee.de");
            //SMTP.Credentials = new System.Net.NetworkCredential("info@cookiesandcoffee.de", "jha%ha8KjUr");
            //Mail.To.Add("sascha.kober@cobera.com");
            //Mail.IsBodyHtml = true;
            //SMTP.EnableSsl = true;
            //SMTP.Port = 587;
            //Mail.Body ="<html xmlns = 'http://www.w3.org/1999/xhtml'><head> <meta http-equiv = 'Content-Type' content = 'text/html; charset=utf-8'> <title> REX API CRAWLER ERROR </title> <style type = 'text/css'> body { margin: 0; padding: 0; min - width: 100 % !important; } img { height: auto; } .content { width: 100 %; max - width: 600px; } .header { padding: 40px 30px 20px 30px; } .innerpadding { padding: 30px 30px 30px 30px; } .borderbottom {                border - bottom: 1px solid #f2eeed;} .subhead {font-size: 15px; color: #ffffff; font-family: sans-serif; letter-spacing: 10px;} .h1, .h2, .bodycopy {color: black; font-family: sans-serif;} .h1 {font-size: 33px; line-height: 38px; font-weight: bold;} .h2 {padding: 0 0 15px 0; font-size: 24px; line-height: 28px; font-weight: bold;} .bodycopy {font-size: 16px; line-height: 22px;} .button {text-align: center; font-size: 18px; font-family: sans-serif; font-weight: bold; padding: 0 30px 0 30px;} .button a {color: #ffffff; text-decoration: none;} .footer {padding: 20px 30px 15px 30px;} .footercopy {font-family: sans-serif; font-size: 14px; color: #ffffff;} .footercopy a {color: #ffffff; text-decoration: underline;} @media only screen and (max-width: 550px), screen and (max-device-width: 550px) { body[yahoo] .hide {display: none!important;} body[yahoo] .buttonwrapper {background-color: transparent!important;} body[yahoo] .button {padding: 0px!important;} body[yahoo] .button a {background-color: #e05443; padding: 15px 15px 13px!important;} body[yahoo] .unsubscribe {display: block; margin-top: 20px; padding: 10px 50px; background: #2f3942; border-radius: 5px; text-decoration: none!important; font-weight: bold;} } /*@media only screen and (min-device-width: 601px) { .content {width: 600px !important;} .col425 {width: 425px!important;} .col380 {width: 380px!important;} }*/ </style></head><body yahoo='' bgcolor='#f6f8f1'><table width='100%' bgcolor='#f6f8f1' border='0' cellpadding='0' cellspacing='0'><tbody><tr> <td> <!--[if (gte mso 9)|(IE)]> <table width='600' align='center' cellpadding='0' cellspacing='0' border='0'> <tr> <td> <![endif]--> <table bgcolor='#ffffff' class='content' align='center' cellpadding='0' cellspacing='0' border='0'> <tbody><tr> <td bgcolor='#dc3545' class='header'> <table width='150' align='left' border='0' cellpadding='0' cellspacing='0'> <tbody><tr> <td style='padding: 0 20px 20px 0;'> <div style='height:auto;;margin:auto;'><a href='https://www.combera.com/tme/ot'><img border='0' style='height:25px;width:50px;' src='data:image/jpeg;base64,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'></a></div> </td> </tr> </tbody></table> <!--[if (gte mso 9)|(IE)]> <table width='425' align='left' cellpadding='0' cellspacing='0' border='0'> <tr> <td> <![endif]--> <table class='col425' align='left' border='0' cellpadding='0' cellspacing='0' style='width: 100%; max-width: 425px;'> <tbody><tr> <td height='70'> <table width='100%' border='0' cellspacing='0' cellpadding='0'> <tbody><tr> <td class='subhead&quot;' style='padding: 0 0 0 3px;font-size:20px;'>REX API Fehler</td> </tr> <tr> <td class='h1' style='padding: 5px 0 0 0; color:white !important;'> </td> </tr> </tbody></table> </td> </tr> </tbody></table> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </td> </tr> <tr> <td class='innerpadding borderbottom'> <table style='max-width:300px;margin:auto; ' width='100%' border='0' cellspacing='0' cellpadding='0'> <tbody><tr> <td class='h2'> <!--?xml version='1.0' encoding='iso-8859-1'?--><!-- Generator: Adobe Illustrator 19.0.0, SVG Export Plug-In . SVG Version: 6.00 Build 0) --><svg version='1.1' id='Capa_1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' x='0px' y='0px' viewBox='0 0 480 480' style='enable-background:new 0 0 480 480;' xml:space='preserve'><rect x='8' y='8' style='fill:#EA7E73;' width='464' height='64'></rect><path style='fill:#F7EEDA;' d='M8,472h120v-24c0-35.36,28.64-64,64-64h-88v-72H72v-96h32v-48h136h136v48h32v96h-32v72h-88c35.36,0,64,28.64,64,64v24h120V72H8V472z M240,104c8.84,0,16,7.16,16,16s-7.16,16-16,16s-16-7.16-16-16S231.16,104,240,104z'></path><circle style='fill:#EA7E73;' cx='240' cy='120' r='16'></circle><path style='fill:#61DBDB;' d='M288,384h88v-72v-96v-48H240H104v48v96v72h88c-35.36,0-64,28.64-64,64v24h224v-24C352,412.64,323.36,384,288,384z M288,352h-96c0-26.512,21.488-48,48-48S288,325.488,288,352z'></path><g><rect x='376' y='216' style='fill:#EFC062;' width='32' height='96'></rect><rect x='72' y='216' style='fill:#EFC062;' width='32' height='96'></rect><path style='fill:#EFC062;' d='M192,352h96c0-26.512-21.488-48-48-48S192,325.488,192,352z'></path></g><g><path style='fill:#122333;' d='M472,0H8C3.576,0,0,3.576,0,8v464c0,4.424,3.576,8,8,8h120h224h120c4.424,0,8-3.576,8-8V8C480,3.576,476.424,0,472,0z M136,464v-16c0-30.872,25.128-56,56-56h96c30.872,0,56,25.128,56,56v16H136z M96,304H80v-80h16V304z M112,312v-96v-40h256v40v96v64h-80h-96h-80V312z M232,120c0-4.416,3.584-8,8-8c4.416,0,8,3.584,8,8s-3.584,8-8,8S232,124.416,232,120z M384,224h16v80h-16V224z M464,464H360v-16c0-22.608-10.496-42.792-26.84-56H376c4.424,0,8-3.576,8-8v-64h24c4.424,0,8-3.576,8-8v-96c0-4.424-3.576-8-8-8h-24v-40c0-4.424-3.576-8-8-8H248v-17.472c9.288-3.312,16-12.112,16-22.528c0-13.232-10.768-24-24-24s-24,10.768-24,24c0,10.416,6.712,19.216,16,22.528V160H104c-4.424,0-8,3.576-8,8v40H72c-4.424,0-8,3.576-8,8v96c0,4.424,3.576,8,8,8h24v64c0,4.424,3.576,8,8,8h42.84C130.496,405.208,120,425.392,120,448v16H16V80h448V464z M464,64H16V16h448V64z'></path><rect x='32' y='32' style='fill:#122333;' width='16' height='16'></rect><rect x='64' y='32' style='fill:#122333;' width='16' height='16'></rect><rect x='96' y='32' style='fill:#122333;' width='16' height='16'></rect><rect x='208' y='32' style='fill:#122333;' width='240' height='16'></rect><polygon style='fill:#122333;' points='202.344,285.656 213.656,274.344 191.312,252 213.656,229.656 202.344,218.344 180,240.688 157.656,218.344 146.344,229.656 168.688,252 146.344,274.344 157.656,285.656 180,263.312 '></polygon><polygon style='fill:#122333;' points='277.656,285.656 300,263.312 322.344,285.656 333.656,274.344 311.312,252 333.656,229.656 322.344,218.344 300,240.688 277.656,218.344 266.344,229.656 288.688,252 266.344,274.344 '></polygon><path style='fill:#122333;' d='M288,360c4.424,0,8-3.576,8-8c0-30.872-25.128-56-56-56s-56,25.128-56,56c0,4.424,3.576,8,8,8H288z M240,312c19.32,0,35.48,13.768,39.192,32H200.8C204.52,325.768,220.68,312,240,312z'></path></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g><g></g></svg> </td> </tr> </tbody></table> </td> </tr> <tr> <td class='innerpadding borderbottom'> <table class='col380' align='left' border='0' cellpadding='0' cellspacing='0' style='width: 100%; max-width: 380px;'> <tbody><tr> <td> <table width='100%' border='0' cellspacing='0' cellpadding='0'> <tbody><tr> <td class='h2'>Fehlertext:</td> </tr> <tr> <td class='bodycopy'>"+ errortext + "</td> </tr> <tr> <td style='padding: 20px 0 0 0;'> <table class='buttonwrapper' bgcolor='black' border='0' cellspacing='0' cellpadding='0'> <tbody><tr> </tr> </tbody></table> </td> </tr> </tbody></table> </td> </tr> </tbody></table> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </td> </tr> <tr> </tr><tr> <td class='innerpadding bodycopy'> </td> </tr> <tr> <td class='footer' bgcolor='#44525f'> <table width='100%' border='0' cellspacing='0' cellpadding='0'> <tbody><tr> <td align='center' class='footercopy'><br> <span class='hide'></span> </td> </tr> <tr> <td align='center' style='padding: 20px 0 0 0;'> <table border='0' cellspacing='0' cellpadding='0'> <tbody><tr> <td width='37' style='text-align: center; padding: 0 10px 0 10px;'> </td> <td width='37' style='text-align: center; padding: 0 10px 0 10px;'> </td> </tr> </tbody></table> </td> </tr> </tbody></table> </td> </tr> </tbody></table> <!--[if (gte mso 9)|(IE)]> </td> </tr> </table> <![endif]--> </td> </tr></tbody></table><!--analytics--></body></html>";


            //SMTP.Send(Mail);

        }





        public static void executeQuery(string query)
        {

            try
            {
                SQLInterface con = new SQLInterface();
                using (SqlConnection connection = con.getConnection())
                {
                    SqlCommand cmd_Info = new SqlCommand(query, connection);
                    cmd_Info.ExecuteNonQuery();
                }

                con.closeConnection();
            }
            catch (Exception ex)
            {
                Utilities.SetInfo("ERROR: " + ex.ToString());

            }

        }


        public static void TransferToDatabase<T>(List<T> list, string CurrentTableName = "Table", string refKeyName= "id")
        {
            try
            {       
                Utilities.CreateDataTable(list, Utilities.SqlTablePrefix + CurrentTableName, new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>(refKeyName, null) });   
                Utilities.AutoSqlBulkCopy(Utilities.tmpDataSet);
            }

            catch (Exception ex)
            {
                Utilities.SetInfo("ERROR: " + ex.ToString());
            }


        }

        public static List<T> CreateList<T>(T c)
        {

            Type type = typeof(T);
            var properties = type.GetProperties();
            List<T> list = new List<T>();
            list.Add(c);

            return list;
        }


        private static bool CheckIfDataTableExists(string tableName)
        {
                   
            if (tmpDataSet.Tables.IndexOf(tableName) >= 0)
            {
                return true;

            }
            else
            {

                return false;
            }

        }

        public static string IsObjectOrList(System.Reflection.PropertyInfo property)
        {
            if (property == null)
            {
                return "";
            }
            if (property.PropertyType.BaseType == null)
            {
                return "";
            }          

            if ((property.PropertyType.IsClass || property.PropertyType.Name.ToLower() == "object") && !property.PropertyType.FullName.ToLower().StartsWith("system.") )
            {
                return "object";
            }

            if (property.PropertyType.FullName.StartsWith("System.Collections.Generic.List"))
            {

                return "list";
            }

            return "";
        }


        public static void CreateDataTable<T>(IEnumerable<T> list, string currentTableName = "Table", List<KeyValuePair<string, string>> refKeyName = null)
        {
            try 
            { 
                Type type = typeof(T);
                var properties = type.GetProperties();
             
                int refKey = 0;
                bool tableExists = CheckIfDataTableExists(currentTableName);
               
                List<KeyValuePair<int, string>> tempColumnIsObject = new List<KeyValuePair<int, string>>();
                List<KeyValuePair<int, string>> tempColumnIsList = new List<KeyValuePair<int, string>>();
                List<int> tempColumnForDataTable = new List<int>();
                List<KeyValuePair<string, string>> tmpListKeyValue= new List<KeyValuePair<string, string>>(); ;

                // creating the DataTable with Columns
                List<DataColumn> primaryKeys = new List<DataColumn>();
                DataTable dataTable = new DataTable(currentTableName);        
                int columnIndex = 0;            

                    foreach (KeyValuePair<string, string> rKey in refKeyName)
                    {
                        if (rKey.Value != null)
                        {
                            DataColumn newColumn = new DataColumn("fk_" + rKey.Key, rKey.Value.GetType());
                            dataTable.Columns.Add(newColumn);
                            primaryKeys.Add(newColumn);
                            refKey++;
                        }
                        else
                        {
                            DataColumn newColumn = new DataColumn(rKey.Key, System.Type.GetType("System.Int64"));                         
                            primaryKeys.Add(newColumn);

                        }
                    }

                    bool listContainsListOrObject = false;

                    // check if list contains another list or object
                    foreach (System.Reflection.PropertyInfo info in properties)
                    {
                        string BaseType = IsObjectOrList(info).ToLower();
                        if (BaseType != "")
                        {
                        listContainsListOrObject = true;

                        }
                    }


                    foreach (System.Reflection.PropertyInfo info in properties)
                    {
                        string BaseType = IsObjectOrList(info).ToLower();
                        if (BaseType!="")
                        {
                            if (BaseType == "object")
                            {
                                //add column to List tempColumnIsObject
                                tempColumnIsObject.Add(new KeyValuePair<int, string>(columnIndex, info.Name));
                            }
                        
                            if (BaseType == "list")
                            {
                                //add column to List tempColumnIsList
                                tempColumnIsList.Add(new KeyValuePair<int, string>(columnIndex, info.Name));
                            }
                        }                
                        else
                        {
                        //add column to DataTable
                        DataColumn newColumn = new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType);
                        dataTable.Columns.Add(newColumn);
                            tempColumnForDataTable.Add(columnIndex);


                            if (columnIndex == 0 && info.Name.ToLower().Contains("id"))
                            {
                                bool refKeyExistsInList = false;
                                foreach (KeyValuePair<string, string> rKey in refKeyName)
                                {
                                    if (rKey.Key == info.Name)
                                    {
                                        refKeyExistsInList = true;
                                    }

                                }


                                if (!refKeyExistsInList && listContainsListOrObject)     
                                {                          
                                    refKeyName.Add(new KeyValuePair<string, string>(info.Name, null));  
                                }                                
                             
                                if (!refKeyExistsInList)     
                                {
                                    primaryKeys.Add(newColumn);
                            }                                
                             
                            }
                        }

                        columnIndex++;
                    }


                DataColumn[] pKeys = new DataColumn[primaryKeys.Count];
                int iDc = 0;
                foreach(DataColumn dc in primaryKeys)
                {
                    pKeys[iDc] = dataTable.Columns[dc.ColumnName];
                    iDc++;
                }           

                dataTable.PrimaryKey = pKeys;
                
                if (!tableExists) 
                {
                    tmpDataSet.Tables.Add(dataTable);
                }
                int tableIndex = tmpDataSet.Tables.IndexOf(dataTable.TableName);
          
                // Add values to DataTable
                foreach (T entity in list)
                {                
                    object[] values = new object[tempColumnForDataTable.Count + refKey];

                    for (int i = 0; i < refKey; i++)
                    {
                        
                        if (refKeyName[i].Value != null) 
                        { 
                            values[i] = refKeyName[i].Value;
                        }

                    }

                    foreach (int i in tempColumnForDataTable)
                    {                                                      
                        values[i + refKey] = properties[i].GetValue(entity);                     


                        tmpListKeyValue = new List<KeyValuePair<string, string>>(refKeyName);     

                        foreach (KeyValuePair<string, string> rKey in tmpListKeyValue)
                        {
                            if (properties[i].Name == rKey.Key && rKey.Value == null)
                            {
                                refKeyName.Remove(rKey);
                                refKeyName.Add(new KeyValuePair<string, string>(rKey.Key, properties[i].GetValue(entity).ToString()));
                            }

                        }
                    }                  

                    tmpDataSet.Tables[tableIndex].Rows.Add(values);               
                  

                    foreach (KeyValuePair<int, string> objectColumn in tempColumnIsObject)
                    {
                        CreateDataTable((ConvertDataTable((dynamic)properties[objectColumn.Key].GetValue(entity))), currentTableName + "_" + objectColumn.Value, refKeyName);
                    } 
                    
                    foreach (KeyValuePair<int, string> objectColumn in tempColumnIsList)
                    {
                        CreateDataTable(((dynamic)properties[objectColumn.Key].GetValue(entity)), currentTableName + "_" + objectColumn.Value, refKeyName);
                    }

                    refKeyName = new List<KeyValuePair<string, string>>(tmpListKeyValue); 

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(currentTableName + ": " + ex);

            }
        }






        //public static DataTable CreateDataTable<T>(IEnumerable<T> list)
        //{

        //    Type type = typeof(T);
        //    var properties = type.GetProperties();

        //    DataTable dataTable = new DataTable();
        //    foreach (System.Reflection.PropertyInfo info in properties)
        //    {
        //        dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
        //    }

        //    foreach (T entity in list)
        //    {
        //        object[] values = new object[properties.Length];
        //        for (int i = 0; i < properties.Length; i++)
        //        {
        //            values[i] = properties[i].GetValue(entity);
        //        }

        //        dataTable.Rows.Add(values);
        //    }

        //    return dataTable;
        //}


        public static void AddToDataSet(DataSet set, object value)
        {

            try
            {


           
            if (set == null)
                throw new ArgumentNullException(nameof(set));

            if (value == null)
                return;

            var type = value.GetType();
            var table = set.Tables[type.FullName];
            if (table == null)
            {
                // create one table per type (name)
                table = new DataTable(type.FullName);
                set.Tables.Add(table);
                foreach (var prop in type.GetProperties().Where(p => p.CanRead))
                {
                    if (IsEnumerable(prop))
                        continue;

                    var col = new DataColumn(prop.Name, prop.PropertyType);
                    table.Columns.Add(col);
                }
            }

            var row = table.NewRow();
            foreach (var prop in type.GetProperties().Where(p => p.CanRead))
            {
                object propValue = prop.GetValue(value);
                if (IsEnumerable(prop))
                {
                    if (propValue != null)
                    {
                        foreach (var child in (ICollection)propValue)
                        {
                            AddToDataSet(set, child);
                        }
                    }
                    continue;
                }

                row[prop.Name] = propValue;
            }
            table.Rows.Add(row);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private static bool IsEnumerable(PropertyInfo pi)
        {
            // note: we could also use IEnumerable (but string, arrays are IEnumerable...)
            return typeof(ICollection).IsAssignableFrom(pi.PropertyType);
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> self)
        {
            var properties = typeof(T).GetProperties();

            var dataTable = new DataTable();
            foreach (var info in properties)
                dataTable.Columns.Add(info.Name, Nullable.GetUnderlyingType(info.PropertyType)
                   ?? info.PropertyType);

            foreach (var entity in self)
                dataTable.Rows.Add(properties.Select(p => p.GetValue(entity)).ToArray());

            return dataTable;
        }


        public static void CreateDataTableSet<T>(IEnumerable<T> list,  string CurrentTableName = "Table", List<KeyValuePair<string, string>> FkPprimaryColumns = null,bool isDataColumnObject = false)
        {
            
            try
            {                            
                Type type = typeof(T);                
                var properties = type.GetProperties();
                int columnscount = properties.Length;              

                List<int> columnsKickFromList = new List<int>();
                List<int> columnIsObject = new List<int>();
                List<KeyValuePair<int, string>> TempPrimaryColumns = new List<KeyValuePair<int, string>>();
                List<KeyValuePair<int, string>> TempColumnIsTableTableName = new List<KeyValuePair<int, string>>();
                List<KeyValuePair<int, string>> TempColumnIsObject = new List<KeyValuePair<int, string>>();

                if (FkPprimaryColumns == null) {
                    FkPprimaryColumns = new List<KeyValuePair<string, string>>();
                }

                int iColumn = 0;
                bool tablexists = false;
                
                string ColumnHasTableName = "";
                DataTable dataTable = new DataTable();

                foreach (DataTable dt in tmpDataSet.Tables)
                {
                    if (dt.TableName == CurrentTableName)
                    {
                        tablexists = true;
                       
                    }
                }

                //add ForeignPrimaryKey to DataTable for references #####
                if (!tablexists)
                {                                       
                        foreach (KeyValuePair<string, string> match in FkPprimaryColumns)
                        {
                            dataTable.Columns.Add(new DataColumn("fk_" + match.Key));                       
                        }
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //check each column in given list
                //if column is a list, mark this an call this procedure recursive
                //if Column is marked with [Key] in its class -> put it to the primary keys

                foreach (System.Reflection.PropertyInfo info in properties)
                {
                    //check if column is containing a list/table
                    //||
                    // if ((info.PropertyType.Name != "String"))

                    if ((info.PropertyType.Name == "List`1" || info.PropertyType.Name == "Object") || ((info.PropertyType.BaseType!= null && info.PropertyType.BaseType.Name == "Object") && (info.PropertyType.Name != "String")))
                    {
                        ColumnHasTableName = info.Name;                    
                        columnsKickFromList.Add(iColumn);
                        TempColumnIsTableTableName.Add(new KeyValuePair<int, string>(iColumn, info.Name));
                    
                        if ((info.PropertyType.Name != "List`1" && info.PropertyType.Name != "Dictionary`2"))
                        {
                            TempColumnIsObject.Add(new KeyValuePair<int, string>(iColumn, info.Name));
                        }     
                    }
                    else
                    {                      

                            if (!tablexists)
                            {
                                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));                      
                            }

                            //check if its primary key
                            var attribute = Attribute.GetCustomAttribute(info, typeof(KeyAttribute)) as KeyAttribute;
                            if (attribute != null)
                            {
                                dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[info.Name] };
                                TempPrimaryColumns.Add(new KeyValuePair<int, string>(iColumn, info.Name));
                            }


                        if (info.Name.ToLower()=="id")
                        {


                            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[info.Name] };
                            TempPrimaryColumns.Add(new KeyValuePair<int, string>(iColumn, info.Name));
                        }
                    }

                    iColumn++;
                }
               


                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //loop each dataset
                foreach (T entity in list)
                {
                       
                        List<KeyValuePair<string, string>> PrimaryColumns = new List<KeyValuePair<string, string>>();
                        int iFK = 0;                   
                        object[] values = new object[columnscount - columnsKickFromList.Count + FkPprimaryColumns.Count];
                        int itemIsDataTableColumn = 99999;
                        int iColumnDataSet = 0;

                        foreach (KeyValuePair<string, string> match in FkPprimaryColumns)
                        {
                            values[iFK] = match.Value;                           
                            iFK++;
                        }

                        for (int i=0; i < columnscount; i++)
                        {
                                              
                            bool ColumnIsList = false;
                            for (int runs = 0; runs < columnsKickFromList.Count; runs++)
                            {

                                itemIsDataTableColumn = columnsKickFromList[runs];

                                if (i == itemIsDataTableColumn)
                                {
                                ColumnIsList = true;
                                }

                            }
                            if (!ColumnIsList)
                            {
                                values[i + iFK - iColumnDataSet] = properties[i].GetValue(entity);


                                var matches = from val in TempPrimaryColumns where val.Key == i select val.Value;                               
                                foreach (var match in matches)
                                {
                                    PrimaryColumns.Add(new KeyValuePair<string, string>(match.ToString(), values[i+ iFK].ToString()));                                    
                                }



                        }
                        else
                            {                               

                                bool ColumnIsObject = false;
                                iColumnDataSet++;

                                var matches = from val in TempColumnIsTableTableName where val.Key == i select val.Value;
                                foreach (var match in matches)
                                {
                                    ColumnHasTableName = match.ToString();
                                }    
                            
                            
                                matches = from val in TempColumnIsObject where val.Key == i select val.Value;
                                foreach (var match in matches)
                                {
                                    ColumnIsObject = true;
                                }                                                

                                //Recursive #####
                                dynamic DataTableList = properties[i].GetValue(entity);

                            
                                if (DataTableList != null)
                                {
                                    //if Column is Object and not a list, then convert object to list because CreateDataTableSet wants a list
                                    if (!ColumnIsObject) {
                                        CreateDataTableSet(((dynamic)DataTableList), CurrentTableName + "_" + ColumnHasTableName, PrimaryColumns);                                    
                                    }
                                    else
                                    {
                                        CreateDataTableSet((ConvertDataTable(DataTableList)), CurrentTableName + "_" + ColumnHasTableName, PrimaryColumns, true);    
                                    }
                                }
                            }

                        }
                   
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    // if table exists, add to that table, otherwise add to temp table and create that table
                    try
                    {
                        if (tablexists)
                        {
                            foreach (DataTable dt in tmpDataSet.Tables)
                            {
                                if (dt.TableName == CurrentTableName)
                                {

                                    dt.Rows.Add(values);

                                }
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.SetInfo(" ERROR: " + ex.ToString());

                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // if table not exists -> create that table
                if (!tablexists)
                {
                    dataTable.TableName = CurrentTableName;
                    tmpDataSet.Tables.Add(dataTable);
                }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            }

            catch (Exception ex)
            {
                 Utilities.SetInfo(" ERROR: " + ex.ToString());

            }

        }
        private static List<dynamic> ConvertDataTable<dynamic>(dynamic dt)
        {
            List<dynamic> data = new List<dynamic>();
            try
            {               
                data.Add(dt);
            }
            catch (Exception ex)
            {
                Utilities.SetInfo(" ERROR: " + ex.ToString());
            }

            return data;
        }

      

  
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }



   

        public static void AutoSqlBulkCopy(DataSet dataSet)
        {

            string table = "";
            try { 
                SQLInterface con = new SQLInterface();
                using (SqlConnection connection = con.getConnection())
                {
                    //connection.Open();
                    foreach (DataTable dataTable in dataSet.Tables)
                    {

                        table = dataTable.TableName;
                        // checking whether the table selected from the dataset exists in the database or not
                        var checkTableIfExistsCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM sysobjects WHERE name =  '" + dataTable.TableName + "') SELECT 1 ELSE SELECT 0", connection);
                        var exists = checkTableIfExistsCommand.ExecuteScalar().ToString().Equals("1");
                        string addPrimary = ","; 
                        // if does not exist
                        if (!exists)
                        {
                            var createTableBuilder = new StringBuilder("CREATE TABLE [" + dataTable.TableName + "]");
                  
                            createTableBuilder.AppendLine("(");

                            // selecting each column of the datatable to create a table in the database
                            foreach (DataColumn dc in dataTable.Columns)
                            {      
                                Type dataType = dc.DataType;
                                string sqlColumn = "VARCHAR(8000)";

                                if (dataType == typeof(int) || dataType == typeof(Int64) || dataType == typeof(Int32) || dataType == typeof(Int16))
                                {
                                    sqlColumn = "int";
                                }
                                else if (dataType == typeof(double) || dataType == typeof(decimal))
                                {
                                    sqlColumn = "decimal(16,4)";
                                }
                                else if (dataType == typeof(string))
                                {
                                    sqlColumn = "VARCHAR(8000)";
                                }
                                else if (dataType == typeof(DateTime))
                                {
                                    sqlColumn = "datetime";
                                }
                                else if (dataType == typeof(DateTimeOffset))
                                {
                                    sqlColumn = "datetimeoffset(7)";
                                }
                                else if (dataType == typeof(byte[]))
                                {
                                    // Do for Binary (BINARY, VARBINARY, NVARBINARY, IMAGE)
                                    sqlColumn = "BINARY";
                                }

                                else if (dataType == typeof(bool))
                                {
                                    // Do for Binary (BINARY, VARBINARY, NVARBINARY, IMAGE)
                                    sqlColumn = "BIT";
                                }

                                for (int i = 0; i < dataTable.PrimaryKey.Length; i++)
                                {
                                    if (dc.ColumnName == dataTable.PrimaryKey[i].ColumnName)
                                    {
                                        sqlColumn = "VARCHAR(255) NOT NULL";
                                        addPrimary += "," + dc.ColumnName;
                                    }
                                }

                                if (dataTable.PrimaryKey.Length == 0) { 
                                    if (dc.ColumnName.Length > 3) { 
                                        if (dc.ColumnName.Substring(0, 3) == "fk_")
                                        {
                                            sqlColumn = "VARCHAR(255) NOT NULL";
                                            addPrimary += "," + dc.ColumnName;
                                        }
                                    }
                                }


                                createTableBuilder.AppendLine("  [" + dc.ColumnName + "]  " + sqlColumn + ", ");

                            }
                            //createTableBuilder.Remove(createTableBuilder.Length - 1, 1);

                            //createDate Column

                            createTableBuilder.AppendLine(" [db_create_date] [datetime] NOT NULL DEFAULT (getdate())");
                          
                            createTableBuilder.AppendLine(")");
                       
                            var createTableCommand = new SqlCommand(createTableBuilder.ToString(), connection);
                            createTableCommand.ExecuteNonQuery();
                            if (addPrimary != ",")
                            {
                                var alterTableBuilder = new StringBuilder("ALTER TABLE [" + dataTable.TableName + "] ADD PRIMARY KEY (" + addPrimary.Replace(",,", "") + ") WITH (IGNORE_DUP_KEY = ON);");
                                var alterTableCommand = new SqlCommand(alterTableBuilder.ToString(), connection);
                                alterTableCommand.ExecuteNonQuery();
                            }


                        }

                        // if table exists, just copy the data to the destination table in the database
                        // copying the data from datatable to database table
                        using (var bulkCopy = new SqlBulkCopy(connection))
                        
                        {
                            bulkCopy.DestinationTableName = dataTable.TableName;
                            bulkCopy.WriteToServer(dataTable);
                            dataTable.Clear();
                        }
                    }
                }         
            }         

            catch (Exception ex)
            {
                Utilities.SetInfo("ERROR: " + ex.ToString() + table);

            }
         }



        }






}