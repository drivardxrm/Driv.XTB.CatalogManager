// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.1.2 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://drivard-dev.crm.dynamics.com/
// Filename   : C:\GithubRepos\Driv.XTB.CatalogManager\Driv.XTB.CatalogManager\Driv.XTB.CatalogManager\Entities\Entity.cs
// Created    : 2021-06-11 00:10:32
// *********************************************************************

namespace Driv.XTB.CatalogManager
{
    /// <summary>OwnershipType: None, IntroducedVersion: 9.1.0.0</summary>
    public static class EntityTable
    {
        public const string EntityName = "entity";
        public const string EntityCollectionName = "entities";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "entityid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string AddressTableName = "addresstablename";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string BaseTableName = "basetablename";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string CollectionName = "collectionname";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Component State, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ComponentState = "componentstate";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string EntitySetName = "entitysetname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string ExtensionTableName = "extensiontablename";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string ExternalCollectionName = "externalcollectionname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string ExternalName = "externalname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string LogicalCollectionName = "logicalcollectionname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string LogicalName = "logicalname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string OriginalLocalizedCollectionName = "originallocalizedcollectionname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string OriginalLocalizedName = "originallocalizedname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string ParentControllingAttributeName = "parentcontrollingattributename";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string PhysicalName = "physicalname";
        /// <summary>Type: DateTime, RequiredLevel: SystemRequired, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RecordOverwriteTime = "overwritetime";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string ReportViewName = "reportviewname";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string Solution = "solutionid";

        #endregion Attributes

        #region OptionSets

        public enum ComponentState_OptionSet
        {
            Published = 0,
            Unpublished = 1,
            Deleted = 2,
            DeletedUnpublished = 3
        }

        #endregion OptionSets
    }
}
