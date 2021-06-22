using Driv.XTB.CatalogManager.Proxy;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;


namespace Driv.XTB.CatalogManager.Forms
{
    public partial class UpdateCatalogAssignmentForm : Form
    {
        #region Private Fields

      
        private IOrganizationService _service;
        private CatalogAssignmentProxy _catalogassignmentproxy;
        private bool _shouldupdate;

        #endregion Private Fields

        #region Public Constructors

        public UpdateCatalogAssignmentForm(IOrganizationService service, CatalogAssignmentProxy catalogassignementtoupdate)
        {
            InitializeComponent();
            _service = service;
            _catalogassignmentproxy = catalogassignementtoupdate;


            txtAssignmentName.Text = _catalogassignmentproxy.Name;
            txtAssignmentType.Text = _catalogassignmentproxy.ObjectType;
            txtAssignmentObject.Text = _catalogassignmentproxy.Object.Name;
            chkIsCustomizable.Checked = _catalogassignmentproxy.IsCustomizable;

        }

        #endregion Public Constructors

        #region Public Properties

       

        public bool CatalogAssignmentUpdated { get; private set; }

        #endregion Public Properties

        #region Public Methods



        #endregion Public Methods

        #region Private Event Handlers
        






        #endregion Private Event Handlers

        #region Private Methods



        #endregion Private Methods





     
        private Entity GetCatalogAssignmentToUpdate() 
        {
            var catalogassignment = new Entity(CatalogAssignment.EntityName,_catalogassignmentproxy.CatalogAssignmentRow.Id);
            
            //Update only if needed
            if (_catalogassignmentproxy.Name != txtAssignmentName.Text) 
            {
                catalogassignment[CatalogAssignment.PrimaryName] = txtAssignmentName.Text;
                _shouldupdate = true;
            };

            if (_catalogassignmentproxy.IsCustomizable != chkIsCustomizable.Checked)
            {
                catalogassignment[CatalogAssignment.IsCustomizable] = chkIsCustomizable.Checked;
                _shouldupdate = true;
            };

            

            return catalogassignment;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //todo modify for Update
                var catalogassignmenttoupdate = GetCatalogAssignmentToUpdate();
                if (_shouldupdate)
                {
                    Cursor = Cursors.WaitCursor;
                    _service.Update(catalogassignmenttoupdate);
                    CatalogAssignmentUpdated = true;
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
