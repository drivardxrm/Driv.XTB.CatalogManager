﻿using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.CatalogManager.Proxy
{
    public class SolutionProxy
    {


        public Entity SolutionRow;



        public SolutionProxy(Entity solution)
        {
            SolutionRow = solution;
        }

        public Guid Id => SolutionRow.Attributes.Contains(Solution.PrimaryKey) ?
                                                    (Guid)SolutionRow[Solution.PrimaryKey] :
                                                    Guid.Empty;

        public string Prefix => ((AliasedValue)SolutionRow[$"P.{Publisher.Prefix}"]).Value.ToString();


        public string FriendlyName => SolutionRow[Solution.PrimaryName].ToString();
        public string UniqueName => SolutionRow[Solution.Name].ToString();


        public EntityReference PublisherRef => SolutionRow.Attributes.Contains(Solution.Publisher) ?
                                                    SolutionRow[Solution.Publisher] as EntityReference :
                                                    null;

    }
}
