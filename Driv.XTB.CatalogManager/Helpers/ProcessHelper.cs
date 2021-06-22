using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.CatalogManager.Helpers
{
    public static class ProcessHelper
    {

        public static Entity GetProcess(this IOrganizationService service, Guid processid)
            => service.Retrieve(Process.EntityName, processid, new ColumnSet() { AllColumns = true });

        

        //public static EntityCollection GetCustomApisFor(this IOrganizationService service, Guid solutionid)
        //{
        //    var fetchXml = $@"
        //    <fetch>
        //      <entity name='customapi'>
        //        <attribute name='createdonbehalfbyyominame' />
        //        <attribute name='owninguser' />
        //        <attribute name='statecode' />
        //        <attribute name='owneridname' />
        //        <attribute name='description' />
        //        <attribute name='statecodename' />
        //        <attribute name='ismanagedname' />
        //        <attribute name='createdonbehalfby' />
        //        <attribute name='isfunctionname' />
        //        <attribute name='sdkmessageidname' />
        //        <attribute name='name' />
        //        <attribute name='componentidunique' />
        //        <attribute name='iscustomizable' />
        //        <attribute name='isprivate' />
        //        <attribute name='customapiid' />
        //        <attribute name='importsequencenumber' />
        //        <attribute name='bindingtypename' />
        //        <attribute name='modifiedbyyominame' />
        //        <attribute name='allowedcustomprocessingsteptype' />
        //        <attribute name='componentstate' />
        //        <attribute name='allowedcustomprocessingsteptypename' />
        //        <attribute name='utcconversiontimezonecode' />
        //        <attribute name='createdbyyominame' />
        //        <attribute name='owningbusinessunit' />
        //        <attribute name='modifiedbyname' />
        //        <attribute name='owningteam' />
        //        <attribute name='isfunction' />
        //        <attribute name='workflowsdkstepenabled' />
        //        <attribute name='modifiedby' />
        //        <attribute name='createdby' />
        //        <attribute name='timezoneruleversionnumber' />
        //        <attribute name='sdkmessageid' />
        //        <attribute name='plugintypeid' />
        //        <attribute name='owneridtype' />
        //        <attribute name='statuscodename' />
        //        <attribute name='overwritetime' />
        //        <attribute name='uniquename' />
        //        <attribute name='solutionid' />
        //        <attribute name='owneridyominame' />
        //        <attribute name='modifiedon' />
        //        <attribute name='displayname' />
        //        <attribute name='bindingtype' />
        //        <attribute name='ismanaged' />
        //        <attribute name='statuscode' />
        //        <attribute name='createdbyname' />
        //        <attribute name='createdon' />
        //        <attribute name='plugintypeidname' />
        //        <attribute name='componentstatename' />
        //        <attribute name='boundentitylogicalname' />
        //        <attribute name='executeprivilegename' />
        //        <attribute name='isprivatename' />
        //        <attribute name='ownerid' />
        //        <link-entity name='solutioncomponent' from='objectid' to='customapiid' link-type='inner' alias='SC'>
        //            <attribute name='componenttype' />
        //            <attribute name='solutionid' />
        //            <filter>
        //                <condition attribute='solutionid' operator='eq' value='{solutionid}'/>
        //            </filter>
                    
        //        </link-entity>
        //        <order attribute='name' />
        //      </entity>
        //    </fetch>";


        //    var fetch = new FetchExpression(fetchXml);
        //    return service.RetrieveMultiple(fetch);
        //}

        //public static EntityCollection GetAllCustomApis(this IOrganizationService service)
        //{
        //    var fetchXml = $@"
        //    <fetch>
        //      <entity name='customapi'>
        //        <attribute name='createdonbehalfbyyominame' />
        //        <attribute name='owninguser' />
        //        <attribute name='statecode' />
        //        <attribute name='owneridname' />
        //        <attribute name='description' />
        //        <attribute name='statecodename' />
        //        <attribute name='ismanagedname' />
        //        <attribute name='createdonbehalfby' />
        //        <attribute name='isfunctionname' />
        //        <attribute name='sdkmessageidname' />
        //        <attribute name='name' />
        //        <attribute name='componentidunique' />
        //        <attribute name='iscustomizable' />
        //        <attribute name='isprivate' />
        //        <attribute name='customapiid' />
        //        <attribute name='importsequencenumber' />
        //        <attribute name='bindingtypename' />
        //        <attribute name='modifiedbyyominame' />
        //        <attribute name='allowedcustomprocessingsteptype' />
        //        <attribute name='componentstate' />
        //        <attribute name='allowedcustomprocessingsteptypename' />
        //        <attribute name='utcconversiontimezonecode' />
        //        <attribute name='createdbyyominame' />
        //        <attribute name='owningbusinessunit' />
        //        <attribute name='modifiedbyname' />
        //        <attribute name='owningteam' />
        //        <attribute name='isfunction' />
        //        <attribute name='workflowsdkstepenabled' />
        //        <attribute name='modifiedby' />
        //        <attribute name='createdby' />
        //        <attribute name='timezoneruleversionnumber' />
        //        <attribute name='sdkmessageid' />
        //        <attribute name='plugintypeid' />
        //        <attribute name='owneridtype' />
        //        <attribute name='statuscodename' />
        //        <attribute name='overwritetime' />
        //        <attribute name='uniquename' />
        //        <attribute name='solutionid' />
        //        <attribute name='owneridyominame' />
        //        <attribute name='modifiedon' />
        //        <attribute name='displayname' />
        //        <attribute name='bindingtype' />
        //        <attribute name='ismanaged' />
        //        <attribute name='statuscode' />
        //        <attribute name='createdbyname' />
        //        <attribute name='createdon' />
        //        <attribute name='plugintypeidname' />
        //        <attribute name='componentstatename' />
        //        <attribute name='boundentitylogicalname' />
        //        <attribute name='executeprivilegename' />
        //        <attribute name='isprivatename' />
        //        <attribute name='ownerid' />
        //        <order attribute='name' />

        //      </entity>
        //    </fetch>";


        //    var fetch = new FetchExpression(fetchXml);
        //    return service.RetrieveMultiple(fetch);
        //}

    }
}
