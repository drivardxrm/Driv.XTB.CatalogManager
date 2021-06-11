using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.CatalogManager.Helpers
{
    public static class EntityHelper
    {

        public static EntityMetadata[] GetAllMetadata(this IOrganizationService service)
        {
            var retrieveAllEntityRequest = new RetrieveAllEntitiesRequest
            {
                RetrieveAsIfPublished = false,
                EntityFilters = EntityFilters.Attributes
            };
            var retrieveAllEntityResponse = (RetrieveAllEntitiesResponse)service.Execute(retrieveAllEntityRequest);

            return retrieveAllEntityResponse.EntityMetadata;
        }

        public static EntityMetadata GetMetadata(this IOrganizationService service, string entityname)
        {
            RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
            {
                EntityFilters = EntityFilters.Attributes,
                LogicalName = entityname,
                RetrieveAsIfPublished = false
            };
            RetrieveEntityResponse entityResponse = (RetrieveEntityResponse)service.Execute(entityRequest);

            return entityResponse.EntityMetadata;
        }



        

    }
}
