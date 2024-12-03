/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/
namespace Opc.Ua.Onboarding.WebApi
{
    /// <summary>
    /// The namespaces used in the model.
    /// </summary>
    public static class Namespaces
    {
        /// <remarks />
        public const string Uri = "http://opcfoundation.org/UA/Onboarding/";
    }

    /// <summary>
    /// The browse names defined in the model.
    /// </summary>
    public static class BrowseNames
    {
        /// <remarks />
        public const string AddApplication = "AddApplication";
        /// <remarks />
        public const string AddEndpoint = "AddEndpoint";
        /// <remarks />
        public const string AddIdentity = "AddIdentity";
        /// <remarks />
        public const string Administration = "Administration";
        /// <remarks />
        public const string Applications = "Applications";
        /// <remarks />
        public const string ApplicationsExclude = "ApplicationsExclude";
        /// <remarks />
        public const string BaseTicketType = "BaseTicketType";
        /// <remarks />
        public const string Certificate = "Certificate";
        /// <remarks />
        public const string CertificateAuthorityType = "CertificateAuthorityType";
        /// <remarks />
        public const string Composite = "Composite";
        /// <remarks />
        public const string CompositeIdentityTicketType = "CompositeIdentityTicketType";
        /// <remarks />
        public const string CustomConfiguration = "CustomConfiguration";
        /// <remarks />
        public const string DeviceIdentityAcceptedAuditEventType = "DeviceIdentityAcceptedAuditEventType";
        /// <remarks />
        public const string DeviceIdentityAuthorities = "DeviceIdentityAuthorities";
        /// <remarks />
        public const string DeviceIdentityTicketType = "DeviceIdentityTicketType";
        /// <remarks />
        public const string DeviceRegistrar = "DeviceRegistrar";
        /// <remarks />
        public const string DeviceRegistrarAdminType = "DeviceRegistrarAdminType";
        /// <remarks />
        public const string DeviceRegistrarType = "DeviceRegistrarType";
        /// <remarks />
        public const string DeviceRegistrationAuditEventType = "DeviceRegistrationAuditEventType";
        /// <remarks />
        public const string DeviceSoftwareUpdatedAuditEventType = "DeviceSoftwareUpdatedAuditEventType";
        /// <remarks />
        public const string Endpoints = "Endpoints";
        /// <remarks />
        public const string EndpointsExclude = "EndpointsExclude";
        /// <remarks />
        public const string GetManagers = "GetManagers";
        /// <remarks />
        public const string ManagerDescription = "ManagerDescription";
        /// <remarks />
        public const string ModelVersion = "ModelVersion";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema = "Opc.Ua.Onboarding";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema = "Opc.Ua.Onboarding";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata = "http://opcfoundation.org/UA/Onboarding/";
        /// <remarks />
        public const string ProductInstanceUri = "ProductInstanceUri";
        /// <remarks />
        public const string ProvideIdentities = "ProvideIdentities";
        /// <remarks />
        public const string RegisterDeviceEndpoint = "RegisterDeviceEndpoint";
        /// <remarks />
        public const string RegisterManagedApplication = "RegisterManagedApplication";
        /// <remarks />
        public const string RegisterTickets = "RegisterTickets";
        /// <remarks />
        public const string RemoveApplication = "RemoveApplication";
        /// <remarks />
        public const string RemoveEndpoint = "RemoveEndpoint";
        /// <remarks />
        public const string RemoveIdentity = "RemoveIdentity";
        /// <remarks />
        public const string SoftwareRevision = "SoftwareRevision";
        /// <remarks />
        public const string Status = "Status";
        /// <remarks />
        public const string Ticket = "Ticket";
        /// <remarks />
        public const string TicketAuthorities = "TicketAuthorities";
        /// <remarks />
        public const string TicketListType = "TicketListType";
        /// <remarks />
        public const string UnregisterTickets = "UnregisterTickets";
        /// <remarks />
        public const string UpdateSoftwareStatus = "UpdateSoftwareStatus";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin = "RegistrarAdmin";
    }

