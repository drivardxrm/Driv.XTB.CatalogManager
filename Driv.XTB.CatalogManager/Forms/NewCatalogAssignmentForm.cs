﻿using Driv.XTB.CatalogManager;
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
        private SolutionProxy _selectedSolution;

        #endregion Private Fields

        #region Public Constructors

        public NewCatalogAssignmentForm(IOrganizationService service, SolutionProxy solution, CatalogProxy parentcatalog, CatalogProxy catalog)
        {
            InitializeComponent();
            _service = service;

            
            txtParentCatalog.OrganizationService = service;
            txtParentCatalog.Entity = parentcatalog.CatalogRow;

            txtCategory.OrganizationService = service;
            txtCategory.Entity = catalog.CatalogRow;

            txtLookupCustomAPI.OrganizationService = service;
            dlgCustomAPI.Service = service;
            dlgProcess.Service = service;

            cboEntities.Service = service;


            txtLookupCustomAPI.Enabled = false;
            txtLookupProcess.Enabled = false;
            cboEntities.Enabled = false;

            cdsCboSolutions.OrganizationService = service;

            var unmanagedsolutions = _service.GetUnmanagedSolutions();
            cdsCboSolutions.SelectedIndexChanged -= new EventHandler(cdsCboSolutions_SelectedIndexChanged);
            cdsCboSolutions.DataSource = unmanagedsolutions;
            cdsCboSolutions.SelectedIndexChanged += new EventHandler(cdsCboSolutions_SelectedIndexChanged);

            cdsCboSolutions.SelectedIndex = unmanagedsolutions.Entities.Select(e => e.Id).ToList().IndexOf(solution?.SolutionRow?.Id ?? Guid.Empty);


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
                if (_selectedSolution != null)
                {
                    createRequest["SolutionUniqueName"] = _selectedSolution.UniqueName;
                }

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


            catalogassignment[CatalogAssignment.PrimaryName] = txtName.Text;
            catalogassignment[CatalogAssignment.catalog] = txtCategory.EntityReference;

            catalogassignment[CatalogAssignment.IsCustomizable] = chkIsCustomizable.Checked;

            if (rbTable.Checked) 
            {
                var metadata = _service.GetMetadata(cboEntities.SelectedEntity.LogicalName);
                var metadataid = metadata.MetadataId;
                catalogassignment[CatalogAssignment.CatalogAssignmentObject] = new EntityReference(EntityTable.EntityName, metadataid ?? Guid.Empty);
            }

            if (rbCustomAPI.Checked) 
            {
                catalogassignment[CatalogAssignment.CatalogAssignmentObject] = txtLookupCustomAPI.EntityReference;
            }

            if (rbCustomProcessAction.Checked) 
            {
                catalogassignment[CatalogAssignment.CatalogAssignmentObject] = txtLookupProcess.EntityReference;
            }

            return catalogassignment;
        }

        private void btnLookupCustomAPI_Click(object sender, EventArgs e)
        {
            
            Cursor = Cursors.WaitCursor;
            switch (dlgCustomAPI.ShowDialog(this))
            {
                case DialogResult.OK:

                    txtLookupCustomAPI.Entity = dlgCustomAPI.Entity?.Id != null ? 
                                                _service.GetCustomApi(dlgCustomAPI.Entity.Id) : 
                                                null;

                    if (string.IsNullOrEmpty(txtName.Text)) 
                    {
                        txtName.Text = txtLookupCustomAPI.Entity[CustomAPI.PrimaryName].ToString();
                    }


                    break;
                case DialogResult.Abort:
   
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
                    if (string.IsNullOrEmpty(txtName.Text))
                    {
                        txtName.Text = txtLookupProcess.Entity[Process.PrimaryName].ToString();
                    }

                    break;
                case DialogResult.Abort:
               
                    break;
            }

            Cursor = Cursors.Default;

        }

        private void cboEntities_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void rbTable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTable.Checked)
            {
                txtLookupCustomAPI.Entity = null;
                txtLookupCustomAPI.Enabled = false;
                btnLookupCustomAPI.Enabled = false;

                txtLookupProcess.Entity = null;
                txtLookupProcess.Enabled = false;
                btnLookupProcess.Enabled = false;

                cboEntities.Enabled = true;
                cboEntities.LoadData();

            }
        }

        private void rbCustomAPI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomAPI.Checked)
            {
         
                txtLookupCustomAPI.Enabled = true;
                btnLookupCustomAPI.Enabled = true;

                txtLookupProcess.Entity = null;
                txtLookupProcess.Enabled = false;
                btnLookupProcess.Enabled = false;

                cboEntities.Enabled = false;
                cboEntities.ClearData();
                

            }
        }

        private void rbCustomProcessAction_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomProcessAction.Checked)
            {

                txtLookupCustomAPI.Enabled = false;
                txtLookupCustomAPI.Entity = null;
                btnLookupCustomAPI.Enabled = false;


                txtLookupProcess.Enabled = true;
                btnLookupProcess.Enabled = true;

                cboEntities.Enabled = false;
                cboEntities.ClearData();


            }

        }

        private void cdsCboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSolution = cdsCboSolutions.SelectedIndex != -1 ?
                                            new SolutionProxy(cdsCboSolutions.SelectedEntity) :
                                            null;

        }

        private void cdsCboSolutions_TextUpdate(object sender, EventArgs e)
        {
            if (cdsCboSolutions.SelectedText == "")
            {
                cdsCboSolutions.SelectedIndex = -1;
            }
        }

        
    }
}
