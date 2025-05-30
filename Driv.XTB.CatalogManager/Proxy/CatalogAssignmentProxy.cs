﻿using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.CatalogManager.Proxy
{
    public class CatalogAssignmentProxy
    {


        public Entity CatalogAssignmentRow;



        public CatalogAssignmentProxy(Entity catalogassignment)
        {
            CatalogAssignmentRow = catalogassignment;
        }

        public Guid Id => CatalogAssignmentRow.Attributes.Contains(CatalogAssignment.PrimaryKey) ?
                                                    (Guid)CatalogAssignmentRow[CatalogAssignment.PrimaryKey] :
                                                    Guid.Empty;

        public string Name => CatalogAssignmentRow.Attributes.Contains(CatalogAssignment.PrimaryName) ?
                                                    CatalogAssignmentRow[CatalogAssignment.PrimaryName].ToString() :
                                                    string.Empty;
        public EntityReference Object => CatalogAssignmentRow.Attributes.Contains(CatalogAssignment.CatalogAssignmentObject) ?
                                                    CatalogAssignmentRow[CatalogAssignment.CatalogAssignmentObject] as EntityReference :
                                                    null;

        public string ObjectType => Object?.LogicalName;



        public string ObjectIdType => CatalogAssignmentRow.Attributes.Contains(CatalogAssignment.objectidtype) ?
                                                    CatalogAssignmentRow[CatalogAssignment.objectidtype].ToString() :
                                                    string.Empty;

        

        public bool IsCustomizable => CatalogAssignmentRow.Attributes.Contains(CatalogAssignment.IsCustomizable) &&
                                   ((BooleanManagedProperty)CatalogAssignmentRow[CatalogAssignment.IsCustomizable]).Value;


        public bool IsManaged => CatalogAssignmentRow.Attributes.Contains(CatalogAssignment.IsManaged) &&
                                    (bool)CatalogAssignmentRow[CatalogAssignment.IsManaged];

        


        public bool CanCustomize => !IsManaged || IsManaged && IsCustomizable;

        public EntityReference CatalogRef => CatalogAssignmentRow.Attributes.Contains(CatalogAssignment.catalog) ?
                                                    (EntityReference)CatalogAssignmentRow[CatalogAssignment.catalog] :
                                                    null;


    }
}
