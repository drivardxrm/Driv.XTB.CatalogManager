// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.1.2 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://drivard-dev.crm.dynamics.com/
// Filename   : C:\GithubRepos\Driv.XTB.CatalogManager\Driv.XTB.CatalogManager\Driv.XTB.CatalogManager\Entities\Process.cs
// Created    : 2021-06-11 00:10:32
// *********************************************************************

namespace Driv.XTB.CatalogManager
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Process
    {
        public const string EntityName = "workflow";
        public const string EntityCollectionName = "workflows";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "workflowid";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 100, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: workflow</summary>
        public const string ActiveProcessID = "activeworkflowid";
        /// <summary>Type: ManagedProperty, RequiredLevel: SystemRequired</summary>
        public const string Allowcustomprocessingstepforotherpublishers = "iscustomprocessingstepallowedforotherpublishers";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Business Process Type, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string BusinessProcessType = "businessprocesstype";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Category, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Category = "category";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string ClientData = "clientdata";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Component State, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ComponentState = "componentstate";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Workflow Stage, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string CreateStage = "createstage";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: ManagedProperty, RequiredLevel: SystemRequired</summary>
        public const string Customizable = "iscustomizable";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string DeleteJobOnCompletion = "asyncautodelete";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Workflow Stage, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Deletestage = "deletestage";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 100000</summary>
        public const string Description = "description";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Desktop Flow Type, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string DesktopFlowType = "uiflowtype";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string EntityImageId = "entityimageid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string FormID = "formid";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string InputParameters = "inputparameters";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 48, Format: VersionNumber</summary>
        public const string IntroducedVersion = "introducedversion";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsChildProcess = "subprocess";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsCRMProcess = "iscrmuiworkflow";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsManaged = "ismanaged";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: True</summary>
        public const string IsTransacted = "istransacted";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string Language = "languagecode";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string LoguponFailure = "syncworkflowlogonfailure";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Mode, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string Mode = "mode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: workflow</summary>
        public const string ParentProcessID = "parentworkflowid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sdkmessagefilter</summary>
        public const string plugintypeid = "plugintypeid";
        /// <summary>Type: EntityName, RequiredLevel: SystemRequired, DisplayName: Primary Entity, OptionSetType: Picklist</summary>
        public const string PrimaryEntity = "primaryentity";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string ProcessOrder = "processorder";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ProcessTriggerFormId = "processtriggerformid";
        /// <summary>Type: Picklist, RequiredLevel: None, OptionSetType: Picklist</summary>
        public const string ProcessTriggerScope = "processtriggerscope";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string Rank = "rank";
        /// <summary>Type: DateTime, RequiredLevel: SystemRequired, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RecordOverwriteTime = "overwritetime";
        /// <summary>Type: EntityName, RequiredLevel: None</summary>
        public const string RendererType = "rendererobjecttypecode";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1048576</summary>
        public const string RoleassignmentforProcess = "processroleassignment";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string RunasOnDemand = "ondemand";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Executing User, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string RunAsUser = "runas";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Scope, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Scope = "scope";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sdkmessage</summary>
        public const string SDKMessage = "sdkmessageid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string Solution = "solutionid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Solution1 = "supportingsolutionid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string TriggerOnCreate = "triggeroncreate";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string TriggerOnDelete = "triggerondelete";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string TriggerOnUpdateAttributeList = "triggeronupdateattributelist";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Type, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Type = "type";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string UIData = "uidata";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 256, Format: Text</summary>
        public const string UniqueName = "uniquename";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Workflow Stage, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string UpdateStage = "updatestage";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string workflowidunique = "workflowidunique";
        /// <summary>Type: Memo, RequiredLevel: ApplicationRequired, MaxLength: 1073741823</summary>
        public const string xaml = "xaml";

        #endregion Attributes

        #region OptionSets

        public enum BusinessProcessType_OptionSet
        {
            BusinessFlow = 0,
            TaskFlow = 1
        }
        public enum Category_OptionSet
        {
            Workflow = 0,
            Dialog = 1,
            BusinessRule = 2,
            Action = 3,
            BusinessProcessFlow = 4,
            ModernFlow = 5,
            DesktopFlow = 6
        }
        public enum ComponentState_OptionSet
        {
            Published = 0,
            Unpublished = 1,
            Deleted = 2,
            DeletedUnpublished = 3
        }
        public enum CreateStage_OptionSet
        {
            Pre_operation = 20,
            Post_operation = 40
        }
        public enum Deletestage_OptionSet
        {
            Pre_operation = 20,
            Post_operation = 40
        }
        public enum DesktopFlowType_OptionSet
        {
            WindowsrecorderV1 = 0,
            SeleniumIDE = 1,
            PowerAutomateDesktop = 2
        }
        public enum Mode_OptionSet
        {
            Background = 0,
            Real_time = 1
        }
        public enum PrimaryEntity_OptionSet
        {
        }
        public enum ProcessTriggerScope_OptionSet
        {
            Form = 1,
            Entity = 2
        }
        public enum RendererType_OptionSet
        {
        }
        public enum RunAsUser_OptionSet
        {
            Owner = 0,
            CallingUser = 1
        }
        public enum Scope_OptionSet
        {
            User = 1,
            BusinessUnit = 2,
            ParentChildBusinessUnits = 3,
            Organization = 4
        }
        public enum Status_OptionSet
        {
            Draft = 0,
            Activated = 1
        }
        public enum StatusReason_OptionSet
        {
            Draft = 1,
            Activated = 2
        }
        public enum Type_OptionSet
        {
            Definition = 1,
            Activation = 2,
            Template = 3
        }
        public enum UpdateStage_OptionSet
        {
            Pre_operation = 20,
            Post_operation = 40
        }

        #endregion OptionSets
    }
}
