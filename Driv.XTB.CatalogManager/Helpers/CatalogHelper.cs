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
    public static class CatalogHelper
    {

        public static Entity GetCatalog(this IOrganizationService service, Guid catalogid)
            => service.Retrieve(Catalog.EntityName, catalogid, new ColumnSet() { AllColumns = true });

        

        public static EntityCollection GetCatalogsFor(this IOrganizationService service, Guid solutionid)
        {
            var fetchXml = $@"
            <fetch>
                <entity name='catalog'>
                <attribute name='createdonbehalfbyyominame' />
                <attribute name='modifiedonbehalfby' />
                <attribute name='statecode' />
                <attribute name='description' />
                <attribute name='statecodename' />
                <attribute name='ismanagedname' />
                <attribute name='createdonbehalfby' />
                <attribute name='name' />
                <attribute name='componentidunique' />
                <attribute name='iscustomizable' />
                <attribute name='importsequencenumber' />
                <attribute name='organizationidname' />
                <attribute name='modifiedbyyominame' />
                <attribute name='catalogid' />
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
                <attribute name='overwritetime' />
                <attribute name='parentcatalogidname' />
                <attribute name='solutionid' />
                <attribute name='uniquename' />
                <attribute name='modifiedon' />
                <attribute name='componentstate' />
                <attribute name='modifiedonbehalfbyyominame' />
                <attribute name='statuscode' />
                <attribute name='createdbyname' />
                <attribute name='createdon' />
                <attribute name='organizationid' />
                <attribute name='createdonbehalfbyname' />
                <attribute name='modifiedonbehalfbyname' />
                <attribute name='displayname' />
                <attribute name='parentcatalogid' />
                <attribute name='overriddencreatedon' />
                <filter>
                    <condition attribute='parentcatalogid' operator='null' />
                </filter>
                <link-entity name='solutioncomponent' from='objectid' to='catalogid' link-type='inner' alias='SC'>
                    <attribute name='componenttype' />
                    <attribute name='solutionid' />
                    <filter>
                        <condition attribute='solutionid' operator='eq' value='{solutionid}'/>
                    </filter>
                    
                </link-entity>
                <order attribute='name' />
                </entity>
            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        public static EntityCollection GetAllRootCatalogs(this IOrganizationService service)
        {
            var fetchXml = $@"
                            <fetch>
                              <entity name='catalog'>
                                <attribute name='createdonbehalfbyyominame' />
                                <attribute name='modifiedonbehalfby' />
                                <attribute name='statecode' />
                                <attribute name='description' />
                                <attribute name='statecodename' />
                                <attribute name='ismanagedname' />
                                <attribute name='createdonbehalfby' />
                                <attribute name='name' />
                                <attribute name='componentidunique' />
                                <attribute name='iscustomizable' />
                                <attribute name='importsequencenumber' />
                                <attribute name='organizationidname' />
                                <attribute name='modifiedbyyominame' />
                                <attribute name='catalogid' />
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
                                <attribute name='overwritetime' />
                                <attribute name='parentcatalogidname' />
                                <attribute name='solutionid' />
                                <attribute name='uniquename' />
                                <attribute name='modifiedon' />
                                <attribute name='componentstate' />
                                <attribute name='modifiedonbehalfbyyominame' />
                                <attribute name='statuscode' />
                                <attribute name='createdbyname' />
                                <attribute name='createdon' />
                                <attribute name='organizationid' />
                                <attribute name='createdonbehalfbyname' />
                                <attribute name='modifiedonbehalfbyname' />
                                <attribute name='displayname' />
                                <attribute name='parentcatalogid' />
                                <attribute name='overriddencreatedon' />
                                <filter>
                                      <condition attribute='parentcatalogid' operator='null' />
                                </filter>
                              </entity>
                            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        public static EntityCollection GetChildCatalogsFor(this IOrganizationService service, Guid parentcatalogid)
        {
            var fetchXml = $@"
                            <fetch>
                              <entity name='catalog'>
                                <attribute name='createdonbehalfbyyominame' />
                                <attribute name='modifiedonbehalfby' />
                                <attribute name='statecode' />
                                <attribute name='description' />
                                <attribute name='statecodename' />
                                <attribute name='ismanagedname' />
                                <attribute name='createdonbehalfby' />
                                <attribute name='name' />
                                <attribute name='componentidunique' />
                                <attribute name='iscustomizable' />
                                <attribute name='importsequencenumber' />
                                <attribute name='organizationidname' />
                                <attribute name='modifiedbyyominame' />
                                <attribute name='catalogid' />
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
                                <attribute name='overwritetime' />
                                <attribute name='parentcatalogidname' />
                                <attribute name='solutionid' />
                                <attribute name='uniquename' />
                                <attribute name='modifiedon' />
                                <attribute name='componentstate' />
                                <attribute name='modifiedonbehalfbyyominame' />
                                <attribute name='statuscode' />
                                <attribute name='createdbyname' />
                                <attribute name='createdon' />
                                <attribute name='organizationid' />
                                <attribute name='createdonbehalfbyname' />
                                <attribute name='modifiedonbehalfbyname' />
                                <attribute name='displayname' />
                                <attribute name='parentcatalogid' />
                                <attribute name='overriddencreatedon' />
                                <filter>
                                  <condition attribute='parentcatalogid' operator='eq' value='{parentcatalogid}'/>
                                </filter>

                              </entity>
                            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        public static EntityCollection GetAllCatalogs(this IOrganizationService service)
        {
            var fetchXml = $@"
                            <fetch>
                              <entity name='catalog'>
                                <attribute name='createdonbehalfbyyominame' />
                                <attribute name='modifiedonbehalfby' />
                                <attribute name='statecode' />
                                <attribute name='description' />
                                <attribute name='statecodename' />
                                <attribute name='ismanagedname' />
                                <attribute name='createdonbehalfby' />
                                <attribute name='name' />
                                <attribute name='componentidunique' />
                                <attribute name='iscustomizable' />
                                <attribute name='importsequencenumber' />
                                <attribute name='organizationidname' />
                                <attribute name='modifiedbyyominame' />
                                <attribute name='catalogid' />
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
                                <attribute name='overwritetime' />
                                <attribute name='parentcatalogidname' />
                                <attribute name='solutionid' />
                                <attribute name='uniquename' />
                                <attribute name='modifiedon' />
                                <attribute name='componentstate' />
                                <attribute name='modifiedonbehalfbyyominame' />
                                <attribute name='statuscode' />
                                <attribute name='createdbyname' />
                                <attribute name='createdon' />
                                <attribute name='organizationid' />
                                <attribute name='createdonbehalfbyname' />
                                <attribute name='modifiedonbehalfbyname' />
                                <attribute name='displayname' />
                                <attribute name='parentcatalogid' />
                                <attribute name='overriddencreatedon' />
                              </entity>
                            </fetch>"; 


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        public static EntityCollection GetFullCatalog(this IOrganizationService service, Guid parentcatalogid) 
        {


            var fetchXml = $@"
                            <fetch>
                              <entity name='catalog'>
                                <attribute name='catalogid' alias='root_catalogid' />
                                <attribute name='uniquename' alias='root_uniquename' />
                                <attribute name='name' alias='root_name' />
                                <attribute name='displayname' alias='root_displayname' />
                                <attribute name='description' alias='root_description' />
                                <attribute name='iscustomizable' alias='root_iscustomizable' />
                                <attribute name='ismanaged' alias='root_ismanaged' />
                                <filter>
                                  <condition attribute='catalogid' operator='eq' value='{parentcatalogid}'/>
                                </filter>
                                <link-entity name='catalog' from='parentcatalogid' to='catalogid' link-type='outer'>
                                  <attribute name='catalogid' alias='category_catalogid' />
                                  <attribute name='uniquename' alias='category_uniquename' />
                                  <attribute name='name' alias='category_name' />
                                  <attribute name='displayname' alias='category_displayname' />
                                  <attribute name='description' alias='category_description' />
                                  <attribute name='iscustomizable' alias='category_iscustomizable' />
                                  <attribute name='ismanaged' alias='category_ismanaged' />
                                  <link-entity name='catalogassignment' from='catalogid' to='catalogid' link-type='outer'>
                                    <attribute name='catalogassignmentid' alias='assignment_catalogassignmentid' />
                                    <attribute name='name' alias='assignment_name' />
                                    <attribute name='object' alias='assignment_object' />
                                    <attribute name='iscustomizable' alias='assignment_iscustomizable' />
                                    <attribute name='ismanaged' alias='assignment_ismanaged' />
                                  </link-entity>
                                </link-entity>
                              </entity>
                            </fetch>";

            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);

        }

    }
}
