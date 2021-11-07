using System;
using System.Collections.Generic;
using APICrawlerCall.Class;
using APICrawlerCall.Calls;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APICrawler.Api.Model;
using System.Data;
using RestSharp;


namespace APICrawlerCall.Calls
{
    static class ExecuteCalls
    {
        public static void Start()
        {           

            var apiInstance = ConfigurationCalls.GetApiInstance();


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //edit api calls here
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            



            Utilities.TransferToDatabase(apiInstance.AdresseGet().Items, apiInstance.AdresseGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.AntragGet().Items, apiInstance.AntragGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AuflagenGet().Items, apiInstance.AuflageReduGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AuflageReduGet().Items, apiInstance.AdresseGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.AwgGet().Items, apiInstance.AwgGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgAufwandGet().Items, apiInstance.AwgAufwandGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgBemGet().Items, apiInstance.AwgBemGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgKulturGet().Items, apiInstance.AwgKulturGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgPartnerGet().Items, apiInstance.AwgPartnerGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgSchadorgGet().Items, apiInstance.AwgSchadorgGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgVerwendungszweckGet().Items, apiInstance.AwgVerwendungszweckGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgWartezeitGet().Items, apiInstance.AwgWartezeitGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgWartezeitAusgKulturGet().Items, apiInstance.AwgWartezeitAusgKulturGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgZeitpunktGet().Items, apiInstance.AwgZeitpunktGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.AwgZulassungGet().Items, apiInstance.AwgZulassungGet().GetType().Name);


            Utilities.TransferToDatabase(apiInstance.GhsGefahrenhinweiseGet().Items, apiInstance.GhsGefahrenhinweiseGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.GhsGefahrensymboleGet().Items, apiInstance.GhsGefahrensymboleGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.GhsSicherheitshinweiseGet().Items, apiInstance.GhsSicherheitshinweiseGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.GhsSignalwoerterGet().Items, apiInstance.GhsSignalwoerterGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.HinweisGet().Items, apiInstance.HinweisGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.KodeGet().Items, apiInstance.KodeGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.KodelisteGet().Items, apiInstance.KodelisteGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.KodelisteFeldnameGet().Items, apiInstance.KodelisteFeldnameGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.KulturGruppeGet().Items, apiInstance.KulturGruppeGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.MittelGet().Items, apiInstance.MittelGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.MittelAbgelaufenGet().Items, apiInstance.MittelAbgelaufenGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.MittelAbpackungGet().Items, apiInstance.MittelAbpackungGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.MittelGefahrenSymbolGet().Items, apiInstance.MittelGefahrenSymbolGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.MittelVertriebGet().Items, apiInstance.MittelVertriebGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.MittelWirkbereichGet().Items, apiInstance.MittelWirkbereichGet().GetType().Name);


            Utilities.TransferToDatabase(apiInstance.ParallelimportAbgelaufenGet().Items, apiInstance.ParallelimportAbgelaufenGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.ParallelimportGueltigGet().Items, apiInstance.ParallelimportGueltigGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.SchadorgGruppeGet().Items, apiInstance.SchadorgGruppeGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.StaerkungGet().Items, apiInstance.StaerkungGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.StaerkungVertriebGet().Items, apiInstance.StaerkungVertriebGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.StandGet().Items, apiInstance.StandGet().GetType().Name);

            Utilities.TransferToDatabase(apiInstance.WirkstoffGet().Items, apiInstance.WirkstoffGet().GetType().Name);
            Utilities.TransferToDatabase(apiInstance.WirkstoffGehaltGet().Items, apiInstance.WirkstoffGehaltGet().GetType().Name);


            Utilities.TransferToDatabase(apiInstance.ZusatzstoffVertriebGet().Items, apiInstance.ZusatzstoffVertriebGet().GetType().Name);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //edit api calls above
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            Utilities.executeQuery("EXEC [dbo].[sp_Transfer_Endpoints_To_DataHub] @tmpsourceTableNameContain = 'Endpoint'");
        }
    }
}
