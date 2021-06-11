using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.CatalogManager.Proxy
{
    public class CatalogProxy
    {


        public Entity CatalogRow;



        public CatalogProxy(Entity catalog)
        {
            CatalogRow = catalog;
        }



        public string Name => CatalogRow.Attributes.Contains(Catalog.PrimaryName) ?
                                                    CatalogRow[Catalog.PrimaryName].ToString() :
                                                    string.Empty;
        public string UniqueName => CatalogRow.Attributes.Contains(Catalog.UniqueName) ?
                                                    CatalogRow[Catalog.UniqueName].ToString() :
                                                    string.Empty;



        public string DisplayName => CatalogRow.Attributes.Contains(Catalog.DisplayName) ?
                                                    CatalogRow[Catalog.DisplayName].ToString() :
                                                    string.Empty;

        public string Description => CatalogRow.Attributes.Contains(Catalog.Description) ?
                                                    CatalogRow[Catalog.Description].ToString() :
                                                    string.Empty;


        //public string BoundEntityLogicalName => CatalogRow.Attributes.Contains(CustomAPI.BoundEntityLogicalName) ?
        //                                            CatalogRow[CustomAPI.BoundEntityLogicalName].ToString() :
        //                                            string.Empty;


        //public CustomAPI.BindingType_OptionSet BindingType => (CustomAPI.BindingType_OptionSet)(CatalogRow[CustomAPI.BindingType] as OptionSetValue).Value;

        //public CustomAPI.AllowedCustomProcessingStepType_OptionSet AllowedProcesingStep => (CustomAPI.AllowedCustomProcessingStepType_OptionSet)(CatalogRow[CustomAPI.AllowedCustomProcessingStepType] as OptionSetValue).Value;

        //public EntityReference PluginType => CatalogRow.Attributes.Contains(CustomAPI.PluginType) ?
        //                                            CatalogRow[CustomAPI.PluginType] as EntityReference :
        //                                            null;


        //public string ExecutePrivilegeName => CatalogRow.Attributes.Contains(CustomAPI.ExecutePrivilegeName) ?
        //                                            CatalogRow[CustomAPI.ExecutePrivilegeName].ToString() :
        //                                            string.Empty;

        //public bool IsFunction => CatalogRow.Attributes.Contains(CustomAPI.IsFunction) &&
        //                            (bool)CatalogRow[CustomAPI.IsFunction];

        //public bool EnabledforWorkflow => CatalogRow.Attributes.Contains(CustomAPI.EnabledforWorkflow) &&
        //                            (bool)CatalogRow[CustomAPI.EnabledforWorkflow];

        //public bool IsPrivate => CatalogRow.Attributes.Contains(CustomAPI.IsPrivate) &&
        //                            (bool)CatalogRow[CustomAPI.IsPrivate];

        public bool IsManaged => CatalogRow.Attributes.Contains(Catalog.IsManaged) &&
                                    (bool)CatalogRow[Catalog.IsManaged];

        public bool IsCustomizable => CatalogRow.Attributes.Contains(Catalog.IsCustomizable) &&
                                   ((BooleanManagedProperty)CatalogRow[Catalog.IsCustomizable]).Value;


        public bool CanCustomize => !IsManaged || IsManaged && IsCustomizable;


    }
}
