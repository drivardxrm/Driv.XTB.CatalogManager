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
    public partial class NewCatalogForm : Form
    {
        #region Private Fields

        //private Control focus;
        private IOrganizationService _service;
        private SolutionProxy _selectedSolution;
        private Settings _connectionsettings;

        #endregion Private Fields

        #region Public Constructors

        public NewCatalogForm(IOrganizationService service, SolutionProxy solution, CatalogProxy parentcatalog, Settings connectionsettings)
        {
            InitializeComponent();
            _service = service;
            _connectionsettings = connectionsettings;


            dlgLookupPublisher.Service = service;

            if (parentcatalog != null)
            {
                cdsTextParentCatalog.OrganizationService = service;
                cdsTextParentCatalog.Entity = parentcatalog.CatalogRow;
            }
            else 
            {
                lblParentCatalog.Visible = false;
                cdsTextParentCatalog.Visible = false;
            
            }

            cdsCboSolutions.OrganizationService = service;

            var unmanagedsolutions = _service.GetUnmanagedSolutions();
            cdsCboSolutions.SelectedIndexChanged -= new EventHandler(cdsCboSolutions_SelectedIndexChanged);
            cdsCboSolutions.DataSource = unmanagedsolutions;
            cdsCboSolutions.SelectedIndexChanged += new EventHandler(cdsCboSolutions_SelectedIndexChanged);

            cdsCboSolutions.SelectedIndex = unmanagedsolutions.Entities.Select(e => e.Id).ToList().IndexOf(solution?.SolutionRow?.Id ?? Guid.Empty);

            // Set default publisher, Takes it from Settings file or from the solution
            if (_connectionsettings.DefaultPublisherId != Guid.Empty)
            {
                var publisher = _service.GetPublisher(_connectionsettings.DefaultPublisherId);
                if (publisher != null) 
                {
                    txtLookupPublisher.EntityReference = new EntityReference(Publisher.EntityName, _connectionsettings.DefaultPublisherId);
                    txtLookupPublisher.Text = publisher.Attributes[Publisher.Name].ToString();
                    txtPrefix.Text = $"{publisher.Attributes[Publisher.Prefix]}_";
                }
                
            }
            else if (solution?.PublisherRef != null)
            {
                txtLookupPublisher.EntityReference = solution.PublisherRef;
                txtLookupPublisher.Text = solution.PublisherRef.Name;
                txtPrefix.Text = $"{solution.Prefix}_";
            }

        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// GUID of the Custom API Created
        /// </summary>
        public Guid NewCatalogId { get; private set; }

        #endregion Public Properties



        #region Private Event Handlers
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                var createRequest = new CreateRequest
                {
                    Target = CatalogToCreate()
                };
                if (_selectedSolution != null)
                {
                    createRequest["SolutionUniqueName"] = _selectedSolution.UniqueName;
                }

                var createResponse = (CreateResponse)_service.Execute(createRequest);

                NewCatalogId = createResponse.id;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult = DialogResult.None;
            }

        }


        private void txtUniqueName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                txtName.Text = txtUniqueName.Text;
            }

            if (txtDisplayName.Text == string.Empty)
            {
                txtDisplayName.Text = txtUniqueName.Text;
            }

            if (txtDescription.Text == string.Empty)
            {
                txtDescription.Text = txtUniqueName.Text;
            }

        }





        private void btnLookupPublisher_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            switch (dlgLookupPublisher.ShowDialog(this))
            {
                case DialogResult.OK:
                    txtLookupPublisher.Entity = dlgLookupPublisher.Entity;
                    var prefix = _service.GetPublisherPrefix((Guid)dlgLookupPublisher.Entity.Attributes[Publisher.PrimaryKey]);
                    txtPrefix.Text = $"{prefix}_";

                    //unlock

                    break;
                case DialogResult.Abort:

                    break;
            }

            Cursor = Cursors.Default;
        }

        #endregion Private Event Handlers

        #region Private Methods



        #endregion Private Methods





        private Entity CatalogToCreate() 
        {
            var catalog = new Entity(Catalog.EntityName);

            if (cdsTextParentCatalog.Id != Guid.Empty) 
            {
                catalog[Catalog.ParentCatalog] = cdsTextParentCatalog.EntityReference;
            }

            catalog[Catalog.UniqueName] = txtPrefix.Text + txtUniqueName.Text;          
            catalog[Catalog.Description] = txtDescription.Text;
            catalog[Catalog.DisplayName] = txtDisplayName.Text;          
            catalog[Catalog.PrimaryName] = txtName.Text;
            catalog[Catalog.IsCustomizable] = chkIsCustomizable.Checked;

            return catalog;
        }

        

        


        private bool IsPublisherSelected()
        {
            return !string.IsNullOrEmpty(txtLookupPublisher.Text);
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
