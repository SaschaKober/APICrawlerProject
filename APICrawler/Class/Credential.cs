using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace APICrawlerCall.Class
{

    public partial class AppSettings
    {  
        public ConnectionStrings ConnectionStrings { get; set; }
        public ApiConfig ApiConfig { get; set; }
    }


    
    public partial class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    
    }


    public partial class ApiConfig
    {
        public string BasePath { get; set; }
        public string SQLPrefix { get; set; }
        public string AccessToken { get; set; }


    }

}
