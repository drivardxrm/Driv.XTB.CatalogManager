using Driv.XTB.CatalogManager.Forms;
using Driv.XTB.CatalogManager.Helpers;
using Driv.XTB.CatalogManager.Proxy;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Driv.XTB.CatalogManager
{
    public partial class CatalogManagerControl : PluginControlBase, IMessageBusHost, IGitHubPlugin
    {
        private Settings _globalsettings;

        private Settings _connectionsettings;

        private SolutionProxy _selectedSolution;

        private CatalogProxy _selectedCatalog;

        private CatalogProxy _selectedCategory; //2nd level catalog

        private CatalogAssignmentProxy _selectedCatalogAssignment; 



        private Entity _selectedPublisher;

        public string RepositoryName => "Driv.XTB.CatalogManager";

        public string UserName => "drivardxrm";

       

        public event EventHandler<MessageBusEventArgs> OnOutgoingMessage;

        public CatalogManagerControl()
        {
            InitializeComponent();
        }

        private void CatalogManagerControl_Load(object sender, EventArgs e)
        {

            LoadGlobalSettings();
            LoadConnectionSettings();

            ExecuteMethod(InitializeService);

            //select the all radio button
            rbAll.Checked = true;

            cboCatalog.Select();
        }

        private void LoadConnectionSettings()
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out _connectionsettings, ConnectionDetail.ConnectionId.ToString()))
            {
                _connectionsettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void LoadGlobalSettings()
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out _globalsettings))
            {
                _globalsettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void InitializeService()
        {



            

            cboCatalog.OrganizationService = Service;
            
            txtCatalogUniqueName.OrganizationService = Service;
            
            txtCatalogName.OrganizationService = Service;
            txtCatalogDisplayName.OrganizationService = Service;
            txtCatalogDescription.OrganizationService = Service;
            txtCatalogIsManaged.OrganizationService = Service;
            txtCatalogIsCustomizable.OrganizationService = Service;

            //2nd Level catalog (category)
            gridCategories.OrganizationService = Service;
            txtCategoryUniqueName.OrganizationService = Service;

            txtCategoryName.OrganizationService = Service;
            txtCategoryDisplayName.OrganizationService = Service;
            txtCategoryDescription.OrganizationService = Service;
            txtCategoryIsCustomizable.OrganizationService = Service;
            txtCategoryIsManaged.OrganizationService = Service;


            //Catalog assignment
            txtAssignmentIsCustomizable.OrganizationService = Service;
            txtAssignmentName.OrganizationService = Service;
            txtAssignmentObject.OrganizationService = Service;
            txtAssignmentIsManaged.OrganizationService = Service;



        }

        //If Plugin is opened from Integration with another plugin
        //TargetArgumet = GUID of Catalog, Category or CatalogAssignment to display
        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            
            if (message.TargetArgument is string arg && Guid.TryParse(arg, out Guid argid))
            {
                DisplayResource(argid);
            }
        }

        /// <summary>
        /// Called by OnIncomingMessage to display a specific resource in the plugin.
        /// </summary>
        /// <param name="argid"></param>
        private void DisplayResource(Guid argid)
        {
            var catalogAssignment = Service.GetCatalogAssignment(argid);
            if (catalogAssignment != null)
            {
                var catalogAssignmentProxy = new CatalogAssignmentProxy(catalogAssignment);
                var catalog = Service.GetCatalog(catalogAssignmentProxy.CatalogRef.Id);
                var catalogProxy = new CatalogProxy(catalog);
                var parentcatalog = Service.GetCatalog(catalogProxy.ParentCatalogRef.Id);

                SetSelectedCatalog(parentcatalog);
                SetSelectedCategory(catalog);
                SetSelectedAssignment(catalogAssignment);

                LoadRootCatalogs(parentcatalog.Id, catalog.Id, catalogAssignment.Id);
            }
            else
            {
                var catalog = Service.GetCatalog(argid);
                var catalogProxy = new CatalogProxy(catalog);

                if (catalogProxy.ParentCatalogRef != null)
                {
                    var parentcatalog = Service.GetCatalog(catalogProxy.ParentCatalogRef.Id);
                    var parentCatalogProxy = new CatalogProxy(parentcatalog);

                    SetSelectedCatalog(parentcatalog);
                    SetSelectedCategory(catalog);
                    SetSelectedAssignment(null);

                    LoadRootCatalogs();
                    LoadCategories(parentcatalog.Id, catalog.Id);
                }
                else
                {
                    SetSelectedCatalog(catalog);
                    SetSelectedCategory(null);
                    SetSelectedAssignment(null);
                    LoadRootCatalogs(catalog.Id);
                }
            }

            UpdateTreeView();
        }


        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomApiManagerControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), _globalsettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            

            if (_globalsettings != null && detail != null)
            {
                LoadConnectionSettings();

                _globalsettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);

                SetCboCatalogDataSource(null);


                ExecuteMethod(InitializeService);
                

                //select the all radio button
                rbAll.Checked = true;
                LoadRootCatalogs();
                cboCatalog.Select();
            }
        }



        #region Form Events
        private void menuRefresh_Click(object sender, EventArgs e)
        {
            LoadRootCatalogs();
        }


        private void menuNewApi_Click(object sender, EventArgs e)
        {
            CreateCatalogDialog();
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            SettingsDialog();
        }


        private void btnNewApi_Click(object sender, EventArgs e)
        {
            CreateCatalogDialog();
        }

        private void btnEditCatalog_Click(object sender, EventArgs e)
        {
            UpdateCatalogDialog();
        }


        private void btnDeleteCatalog_Click(object sender, EventArgs e)
        {
            DeleteCatalogDialog();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategoryDialog();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            UpdateCategoryDialog();
        }

        private void btnNewAssignment_Click(object sender, EventArgs e)
        {
            CreateCategoryAssignmentDialog();
        }

        private void btnUpdateAssignment_Click(object sender, EventArgs e)
        {
            UpdateAssignmentDialog();
        }

        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            DeleteAssignmentDialog();
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
                LoadRootCatalogs();
            }
        }

        private void rbSolution_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSolution.Checked)
            {

                SetCboCatalogDataSource(null);


                cboCatalog.SelectedIndex = -1;

                cboSolutions.Enabled = true;

                ExecuteMethod(LoadSolutions, Guid.Empty);
                cboSolutions.Select();

            }
            else
            {
                cboSolutions.Enabled = false;


                SetCboSolutionsDataSource(null);


                cboSolutions.SelectedIndex = -1;
                _selectedSolution = null;

            }
        }


        private void cboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSolution = cboSolutions.SelectedIndex != -1 ?
                                            new SolutionProxy(cboSolutions.SelectedEntity) :
                                            null;

            LoadRootCatalogs();

        }

        

        



        private void cboCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {


            SetSelectedCategory(null);
            SetSelectedAssignment(null);


            var catalog = cboCatalog.SelectedIndex == -1 ? null : cboCatalog.SelectedEntity;
            SetSelectedCatalog(catalog);


            LoadCategories(catalog?.Id ?? Guid.Empty);

            UpdateTreeView();

        }

        




        #endregion

        #region Private Methods

        private void LoadSolutions(Guid solutionId)
        {

            SetCboSolutionsDataSource(null);

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
                            var index = solutions.Entities.Select(e => e.Id).ToList().IndexOf(solutionId);

                            SetCboSolutionsDataSource(solutions);
                           
                            
                            cboSolutions.SelectedIndex = index;
                            cboSolutions.Enabled = true;

                        }
                    }
                }
            });

        }

        private void LoadRootCatalogs(Guid? catalogId = null, Guid? categoryId = null, Guid? assignmentId = null)
        {

            SetCboCatalogDataSource(null);



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

                            var catalogs = (EntityCollection)args.Result;
                            //Find the index of the selected Catalog in the list
                            var index = catalogs.Entities.Select(e => e.Id).ToList().IndexOf(catalogId ?? Guid.Empty);

                            SetCboCatalogDataSource(catalogs);
                            
                            //hack to force a refresh... must be a better way
                            if (cboCatalog.SelectedIndex == index) 
                            {
                                cboCatalog.SelectedIndex = -1;
                            }
                            cboCatalog.SelectedIndex = index;
                            cboCatalog.Enabled = true;

                            if (categoryId != null)
                            {
                                LoadCategories(catalogId.Value, categoryId, assignmentId);
                            }
                            

                        }
                        else
                        {
                            SetCboCatalogDataSource(null);

                            cboCatalog.SelectedIndex = -1;
                            cboCatalog.Enabled = false;
                        }
                    }
                }
            });

        }

        private void LoadCategories(Guid catalogId, Guid? categoryId = null, Guid? assignmentId = null)
        {
            SetGridCategoriesDataSource(null);

            if (categoryId == null) 
            {
                SetSelectedCategory(null);
                
            }

            if (assignmentId == null) 
            {
                SetSelectedAssignment(null);
                SetGridAssignmentsDataSource(null);
            }
            

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading categories...",
                Work = (worker, args) =>
                {
                    args.Result = Service.GetChildCatalogsFor(catalogId);

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

                            gridCategories.ClearSelection();

                            

                            if (gridCategories.Rows.Count > 0)
                            {
                                
                                
                                int index = GetGridSelectedIndex(gridCategories, categoryId);

                                if (categoryId != null || categoryId == Guid.Empty) 
                                {
                                    gridCategories.RecordEnter -= new CRMRecordEventHandler(gridCategories_RecordEnter);
                                }
                                
                                gridCategories.CurrentCell = gridCategories.Rows[index].Cells[2];

                                if (categoryId != null || categoryId == Guid.Empty)
                                {
                                    gridCategories.RecordEnter += new CRMRecordEventHandler(gridCategories_RecordEnter);
                                }

                            }

                            if (categoryId != null)
                            {
                                LoadAssignments(categoryId.Value, assignmentId);
                            }


                        }
                    }
                }
            });
        }

        private void LoadAssignments(Guid categoryId, Guid? assignmentId = null)
        {
            SetGridAssignmentsDataSource(null);

            if(assignmentId == null || assignmentId == Guid.Empty)
            {
                SetSelectedAssignment(null);
            }
            

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading assignments...",
                Work = (worker, args) =>
                {
                    
                    args.Result = Service.GetCatalogAssignmentsFor(categoryId);

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
                            var assignments = (EntityCollection)args.Result;

                            SetGridAssignmentsDataSource(assignments);

                            gridAssignments.ClearSelection();

                            if (gridAssignments.Rows.Count > 0)
                            {
                                int index = GetGridSelectedIndex(gridAssignments, assignmentId);
                                gridAssignments.CurrentCell = gridAssignments.Rows[index].Cells[2];

                            }
                            

                        }
                    }
                }
            });
        }

        /// Will set the DataSource of the control. Disabling the event handlers will prevent unessesary triggers.
        private void SetCboSolutionsDataSource(object datasource)
        {
            cboSolutions.SelectedIndexChanged -= new EventHandler(cboSolutions_SelectedIndexChanged);
            cboSolutions.DataSource = datasource;
            cboSolutions.SelectedIndexChanged += new EventHandler(cboSolutions_SelectedIndexChanged);
        }

        
        private void SetCboCatalogDataSource(object datasource)
        {
            cboCatalog.SelectedIndexChanged -= new EventHandler(cboCatalog_SelectedIndexChanged);
            cboCatalog.DataSource = datasource;
            cboCatalog.SelectedIndexChanged += new EventHandler(cboCatalog_SelectedIndexChanged);
        }

        private void SetGridCategoriesDataSource(object datasource)
        {
            gridCategories.RecordEnter -= new CRMRecordEventHandler(gridCategories_RecordEnter);
            gridCategories.DataSource = datasource;
            gridCategories.RecordEnter += new CRMRecordEventHandler(gridCategories_RecordEnter);
        }

        private void SetGridAssignmentsDataSource(object datasource)
        {
            gridAssignments.RecordEnter -= new CRMRecordEventHandler(gridAssigments_RecordEnter);
            gridAssignments.DataSource = datasource;
            gridAssignments.RecordEnter += new CRMRecordEventHandler(gridAssigments_RecordEnter);
        }





        private void SetSelectedCatalog(Entity catalog) 
        {
            _selectedCatalog = catalog != null ? new CatalogProxy(catalog) : null;

            

            txtCatalogUniqueName.Entity = _selectedCatalog?.CatalogRow;
            txtCatalogName.Entity = _selectedCatalog?.CatalogRow;
            txtCatalogDisplayName.Entity = _selectedCatalog?.CatalogRow;
            txtCatalogDescription.Entity = _selectedCatalog?.CatalogRow;


            txtCatalogIsManaged.Entity = _selectedCatalog?.CatalogRow;
            txtCatalogIsCustomizable.Entity = _selectedCatalog?.CatalogRow;

            if (_selectedCatalog != null)
            {
                txtCustomizableWarning.Visible = !_selectedCatalog.CanCustomize;
                btnEditCatalog.Enabled = _selectedCatalog.CanCustomize;
                btnDeleteCatalog.Enabled = _selectedCatalog.CanCustomize;
                
            }

            imgGrpRootCatalog.Enabled = _selectedCatalog != null;
            imgGrpCategories.Enabled = _selectedCatalog != null;


        }

        private void SetSelectedCategory(Entity catalog)
        {
            _selectedCategory = catalog != null ? new CatalogProxy(catalog) : null;



            txtCategoryUniqueName.Entity = _selectedCategory?.CatalogRow;
            txtCategoryName.Entity = _selectedCategory?.CatalogRow;
            txtCategoryDisplayName.Entity = _selectedCategory?.CatalogRow;
            txtCategoryDescription.Entity = _selectedCategory?.CatalogRow;
            txtCategoryIsCustomizable.Entity = _selectedCategory?.CatalogRow;
            txtCategoryIsManaged.Entity = _selectedCategory?.CatalogRow;


            


            if (_selectedCategory != null)
            {
                txtCategoryCustomizableWarning.Visible = !_selectedCategory.CanCustomize;
                btnEditCategory.Enabled = _selectedCategory.CanCustomize;
                btnDeleteCategory.Enabled = _selectedCategory.CanCustomize;

            }
            else 
            {
                txtCategoryCustomizableWarning.Visible = false;
                btnEditCategory.Enabled = false;
                btnDeleteCategory.Enabled = false;

            }

            imgGrpAssignments.Enabled = _selectedCategory != null;

        }

        private void SetSelectedAssignment(Entity catalogassignment)
        {
            _selectedCatalogAssignment = catalogassignment != null ? new CatalogAssignmentProxy(catalogassignment) : null;

            txtAssignmentName.Entity = _selectedCatalogAssignment?.CatalogAssignmentRow;
            txtAssignmentObject.Entity = _selectedCatalogAssignment?.CatalogAssignmentRow;
            txtAssignmentIsCustomizable.Entity = _selectedCatalogAssignment?.CatalogAssignmentRow;
            txtAssignmentType.Text = _selectedCatalogAssignment?.ObjectType;
            txtAssignmentIsManaged.Entity = _selectedCatalogAssignment?.CatalogAssignmentRow;

            pictTable.Visible = txtAssignmentType.Text == "entity";
            pictAPI.Visible = txtAssignmentType.Text == "customapi";
            pictProcess.Visible = txtAssignmentType.Text == "workflow";

            btnOpenInCustomApiManager.Visible = txtAssignmentType.Text == "customapi";
            btnOpenInCustomApiTester.Visible = txtAssignmentType.Text == "customapi";

            if (_selectedCatalogAssignment != null)
            {
                txtAssignmentCustomizableWarning.Visible = !_selectedCatalogAssignment.CanCustomize;
                btnUpdateAssignment.Enabled = _selectedCatalogAssignment.CanCustomize;
                btnDeleteAssignment.Enabled = _selectedCatalogAssignment.CanCustomize;

            }
            else
            {
                txtAssignmentCustomizableWarning.Visible = false;
                btnUpdateAssignment.Enabled = false;
                btnDeleteAssignment.Enabled = false;

            }

        }



        private void UpdateTreeView() 
        {

            treeCatalog.AfterCheck -= new TreeViewEventHandler(treeCatalog_AfterSelect);


            treeCatalog.Nodes.Clear();
            
            if (_selectedCatalog != null) 
            {
                var fullcatalog = Service.GetFullCatalog(_selectedCatalog.CatalogRow.Id);
                var root = fullcatalog.Entities.First();

                var rootname = ((AliasedValue)root["root_name"])?.Value.ToString();

                var rootnode = treeCatalog.Nodes.Add(rootname);
                rootnode.Tag = Guid.Parse(((AliasedValue)root["root_catalogid"])?.Value.ToString());

                rootnode.ImageIndex = 0;
                rootnode.SelectedImageIndex = 0;


                var categories = fullcatalog.Entities.Where(e => e.Contains("category_catalogid")).GroupBy(e => ((AliasedValue)e["category_catalogid"]).Value);


                foreach (var categorygroup in categories)
                {
                    var category = categorygroup.First();
                    var categoryname = ((AliasedValue)category["category_name"])?.Value.ToString();
                    var categorynode = rootnode.Nodes.Add(categoryname);
                    categorynode.Tag = Guid.Parse(((AliasedValue)category["category_catalogid"])?.Value.ToString());

                    categorynode.ImageIndex = 1;
                    categorynode.SelectedImageIndex = 1;

                            
                    foreach (var assignment in categorygroup)
                    {
                        var assignmentobject = assignment.Contains("assignment_object") ?
                                                (EntityReference)((AliasedValue)assignment["assignment_object"])?.Value :
                                                null;


                        if (assignmentobject != null)
                        {
                            var assignmenttype = assignmentobject.LogicalName;

                            var primaryname = string.Empty;
                            if (!assignment.Contains("assignment_name"))
                            {
                                switch (assignmenttype)
                                {
                                    case "entity":
                                        primaryname = $"_{((AliasedValue)assignment["assignment_entity_name"])?.Value.ToString()}";
                                        break;
                                    case "customapi":
                                        primaryname = $"_{((AliasedValue)assignment["assignment_customapi_name"])?.Value.ToString()}";
                                        break;
                                    case "workflow":
                                        primaryname = $"_{((AliasedValue)assignment["assignment_workflow_name"])?.Value.ToString()}";
                                        break;

                                }
                            }
                            else 
                            {
                                primaryname = ((AliasedValue)assignment["assignment_name"])?.Value.ToString();
                            }



                            var assignmentname = $"{primaryname} ({assignmenttype})";

                            var assignmentnode = categorynode.Nodes.Add(assignmentname);
                            assignmentnode.Tag = Guid.Parse(((AliasedValue)assignment["assignment_catalogassignmentid"])?.Value.ToString());

                            var assignmentimgindex = 0;
                            switch (assignmenttype)
                            {
                                case "entity":
                                    assignmentimgindex = 2;
                                    break;
                                case "customapi":
                                    assignmentimgindex = 3;
                                    break;
                                case "workflow":
                                    assignmentimgindex = 4;
                                    break;

                            }
                            assignmentnode.ImageIndex = assignmentimgindex;
                            assignmentnode.SelectedImageIndex = assignmentimgindex;
                        }
                        

                    }
                    
                }
            }
            treeCatalog.ExpandAll();

            treeCatalog.AfterCheck += new TreeViewEventHandler(treeCatalog_AfterSelect);

        }




        private void SettingsDialog()
        {
            var inputdlg = new SettingsForm(Service, ConnectionDetail, _globalsettings, _connectionsettings);
            var dlgresult = inputdlg.ShowDialog();

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
            var inputdlg = new NewCatalogForm(Service, _selectedSolution, null, _connectionsettings);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.NewCatalogId != null)
            {

                //refresh catalog list and select newly created
                SetSelectedCatalog(Service.GetCatalog(inputdlg.NewCatalogId));
                LoadRootCatalogs(inputdlg.NewCatalogId);
                UpdateTreeView();
            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void CreateCategoryDialog()
        {
            var inputdlg = new NewCatalogForm(Service, _selectedSolution, _selectedCatalog, _connectionsettings);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.NewCatalogId != null)
            {

                //refresh category list
                SetSelectedCategory(Service.GetCatalog(inputdlg.NewCatalogId));
                LoadCategories(_selectedCatalog.CatalogRow.Id,  inputdlg.NewCatalogId);
                UpdateTreeView();
            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void CreateCategoryAssignmentDialog()
        {
            var inputdlg = new NewCatalogAssignmentForm(Service, _selectedSolution, _selectedCatalog, _selectedCategory);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.NewCatalogAssignmentId != null)
            {

                //refresh category list
                LoadAssignments(_selectedCategory.CatalogRow.Id, inputdlg.NewCatalogAssignmentId);
                UpdateTreeView();
            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }



        private void UpdateCatalogDialog()
        {

            var inputdlg = new UpdateCatalogForm(Service, _selectedCatalog,null);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogUpdated)
            {


                //refresh custom api list and select newly updated
                SetSelectedCatalog(Service.GetCatalog(_selectedCatalog.CatalogRow.Id));
                LoadRootCatalogs(_selectedCatalog.CatalogRow.Id);
                UpdateTreeView();
            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void UpdateCategoryDialog()
        {

            var inputdlg = new UpdateCatalogForm(Service, _selectedCategory, _selectedCatalog);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogUpdated)
            {
                //clear and refetch
                var currentcategory = _selectedCategory.CatalogRow.Id;
                SetSelectedCategory(null);
                SetSelectedCategory(Service.GetCatalog(currentcategory));
                LoadCategories(_selectedCatalog.CatalogRow.Id, currentcategory);
                UpdateTreeView();
                gridCategories.Focus();

            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void UpdateAssignmentDialog()
        {

            var inputdlg = new UpdateCatalogAssignmentForm(Service, _selectedCatalogAssignment);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogAssignmentUpdated)
            {
                //Clear and Refetch
                var currentassignment = _selectedCatalogAssignment.CatalogAssignmentRow.Id;
                SetSelectedAssignment(null);
                SetSelectedAssignment(Service.GetCatalogAssignment(currentassignment));
                LoadAssignments(_selectedCategory.CatalogRow.Id, currentassignment);
                UpdateTreeView();
                gridAssignments.Focus();

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
               

                LoadRootCatalogs();

                UpdateTreeView();


            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void DeleteCategoryDialog()
        {

            var inputdlg = new DeleteCatalogForm(Service, _selectedCategory);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogDeleted)
            {

                SetSelectedCategory(null);
                SetSelectedAssignment(null);
                LoadCategories(_selectedCatalog.CatalogRow.Id);
                
                UpdateTreeView();



            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void DeleteAssignmentDialog()
        {

            var inputdlg = new DeleteCatalogAssignmentForm(Service, _selectedCatalogAssignment);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogAssignmentDeleted)
            {

                SetSelectedAssignment(null);


                LoadAssignments(_selectedCategory.CatalogRow.Id);
                UpdateTreeView();

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

        private void gridCategories_RecordEnter(object sender, CRMRecordEventArgs e)
        {
            SetSelectedCategory(Service.GetCatalog(e.Entity.Id));

            if (_selectedCategory != null && _selectedCategory?.CatalogRow?.Id != _selectedCatalogAssignment?.CatalogRef?.Id) 
            {
                LoadAssignments(_selectedCategory.CatalogRow.Id);
            }
        }

        

        private void gridAssigments_RecordEnter(object sender, CRMRecordEventArgs e)
        {
            if ((e?.Entity) != null)
            {
                SetSelectedAssignment(Service.GetCatalogAssignment(e.Entity.Id));
            }
           


        }

        private void btnOpenInCustomApiManager_Click(object sender, EventArgs e)
        {
            try
            {
                OnOutgoingMessage(this, new MessageBusEventArgs("Custom API Manager") { TargetArgument = _selectedCatalogAssignment.Object.Id.ToString() });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnOpenInCustomApiTester_Click(object sender, EventArgs e)
        {
            try
            {
                OnOutgoingMessage(this, new MessageBusEventArgs("Custom API Tester") { TargetArgument = _selectedCatalogAssignment.Object.Id.ToString() });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void treeCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = e.Node;
            var id = (Guid)selectedNode.Tag; // Cast to the appropriate type, e.g., (Guid)selectedNode.Tag
            switch (e.Node.Level)
            {
                
                case 0: // Catalog

                    SetSelectedCategory(null);
                    SetSelectedAssignment(null);
                    LoadCategories(_selectedCatalog.CatalogRow.Id);

                    break;
                case 1: // Category
                    
                    SetSelectedCategory(Service.GetCatalog(id));
                    SetSelectedAssignment(null);
                    LoadCategories(_selectedCatalog.CatalogRow.Id, _selectedCategory.CatalogRow.Id);
                    break;
                case 2: // Assignment

                    var assignment = Service.GetCatalogAssignment(id);
                    var assignmentProxy = new CatalogAssignmentProxy(assignment);
                    if(assignmentProxy.CatalogRef.Id != _selectedCategory.CatalogRow.Id) 
                    {
                        SetSelectedCategory(Service.GetCatalog(assignmentProxy.CatalogRef.Id));
                    }
                    SetSelectedAssignment(assignment);
                    LoadCategories(_selectedCatalog.CatalogRow.Id, _selectedCategory.CatalogRow.Id);


                    break;
                default:
                    break;
            }



        }
    }
}