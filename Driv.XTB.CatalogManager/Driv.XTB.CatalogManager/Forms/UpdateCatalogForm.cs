using Driv.XTB.CatalogManager.Proxy;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;


namespace Driv.XTB.CatalogManager.Forms
{
    public partial class UpdateCatalogForm : Form
    {
        #region Private Fields

      
        private IOrganizationService _service;
        private CatalogProxy _catalogproxy;
        private bool _shouldupdate;

        #endregion Private Fields

        #region Public Constructors

        public UpdateCatalogForm(IOrganizationService service, CatalogProxy catalogtoupdate)
        {
            InitializeComponent();
            _service = service;
            _catalogproxy = catalogtoupdate;


            txtUniqueName.Text = _catalogproxy.UniqueName;
            txtName.Text = _catalogproxy.Name;
            txtDisplayName.Text = _catalogproxy.DisplayName;
            txtDescription.Text = _catalogproxy.Description;

        }

        #endregion Public Constructors

        #region Public Properties

       

        public bool CatalogUpdated { get; private set; }

        #endregion Public Properties

        #region Public Methods



        #endregion Public Methods

        #region Private Event Handlers
        






        #endregion Private Event Handlers

        #region Private Methods



        #endregion Private Methods





     
        private Entity CatalogToUpdate() 
        {
            var catalog = new Entity(Catalog.EntityName,_catalogproxy.CatalogRow.Id);
            
            //Update only if needed
            if (_catalogproxy.Name != txtName.Text) 
            {
                catalog[Catalog.PrimaryName] = txtName.Text;
                _shouldupdate = true;
            };

            if (_catalogproxy.Description != txtDescription.Text)
            {
                catalog[Catalog.Description] = txtDescription.Text;
                _shouldupdate = true;
            };

            if (_catalogproxy.DisplayName != txtDisplayName.Text)
            {
                catalog[Catalog.DisplayName] = txtDisplayName.Text;
                _shouldupdate = true;
            };

            return catalog;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //todo modify for Update
                var customapitoupdate = CatalogToUpdate();
                if (_shouldupdate)
                {
                    Cursor = Cursors.WaitCursor;
                    _service.Update(customapitoupdate);
                    CatalogUpdated = true;
                    Cursor = Cursors.Default;
                }
                else 
                {
                    MessageBox.Show($"No change detected.", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    DialogResult = DialogResult.None;
                }
                
                
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult = DialogResult.None;
            }

        }
       
    }
}
