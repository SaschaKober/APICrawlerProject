
docker run --rm -v ${pwd}:/local openapitools/openapi-generator-cli generate -i /local/api-v1-titled_deref_v2.yaml -c /local/oa_gen_config.json -g csharp-netcore -o /local/OpenAPIClient