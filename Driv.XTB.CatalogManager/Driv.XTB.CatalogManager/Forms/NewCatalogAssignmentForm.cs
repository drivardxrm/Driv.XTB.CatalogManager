using Driv.XTB.CatalogManager;
using Driv.XTB.CatalogManager.Helpers;
using Driv.XTB.CatalogManager.Proxy;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;


namespace Driv.XTB.CatalogManager.Forms
{
    public partial class NewCatalogAssignmentForm : Form
    {
        #region Private Fields

        //private Control focus;
        private IOrganizationService _service;
        

        #endregion Private Fields

        #region Public Constructors

        public NewCatalogAssignmentForm(IOrganizationService service, SolutionProxy solution, CatalogProxy parentcatalog, CatalogProxy catalog)
        {
            InitializeComponent();
            _service = service;

            
            cdsTextParentCatalog.OrganizationService = service;
            cdsTextParentCatalog.Entity = parentcatalog.CatalogRow;

            cdsTextCategory.OrganizationService = service;
            cdsTextCategory.Entity = catalog.CatalogRow;

            txtLookupCustomAPI.OrganizationService = service;
            dlgCustomAPI.Service = service;
            dlgProcess.Service = service;

            cboEntities.Service = service;

           

        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// GUID of the Catalog Assignment Created
        /// </summary>
        public Guid NewCatalogAssignmentId { get; private set; }

        #endregion Public Properties



        #region Private Event Handlers
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                var createRequest = new CreateRequest
                {
                    Target = CatalogAssignmentToCreate()
                };
                //createRequest["SolutionUniqueName"] = "CatalogTest"; //todo replace

                var createResponse = (CreateResponse)_service.Execute(createRequest);

                NewCatalogAssignmentId = createResponse.id;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult = DialogResult.None;
            }

        }



        






        #endregion Private Event Handlers

        #region Private Methods



        #endregion Private Methods





        private Entity CatalogAssignmentToCreate() 
        {
            var catalogassignment = new Entity(CatalogAssignment.EntityName);

            //if (cdsTextParentCatalog.Id != Guid.Empty) 
            //{
            //    catalog[Catalog.ParentCatalog] = cdsTextParentCatalog.EntityReference;
            //}

            catalogassignment[CatalogAssignment.PrimaryName] = txtName.Text;
            catalogassignment[CatalogAssignment.catalog] = cdsTextCategory.EntityReference;
            //catalogassignment[CatalogAssignment.CatalogAssignmentObject] = txtLookupCustomAPI.EntityReference;

            //var metadata = _service.GetMetadata(cboEntities.SelectedEntity.LogicalName);
            //var metadataid = metadata.MetadataId;

            //catalogassignment[CatalogAssignment.CatalogAssignmentObject] = new EntityReference(EntityTable.EntityName,metadataid ?? Guid.Empty);

            catalogassignment[CatalogAssignment.CatalogAssignmentObject] = txtLookupProcess.EntityReference;

            return catalogassignment;
        }

        private void btnLookupCustomAPI_Click(object sender, EventArgs e)
        {
            
            Cursor = Cursors.WaitCursor;
            switch (dlgCustomAPI.ShowDialog(this))
            {
                case DialogResult.OK:
                    txtLookupCustomAPI.Entity = dlgCustomAPI.Entity;

                    break;
                case DialogResult.Abort:
                    //txtLookupPluginType.Entity = null;
                    break;
            }

            Cursor = Cursors.Default;
            
        }

        private void btnLookupProcess_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            switch (dlgProcess.ShowDialog(this))
            {
                case DialogResult.OK:
                    txtLookupProcess.Entity = dlgProcess.Entity;

                    break;
                case DialogResult.Abort:
                    //txtLookupPluginType.Entity = null;
                    break;
            }

            Cursor = Cursors.Default;

        }

        private void cboEntities_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }
    }
}
