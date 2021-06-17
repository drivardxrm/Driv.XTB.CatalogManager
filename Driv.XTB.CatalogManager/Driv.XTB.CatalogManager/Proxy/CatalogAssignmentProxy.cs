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


        


    }
}
