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
    public static class CatalogAssignmentHelper
    {

        public static Entity GetCatalogAssignment(this IOrganizationService service, Guid catalogassignmentid)
            => service.Retrieve(CatalogAssignment.EntityName, catalogassignmentid, new ColumnSet() { AllColumns = true });

        

        public static EntityCollection GetCatalogAssignmentsFor(this IOrganizationService service, Guid catalogid)
        {

            var fetchXml = $@"
                            <fetch>
                              <entity name='catalogassignment'>
                                <attribute name='objectname' />
                                <attribute name='createdonbehalfbyyominame' />
                                <attribute name='modifiedonbehalfby' />
                                <attribute name='statecode' />
                                <attribute name='statecodename' />
                                <attribute name='ismanagedname' />
                                <attribute name='createdonbehalfby' />
                                <attribute name='objectyominame' />
                                <attribute name='name' />
                                <attribute name='componentidunique' />
                                <attribute name='iscustomizable' />
                                <attribute name='catalogidname' />
                                <attribute name='importsequencenumber' />
                                <attribute name='organizationidname' />
                                <attribute name='modifiedbyyominame' />
                                <attribute name='componentstate' />
                                <attribute name='utcconversiontimezonecode' />
                                <attribute name='createdbyyominame' />
                                <attribute name='componentstatename' />
                                <attribute name='modifiedbyname' />
                                <attribute name='versionnumber' />
                                <attribute name='modifiedby' />
                                <attribute name='createdby' />
                                <attribute name='timezoneruleversionnumber' />
                                <attribute name='ismanaged' />
                                <attribute name='statuscodename' />
                                <attribute name='catalogassignmentid' />
                                <attribute name='overwritetime' />
                                <attribute name='catalogid' />
                                <attribute name='object' />
                                <attribute name='solutionid' />
                                <attribute name='modifiedon' />
                                <attribute name='modifiedonbehalfbyyominame' />
                                <attribute name='statuscode' />
                                <attribute name='createdbyname' />
                                <attribute name='createdon' />
                                <attribute name='organizationid' />
                                <attribute name='createdonbehalfbyname' />
                                <attribute name='modifiedonbehalfbyname' />
                                <attribute name='objectidtype' />
                                <attribute name='overriddencreatedon' />
                                <filter>
                                  <condition attribute='catalogid' operator='eq' value='{catalogid}'/>
                                </filter>
                              </entity>
                            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        

    }
}
