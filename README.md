# APICrawlerProject



## Prepare Database

1. Install a MS SQL Server
2. Edit the password in script *ApiCawler_Database.sql*
3. Run the script *ApiCawler_Database.sql* 

## Tutorial

1. Run docker
2. Place you YAML or JSON OpenAPI/Swagger in Folder **APICrawlerProject**

3. Edit oa_start.ps1 to your Swagger FileName (Default: *api-v1-titled_deref_v2.yaml*) 
4. Run *run_openapi_gen.bat* File

or

3. Run the following cmd
```
docker run --rm -v ${pwd}:/local openapitools/openapi-generator-cli generate -i /local/api-v1-titled_deref_v2.yaml -c /local/oa_gen_config.json -g csharp-netcore -o /local/OpenAPIClient
```


5. Read the generated docs in **APICrawlerProject\OpenAPIClient\docs**
6. Config the *appsettings.json*
7. Edit the class *ExecuteCalls.cs* for the endpoints you want to crawl like
it's in the generated docs
8. Run you code and get a look into the database