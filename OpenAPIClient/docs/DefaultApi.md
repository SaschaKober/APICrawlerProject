# APICrawler.Api.Api.DefaultApi

All URIs are relative to *https://psm-api.bvl.bund.de/ords/psm/api-v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdresseGet**](DefaultApi.md#adresseget) | **GET** /adresse/ | 
[**AntragGet**](DefaultApi.md#antragget) | **GET** /antrag/ | 
[**AuflageReduGet**](DefaultApi.md#auflagereduget) | **GET** /auflage_redu/ | 
[**AuflagenGet**](DefaultApi.md#auflagenget) | **GET** /auflagen/ | 
[**AwgAufwandGet**](DefaultApi.md#awgaufwandget) | **GET** /awg_aufwand/ | 
[**AwgBemGet**](DefaultApi.md#awgbemget) | **GET** /awg_bem/ | 
[**AwgGet**](DefaultApi.md#awgget) | **GET** /awg/ | 
[**AwgKulturGet**](DefaultApi.md#awgkulturget) | **GET** /awg_kultur/ | 
[**AwgPartnerAufwandGet**](DefaultApi.md#awgpartneraufwandget) | **GET** /awg_partner_aufwand/ | 
[**AwgPartnerGet**](DefaultApi.md#awgpartnerget) | **GET** /awg_partner/ | 
[**AwgSchadorgGet**](DefaultApi.md#awgschadorgget) | **GET** /awg_schadorg/ | 
[**AwgVerwendungszweckGet**](DefaultApi.md#awgverwendungszweckget) | **GET** /awg_verwendungszweck/ | 
[**AwgWartezeitAusgKulturGet**](DefaultApi.md#awgwartezeitausgkulturget) | **GET** /awg_wartezeit_ausg_kultur/ | 
[**AwgWartezeitGet**](DefaultApi.md#awgwartezeitget) | **GET** /awg_wartezeit/ | 
[**AwgZeitpunktGet**](DefaultApi.md#awgzeitpunktget) | **GET** /awg_zeitpunkt/ | 
[**AwgZulassungGet**](DefaultApi.md#awgzulassungget) | **GET** /awg_zulassung/ | 
[**GhsGefahrenhinweiseGet**](DefaultApi.md#ghsgefahrenhinweiseget) | **GET** /ghs_gefahrenhinweise/ | 
[**GhsGefahrensymboleGet**](DefaultApi.md#ghsgefahrensymboleget) | **GET** /ghs_gefahrensymbole/ | 
[**GhsSicherheitshinweiseGet**](DefaultApi.md#ghssicherheitshinweiseget) | **GET** /ghs_sicherheitshinweise/ | 
[**GhsSignalwoerterGet**](DefaultApi.md#ghssignalwoerterget) | **GET** /ghs_signalwoerter/ | 
[**HinweisGet**](DefaultApi.md#hinweisget) | **GET** /hinweis/ | 
[**KodeGet**](DefaultApi.md#kodeget) | **GET** /kode/ | 
[**KodelisteFeldnameGet**](DefaultApi.md#kodelistefeldnameget) | **GET** /kodeliste_feldname/ | 
[**KodelisteGet**](DefaultApi.md#kodelisteget) | **GET** /kodeliste/ | 
[**KulturGruppeGet**](DefaultApi.md#kulturgruppeget) | **GET** /kultur_gruppe/ | 
[**MittelAbgelaufenGet**](DefaultApi.md#mittelabgelaufenget) | **GET** /mittel_abgelaufen/ | 
[**MittelAbpackungGet**](DefaultApi.md#mittelabpackungget) | **GET** /mittel_abpackung/ | 
[**MittelGefahrenSymbolGet**](DefaultApi.md#mittelgefahrensymbolget) | **GET** /mittel_gefahren_symbol/ | 
[**MittelGet**](DefaultApi.md#mittelget) | **GET** /mittel/ | 
[**MittelVertriebGet**](DefaultApi.md#mittelvertriebget) | **GET** /mittel_vertrieb/ | 
[**MittelWirkbereichGet**](DefaultApi.md#mittelwirkbereichget) | **GET** /mittel_wirkbereich/ | 
[**ParallelimportAbgelaufenGet**](DefaultApi.md#parallelimportabgelaufenget) | **GET** /parallelimport_abgelaufen/ | 
[**ParallelimportGueltigGet**](DefaultApi.md#parallelimportgueltigget) | **GET** /parallelimport_gueltig/ | 
[**SchadorgGruppeGet**](DefaultApi.md#schadorggruppeget) | **GET** /schadorg_gruppe/ | 
[**StaerkungGet**](DefaultApi.md#staerkungget) | **GET** /staerkung/ | 
[**StaerkungVertriebGet**](DefaultApi.md#staerkungvertriebget) | **GET** /staerkung_vertrieb/ | 
[**StandGet**](DefaultApi.md#standget) | **GET** /stand/ | 
[**WirkstoffGehaltGet**](DefaultApi.md#wirkstoffgehaltget) | **GET** /wirkstoff_gehalt/ | 
[**WirkstoffGet**](DefaultApi.md#wirkstoffget) | **GET** /wirkstoff/ | 
[**ZusatzstoffGet**](DefaultApi.md#zusatzstoffget) | **GET** /zusatzstoff/ | 
[**ZusatzstoffVertriebGet**](DefaultApi.md#zusatzstoffvertriebget) | **GET** /zusatzstoff_vertrieb/ | 


<a name="adresseget"></a>
# **AdresseGet**
> Adresse AdresseGet (string adresseNr = null)



Liefert eine Liste aller Adressen und Namen von Vertriebsfirmen/Antragstellern/Importeuren von Pflanzenschutzmitteln.                       Optional kann nur nach einer Adresse gesucht werden, wenn die entsprechende {adresse_nr} gegeben wird.                       Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {adresse_nr} ist der eindeutige Identifizierer fÃ¼r eine Adresse und damit eine/n Vertriebsfirma/Antragsteller/Importeur. Nummer mit bis zu 38 Ziffern, Bsp: 10784.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AdresseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var adresseNr = adresseNr_example;  // string | Implicit parameter (optional) 

            try
            {
                Adresse result = apiInstance.AdresseGet(adresseNr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AdresseGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **adresseNr** | **string**| Implicit parameter | [optional] 

### Return type

[**Adresse**](Adresse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="antragget"></a>
# **AntragGet**
> Antrag AntragGet (string antragnr = null, string antragstellerNr = null, string kennr = null)



Liefert die ZulassungsantrÃ¤ge und Antragsteller zu aktuell gÃ¼ltigen Pflanzenschutzmitteln (im Endpunkt /mittel).                       Optional kann nach der Antragnummer {antragnr}, dem Antragsteller {antragsteller_nr} und/oder der Kennnummer des Mittels gefiltert werden.                       Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer setzt sich zusammen aus {antragnr} und {kennr}.     {antragnr} ist die Nummer des Antrags. Zeichenfolge aus zwei Zeichen, Bsp: 00.     {antragsteller_nr} ist die Nummer des Antragstellers, referenziert aus dem /adresse Endpunkt. Zahl aus maximal 22 Ziffern, Bsp: 10091.     {kennr} ist die Kennummer eines Pflanzenschutzmittels, referenziert aus dem /mittel Endpunkt. Zeichenkette aus neun Zeichen, Bsp: 005632-60.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AntragGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var antragnr = antragnr_example;  // string | Implicit parameter (optional) 
            var antragstellerNr = antragstellerNr_example;  // string | Implicit parameter (optional) 
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                Antrag result = apiInstance.AntragGet(antragnr, antragstellerNr, kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AntragGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **antragnr** | **string**| Implicit parameter | [optional] 
 **antragstellerNr** | **string**| Implicit parameter | [optional] 
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**Antrag**](Antrag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auflagereduget"></a>
# **AuflageReduGet**
> AuflageRedu AuflageReduGet (string auflagenr = null)



Liefert eine Liste der Auflagen mit reduzierten AbstÃ¤nden bei verwendeten GerÃ¤ten verschiedener Abdriftminderungsklassen.                       Optional kann nach einer Auflagennummer {auflagenr} gefiltert werden.                       Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer wird gebildet aus allen Attributen dieses Endpunkts.     {auflagenr} ist die Nummer einer Auflage, referenziert aus dem /auflagen Endpunkt. Ziffernfolge, Bsp: 49804321.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AuflageReduGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var auflagenr = auflagenr_example;  // string | Implicit parameter (optional) 

            try
            {
                AuflageRedu result = apiInstance.AuflageReduGet(auflagenr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AuflageReduGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **auflagenr** | **string**| Implicit parameter | [optional] 

### Return type

[**AuflageRedu**](AuflageRedu.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auflagenget"></a>
# **AuflagenGet**
> Auflagen AuflagenGet (string auflage = null, string auflagenr = null, string ebene = null)



Liefert die Liste aller gesetzlichen Auflagen zu Mitteln und Anwendungen.                       Optional kann nach Auflagennummer {auflagenr}, der Ebene {ebene} und/oder eines Auflagenkodes {auflage} gefiltert werden.                       Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {auflagenr} ist der eindeutige Identifizierer einer Auflage. Ziffernfolge, Bsp: 49747804.     {auflage} ist der Kode einer Auflage. Der entsprechende Kode Text kann im /kode Endpunkt angefragt werden. Zeichenkette aus maximal 20 Zeichen, Bsp: WMA.     {ebene} ist entweder die Kennnummer eines Mittels (kennr im /mittel Endpunkt, 9 Zeichen) oder der Identifizierer einer Anwendung (awg_id im /awg Endpunkt, 16 Zeichen). Zeichenkette aus maximal 16 Zeichen, Bsp: 024366-00 oder 005190-00/00-004.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AuflagenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var auflage = auflage_example;  // string | Implicit parameter (optional) 
            var auflagenr = auflagenr_example;  // string | Implicit parameter (optional) 
            var ebene = ebene_example;  // string | Implicit parameter (optional) 

            try
            {
                Auflagen result = apiInstance.AuflagenGet(auflage, auflagenr, ebene);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AuflagenGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **auflage** | **string**| Implicit parameter | [optional] 
 **auflagenr** | **string**| Implicit parameter | [optional] 
 **ebene** | **string**| Implicit parameter | [optional] 

### Return type

[**Auflagen**](Auflagen.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgaufwandget"></a>
# **AwgAufwandGet**
> AwgAufwand AwgAufwandGet (string awgId = null)



Liefert eine Zuordnung von Anwendungen ({awg_id}) auf vorgeschriebene AufwÃ¤nde/Mengen von Pflanzenschutzmittel und Wasser bei dieser Anwendung.                       Optional kann auf einzelnde Anwendungen per {awg_id} gefiltert werden.                       Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der awg_id, der aufwandbedingung und der sortier_nr.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 024785-63/00-002.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgAufwandGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgAufwand result = apiInstance.AwgAufwandGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgAufwandGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgAufwand**](AwgAufwand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgbemget"></a>
# **AwgBemGet**
> AwgBem AwgBemGet (string awgId = null)



Liefert eine Liste von Bemerkungen/ErlÃ¤uterungen zu Anwendungen. (&quot;Auflage&quot; hat in diesem Endpunkt KEINE Verbindung zum Endpunkt /auflage!)                       Optional kann nach einzelnen Anwendungen ({awg_id}) gefiltert werden.                       Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der awg_id und der auflage_bem.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 034210-64/00-007.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgBemGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgBem result = apiInstance.AwgBemGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgBemGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgBem**](AwgBem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgget"></a>
# **AwgGet**
> Awg AwgGet (string awgId = null, string kennr = null)



Liefert eine Liste aller zugelassenen Anwendungen. Eine Anwendung beinhaltet ein angewendetes Mittel, eine Kultur, dessen Wachstumsstadium und einen Schadorganismus. Kultur und Schadorganismus kÃ¶nnen Ã¼ber die Endpunkte /awg_kultur und /awg_schadorg abgerufen werden.                       Optional kann die ID der Anwendung {awg_id} und/oder die Kennnummer eines Mittels {kennr} Ã¼bergeben werden, um die Ergebnisse zu filtern.                       Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {awg_id} ist der eindeutige Identifizierer einer Anwendung. Zeichenfolge aus 16 Zeichen, Bsp: 007472-60/01-012.     {kennr} ist die Kennummer des Mittels auf das sich die Anwendung bezieht, referenziert aus dem /mittel Endpunkt. Zeichenfolge aus 9 Zeichen, Bsp: 007472-60.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                Awg result = apiInstance.AwgGet(awgId, kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**Awg**](Awg.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgkulturget"></a>
# **AwgKulturGet**
> AwgKultur AwgKulturGet (string awgId = null)



Liefert eine Zuordnung von Anwendungen zu Kulturen. Wenn das Feld &quot;ausgenommen&quot; &quot;J&quot; beinhaltet, bildet die in &quot;kultur&quot; angegebene Kultur eine Ausnahme und ist nicht in der Anwendung enthalten.                             Optional kann nach einzelnen Anwendungen ({awg_id}) gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der awg_id und der kultur.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 042688-00/00-001.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgKulturGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgKultur result = apiInstance.AwgKulturGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgKulturGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgKultur**](AwgKultur.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgpartneraufwandget"></a>
# **AwgPartnerAufwandGet**
> AwgPartnerAufwand AwgPartnerAufwandGet (string awgId = null)



Liefert die Zuordnung von Anwendungen zu einem Partnermittel inklusive dem maximalen Aufwand.                             Optional kann nach einer Anwendung {awg_id} gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.       Der eindeutige Identifizierer bestimmt sich aus der awg_id, der aufwandbedingung und der partner_kennr.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 024366-00/02-005.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgPartnerAufwandGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgPartnerAufwand result = apiInstance.AwgPartnerAufwandGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgPartnerAufwandGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgPartnerAufwand**](AwgPartnerAufwand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgpartnerget"></a>
# **AwgPartnerGet**
> AwgPartner AwgPartnerGet (string awgId = null)



Liefert die Zuordnung von Anwendungen zu Partnermitteln, die gemeinsam verwendet werden dÃ¼rfen, zum Beipiel als Tankmischungen.                             Optional kann auf eine Anwendung {awg_id} gefiltert werden.                             Der Parameter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der awg_id und der partner_kennr.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 034078-00/01-003.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgPartnerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgPartner result = apiInstance.AwgPartnerGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgPartnerGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgPartner**](AwgPartner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgschadorgget"></a>
# **AwgSchadorgGet**
> AwgSchadorg AwgSchadorgGet (string awgId = null)



Liefert eine Zuordnung von Anwendungen zu Schadorganismen. Wenn das Feld &quot;ausgenommen&quot; &quot;J&quot; beinhaltet, bildet der in &quot;schadorg&quot; angegebene Schadorganismus eine Ausnahme und ist nicht in der Anwendung enthalten.                             Optional kann nach einzelnen Anwendungen ({awg_id}) gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der awg_id und dem schadorg.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 043099-63/00-007.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgSchadorgGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgSchadorg result = apiInstance.AwgSchadorgGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgSchadorgGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgSchadorg**](AwgSchadorg.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgverwendungszweckget"></a>
# **AwgVerwendungszweckGet**
> AwgVerwendungszweck AwgVerwendungszweckGet (string awgId = null)



Liefert die Zuordnung der Anwendungen zu Verwendungszwecken des assoziierten Mittels. Welcher Verwendng die behandelte Kultur also zugefÃ¼hrt werden darf. Kodiert Ã¼ber Kodeliste 31, einzusehen Ã¼ber den Endpunkt /kode.                             Optional kann auf eine Anwendung {awg_id} gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus allen Attributen des Endpunkts.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 024436-63/00-069.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgVerwendungszweckGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgVerwendungszweck result = apiInstance.AwgVerwendungszweckGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgVerwendungszweckGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgVerwendungszweck**](AwgVerwendungszweck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgwartezeitausgkulturget"></a>
# **AwgWartezeitAusgKulturGet**
> AwgWartezeitAusgKultur AwgWartezeitAusgKulturGet (string awgWartezeitNr = null, string kultur = null)



Liefert die Zuordnung von Anwendungswartezeiten auf Kulturen, die fÃ¼r diese Wartezeit ausgenommen sind. Die Wartezeit fÃ¼r die Ã¼brigen Kulturen kann im Endpunkt /awg_wartezeit abgerufen werden.                             Optional kann nach der Wartezeit ID {awg_wartezeit_nr} oder der Kultur {kultur} gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus sÃ¤mtlichen Attributen des Endpunkts.     {awg_wartezeit_nr} ist der Identifizierer der Zuordnung einer Anwendung zu einer Wartezeit aus dem Endpunkt /awg_wartezeit. Ziffernfolge aus maximal 38 Ziffern, Bsp: 129281.     {kultur} ist der Kode der behandelten Kultur, referenziert aus dem Endpunkt /kultur_gruppe. Zeichenfolge aus maximal 20 Zeichen, Bsp: VIOWH.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgWartezeitAusgKulturGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgWartezeitNr = awgWartezeitNr_example;  // string | Implicit parameter (optional) 
            var kultur = kultur_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgWartezeitAusgKultur result = apiInstance.AwgWartezeitAusgKulturGet(awgWartezeitNr, kultur);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgWartezeitAusgKulturGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgWartezeitNr** | **string**| Implicit parameter | [optional] 
 **kultur** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgWartezeitAusgKultur**](AwgWartezeitAusgKultur.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgwartezeitget"></a>
# **AwgWartezeitGet**
> AwgWartezeit AwgWartezeitGet (string awgId = null, string awgWartezeitNr = null, string kultur = null)



Liefert die Zuordnung von Anwendungen zu Wartezeiten in Tagen fÃ¼r eine bestimmte Kultur, bis die Anwendung erneut durchgefÃ¼hrt werden kann. Ausgenommene Kulturen sind Ã¼ber den Endpunkt /awg_wartezeit_ausg_kultur abzurufen. Genutzt wird fÃ¼r die Bemerkungen Kodeliste 89, dekodierbar Ã¼ber den Endpunkt /kode.                             Optional kann nach der Wartezeit ID {awg_wartezeit_nr}, der Anwendungs ID {awg_id} oder der Kultur {kultur} gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {awg_wartezeit_nr} ist der eindeutige Identifizierer der Zuordnung einer Anwendung zu einer Wartezeit. Ziffernfolge aus maximal 38 Ziffern, Bsp: 151592.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 033274-64/02-001.     {kultur} ist der Kode der behandelten Kultur, referenziert aus dem Endpunkt /kultur_gruppe. Zeichenfolge aus maximal 20 Zeichen, Bsp: FRAAN.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgWartezeitGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 
            var awgWartezeitNr = awgWartezeitNr_example;  // string | Implicit parameter (optional) 
            var kultur = kultur_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgWartezeit result = apiInstance.AwgWartezeitGet(awgId, awgWartezeitNr, kultur);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgWartezeitGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 
 **awgWartezeitNr** | **string**| Implicit parameter | [optional] 
 **kultur** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgWartezeit**](AwgWartezeit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgzeitpunktget"></a>
# **AwgZeitpunktGet**
> AwgZeitpunkt AwgZeitpunktGet (string awgId = null)



Liefert die Zuordnung von Anwendungen zu Zeitpunkten. Es kann mehrere Zeitpunkte pro Anwendung geben, die Ã¼ber das Feld &quot;operand_zu_vorher&quot; aneinandergefÃ¼gt werden in der Reihenfolge nach &quot;sortier_nr&quot;. Die Zeitpunkte sind Ã¼ber Kodeliste 30 kodiert, die Ã¼ber den Endpunkt /kode dekodiert werden kÃ¶nnen.                             Optional kann auf eine Anwendung {awg_id} gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der awg_id, und dem zeitpunkt.     {awg_id} ist der Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 024560-64/04-025.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgZeitpunktGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgZeitpunkt result = apiInstance.AwgZeitpunktGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgZeitpunktGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgZeitpunkt**](AwgZeitpunkt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awgzulassungget"></a>
# **AwgZulassungGet**
> AwgZulassung AwgZulassungGet (string awgId = null)



Liefert die Zuordnung von Anwendungen zu ihrem Zulassungsende.                             Optional kann nach deiner Anwendung {awg_id} gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {awg_id} ist der eindeutige Identifizierer einer Anwendung, referenziert aus dem Endpunkt /awg. Zeichenfolge aus 16 Zeichen, Bsp: 026865-00/00-002.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class AwgZulassungGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var awgId = awgId_example;  // string | Implicit parameter (optional) 

            try
            {
                AwgZulassung result = apiInstance.AwgZulassungGet(awgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AwgZulassungGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **awgId** | **string**| Implicit parameter | [optional] 

### Return type

[**AwgZulassung**](AwgZulassung.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ghsgefahrenhinweiseget"></a>
# **GhsGefahrenhinweiseGet**
> GhsGefahrenhinweise GhsGefahrenhinweiseGet (string kennr = null)



Liefert eine Zuordnung von Mitteln zu ihren Gefahrenhinweisen. Die Gefahrenhinweise verwenden die Kodeliste 70 und kÃ¶nnen dekodiert werden Ã¼ber den Endpunkt /kode.                             Optional kann auf ein Mittel {kennr} gefiltert werden.                             Die Hinweise entspringen dem &quot;Global harmonisierten System zur Einstufung und Kennzeichnung von Chemikalien&quot;, kurz GHS.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus allen Attributen des Endpunkts.     {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenfolge aus 9 Zeichen, Bsp: 024780-67.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class GhsGefahrenhinweiseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                GhsGefahrenhinweise result = apiInstance.GhsGefahrenhinweiseGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GhsGefahrenhinweiseGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**GhsGefahrenhinweise**](GhsGefahrenhinweise.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ghsgefahrensymboleget"></a>
# **GhsGefahrensymboleGet**
> GhsGefahrensymbole GhsGefahrensymboleGet (string kennr = null)



Liefert eine Zuordnung von Mitteln zu ihren Gefahrensymbolen. Die Gefahrensymbole verwenden die Kodeliste 40 und kÃ¶nnen dekodiert werden Ã¼ber den Endpunkt /kode.                             Optional kann auf ein Mittel {kennr} gefiltert werden.                             Die Symbole entspringen dem &quot;Global harmonisierten System zur Einstufung und Kennzeichnung von Chemikalien&quot;, kurz GHS.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus allen Attributen des Endpunkts.     {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenfolge aus 9 Zeichen, Bsp: 026557-00.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class GhsGefahrensymboleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                GhsGefahrensymbole result = apiInstance.GhsGefahrensymboleGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GhsGefahrensymboleGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**GhsGefahrensymbole**](GhsGefahrensymbole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ghssicherheitshinweiseget"></a>
# **GhsSicherheitshinweiseGet**
> GhsSicherheitshinweise GhsSicherheitshinweiseGet (string kennr = null)



Liefert eine Zuordnung von Mitteln zu ihren Sicherheitshinweisen. Die Sicherheitshinweise verwenden die Kodeliste 71 und kÃ¶nnen dekodiert werden Ã¼ber den Endpunkt /kode.                             Optional kann auf ein Mittel {kennr} gefiltert werden.                             Die Hinweise entspringen dem &quot;Global harmonisierten System zur Einstufung und Kennzeichnung von Chemikalien&quot;, kurz GHS.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus allen Attributen des Endpunkts.     {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenfolge aus 9 Zeichen, Bsp: 024350-61.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class GhsSicherheitshinweiseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                GhsSicherheitshinweise result = apiInstance.GhsSicherheitshinweiseGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GhsSicherheitshinweiseGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**GhsSicherheitshinweise**](GhsSicherheitshinweise.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ghssignalwoerterget"></a>
# **GhsSignalwoerterGet**
> GhsSignalwoerter GhsSignalwoerterGet (string kennr = null)



Liefert eine Zuordnung von Mitteln zu ihren SignalwÃ¶rtern. Die SignalwÃ¶rter verwenden die Kodeliste 76 und kÃ¶nnen dekodiert werden Ã¼ber den Endpunkt /kode.                             Optional kann auf ein Mittel {kennr} gefiltert werden.                             Die WÃ¶rter entspringen dem &quot;Global harmonisierten System zur Einstufung und Kennzeichnung von Chemikalien&quot;, kurz GHS.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus allen Attributen des Endpunkts.     {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenfolge aus 9 Zeichen, Bsp: 008263-00.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class GhsSignalwoerterGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                GhsSignalwoerter result = apiInstance.GhsSignalwoerterGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GhsSignalwoerterGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**GhsSignalwoerter**](GhsSignalwoerter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hinweisget"></a>
# **HinweisGet**
> Hinweis HinweisGet (string ebene = null)



Liefert eine Zuordnung von Ebenen (Mitteln und Anwendungen) zu Hinweisen. Die Hinweise verwenden die Kodeliste 74 und kÃ¶nnen dekodiert werden Ã¼ber den Endpunkt /kode.                             Optional kann nach einer Ebene {ebene} (einem Mittel/einer Anwendung) gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der {ebene} und dem hinweis.     {ebene} ist entweder die Kennnummer eines Mittels (kennr im /mittel Endpunkt, 9 Zeichen) oder der Identifizierer einer Anwendung (awg_id im /awg Endpunkt, 16 Zeichen). Zeichenkette aus maximal 16 Zeichen, Bsp: 027821-61.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class HinweisGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var ebene = ebene_example;  // string | Implicit parameter (optional) 

            try
            {
                Hinweis result = apiInstance.HinweisGet(ebene);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.HinweisGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ebene** | **string**| Implicit parameter | [optional] 

### Return type

[**Hinweis**](Hinweis.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kodeget"></a>
# **KodeGet**
> Kode KodeGet (string kode = null, string kodeliste = null, string sprache = null)



Liefert die Zuordnung von Kodes, Kodelisten und Sprache auf den Kodetext. Verwendet zur Dekodierung verschiedener Kodes aus anderen Tabellen.                             Optional kann auf einen Kode, die dazugehÃ¶rige Kodeliste und/oder eine Sprache gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus dem {kode}, der {kodeliste} und der {sprache}.     {kode} ist ein Kode, der in anderen Tabellen als Kodierung fÃ¼r Werte verwendet wird. Zeichenkette aus maximal 20 Zeichen, Bsp: ASPOF.     {kodeliste} ist die Nummer der Liste, der der ensprechende Kode entnommen ist. Die Bedeutung der Liste kann dem Endpoint /kodeliste entnommen werden. Ziffernfolge aus maximal 3 Ziffern, Bsp: 948.     {sprache} ist die Sprache in der der Kodetext geliefert werden soll. Aktuell bereitgestellt werden DE, GB und teilweise VA (Latein). Zeichenkette aus maximal 20 Zeichen, Bsp: DE.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class KodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kode = kode_example;  // string | Implicit parameter (optional) 
            var kodeliste = kodeliste_example;  // string | Implicit parameter (optional) 
            var sprache = sprache_example;  // string | Implicit parameter (optional) 

            try
            {
                Kode result = apiInstance.KodeGet(kode, kodeliste, sprache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.KodeGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kode** | **string**| Implicit parameter | [optional] 
 **kodeliste** | **string**| Implicit parameter | [optional] 
 **sprache** | **string**| Implicit parameter | [optional] 

### Return type

[**Kode**](Kode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kodelistefeldnameget"></a>
# **KodelisteFeldnameGet**
> KodelisteFeldname KodelisteFeldnameGet (string feldname = null, string kodeliste = null, string tabelle = null)



Liefert eine Zuordnung von Kodelistennummer auf die Tabelle und das Feld in dem diese Kodeliste verwendet wird.                             Optional kann nach Kodelistennummer {kodeliste} und/oder Tabellennamen {tabelle} und/oder Spaltennamen {feldname} gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der {tabelle}, der {kodeliste} und dem {feldname}.     {tabelle} ist der Name einer Tabelle, in der eine Kodeliste verwendet wird. Zeichenkette aus maximal 30 Zeichen, Bsp: ADRESSE.     {kodeliste} ist die Nummer der Liste, die in der Spalte verwendet wird. Ziffernfolge aus maximal 3 Ziffern, Bsp: 3.     {feldname} ist der Name der Spalte, in der eine Kodeliste verwendet wird. Zeichenkette aus maximal 30 Zeichen, Bsp: LAND.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class KodelisteFeldnameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var feldname = feldname_example;  // string | Implicit parameter (optional) 
            var kodeliste = kodeliste_example;  // string | Implicit parameter (optional) 
            var tabelle = tabelle_example;  // string | Implicit parameter (optional) 

            try
            {
                KodelisteFeldname result = apiInstance.KodelisteFeldnameGet(feldname, kodeliste, tabelle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.KodelisteFeldnameGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **feldname** | **string**| Implicit parameter | [optional] 
 **kodeliste** | **string**| Implicit parameter | [optional] 
 **tabelle** | **string**| Implicit parameter | [optional] 

### Return type

[**KodelisteFeldname**](KodelisteFeldname.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kodelisteget"></a>
# **KodelisteGet**
> Kodeliste KodelisteGet (string kodeliste = null)



Liefert eine Auflistung der Kodelisten inklusive dem Listennamen, also der testlichen Beschreibung wofÃ¼r die Liste steht.                             Optional kann nut auf eine Kodeliste {kodeliste} gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {kodeliste} ist der eindeutige Identifizierer der Liste. Ziffernfolge aus maximal 3 Ziffern, Bsp: 3.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class KodelisteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kodeliste = kodeliste_example;  // string | Implicit parameter (optional) 

            try
            {
                Kodeliste result = apiInstance.KodelisteGet(kodeliste);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.KodelisteGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kodeliste** | **string**| Implicit parameter | [optional] 

### Return type

[**Kodeliste**](Kodeliste.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="kulturgruppeget"></a>
# **KulturGruppeGet**
> KulturGruppe KulturGruppeGet (string kultur = null, string kulturGruppe = null)



Liefert eine Liste der Kulturen und der korrespondierenden Kulturgruppe. Der Enpunkt ist eine ReprÃ¤sentation einer Baumstruktur. kultur_gruppe ist dabei ein Parent, dem das Child kultur zugeordnet ist. Eine Kulturgruppe kann mehrere Kulturen als Children besitzen, eine Kultur kann mehrere Parents haben. Da der Baum mehrere Stufen hat, stehen einige Kulturen als Child (kultur) UND als Parent (kultur_gruppe) in unterschiedlichen Zeilen.                             Optional kann auf eine Kultur {kultur} oder eine Kulturgruppe {kultur_gruppe} gefiltert werden.                             Bei einer Ã¼bergebenen {kultur} enthÃ¤lt die RÃ¼ckgabe nur die direkten Parents, also Kulturgruppen zu der korrepondierenden Kultur.                             Bei einer Ã¼bergebenen {kultur_gruppe} enthÃ¤lt die RÃ¼ckgabe nur die direkten Children, also Kulturen zu der korrepondierenden Kulturgruppe.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer bestimmt sich aus der {kultur}, und der {kultur_gruppe}.     {kultur} ist der Kode einer Kultur (Child). Zeichenkette aus maximal 20 Zeichen, Bsp: CAFPA.     {kulturgruppe} ist der Kode der Kulturgruppe der zugeordneten Kultur (Parent). Zeichenkette aus maximal 20 Zeichen, Bsp: NNNZT.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class KulturGruppeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kultur = kultur_example;  // string | Implicit parameter (optional) 
            var kulturGruppe = kulturGruppe_example;  // string | Implicit parameter (optional) 

            try
            {
                KulturGruppe result = apiInstance.KulturGruppeGet(kultur, kulturGruppe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.KulturGruppeGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kultur** | **string**| Implicit parameter | [optional] 
 **kulturGruppe** | **string**| Implicit parameter | [optional] 

### Return type

[**KulturGruppe**](KulturGruppe.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mittelabgelaufenget"></a>
# **MittelAbgelaufenGet**
> MittelAbgelaufen MittelAbgelaufenGet (string kennr = null)



Liefert eine Liste der abgelaufenen Pflanzenschutzmittel, inklusive Aufbrauchfrist. Weitere Informationen sind nur unter den Endpunkten /wirkstoff und /wirkstoff_gehalt enthalten. Andere Referenzen wurden entfernt.                           Optional kann auf eine Kennummer {kennr} gefiltert werden.                           Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          {kennr} ist der eindeutige Identifizierer, die Kennummer eines abgelaufenen Mittels. Zeichenkette aus 9 Zeichen, Bsp: 050023-61.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class MittelAbgelaufenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                MittelAbgelaufen result = apiInstance.MittelAbgelaufenGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MittelAbgelaufenGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**MittelAbgelaufen**](MittelAbgelaufen.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mittelabpackungget"></a>
# **MittelAbpackungGet**
> MittelAbpackung MittelAbpackungGet (string kennr = null)



Liefert eine Liste der Packungsinformationen fÃ¼r Mittel.                           Optional kann auf die Kennummer eines Mittels {kennr} gefiltert werden.                           Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          Der eindeutige Identifizierer setzt sich aus allen Attributen des Endpunkts zusammen.         {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 033274-64.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class MittelAbpackungGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                MittelAbpackung result = apiInstance.MittelAbpackungGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MittelAbpackungGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**MittelAbpackung**](MittelAbpackung.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mittelgefahrensymbolget"></a>
# **MittelGefahrenSymbolGet**
> MittelGefahrenSymbol MittelGefahrenSymbolGet (string kennr = null)



Liefert eine Zuordnung von Mitteln zu Gefahrensymbolen.                           Optional kann auf eine Mittel Kennummer {kennr} gefiltert werden.                           Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          Der eindeutige Identifizierer setzt sich aus der {kennr} und dem gefahren_symbol zusammen.         {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 006978-00.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class MittelGefahrenSymbolGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                MittelGefahrenSymbol result = apiInstance.MittelGefahrenSymbolGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MittelGefahrenSymbolGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**MittelGefahrenSymbol**](MittelGefahrenSymbol.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mittelget"></a>
# **MittelGet**
> Mittel MittelGet (string kennr = null)



Liefert eine Liste aller zugelassenen Pflanzeschutzmittel.                           Optional kann auf eine Zulassungsnummer/Kennummer {kennr} gefiltert werden.                           Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          {kennr} ist der eindeutige Identifizierer, die Kennummer/Zulassungsnummer eines Mittels. Zeichenkette aus 9 Zeichen, Bsp: 024213-73.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class MittelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                Mittel result = apiInstance.MittelGet(kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MittelGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**Mittel**](Mittel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mittelvertriebget"></a>
# **MittelVertriebGet**
> MittelVertrieb MittelVertriebGet (string kennr = null, string vertriebsfirmaNr = null)



Liefert die Zuordnung von Mitteln zu Vetriebsfirmen dieser Mittel.                           Optional kann auf ein Mittel {kennr} oder eine Vertriebsfirma {vertriebsfirma_nr} gefiltert werden.          Der eindeutige Identifizierer setzt sich aus der{kennr} und der {vertriebsfirma_nr} zusammen.         {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 00A502-00.         {vertriebsfirma_nr} ist die Nummer der Vertriebsfirma, referenziert aus dem Endpunkt /adresse. Ziffernfolge aus maximal 22 Ziffern, Bsp: 11281.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class MittelVertriebGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 
            var vertriebsfirmaNr = vertriebsfirmaNr_example;  // string | Implicit parameter (optional) 

            try
            {
                MittelVertrieb result = apiInstance.MittelVertriebGet(kennr, vertriebsfirmaNr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MittelVertriebGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 
 **vertriebsfirmaNr** | **string**| Implicit parameter | [optional] 

### Return type

[**MittelVertrieb**](MittelVertrieb.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mittelwirkbereichget"></a>
# **MittelWirkbereichGet**
> MittelWirkbereich MittelWirkbereichGet (string kennr = null, string wirkungsbereich = null)



Liefert eine Liste von Zuordnungen von Mitteln zu Wirkbereichen. Die konkreten Anwendungen sind abgebildet in Endpunkt /awg. Das Feld &quot;wirkungsbereich&quot; nutzt die Kodeliste 21, die Ã¼ber den Endpunkt /kode dekodiert werden kann.                           Optional kann auf ein Mittel {kennr} oder einen  Wirkungsbereich {wirkungsbereich} gefiltert werden.                           Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          Der eindeutige Identifizierer setzt sich aus der {kennr} und dem {wirkungsbreich} zusammen.         {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 006335-00.         {wirkungsbereich} ist der Kode fÃ¼r den Wirkungsbereich eines Mittels. Die Dekodierung lÃ¤uft Ã¼ber den Endpunkt /kode. Zeichenfolge aus 20 Zeichen, Bsp: F.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class MittelWirkbereichGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 
            var wirkungsbereich = wirkungsbereich_example;  // string | Implicit parameter (optional) 

            try
            {
                MittelWirkbereich result = apiInstance.MittelWirkbereichGet(kennr, wirkungsbereich);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MittelWirkbereichGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 
 **wirkungsbereich** | **string**| Implicit parameter | [optional] 

### Return type

[**MittelWirkbereich**](MittelWirkbereich.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parallelimportabgelaufenget"></a>
# **ParallelimportAbgelaufenGet**
> ParallelimportAbgelaufen ParallelimportAbgelaufenGet (string importeurNr = null, string piReferenzKennr = null)



Liefert eine Liste der abgelaufenen Parallelimporte (Mittel aus anderen LÃ¤ndern die identisch sind zu in Deutschland zugelassenen Mitteln) zu ihren Referenzmitteln.                           Optional kann auf ein Referenzmittel {pi_referenz_kennr} oder einen Importeur {importeur_nr) gefiltert werden.                           Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          Der eindeutige Identifizierer setzt sich aus allen Attributen des Endpunktes zusammen.         {pi_referenz_kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 006768-00.         {importeur_nr} ist die Nummer des Importeurs, referenziert wird die adresse_nr des Endpunktes /adresse. Zeichenfolge aus 20 Zeichen, Bsp: 12158.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class ParallelimportAbgelaufenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var importeurNr = importeurNr_example;  // string | Implicit parameter (optional) 
            var piReferenzKennr = piReferenzKennr_example;  // string | Implicit parameter (optional) 

            try
            {
                ParallelimportAbgelaufen result = apiInstance.ParallelimportAbgelaufenGet(importeurNr, piReferenzKennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ParallelimportAbgelaufenGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **importeurNr** | **string**| Implicit parameter | [optional] 
 **piReferenzKennr** | **string**| Implicit parameter | [optional] 

### Return type

[**ParallelimportAbgelaufen**](ParallelimportAbgelaufen.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parallelimportgueltigget"></a>
# **ParallelimportGueltigGet**
> ParallelimportGueltig ParallelimportGueltigGet (string importeurNr = null, string piReferenzKennr = null)



Liefert eine Liste der gÃ¼ltigen Parallelimporte (Mittel aus anderen LÃ¤ndern die identisch sind zu in Deutschland zugelassenen Mitteln) zu ihren Referenzmitteln.                           Optional kann auf ein Referenzmittel {pi_referenz_kennr} oder einen Importeur {importeur_nr) gefiltert werden.                           Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          Der eindeutige Identifizierer setzt sich aus allen Attributen des Endpunktes zusammen.         {pi_referenz_kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 006767-00.         {importeur_nr} ist die Nummer des Importeurs, referenziert wird die adresse_nr des Endpunktes /adresse. Zeichenfolge aus 20 Zeichen, Bsp: 12158.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class ParallelimportGueltigGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var importeurNr = importeurNr_example;  // string | Implicit parameter (optional) 
            var piReferenzKennr = piReferenzKennr_example;  // string | Implicit parameter (optional) 

            try
            {
                ParallelimportGueltig result = apiInstance.ParallelimportGueltigGet(importeurNr, piReferenzKennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ParallelimportGueltigGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **importeurNr** | **string**| Implicit parameter | [optional] 
 **piReferenzKennr** | **string**| Implicit parameter | [optional] 

### Return type

[**ParallelimportGueltig**](ParallelimportGueltig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schadorggruppeget"></a>
# **SchadorgGruppeGet**
> SchadorgGruppe SchadorgGruppeGet (string schadorg = null, string schadorgGruppe = null)



Liefert eine Liste der Schadorganismen und der korrespondierenden Schadorganismengruppe. Der Enpunkt ist eine ReprÃ¤sentation einer Baumstruktur. schadorg_gruppe ist dabei ein Parent, dem das Child schadorg zugeordnet ist. Eine Schagorganismusgruppe kann mehrere Schadorganismen als Children besitzen, ein Schadorganismus kann mehrere Parents haben. Da der Baum mehrere Stufen hat, stehen einige Schadorganismen als Child (schadorg) UND als Parent (schadorg_gruppe) in unterschiedlichen Zeilen.                           Optional kann auf einen Schadorganismus {schadorg} oder eine Schadorganismusgruppe {schadorg_gruppe} gefiltert werden.                           Bei einer Ã¼bergebenen {schadorg} enthÃ¤lt die RÃ¼ckgabe nur die direkten Parents, also Schadorganismusgruppen zum korrepondierenden Schadorganismus.                           Bei einer Ã¼bergebenen {schadorg_gruppe} enthÃ¤lt die RÃ¼ckgabe nur die direkten Children, also Schadorganismen zu der korrepondierenden Schadorganismusgruppe.                           Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          Der eindeutige Identifizierer bestimmt sich aus dem {schadorg}, und der {schadorg_gruppe}.         {schadorg} ist der Kode eines Schadorganismus. (Child). Zeichenkette aus maximal 20 Zeichen, Bsp: BRORM.         {schadorg_gruppe} ist der Kode der Schdorganismusgruppe des zugeordneten Schadorganismus. (Parent). Zeichenkette aus maximal 20 Zeichen, Bsp: TTTMM.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class SchadorgGruppeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var schadorg = schadorg_example;  // string | Implicit parameter (optional) 
            var schadorgGruppe = schadorgGruppe_example;  // string | Implicit parameter (optional) 

            try
            {
                SchadorgGruppe result = apiInstance.SchadorgGruppeGet(schadorg, schadorgGruppe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SchadorgGruppeGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schadorg** | **string**| Implicit parameter | [optional] 
 **schadorgGruppe** | **string**| Implicit parameter | [optional] 

### Return type

[**SchadorgGruppe**](SchadorgGruppe.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staerkungget"></a>
# **StaerkungGet**
> Staerkung StaerkungGet (string antragstellerNr = null, string kennr = null)



Liefert eine Liste von zugelassenen StÃ¤rkungsmitteln.                           Optional kann auf die Kennummer des StÃ¤rkungsmittels {kennr} und/oder den Anstragsteller {antragsteller_nr} gefiltert werden.                           Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.          {kennr} ist der eindeutige Identifizierer, die Kennummer einer StÃ¤rkung, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 025125-00.         {antragsteller_nr} ist die Nummer des Antragstellers, referenziert wird die adresse_nr des Endpunktes /adresse. Zeichenfolge aus 20 Zeichen, Bsp: 10612.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class StaerkungGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var antragstellerNr = antragstellerNr_example;  // string | Implicit parameter (optional) 
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                Staerkung result = apiInstance.StaerkungGet(antragstellerNr, kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StaerkungGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **antragstellerNr** | **string**| Implicit parameter | [optional] 
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**Staerkung**](Staerkung.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staerkungvertriebget"></a>
# **StaerkungVertriebGet**
> StaerkungVertrieb StaerkungVertriebGet (string kennr = null, string vertriebsfirmaNr = null)



Liefert eine Zuordnung von StÃ¤rungsmitteln auf die Vertriebsfirmen der StÃ¤rkungsmittel.                           Optional kann auf die Kennummer des StÃ¤rkungsmittels {kennr} und/oder die Vertriebsfirma {vertriebsfirma_nr} gefiltert werden.                           Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {kennr] ist der eindeutige Identifizierer, die Kennummer einer StÃ¤rkung, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 007713-00.     {vertriebsfirma_nr} ist die Nummer der Vertriebsfirma, referenziert wird die adresse_nr des Endpunktes /adresse. Zeichenfolge aus 20 Zeichen, Bsp: 12791.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class StaerkungVertriebGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 
            var vertriebsfirmaNr = vertriebsfirmaNr_example;  // string | Implicit parameter (optional) 

            try
            {
                StaerkungVertrieb result = apiInstance.StaerkungVertriebGet(kennr, vertriebsfirmaNr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StaerkungVertriebGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 
 **vertriebsfirmaNr** | **string**| Implicit parameter | [optional] 

### Return type

[**StaerkungVertrieb**](StaerkungVertrieb.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="standget"></a>
# **StandGet**
> Stand StandGet ()



Liefert das Release-Datum fÃ¼r den aktuellen Datenbestand. Das heiÃŸt, das Datum an dem die Daten das letzte Mal aktualisiert wurden.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class StandGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);

            try
            {
                Stand result = apiInstance.StandGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StandGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Stand**](Stand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wirkstoffgehaltget"></a>
# **WirkstoffGehaltGet**
> WirkstoffGehalt WirkstoffGehaltGet (string kennr = null, string wirknr = null)



Liefert eine Zuordnung der Mittel und des korrespondierenden Wirkstoffgehalts.                             Optional kann auf die Nummer eines Wirkstoffes {wirknr} und/oder eines Mittels {kennr} gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer setzt sich zusammen aus der {wirknr}, der {kennr} und der wirkvar.     {wirknr} ist die Nummer des Wirkstoffes, referenziert aus dem Endpunkt /wirkstoff. Zeichenkette aus maximal 4 Zeichen, Bsp: 0875.     {kennr} ist die Kennummer eines Mittels, referenziert aus dem Endpunkt /mittel. Zeichenkette aus 9 Zeichen, Bsp: 024994-00.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class WirkstoffGehaltGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 
            var wirknr = wirknr_example;  // string | Implicit parameter (optional) 

            try
            {
                WirkstoffGehalt result = apiInstance.WirkstoffGehaltGet(kennr, wirknr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.WirkstoffGehaltGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 
 **wirknr** | **string**| Implicit parameter | [optional] 

### Return type

[**WirkstoffGehalt**](WirkstoffGehalt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wirkstoffget"></a>
# **WirkstoffGet**
> Wirkstoff WirkstoffGet (string wirknr = null)



Liefert eine Liste von zugelassenen Wirkstoffen.                             Optional kann auf einen Wirkstoff anhand der korrespondierenden Wirknummer {wirknr} gefiltert werden.                             Der Paramter ist optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {wirknr} ist der eindeutige Identifizierer des Wirkstoffes. Zeichenkette aus maximal 4 Zeichen, Bsp: 1122.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class WirkstoffGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var wirknr = wirknr_example;  // string | Implicit parameter (optional) 

            try
            {
                Wirkstoff result = apiInstance.WirkstoffGet(wirknr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.WirkstoffGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wirknr** | **string**| Implicit parameter | [optional] 

### Return type

[**Wirkstoff**](Wirkstoff.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="zusatzstoffget"></a>
# **ZusatzstoffGet**
> Zusatzstoff ZusatzstoffGet (string antragstellerNr = null, string kennr = null)



Liefert eine Liste der Zusatzstoffe zu Mitteln.                             Optional kann auf die Nummer des Zusatzstoffes {:kennr} oder die Nummer eines Antragstellers {antragsteller_nr} gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      {kennr} ist der eindeutige Identifizierer, die Kennummer des Zusatzstoffes. Zeichenfolge aus 9 Zeichen, Bsp: 008339-00.     {antragsteller_nr} ist die Nummer des Antragsstellers, referenziert wird die adresse_nr des Endpunktes /adresse. Ziffernfolge aus maximal 22 Ziffern, Bsp: 12051.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class ZusatzstoffGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var antragstellerNr = antragstellerNr_example;  // string | Implicit parameter (optional) 
            var kennr = kennr_example;  // string | Implicit parameter (optional) 

            try
            {
                Zusatzstoff result = apiInstance.ZusatzstoffGet(antragstellerNr, kennr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ZusatzstoffGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **antragstellerNr** | **string**| Implicit parameter | [optional] 
 **kennr** | **string**| Implicit parameter | [optional] 

### Return type

[**Zusatzstoff**](Zusatzstoff.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="zusatzstoffvertriebget"></a>
# **ZusatzstoffVertriebGet**
> ZusatzstoffVertrieb ZusatzstoffVertriebGet (string kennr = null, string vertriebsfirmaNr = null)



Liefert eine Zuordnung von Zusatzstoffen auf die Vertriebsfirmen der Zusatzstoffe.                             Optional kann auf die Kennummer des Zusatzstoffes {kennr} und/oder die Vertriebsfirma {vertriebsfirma_nr} gefiltert werden.                             Die Paramter sind optional; werden keine Parameter Ã¼bergeben, enthÃ¤lt die RÃ¼ckgabe alle EintrÃ¤ge.      Der eindeutige Identifizierer setzt sich zusammen aus allen Attributen des Endpunkts.     {kennr} ist die Kennummer des Zusatzstoffes, referenziert aus dem Endpunkt /zusatzstoff. Zeichenkette aus 9 Zeichen, Bsp: 005697-00.     {vertriebsfirma_nr} ist die Nummer der Vertriebsfirma, referenziert wird die adresse_nr des Endpunktes /adresse. Ziffernfolge aus maximal 22 Ziffern, Bsp: 10799.  Wenn auf andere Parameter gefiltert oder Teilabfragen gestellt werden sollen, kÃ¶nnen gesonderte Filtermethoden verwendet werden. Siehe dazu Abschnitt &quot;*JSON Queries*&quot; in der oberen allgemeinen API Beschreibung

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APICrawler.Api.Api;
using APICrawler.Api.Client;
using APICrawler.Api.Model;

namespace Example
{
    public class ZusatzstoffVertriebGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://psm-api.bvl.bund.de/ords/psm/api-v1";
            var apiInstance = new DefaultApi(config);
            var kennr = kennr_example;  // string | Implicit parameter (optional) 
            var vertriebsfirmaNr = vertriebsfirmaNr_example;  // string | Implicit parameter (optional) 

            try
            {
                ZusatzstoffVertrieb result = apiInstance.ZusatzstoffVertriebGet(kennr, vertriebsfirmaNr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ZusatzstoffVertriebGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kennr** | **string**| Implicit parameter | [optional] 
 **vertriebsfirmaNr** | **string**| Implicit parameter | [optional] 

### Return type

[**ZusatzstoffVertrieb**](ZusatzstoffVertrieb.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The queried record. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

