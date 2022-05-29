using Driv.XTB.CatalogManager;
using Driv.XTB.CatalogManager.Helpers;
using Driv.XTB.CatalogManager.Proxy;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;


namespace Driv.XTB.CatalogManager.Forms
{
    public partial class SettingsForm : Form
    {
        #region Private Fields

        //private Control focus;
        private IOrganizationService _service;
        private Settings _globalsettings;
        private Settings _connectionsettings;
        private ConnectionDetail _connectiondetail;

        #endregion Private Fields

        #region Public Constructors

        public SettingsForm(IOrganizationService service, ConnectionDetail connectiondetail, Settings globalsettings, Settings connectionsettings)
        {
            InitializeComponent();
            _service = service;
            _globalsettings = globalsettings;
            _connectionsettings = connectionsettings;
            _connectiondetail = connectiondetail;
            dlgLookupPublisher.Service = service;

            lblConnection.Text = _connectiondetail.ConnectionName;

            if (_connectionsettings.DefaultPublisherId != Guid.Empty)
            {
                var publisher = _service.GetPublisher(_connectionsettings.DefaultPublisherId);

                if (publisher != null)
                {
                    txtLookupPublisher.EntityReference = new EntityReference(Publisher.EntityName, _connectionsettings.DefaultPublisherId);
                    txtLookupPublisher.Text = publisher.Attributes[Publisher.PrimaryName].ToString();
                    txtPrefix.Text = $"{publisher.Attributes[Publisher.Prefix]}_";
                }
                else
                {
                    txtLookupPublisher.EntityReference = new EntityReference(Publisher.EntityName, Guid.Empty);
                    txtLookupPublisher.Text = string.Empty;
                    txtPrefix.Text = string.Empty;
                }

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
            // Global


            // connection related settings
            if (txtLookupPublisher.Id != _connectionsettings.DefaultPublisherId)
            {
                _connectionsettings.DefaultPublisherId = txtLookupPublisher.Id;
            }
            SettingsManager.Instance.Save(typeof(CatalogManagerPlugin), _connectionsettings, _connectiondetail.ConnectionId.ToString());

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

        private void btnPublisherClear_Click(object sender, EventArgs e)
        {
            txtLookupPublisher.EntityReference = new EntityReference(Publisher.EntityName, Guid.Empty);
            txtLookupPublisher.Text = string.Empty;
            txtPrefix.Text = string.Empty;
        }

        #endregion Private Event Handlers

        #region Private Methods



        #endregion Private Methods












        
    }
}
