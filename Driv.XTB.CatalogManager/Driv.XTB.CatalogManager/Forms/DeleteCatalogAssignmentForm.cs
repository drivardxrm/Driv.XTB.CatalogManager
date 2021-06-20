using Driv.XTB.CatalogManager.Proxy;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;


namespace Driv.XTB.CatalogManager.Forms
{
    public partial class DeleteCatalogAssignmentForm : Form
    {

        private IOrganizationService _service;
        private CatalogAssignmentProxy _catalogassignmenttodelete;

        public DeleteCatalogAssignmentForm(IOrganizationService service, CatalogAssignmentProxy catalogassignmenttodelete)
        {
            InitializeComponent();
            _service = service;
            _catalogassignmenttodelete = catalogassignmenttodelete;

            txtAssignmentName.Text = catalogassignmenttodelete.Name;
            txtAssignmentType.Text = catalogassignmenttodelete.ObjectType;
            txtAssignmentObject.Text = catalogassignmenttodelete.Object.Name;

        }


        public bool CatalogAssignmentDeleted { get; private set; }



        

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _service.Delete(CatalogAssignment.EntityName, _catalogassignmenttodelete.CatalogAssignmentRow.Id);
                CatalogAssignmentDeleted = true;
                Cursor = Cursors.Default;
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