    /// <summary>
    /// The well known identifiers for DataType nodes.
    /// </summary>
    public static class DataTypeIds {
        /// <remarks />
        public const string CertificateAuthorityType = "nsu=" + Namespaces.Uri + ";i=1164";
        /// <remarks />
        public const string BaseTicketType = "nsu=" + Namespaces.Uri + ";i=1165";
        /// <remarks />
        public const string DeviceIdentityTicketType = "nsu=" + Namespaces.Uri + ";i=1166";
        /// <remarks />
        public const string CompositeIdentityTicketType = "nsu=" + Namespaces.Uri + ";i=1167";
        /// <remarks />
        public const string TicketListType = "nsu=" + Namespaces.Uri + ";i=1168";
        /// <remarks />
        public const string ManagerDescription = "nsu=" + Namespaces.Uri + ";i=1495";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(DataTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Method nodes.
    /// </summary>
    public static class MethodIds {
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Open = "nsu=" + Namespaces.Uri + ";i=17";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Close = "nsu=" + Namespaces.Uri + ";i=20";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Read = "nsu=" + Namespaces.Uri + ";i=22";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Write = "nsu=" + Namespaces.Uri + ";i=25";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_GetPosition = "nsu=" + Namespaces.Uri + ";i=27";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_SetPosition = "nsu=" + Namespaces.Uri + ";i=30";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_AddIdentity = "nsu=" + Namespaces.Uri + ";i=5041";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_RemoveIdentity = "nsu=" + Namespaces.Uri + ";i=5043";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_AddApplication = "nsu=" + Namespaces.Uri + ";i=5045";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_RemoveApplication = "nsu=" + Namespaces.Uri + ";i=5047";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_AddEndpoint = "nsu=" + Namespaces.Uri + ";i=5049";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_RemoveEndpoint = "nsu=" + Namespaces.Uri + ";i=5051";
        /// <remarks />
        public const string DeviceRegistrarAdminType_RegisterTickets = "nsu=" + Namespaces.Uri + ";i=1176";
        /// <remarks />
        public const string DeviceRegistrarAdminType_UnregisterTickets = "nsu=" + Namespaces.Uri + ";i=1179";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Open = "nsu=" + Namespaces.Uri + ";i=1190";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Close = "nsu=" + Namespaces.Uri + ";i=1193";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Read = "nsu=" + Namespaces.Uri + ";i=1195";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Write = "nsu=" + Namespaces.Uri + ";i=1198";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_GetPosition = "nsu=" + Namespaces.Uri + ";i=1200";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_SetPosition = "nsu=" + Namespaces.Uri + ";i=1203";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=1208";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=1211";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_AddCertificate = "nsu=" + Namespaces.Uri + ";i=1214";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=1216";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Open = "nsu=" + Namespaces.Uri + ";i=1226";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Close = "nsu=" + Namespaces.Uri + ";i=1229";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Read = "nsu=" + Namespaces.Uri + ";i=1231";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Write = "nsu=" + Namespaces.Uri + ";i=1234";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_GetPosition = "nsu=" + Namespaces.Uri + ";i=1236";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_SetPosition = "nsu=" + Namespaces.Uri + ";i=1239";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=1244";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=1247";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_AddCertificate = "nsu=" + Namespaces.Uri + ";i=1250";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=1252";
        /// <remarks />
        public const string DeviceRegistrarType_ProvideIdentities = "nsu=" + Namespaces.Uri + ";i=1260";
        /// <remarks />
        public const string DeviceRegistrarType_UpdateSoftwareStatus = "nsu=" + Namespaces.Uri + ";i=1503";
        /// <remarks />
        public const string DeviceRegistrarType_RegisterDeviceEndpoint = "nsu=" + Namespaces.Uri + ";i=1263";
        /// <remarks />
        public const string DeviceRegistrarType_GetManagers = "nsu=" + Namespaces.Uri + ";i=1505";
        /// <remarks />
        public const string DeviceRegistrarType_RegisterManagedApplication = "nsu=" + Namespaces.Uri + ";i=1507";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_RegisterTickets = "nsu=" + Namespaces.Uri + ";i=1266";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_UnregisterTickets = "nsu=" + Namespaces.Uri + ";i=1269";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Open = "nsu=" + Namespaces.Uri + ";i=1280";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Close = "nsu=" + Namespaces.Uri + ";i=1283";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Read = "nsu=" + Namespaces.Uri + ";i=1285";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Write = "nsu=" + Namespaces.Uri + ";i=1288";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_GetPosition = "nsu=" + Namespaces.Uri + ";i=1290";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_SetPosition = "nsu=" + Namespaces.Uri + ";i=1293";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=1298";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=1301";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_AddCertificate = "nsu=" + Namespaces.Uri + ";i=1304";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=1306";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Open = "nsu=" + Namespaces.Uri + ";i=1316";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Close = "nsu=" + Namespaces.Uri + ";i=1319";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Read = "nsu=" + Namespaces.Uri + ";i=1321";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Write = "nsu=" + Namespaces.Uri + ";i=1324";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_GetPosition = "nsu=" + Namespaces.Uri + ";i=1326";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_SetPosition = "nsu=" + Namespaces.Uri + ";i=1329";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=1334";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=1337";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_AddCertificate = "nsu=" + Namespaces.Uri + ";i=1340";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=1342";
        /// <remarks />
        public const string DeviceRegistrar_ProvideIdentities = "nsu=" + Namespaces.Uri + ";i=1345";
        /// <remarks />
        public const string DeviceRegistrar_UpdateSoftwareStatus = "nsu=" + Namespaces.Uri + ";i=1510";
        /// <remarks />
        public const string DeviceRegistrar_RegisterDeviceEndpoint = "nsu=" + Namespaces.Uri + ";i=1348";
        /// <remarks />
        public const string DeviceRegistrar_GetManagers = "nsu=" + Namespaces.Uri + ";i=1512";
        /// <remarks />
        public const string DeviceRegistrar_RegisterManagedApplication = "nsu=" + Namespaces.Uri + ";i=1514";
        /// <remarks />
        public const string DeviceRegistrar_Administration_RegisterTickets = "nsu=" + Namespaces.Uri + ";i=1351";
        /// <remarks />
        public const string DeviceRegistrar_Administration_UnregisterTickets = "nsu=" + Namespaces.Uri + ";i=1354";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Open = "nsu=" + Namespaces.Uri + ";i=1365";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Close = "nsu=" + Namespaces.Uri + ";i=1368";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Read = "nsu=" + Namespaces.Uri + ";i=1370";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Write = "nsu=" + Namespaces.Uri + ";i=1373";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_GetPosition = "nsu=" + Namespaces.Uri + ";i=1375";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_SetPosition = "nsu=" + Namespaces.Uri + ";i=1378";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=1383";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=1386";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_AddCertificate = "nsu=" + Namespaces.Uri + ";i=1389";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=1391";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Open = "nsu=" + Namespaces.Uri + ";i=1401";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Close = "nsu=" + Namespaces.Uri + ";i=1404";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Read = "nsu=" + Namespaces.Uri + ";i=1406";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Write = "nsu=" + Namespaces.Uri + ";i=1409";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_GetPosition = "nsu=" + Namespaces.Uri + ";i=1411";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_SetPosition = "nsu=" + Namespaces.Uri + ";i=1414";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_OpenWithMasks = "nsu=" + Namespaces.Uri + ";i=1419";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_CloseAndUpdate = "nsu=" + Namespaces.Uri + ";i=1422";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_AddCertificate = "nsu=" + Namespaces.Uri + ";i=1425";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_RemoveCertificate = "nsu=" + Namespaces.Uri + ";i=1427";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(MethodIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Object nodes.
    /// </summary>
    public static class ObjectIds {
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata = "nsu=" + Namespaces.Uri + ";i=1";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin = "nsu=" + Namespaces.Uri + ";i=5034";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities = "nsu=" + Namespaces.Uri + ";i=1182";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities = "nsu=" + Namespaces.Uri + ";i=1218";
        /// <remarks />
        public const string DeviceRegistrarType_Administration = "nsu=" + Namespaces.Uri + ";i=1265";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities = "nsu=" + Namespaces.Uri + ";i=1272";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities = "nsu=" + Namespaces.Uri + ";i=1308";
        /// <remarks />
        public const string DeviceRegistrar = "nsu=" + Namespaces.Uri + ";i=1344";
        /// <remarks />
        public const string DeviceRegistrar_Administration = "nsu=" + Namespaces.Uri + ";i=1350";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities = "nsu=" + Namespaces.Uri + ";i=1357";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities = "nsu=" + Namespaces.Uri + ";i=1393";
        /// <remarks />
        public const string CertificateAuthorityType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=1439";
        /// <remarks />
        public const string BaseTicketType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=1440";
        /// <remarks />
        public const string DeviceIdentityTicketType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=1441";
        /// <remarks />
        public const string CompositeIdentityTicketType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=1442";
        /// <remarks />
        public const string TicketListType_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=1443";
        /// <remarks />
        public const string ManagerDescription_Encoding_DefaultBinary = "nsu=" + Namespaces.Uri + ";i=4206";
        /// <remarks />
        public const string CertificateAuthorityType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=1463";
        /// <remarks />
        public const string BaseTicketType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=1464";
        /// <remarks />
        public const string DeviceIdentityTicketType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=1465";
        /// <remarks />
        public const string CompositeIdentityTicketType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=1466";
        /// <remarks />
        public const string TicketListType_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=1467";
        /// <remarks />
        public const string ManagerDescription_Encoding_DefaultXml = "nsu=" + Namespaces.Uri + ";i=4214";
        /// <remarks />
        public const string CertificateAuthorityType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=1487";
        /// <remarks />
        public const string BaseTicketType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=1488";
        /// <remarks />
        public const string DeviceIdentityTicketType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=1489";
        /// <remarks />
        public const string CompositeIdentityTicketType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=1490";
        /// <remarks />
        public const string TicketListType_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=1491";
        /// <remarks />
        public const string ManagerDescription_Encoding_DefaultJson = "nsu=" + Namespaces.Uri + ";i=4222";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for ObjectType nodes.
    /// </summary>
    public static class ObjectTypeIds {
        /// <remarks />
        public const string DeviceRegistrarAdminType = "nsu=" + Namespaces.Uri + ";i=1175";
        /// <remarks />
        public const string DeviceRegistrarType = "nsu=" + Namespaces.Uri + ";i=1259";
        /// <remarks />
        public const string DeviceRegistrationAuditEventType = "nsu=" + Namespaces.Uri + ";i=1517";
        /// <remarks />
        public const string DeviceIdentityAcceptedAuditEventType = "nsu=" + Namespaces.Uri + ";i=1533";
        /// <remarks />
        public const string DeviceSoftwareUpdatedAuditEventType = "nsu=" + Namespaces.Uri + ";i=1552";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Variable nodes.
    /// </summary>
    public static class VariableIds {
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=2";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceVersion = "nsu=" + Namespaces.Uri + ";i=3";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespacePublicationDate = "nsu=" + Namespaces.Uri + ";i=4";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_IsNamespaceSubset = "nsu=" + Namespaces.Uri + ";i=5";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_StaticNodeIdTypes = "nsu=" + Namespaces.Uri + ";i=6";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_StaticNumericNodeIdRange = "nsu=" + Namespaces.Uri + ";i=7";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_StaticStringNodeIdPattern = "nsu=" + Namespaces.Uri + ";i=8";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Size = "nsu=" + Namespaces.Uri + ";i=10";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Writable = "nsu=" + Namespaces.Uri + ";i=11";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_UserWritable = "nsu=" + Namespaces.Uri + ";i=12";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_OpenCount = "nsu=" + Namespaces.Uri + ";i=13";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=18";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=19";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=21";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=23";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=24";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=26";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=28";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=29";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=31";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_DefaultRolePermissions = "nsu=" + Namespaces.Uri + ";i=33";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_DefaultUserRolePermissions = "nsu=" + Namespaces.Uri + ";i=34";
        /// <remarks />
        public const string OPCUAOnboardingNamespaceMetadata_DefaultAccessRestrictions = "nsu=" + Namespaces.Uri + ";i=35";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_Identities = "nsu=" + Namespaces.Uri + ";i=5035";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_ApplicationsExclude = "nsu=" + Namespaces.Uri + ";i=5036";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_Applications = "nsu=" + Namespaces.Uri + ";i=5037";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_EndpointsExclude = "nsu=" + Namespaces.Uri + ";i=5038";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_Endpoints = "nsu=" + Namespaces.Uri + ";i=5039";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_CustomConfiguration = "nsu=" + Namespaces.Uri + ";i=5040";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_AddIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=5042";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_RemoveIdentity_InputArguments = "nsu=" + Namespaces.Uri + ";i=5044";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_AddApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=5046";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_RemoveApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=5048";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_AddEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=5050";
        /// <remarks />
        public const string WellKnownRole_RegistrarAdmin_RemoveEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=5052";
        /// <remarks />
        public const string DeviceRegistrarAdminType_RegisterTickets_InputArguments = "nsu=" + Namespaces.Uri + ";i=1177";
        /// <remarks />
        public const string DeviceRegistrarAdminType_RegisterTickets_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1178";
        /// <remarks />
        public const string DeviceRegistrarAdminType_UnregisterTickets_InputArguments = "nsu=" + Namespaces.Uri + ";i=1180";
        /// <remarks />
        public const string DeviceRegistrarAdminType_UnregisterTickets_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1181";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Size = "nsu=" + Namespaces.Uri + ";i=1183";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Writable = "nsu=" + Namespaces.Uri + ";i=1184";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_UserWritable = "nsu=" + Namespaces.Uri + ";i=1185";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_OpenCount = "nsu=" + Namespaces.Uri + ";i=1186";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=1191";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1192";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=1194";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=1196";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1197";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=1199";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1201";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1202";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1204";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=1205";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=1209";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1210";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1212";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1213";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1215";
        /// <remarks />
        public const string DeviceRegistrarAdminType_TicketAuthorities_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1217";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Size = "nsu=" + Namespaces.Uri + ";i=1219";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Writable = "nsu=" + Namespaces.Uri + ";i=1220";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_UserWritable = "nsu=" + Namespaces.Uri + ";i=1221";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_OpenCount = "nsu=" + Namespaces.Uri + ";i=1222";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=1227";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1228";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=1230";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=1232";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1233";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=1235";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1237";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1238";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1240";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=1241";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=1245";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1246";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1248";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1249";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1251";
        /// <remarks />
        public const string DeviceRegistrarAdminType_DeviceIdentityAuthorities_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1253";
        /// <remarks />
        public const string DeviceRegistrarType_ProvideIdentities_InputArguments = "nsu=" + Namespaces.Uri + ";i=1261";
        /// <remarks />
        public const string DeviceRegistrarType_ProvideIdentities_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1262";
        /// <remarks />
        public const string DeviceRegistrarType_UpdateSoftwareStatus_InputArguments = "nsu=" + Namespaces.Uri + ";i=1504";
        /// <remarks />
        public const string DeviceRegistrarType_RegisterDeviceEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1264";
        /// <remarks />
        public const string DeviceRegistrarType_GetManagers_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1506";
        /// <remarks />
        public const string DeviceRegistrarType_RegisterManagedApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1508";
        /// <remarks />
        public const string DeviceRegistrarType_RegisterManagedApplication_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1509";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_RegisterTickets_InputArguments = "nsu=" + Namespaces.Uri + ";i=1267";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_RegisterTickets_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1268";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_UnregisterTickets_InputArguments = "nsu=" + Namespaces.Uri + ";i=1270";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_UnregisterTickets_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1271";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Size = "nsu=" + Namespaces.Uri + ";i=1273";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Writable = "nsu=" + Namespaces.Uri + ";i=1274";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_UserWritable = "nsu=" + Namespaces.Uri + ";i=1275";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_OpenCount = "nsu=" + Namespaces.Uri + ";i=1276";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=1281";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1282";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=1284";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=1286";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1287";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=1289";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1291";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1292";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1294";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=1295";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=1299";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1300";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1302";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1303";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1305";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_TicketAuthorities_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1307";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Size = "nsu=" + Namespaces.Uri + ";i=1309";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Writable = "nsu=" + Namespaces.Uri + ";i=1310";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_UserWritable = "nsu=" + Namespaces.Uri + ";i=1311";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_OpenCount = "nsu=" + Namespaces.Uri + ";i=1312";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=1317";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1318";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=1320";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=1322";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1323";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=1325";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1327";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1328";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1330";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=1331";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=1335";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1336";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1338";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1339";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1341";
        /// <remarks />
        public const string DeviceRegistrarType_Administration_DeviceIdentityAuthorities_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1343";
        /// <remarks />
        public const string DeviceRegistrar_ProvideIdentities_InputArguments = "nsu=" + Namespaces.Uri + ";i=1346";
        /// <remarks />
        public const string DeviceRegistrar_ProvideIdentities_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1347";
        /// <remarks />
        public const string DeviceRegistrar_UpdateSoftwareStatus_InputArguments = "nsu=" + Namespaces.Uri + ";i=1511";
        /// <remarks />
        public const string DeviceRegistrar_RegisterDeviceEndpoint_InputArguments = "nsu=" + Namespaces.Uri + ";i=1349";
        /// <remarks />
        public const string DeviceRegistrar_GetManagers_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1513";
        /// <remarks />
        public const string DeviceRegistrar_RegisterManagedApplication_InputArguments = "nsu=" + Namespaces.Uri + ";i=1515";
        /// <remarks />
        public const string DeviceRegistrar_RegisterManagedApplication_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1516";
        /// <remarks />
        public const string DeviceRegistrar_Administration_RegisterTickets_InputArguments = "nsu=" + Namespaces.Uri + ";i=1352";
        /// <remarks />
        public const string DeviceRegistrar_Administration_RegisterTickets_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1353";
        /// <remarks />
        public const string DeviceRegistrar_Administration_UnregisterTickets_InputArguments = "nsu=" + Namespaces.Uri + ";i=1355";
        /// <remarks />
        public const string DeviceRegistrar_Administration_UnregisterTickets_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1356";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Size = "nsu=" + Namespaces.Uri + ";i=1358";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Writable = "nsu=" + Namespaces.Uri + ";i=1359";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_UserWritable = "nsu=" + Namespaces.Uri + ";i=1360";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_OpenCount = "nsu=" + Namespaces.Uri + ";i=1361";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=1366";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1367";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=1369";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=1371";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1372";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=1374";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1376";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1377";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1379";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=1380";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=1384";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1385";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1387";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1388";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1390";
        /// <remarks />
        public const string DeviceRegistrar_Administration_TicketAuthorities_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1392";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Size = "nsu=" + Namespaces.Uri + ";i=1394";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Writable = "nsu=" + Namespaces.Uri + ";i=1395";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_UserWritable = "nsu=" + Namespaces.Uri + ";i=1396";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_OpenCount = "nsu=" + Namespaces.Uri + ";i=1397";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Open_InputArguments = "nsu=" + Namespaces.Uri + ";i=1402";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Open_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1403";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Close_InputArguments = "nsu=" + Namespaces.Uri + ";i=1405";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Read_InputArguments = "nsu=" + Namespaces.Uri + ";i=1407";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Read_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1408";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_Write_InputArguments = "nsu=" + Namespaces.Uri + ";i=1410";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_GetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1412";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_GetPosition_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1413";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_SetPosition_InputArguments = "nsu=" + Namespaces.Uri + ";i=1415";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_LastUpdateTime = "nsu=" + Namespaces.Uri + ";i=1416";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_OpenWithMasks_InputArguments = "nsu=" + Namespaces.Uri + ";i=1420";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_OpenWithMasks_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1421";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_CloseAndUpdate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1423";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_CloseAndUpdate_OutputArguments = "nsu=" + Namespaces.Uri + ";i=1424";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_AddCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1426";
        /// <remarks />
        public const string DeviceRegistrar_Administration_DeviceIdentityAuthorities_RemoveCertificate_InputArguments = "nsu=" + Namespaces.Uri + ";i=1428";
        /// <remarks />
        public const string DeviceRegistrationAuditEventType_ProductInstanceUri = "nsu=" + Namespaces.Uri + ";i=1532";
        /// <remarks />
        public const string DeviceIdentityAcceptedAuditEventType_Certificate = "nsu=" + Namespaces.Uri + ";i=1549";
        /// <remarks />
        public const string DeviceIdentityAcceptedAuditEventType_Ticket = "nsu=" + Namespaces.Uri + ";i=1550";
        /// <remarks />
        public const string DeviceIdentityAcceptedAuditEventType_Composite = "nsu=" + Namespaces.Uri + ";i=1551";
        /// <remarks />
        public const string DeviceSoftwareUpdatedAuditEventType_Status = "nsu=" + Namespaces.Uri + ";i=1563";
        /// <remarks />
        public const string DeviceSoftwareUpdatedAuditEventType_SoftwareRevision = "nsu=" + Namespaces.Uri + ";i=1568";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema = "nsu=" + Namespaces.Uri + ";i=1444";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=1446";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=1447";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_CertificateAuthorityType = "nsu=" + Namespaces.Uri + ";i=1448";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_BaseTicketType = "nsu=" + Namespaces.Uri + ";i=1451";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_DeviceIdentityTicketType = "nsu=" + Namespaces.Uri + ";i=1454";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_CompositeIdentityTicketType = "nsu=" + Namespaces.Uri + ";i=1457";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_TicketListType = "nsu=" + Namespaces.Uri + ";i=1460";
        /// <remarks />
        public const string OpcUaOnboarding_BinarySchema_ManagerDescription = "nsu=" + Namespaces.Uri + ";i=4208";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema = "nsu=" + Namespaces.Uri + ";i=1468";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_NamespaceUri = "nsu=" + Namespaces.Uri + ";i=1470";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_Deprecated = "nsu=" + Namespaces.Uri + ";i=1471";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_CertificateAuthorityType = "nsu=" + Namespaces.Uri + ";i=1472";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_BaseTicketType = "nsu=" + Namespaces.Uri + ";i=1475";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_DeviceIdentityTicketType = "nsu=" + Namespaces.Uri + ";i=1478";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_CompositeIdentityTicketType = "nsu=" + Namespaces.Uri + ";i=1481";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_TicketListType = "nsu=" + Namespaces.Uri + ";i=1484";
        /// <remarks />
        public const string OpcUaOnboarding_XmlSchema_ManagerDescription = "nsu=" + Namespaces.Uri + ";i=4216";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(VariableIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }
    
}
