using Driv.XTB.CatalogManager.Proxy;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;


namespace Driv.XTB.CatalogManager.Forms
{
    public partial class DeleteCatalogForm : Form
    {

        private IOrganizationService _service;
        private CatalogProxy _catalogtodelete;

        public DeleteCatalogForm(IOrganizationService service, CatalogProxy catalogtodelete)
        {
            InitializeComponent();
            _service = service;
            _catalogtodelete = catalogtodelete;

            txtCatalogName.Entity = catalogtodelete.CatalogRow;

        }


        public bool CatalogDeleted { get; private set; }



        

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _service.Delete(Catalog.EntityName, _catalogtodelete.CatalogRow.Id);
                CatalogDeleted = true;
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
