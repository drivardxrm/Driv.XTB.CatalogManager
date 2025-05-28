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
        {
            Entity catalogassignment = null;
            try
            {
                catalogassignment = service.Retrieve(CatalogAssignment.EntityName, catalogassignmentid, new ColumnSet() { AllColumns = true });
            }
            catch (Exception)
            {

                // If the catalog assignment is not found, return null
            }
            return catalogassignment;
        }

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
                                <link-entity name='customapi' from='customapiid' to='object' link-type='outer' alias='customapi'>
                                  <attribute name='name' />
                                  <attribute name='customapiid' />
                                  <attribute name='displayname' />
                                </link-entity>
                                <link-entity name='entity' from='entityid' to='object' link-type='outer' alias='entity'>
                                  <attribute name='logicalname' />
                                  <attribute name='name' />
                                  <attribute name='entityid' />
                                </link-entity>
                                <link-entity name='workflow' from='workflowid' to='object' link-type='outer' alias='workflow'>
                                  <attribute name='name' />
                                  <attribute name='workflowid' />
                                </link-entity>
                                <filter>
                                  <condition attribute='catalogid' operator='eq' value='{catalogid}'/>
                                </filter>
                              </entity>
                            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            
            var fetchresult = service.RetrieveMultiple(fetch);
            // Enrich data
            if (fetchresult != null && fetchresult.Entities.Any()) {
                foreach (var assignment in fetchresult.Entities)
                {
                    if (assignment.Attributes.Contains("entity.entityid") && assignment["entity.entityid"] != null)
                    {
                        assignment["Type"] = "entity";
                        if (!assignment.Contains("name") || string.IsNullOrEmpty(assignment["name"].ToString())){
                            assignment["name"] = $"({(string)((AliasedValue)assignment["entity.name"]).Value})";
                        }
                    }
                    else if (assignment.Attributes.Contains("customapi.customapiid") && assignment["customapi.customapiid"] != null)
                    {
                        assignment["Type"] = "customapi";
                        if (!assignment.Contains("name") || string.IsNullOrEmpty(assignment["name"].ToString()))
                        {
                            assignment["name"] = $"({(string)((AliasedValue)assignment["customapi.name"]).Value})";
                        }
                    }
                    else 
                    {
                        assignment["Type"] = "workflow";
                        if (!assignment.Contains("name") || string.IsNullOrEmpty(assignment["name"].ToString()))
                        {
                            assignment["name"] = $"({(string)((AliasedValue)assignment["workflow.name"]).Value})";
                        }
                    }

                }
            }
            foreach (var item in fetchresult.Entities)
            {

            }

            return fetchresult;
        }

        

    }
}
