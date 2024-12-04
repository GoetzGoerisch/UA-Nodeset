## OpenAPI and JSON Schemas
### Overview
Starting with the 1.05.04 release of the Core specification the normative files include [OpenAPI](https://swagger.io/specification/) and [JSON schemas](https://json-schema.org/specification) for all OPC UA defined Services and DataTypes. 

### Generating Stubs for the OPC UA WebApi
These definitions can be used with the OpenAPI generator to create stubs for OPC UA WebApi in different programming languages. The OPC Foundation publishes pre-generator stubs for a common development environents as listed in the following table. 

| Language | Repository |
|--|--|
|dotnet|[https://github.com/OPCFoundation/opcua-webapi-dotnet](https://github.com/OPCFoundation/opcua-webapi-dotnet)|
|python|[https://github.com/OPCFoundation/opcua-webapi-python](https://github.com/OPCFoundation/opcua-webapi-python)|
|typescript|[https://github.com/OPCFoundation/opcua-webapi-typescript](https://github.com/OPCFoundation/opcua-webapi-typescript)|

Additional development environent will be added based on community requests.

These schema files will also be published for every Companion Specification moving forward. 

### BrowseNames and NodeIds
The specification defines many well-known NodeIds and BrowseNames. These values are defined as constants in files for different development environments. The available definitions are in the the [Constants](./Constants/) folder.

These files are generated automatically with the [OPC UA ModelCompiler](https://github.com/OPCFoundation/UA-ModelCompiler). Support for additional languages will be based on community demand (voluteers are needed to create examples for the templates and to test the published files).

These constant files will also be published for every Companion Specification moving forward. 


