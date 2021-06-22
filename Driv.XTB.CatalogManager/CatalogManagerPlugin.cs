using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Driv.XTB.CatalogManager
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Catalog Manager"),
        ExportMetadata("Description", "Dataverse Catalog / Catalog Assignment Manager"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "AAABAAEAICAAAAEAIACoEAAAFgAAACgAAAAgAAAAQAAAAAEAIAAAAAAAABAAAMMOAADDDgAAAAAAAAAAAAD/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////9v3//3Xc//9K0f//T9P//0/T//9P0///T9P//0/T//9P0///T9P//0/T//9P0///T9P//0/T//9P0///T9P//0/T//9P0///T9P//0/T//9P0///StH//3Xc///2/P////////////////////////////////////////////8hx///ALv//wC+//8Avv//AL7//wC+//8Avv//AL7//wC+//8Avv//AL7//wC+//8Avv//AL7//wC+//8Avv//AL7//wC+//8Avv//AL7//wC+//8Avv//ALv//yLH/////////////////////////////////////////////wC5//8GwP//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8GwP//ALn/////////////////////////////////////////////ALn//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//BsH//wDB//8Awf//AMH//wDB//8Gwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8Auf////////////////////////////////////////////8Auf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wPB//8Awf//WLzJ/6K4mP+huJj/V73J/wDB//8Dwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wC5/////////////////////////////////////////////wC5//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8Dwf//DcH6/8G3hf//s1L//7ln//+5Z///s1L/wbeF/w3A+v8Dwf//B8H//wfB//8Hwf//B8H//wfB//8Hwf//ALn/////////////////////////////////////////////ALj//wfB//8Hwf//B8H//wfB//8Hwf//B8H//wDB//+Buq7//7NX//jGiP/5y5L/+cuS//jGh///slX/gbqu/wDB//8Hwf//B8H//wfB//8Hwf//B8H//wfB//8AuP////////////////////////////////////////////8AuP//ALv//wDB//8Awf//AMH//wDB//8Awf//AMP///yzXP/7wHr/+cuU//nKkP/5ypD/+cyU//q/ef/7sl3/AMP//wDB//8Awf//AMH//wDB//8Awf//ALv//wC4/////////////////////////////////////////////73u//+18v//r7GC/7C3j/+wt4//sLeP/7C3j/+muJX//rFY//jDgv/5ypH/+cqQ//nKkP/5ypH/+MOC//6yWP+muJX/sLeP/7C3j/+wt4//sLeP/6+xgv+18v//vu7/////////////////////////////////////////////////////////slj//7pq//+6av//umr//7pq//+6av/3uW7/+MWG//nKkf/5ypD/+cqQ//nKkf/4xYb/97lu//+6av//umr//7pq//+6av//umr//7JY//////////////////////////////////////////////////////////////////jFhf/5y5P/+cuT//nLk//5y5P/+cuT//nLk//5ypH/+cqQ//nKkP/5ypD/+cqQ//nKkf/5y5P/+cuT//nLk//5y5P/+cuT//nLk//4xYX/////////////////////////////////////////////////////////////////+MOC//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//jDgv/////////////////////////////////////////////////////////////////4w4L/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+MOC//////////////////////////////////////////////////////////////////jDgv/5ypD//NCZ//zQmf/80Jn//NCZ//zQmf/80Jn//NCZ//zQmf/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/4w4L/////////////////////////////////////////////////////////////////+MOC//zQmf/YhCz/24s2/9uLNv/bizb/24s2/9uLNv/bizb/2IQs//zQmf/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//jDgv/////////////////////////////////////////////////////////////////4w4L//NGZ/9iDLP/bijb/24o2/9uKNv/bijb/24o2/9uKNv/Ygyz//NGZ//nKkP/5ypD/+cqQ//nKkP/5ypD/+cqQ//nKkP/5ypD/+MOC//////////////////////////////////////////////////////////////////jDgv/5ypD//9uo///bqP//26j//9uo///bqP/91J7//dSe///bqP/91J7//dSe//3Unv/6zZX/+cqQ//nKkP/5ypD/+cqQ//nKkP/4w4L/////////////////////////////////////////////////////////////////+MOC//3Unv/FWgD/yWQA/8lkAP/JZAD/xl0A/+yvaf/sr2n/xl0A/8lkAP/JZAD/xl0A/+qrZP/6zZX/+cqQ//nKkP/5ypD/+cqQ//jDgv/////////////////////////////////////////////////////////////////4w4L/+s2U/+utaP/tsW3/7bFt/+2xbf/sr2n/9sSH//bEh//sr2n/7bFt/+2xbf/sr2n/9cKF//nLkf/5ypD/+cqQ//nKkP/5ypD/+MOC//////////////////////////////////////////////////////////////////jDgv/5ypD/+s2U//rNlP/6zZT/+s2U//rNlP/5y5H/+cuR//rNlP/6zZT/+s2U//rNlP/5y5H/+cqQ//nKkP/5ypD/+cqQ//nKkP/4w4L/////////////////////////////////////////////////////////////////+MF9//nKkP/5y5P/+cuT//nLk//5y5P/+cuT//nLk//5y5P/+cuT//nLk//5y5P/+cuT//nLk//5y5P/+cuT//nLk//5y5P/+cqQ//jBff/////////////////////////////////////////////////////////////////616z/+MaJ//e9dv/3v3n/9795//e/ef/3v3n/9795//e/ef/3v3n/9795//e/ef/3v3n/9795//e/ef/3v3n/9795//e9dv/4xon/+tes///////////////////////////////////////////////////////////////////////3vHL/85st//SgOP/0oDj/9KA4//SgOP/0oDj/9KA4//SgOP/0oDj/9KA4//SgOP/0oDj/9KA4//SgOP/0oDj/85st//e8cv////////////////////////////////////////////////////////////////////////////nSov/3uGr/9a5V//avWP/2r1j/9q9Y//avWP/2r1j/9q9Y//avWP/2r1j/9q9Y//avWP/2r1j/9q9Y//WuVf/3uGr/+dKi//////////////////////////////////////////////////////////////////////////////////306f/4xoj/+cqR//nKkf/5ypH/+cqR//nKkf/5ypH/+cqR//nKkf/5ypH/+cqR//nKkf/5ypH/+MaI//306f///////////////////////////////////////////////////////////////////////////////////////fPn//rWqv/62bD/+tmw//rZsP/62bD/+tmw//rZsP/62bD/+tmw//rZsP/62bD/+tmw//rZsP/61qr//fPn////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class CatalogManagerPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new CatalogManagerControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public CatalogManagerPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}