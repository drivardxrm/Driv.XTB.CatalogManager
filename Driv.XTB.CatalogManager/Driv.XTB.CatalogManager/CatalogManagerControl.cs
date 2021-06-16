using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.Reflection;

using xrmtb.XrmToolBox.Controls.Controls;
using xrmtb.XrmToolBox.Controls;

using XrmToolBox.Extensibility.Interfaces;
using Driv.XTB.CatalogManager.Proxy;
using Driv.XTB.CatalogManager.Helpers;
using Driv.XTB.CatalogManager.Forms;

namespace Driv.XTB.CatalogManager
{
    public partial class CatalogManagerControl : PluginControlBase, IMessageBusHost, IGitHubPlugin
    {
        private Settings mySettings;

        private SolutionProxy _selectedSolution;

        private CatalogProxy _selectedCatalog;

        private CatalogProxy _selectedCategory; //2nd level catalog

        //private CustomApiRequestParameterProxy _selectedRequestParameter;

        //private CustomApiResponsePropertyProxy _selectedResponseProperty;

        private Entity _selectedPublisher;

        public string RepositoryName => "Driv.XTB.CatalogManager";

        public string UserName => "drivardxrm";

       

        public event EventHandler<MessageBusEventArgs> OnOutgoingMessage;

        public CatalogManagerControl()
        {
            InitializeComponent();
        }

        private void CustomApiManagerControl_Load(object sender, EventArgs e)
        {
            
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            ExecuteMethod(InitializeService);

            //select the all radio button
            rbAll.Checked = true;

            cdsCboCatalog.Select();
        }

        private void InitializeService()
        {



            

            cdsCboCatalog.OrganizationService = Service;
            
            cdsTxtUniqueName.OrganizationService = Service;
            
            cdsTxtName.OrganizationService = Service;
            cdsTxtDisplayName.OrganizationService = Service;
            cdsTxtDescription.OrganizationService = Service;
            cdsTxtIsManaged.OrganizationService = Service;
            cdsTxtIsCustomizable.OrganizationService = Service;

            //2nd Level catalog (category)
            cdsGridCategories.OrganizationService = Service;
            cdsCategoryTxtUniqueName.OrganizationService = Service;

            cdsCategoryTxtName.OrganizationService = Service;
            cdsCategoryTxtDisplayName.OrganizationService = Service;
            cdsCategoryTxtDescription.OrganizationService = Service;



        }

