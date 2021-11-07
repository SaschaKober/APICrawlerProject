using System;
using System.Collections.Generic;
using APICrawlerCall.Class;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APICrawler.Api.Model;
using System.Data;
using RestSharp;
using System.IO;

namespace APICrawlerCall.Calls
{
    static class ConfigurationCalls
    {
        public static DefaultApi GetApiInstance()
        {
            AppSettings AppSetts;

            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                AppSetts = JsonConvert.DeserializeObject<AppSettings>(json);
            }


            Configuration config = new Configuration()
            {
                BasePath = AppSetts.ApiConfig.BasePath,
                Timeout = 10000,
                AccessToken = AppSetts.ApiConfig.AccessToken
            };

            if (AppSetts.ApiConfig.SQLPrefix != "")
            {
                Utilities.SqlTablePrefix = AppSetts.ApiConfig.SQLPrefix + "_";

            }

            Utilities.executeQuery("EXEC [dbo].[sp_Drop_Endpoint_Tables];");


            return new DefaultApi(config);
        }





    }
}

