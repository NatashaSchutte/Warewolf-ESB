
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using Dev2.DataList.Contract;
using Dev2.DynamicServices;
using Dev2.Runtime.Hosting;
using Dev2.Runtime.ServiceModel.Data;
using Dev2.Services.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Dev2.Tests.Runtime.Services
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class AbstractServiceExecutionTests
    {
        #region Create Service

        [TestMethod]
        // ReSharper disable InconsistentNaming
        public void ServiceExecutionAbstract_ExecuteWithCrazyXML_ShouldMap()
        // ReSharper restore InconsistentNaming
        {
            //init
            
            var mockResourceCatalog = new Mock<ResourceCatalog>(It.IsAny<IEnumerable<DynamicService>>());
            mockResourceCatalog.Setup(c => c.GetResource<WebService>(It.IsAny<Guid>(), It.IsAny<Guid>())).Verifiable();
            const string Xml = "<Service ID=\"489a3611-523c-40ce-a13d-3fc32b857cdc\" Name=\"CEWBSUpdateCommsRequest\" ResourceType=\"WebService\" IsValid=\"false\" ServerVersion=\"0.4.5578.26820\" ServerID=\"1d9aa0ae-4ecd-4c7d-b1d1-30fe5a714600\">" +
                               "<Actions>" +
                               "<Action Name=\"CEWBSUpdateCommsRequest\" Type=\"InvokeWebService\" SourceID=\"6ee209c8-04ca-4da7-a2ae-83822a738c82\" SourceName=\"SRVUpdateCommReq\" ExecuteAction=\"\" SourceMethod=\"\" RequestUrl=\"/api/CommsEngine/UpdateCommunicationRequest?CommunicationRequestID=[[CommunicationRequestID]]&amp;Result=[[Result]]&amp;Reason=[[Reason]]&amp;ScheduledFor=[[ScheduledFor]]\" RequestMethod=\"Get\" JsonPath=\"\">" +
                               "<RequestHeaders><![CDATA[Content-type: application/xml MerchantUserName: User180315 MerchantPassword: 465FDB04-EC2F-421D-9ACF-88274285F84B MerchantPublicKey: 8CE86EE7-A303-4900-90B5-C2DADCC1A931]]></RequestHeaders>" +
                               "<RequestBody><![CDATA[]]></RequestBody>" +
                               "<Inputs>" +                              
                               "</Inputs>" +
                               "<Outputs>" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsException:nil\" Name=\"Exception\" MapsTo=\"Exception\" Value=\"[[Exception]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsMessage:nil\" Name=\"Message\" MapsTo=\"Message\" Value=\"[[Message]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsResponseDate\" Name=\"ResponseDate\" MapsTo=\"ResponseDate\" Value=\"[[ResponseDate]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsResult\" Name=\"Result\" MapsTo=\"Result\" Value=\"[[Result]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsStatusCode\" Name=\"StatusCode\" MapsTo=\"StatusCode\" Value=\"[[StatusCode]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationAdded:nil\" Name=\"Added\" MapsTo=\"Added\" Value=\"[[Added]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationToSend:nil\" Name=\"ToSend\" MapsTo=\"ToSend\" Value=\"[[ToSend]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationToUpdateCommsEngineCommunicationToUpdateCommunicationRequestID\" Name=\"UpateCommunicationRequestID\" MapsTo=\"UpateCommunicationRequestID\" Value=\"[[UpateCommunicationRequestID]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationToUpdateCommsEngineCommunicationToUpdateOperationStatus\" Name=\"OperationStatus\" MapsTo=\"OperationStatus\" Value=\"[[OperationStatus]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationToUpdateCommsEngineCommunicationToUpdateReason:nil\" Name=\"UpdateReason\" MapsTo=\"UpdateReason\" Value=\"[[UpdateReason]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationToUpdateCommsEngineCommunicationToUpdateResult\" Name=\"Result\" MapsTo=\"Result\" Value=\"[[Result]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationToUpdateCommsEngineCommunicationToUpdateScheduledFor\" Name=\"ScheduledFor\" MapsTo=\"ScheduledFor\" Value=\"[[ScheduledFor]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "<Output OriginalName=\"CommsEngineResponseViewModelsCommsEngineCommunicationToView:nil\" Name=\"View\" MapsTo=\"View\" Value=\"[[View]]\" RecordsetName=\"\" RecordsetAlias=\"\" Recordset=\"\" />" +
                               "</Outputs>" +
                               "<OutputDescription><![CDATA[<z:anyType xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:d1p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Ouput\" i:type=\"d1p1:OutputDescription\" xmlns:z=\"http://schemas.microsoft.com/2003/10/Serialization/\"><d1p1:DataSourceShapes xmlns:d2p1=\"http://schemas.microsoft.com/2003/10/Serialization/Arrays\"><d2p1:anyType i:type=\"d1p1:DataSourceShape\"><d1p1:_x003C_Paths_x003E_k__BackingField><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.Exception:nil</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.Exception:nil</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[Exception]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">true</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.Message:nil</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.Message:nil</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[Message]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">true</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.ResponseDate</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.ResponseDate</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[ResponseDate]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">2015/04/30 02:02:11 PM</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.Result</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.Result</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[Result]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">OK</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.StatusCode</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.StatusCode</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[StatusCode]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">Success</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationAdded:nil</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationAdded:nil</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[Added]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">true</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToSend:nil</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToSend:nil</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[ToSend]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">true</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.CommunicationRequestID</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.CommunicationRequestID</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[UpateCommunicationRequestID]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">86d02dff-08ef-e411-a221-0018fefdef3a</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.OperationStatus</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.OperationStatus</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[OperationStatus]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">Success</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.Reason:nil</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.Reason:nil</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[UpdateReason]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">true</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.Result</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.Result</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[Result]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">Sent</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.ScheduledFor</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToUpdate.CommsEngineCommunicationToUpdate.ScheduledFor</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[ScheduledFor]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">2015-04-30T14:01:01</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType><d2p1:anyType xmlns:d5p1=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.String.Xml\" i:type=\"d5p1:XmlPath\"><_x003C_ActualPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToView:nil</_x003C_ActualPath_x003E_k__BackingField><_x003C_DisplayPath_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">CommsEngineResponseViewModels.CommsEngineCommunicationToView:nil</_x003C_DisplayPath_x003E_k__BackingField><_x003C_OutputExpression_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">[[View]]</_x003C_OutputExpression_x003E_k__BackingField><_x003C_SampleData_x003E_k__BackingField xmlns=\"http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph\">true</_x003C_SampleData_x003E_k__BackingField></d2p1:anyType></d1p1:_x003C_Paths_x003E_k__BackingField></d2p1:anyType></d1p1:DataSourceShapes><d1p1:Format>ShapedXML</d1p1:Format></z:anyType>]]></OutputDescription>" +
                               "</Action>" +
                               "</Actions>" +
                               "<TypeOf>InvokeWebService</TypeOf>" +
                               "<DisplayName>CEWBSUpdateCommsRequest</DisplayName>" +
                               "<Category>Communications\\Services\\CEWBSUpdateCommsRequest</Category>" +
                               "<VersionInfo DateTimeStamp=\"2015-04-30T14:06:56.2341245+02:00\" Reason=\"\" User=\"\" VersionNumber=\"16\" ResourceId=\"489a3611-523c-40ce-a13d-3fc32b857cdc\" VersionId=\"63895bba-05d2-414b-a4bb-bd189c793a2d\" />  " +
                               "</Service>";
            var xelement = XElement.Parse(Xml);
            var webService = new WebService(xelement);
            mockResourceCatalog.Setup(c => c.GetResource<WebService>(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(webService);
            mockResourceCatalog.Setup(c => c.GetResource<WebSource>(It.IsAny<Guid>(), It.IsAny<Guid>())).Verifiable();
            mockResourceCatalog.Setup(c => c.GetResource<WebSource>(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(new WebSource());
            var webServiceMock = new MockServiceExecutionAbstract<WebService, WebSource>(new DsfDataObject("<DataList></DataList>", Guid.NewGuid()), It.IsAny<bool>());
            webServiceMock.Service = webService;
            webServiceMock.ReturnFromExecute = "<CommsEngineResponseViewModels xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns=\"http://schemas.datacontract.org/2004/07/TU.Genisys2.CEWBS.ViewModels.Response.CommsEngine\">" +
                                               "<Exception xmlns:d2p1=\"http://schemas.datacontract.org/2004/07/System\" i:nil=\"true\" xmlns=\"http://schemas.datacontract.org/2004/07/TU.Genisys2.CEWBS.ViewModels.Response\" />" +
                                               "<Message i:nil=\"true\" xmlns=\"http://schemas.datacontract.org/2004/07/TU.Genisys2.CEWBS.ViewModels.Response\" />" +
                                               "<ResponseDate xmlns=\"http://schemas.datacontract.org/2004/07/TU.Genisys2.CEWBS.ViewModels.Response\">2015/05/06 02:07:02 PM</ResponseDate>" +
                                               "<Result xmlns=\"http://schemas.datacontract.org/2004/07/TU.Genisys2.CEWBS.ViewModels.Response\">OK</Result>" +
                                               "<StatusCode xmlns=\"http://schemas.datacontract.org/2004/07/TU.Genisys2.CEWBS.ViewModels.Response\">Success</StatusCode>" +
                                               "<CommsEngineCommunicationAdded i:nil=\"true\" />" +
                                               "<CommsEngineCommunicationToSend i:nil=\"true\" />" +
                                               "<CommsEngineCommunicationToUpdate>" +
                                               "<CommsEngineCommunicationToUpdate>" +
                                               "<CommunicationRequestID>dee2c3d6-e6f3-e411-a221-0018fefdef3a</CommunicationRequestID>" +
                                               "<OperationStatus>Success</OperationStatus>" +
                                               "<Reason i:nil=\"true\" />" +
                                               "<Result>Sent</Result>" +
                                               "<ScheduledFor>2015-05-06T14:08:00</ScheduledFor>" +
                                               "</CommsEngineCommunicationToUpdate>" +
                                               "</CommsEngineCommunicationToUpdate>" +
                                               "<CommsEngineCommunicationToView i:nil=\"true\" />" +
                                               "</CommsEngineResponseViewModels>";
            //exe
            ErrorResultTO errors;
            webServiceMock.MockExecuteImpl(null,out errors);
            Assert.IsFalse(errors.HasErrors(),"Error while parsing crazy xml");

            //assert
        }

        #endregion

    }
}
