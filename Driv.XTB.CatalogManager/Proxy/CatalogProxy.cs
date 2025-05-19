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



        public bool IsManaged => CatalogRow.Attributes.Contains(Catalog.IsManaged) &&
                                    (bool)CatalogRow[Catalog.IsManaged];

        public bool IsCustomizable => CatalogRow.Attributes.Contains(Catalog.IsCustomizable) &&
                                   ((BooleanManagedProperty)CatalogRow[Catalog.IsCustomizable]).Value;


        public bool CanCustomize => !IsManaged || IsManaged && IsCustomizable;

        public EntityReference ParentCatalogRef => CatalogRow.Attributes.Contains(Catalog.ParentCatalog) ?
                                                    (EntityReference)CatalogRow[Catalog.ParentCatalog] :
                                                    null;


    }
}