        //If Plugin is opened from Integration with another plugin
        //TargetArgumet = GUID of Custom API to display (string format)	Id
        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            
            if (message.TargetArgument is string arg && Guid.TryParse(arg, out Guid argid))
            {
                var catalog = Service.GetCatalog(argid);
                SetSelectedCatalog(catalog);
                
            }
        }


        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomApiManagerControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);

                SetCdsCboCustomApiDataSource(null);


                //LoadSolutions();
                ExecuteMethod(InitializeService);
                

                //select the all radio button
                rbAll.Checked = true;
                ExecuteMethod(LoadRootCatalogs);
                cdsCboCatalog.Select();
            }
        }



        #region Form Events
        private void menuRefresh_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadRootCatalogs);
        }


        private void menuNewApi_Click(object sender, EventArgs e)
        {
            CreateCatalogDialog();
        }
        

        private void btnNewApi_Click(object sender, EventArgs e)
        {
            CreateCatalogDialog();
        }

        private void btnEditCustomApi_Click(object sender, EventArgs e)
        {
            UpdateCatalogDialog();
        }



       


        private void btnDeleteApi_Click(object sender, EventArgs e)
        {
            DeleteCatalogDialog();
        }

       

       


        private void tslAbout_Click(object sender, EventArgs e)
        {


            var about = new About();
            about.StartPosition = FormStartPosition.CenterParent;
            about.lblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            about.ShowDialog();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                ExecuteMethod(LoadRootCatalogs);
            }
        }

        private void rbSolution_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSolution.Checked)
            {

                SetCdsCboCustomApiDataSource(null);


                cdsCboCatalog.SelectedIndex = -1;

                cdsCboSolutions.Enabled = true;

                ExecuteMethod(LoadSolutions, Guid.Empty);
                cdsCboSolutions.Select();

            }
            else
            {
                cdsCboSolutions.Enabled = false;


                SetCdsCboSolutionsDataSource(null);


                cdsCboSolutions.SelectedIndex = -1;
                _selectedSolution = null;

            }
        }


        private void cdsCboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSolution = cdsCboSolutions.SelectedIndex != -1 ?
                                            new SolutionProxy(cdsCboSolutions.SelectedEntity) :
                                            null;

            ExecuteMethod(LoadRootCatalogs);

        }

        

        



        private void cdsCboCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {


           


            var catalog = cdsCboCatalog.SelectedIndex == -1 ? null : cdsCboCatalog.SelectedEntity;
            SetSelectedCatalog(catalog);


            

        }

        




        #endregion

        #region Private Methods

        private void LoadSolutions(Guid selected)
        {

            SetCdsCboSolutionsDataSource(null);

            //TODO Apply filters



            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading solutions...",
                Work = (worker, args) =>
                {
                    args.Result = Service.GetSolutions();

                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message);
                    }
                    else
                    {
                        if (args.Result is EntityCollection)
                        {


                            var solutions = (EntityCollection)args.Result;
                            //Find the index of the selected solution
                            var index = solutions.Entities.Select(e => e.Id).ToList().IndexOf(selected);

                            SetCdsCboSolutionsDataSource(solutions);
                           
                            
                            cdsCboSolutions.SelectedIndex = index;
                            cdsCboSolutions.Enabled = true;

                        }
                    }
                }
            });

        }

        private void LoadRootCatalogs()
        {

            SetCdsCboCustomApiDataSource(null);



            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading root catalogs...",
                Work = (worker, args) =>
                {
                    if (rbAll.Checked)
                    {
                        args.Result = Service.GetAllRootCatalogs();
                    }
                    else if (rbSolution.Checked && _selectedSolution != null) 
                    {
                        args.Result = Service.GetCatalogsFor(_selectedSolution.SolutionRow.Id);
                    }
                    else 
                    {
                        args.Result = null;
                    }
                        
                    
                    

                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message);
                    }
                    else
                    {
                        if (args.Result is EntityCollection)
                        {

                            var customapis = (EntityCollection)args.Result;
                            //Find the index of the selected API in the list
                            var index = customapis.Entities.Select(e => e.Id).ToList().IndexOf(_selectedCatalog?.CatalogRow.Id ?? Guid.Empty);

                            SetCdsCboCustomApiDataSource(customapis);
                            
                            //hack to force a refresh... must be a better way
                            if (cdsCboCatalog.SelectedIndex == index) 
                            {
                                cdsCboCatalog.SelectedIndex = -1;
                            }
                            cdsCboCatalog.SelectedIndex = index;
                            cdsCboCatalog.Enabled = true;

                        }
                        else
                        {
                            SetCdsCboCustomApiDataSource(null);

                            cdsCboCatalog.SelectedIndex = -1;
                            cdsCboCatalog.Enabled = false;
                        }
                    }
                }
            });

        }

        /// Will set the DataSource of the control. Disabling the event handlers will prevent unessesary triggers.
        private void SetCdsCboSolutionsDataSource(object datasource)
        {
            cdsCboSolutions.SelectedIndexChanged -= new EventHandler(cdsCboSolutions_SelectedIndexChanged);
            cdsCboSolutions.DataSource = datasource;
            cdsCboSolutions.SelectedIndexChanged += new EventHandler(cdsCboSolutions_SelectedIndexChanged);
        }

        
        private void SetCdsCboCustomApiDataSource(object datasource)
        {
            cdsCboCatalog.SelectedIndexChanged -= new EventHandler(cdsCboCatalog_SelectedIndexChanged);
            cdsCboCatalog.DataSource = datasource;
            cdsCboCatalog.SelectedIndexChanged += new EventHandler(cdsCboCatalog_SelectedIndexChanged);
        }

        private void SetGridCategoriesDataSource(object datasource)
        {
            cdsGridCategories.RecordEnter -= new CRMRecordEventHandler(cdsGridCategories_RecordEnter);
            cdsGridCategories.DataSource = datasource;
            cdsGridCategories.RecordEnter += new CRMRecordEventHandler(cdsGridCategories_RecordEnter);
        }





        private void SetSelectedCatalog(Entity catalog) 
        {
            _selectedCatalog = catalog != null ? new CatalogProxy(catalog) : null;

            

            cdsTxtUniqueName.Entity = _selectedCatalog?.CatalogRow;
            cdsTxtName.Entity = _selectedCatalog?.CatalogRow;
            cdsTxtDisplayName.Entity = _selectedCatalog?.CatalogRow;
            cdsTxtDescription.Entity = _selectedCatalog?.CatalogRow;


            cdsTxtIsManaged.Entity = _selectedCatalog?.CatalogRow;
            cdsTxtIsCustomizable.Entity = _selectedCatalog?.CatalogRow;

            if (_selectedCatalog != null)
            {
                txtCustomizableWarning.Visible = !_selectedCatalog.CanCustomize;
                btnEditCustomApi.Enabled = _selectedCatalog.CanCustomize;
                btnDeleteApi.Enabled = _selectedCatalog.CanCustomize;
                
            }
            
            
            grpCatalog.Enabled = _selectedCatalog != null;
            


          
        }

        private void SetSelectedCategory(Entity catalog)
        {
            _selectedCategory = catalog != null ? new CatalogProxy(catalog) : null;



            cdsCategoryTxtUniqueName.Entity = _selectedCatalog?.CatalogRow;
            cdsCategoryTxtName.Entity = _selectedCatalog?.CatalogRow;
            cdsCategoryTxtDisplayName.Entity = _selectedCatalog?.CatalogRow;
            cdsCategoryTxtDescription.Entity = _selectedCatalog?.CatalogRow;


            //cdsTxtIsManaged.Entity = _selectedCatalog?.CatalogRow;
            //cdsTxtIsCustomizable.Entity = _selectedCatalog?.CatalogRow;

            //if (_selectedCatalog != null)
            //{
            //    txtCustomizableWarning.Visible = !_selectedCatalog.CanCustomize;
            //    btnEditCustomApi.Enabled = _selectedCatalog.CanCustomize;
            //    btnDeleteApi.Enabled = _selectedCatalog.CanCustomize;

            //}


            //grpCategories.Enabled = _selectedCatalog != null;




        }













        /// Method to find the index of a given ID (Guid) in a CRMGridView. A bit shady but it works.
        private int GetGridSelectedIndex(CRMGridView crmgridview, Guid? selected)
        {
            var index = 0;
            if (selected != null)
            {

                foreach (DataGridViewRow row in crmgridview.Rows)
                {

                    DataRow datarow = ((DataRowView)row.DataBoundItem).Row;
                    if (datarow != null && datarow.Field<Guid>("#id") == selected)
                    {
                        index = datarow.Field<int>("#no") - 1;
                    }
                }
            }
            return index;
        }


        private void CreateCatalogDialog() 
        {
            var inputdlg = new NewCatalogForm(Service, _selectedSolution, null);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.NewCatalogId != null)
            {

                //refresh custom api list and select newly created
                SetSelectedCatalog(Service.GetCatalog(inputdlg.NewCatalogId));
                ExecuteMethod(LoadRootCatalogs);
            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void CreateCategoryDialog()
        {
            var inputdlg = new NewCatalogForm(Service, _selectedSolution, _selectedCatalog);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.NewCatalogId != null)
            {

                //refresh category list
                LoadCategories(inputdlg.NewCatalogId);
            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void LoadCategories(Guid? selected = null)
        {
            SetGridCategoriesDataSource(null);


            SetSelectedCategory(null);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading categories...",
                Work = (worker, args) =>
                {
                    args.Result = Service.GetChildCatalogsFor(_selectedCatalog?.CatalogRow.Id ?? Guid.Empty);

                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message);
                    }
                    else
                    {
                        if (args.Result is EntityCollection)
                        {
                            var categories = (EntityCollection)args.Result;

                            SetGridCategoriesDataSource(categories);

                            cdsGridCategories.ClearSelection();

                            if (cdsGridCategories.Rows.Count > 0)
                            {
                                int index = GetGridSelectedIndex(cdsGridCategories, selected);
                                cdsGridCategories.CurrentCell = cdsGridCategories.Rows[index].Cells[2];

                            }
                            else
                            {
                                SetSelectedCategory(null);
                            }

                        }
                    }
                }
            });
        }

        private void UpdateCatalogDialog()
        {

            var inputdlg = new UpdateCatalogForm(Service, _selectedCatalog);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogUpdated)
            {


                //refresh custom api list and select newly updated
                SetSelectedCatalog(Service.GetCatalog(_selectedCatalog.CatalogRow.Id));
                ExecuteMethod(LoadRootCatalogs);

            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void DeleteCatalogDialog()
        {

            var inputdlg = new DeleteCatalogForm(Service, _selectedCatalog);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogDeleted)
            {

                SetSelectedCatalog(null);
               

                ExecuteMethod(LoadRootCatalogs);


            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }



        #endregion



        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            CreateCategoryDialog();
        }

        private void cdsGridCategories_RecordEnter(object sender, CRMRecordEventArgs e)
        {
            SetSelectedCategory(Service.GetCatalog(e.Entity.Id));

        }


    }
}