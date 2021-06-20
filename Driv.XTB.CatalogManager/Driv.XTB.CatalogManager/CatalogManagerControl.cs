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

        private CatalogAssignmentProxy _selectedCatalogAssignment; 



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

            cboCatalog.Select();
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

            //Catalog assignment
            txtAssignmentIsCustomizable.OrganizationService = Service;
            txtAssignmentName.OrganizationService = Service;
            txtAssignmentObject.OrganizationService = Service;


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

                SetCboCatalogDataSource(null);


                //LoadSolutions();
                ExecuteMethod(InitializeService);
                

                //select the all radio button
                rbAll.Checked = true;
                ExecuteMethod(LoadRootCatalogs);
                cboCatalog.Select();
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


        private void cdsCboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSolution = cboSolutions.SelectedIndex != -1 ?
                                            new SolutionProxy(cboSolutions.SelectedEntity) :
                                            null;

            ExecuteMethod(LoadRootCatalogs);

        }

        

        



        private void cdsCboCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {


            SetSelectedCategory(null);


            var catalog = cboCatalog.SelectedIndex == -1 ? null : cboCatalog.SelectedEntity;
            SetSelectedCatalog(catalog);


            LoadCategories();

        }

        




        #endregion

        #region Private Methods

        private void LoadSolutions(Guid selected)
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
                            var index = solutions.Entities.Select(e => e.Id).ToList().IndexOf(selected);

                            SetCboSolutionsDataSource(solutions);
                           
                            
                            cboSolutions.SelectedIndex = index;
                            cboSolutions.Enabled = true;

                        }
                    }
                }
            });

        }

        private void LoadRootCatalogs()
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

                            var customapis = (EntityCollection)args.Result;
                            //Find the index of the selected API in the list
                            var index = customapis.Entities.Select(e => e.Id).ToList().IndexOf(_selectedCatalog?.CatalogRow.Id ?? Guid.Empty);

                            SetCboCatalogDataSource(customapis);
                            
                            //hack to force a refresh... must be a better way
                            if (cboCatalog.SelectedIndex == index) 
                            {
                                cboCatalog.SelectedIndex = -1;
                            }
                            cboCatalog.SelectedIndex = index;
                            cboCatalog.Enabled = true;

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

                            gridCategories.ClearSelection();

                            if (gridCategories.Rows.Count > 0)
                            {
                                int index = GetGridSelectedIndex(gridCategories, selected);
                                gridCategories.CurrentCell = gridCategories.Rows[index].Cells[2];

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

        private void LoadAssignments(Guid? selected = null)
        {
            SetGridAssignmentsDataSource(null);


            SetSelectedAssignment(null);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading assignments...",
                Work = (worker, args) =>
                {
                    args.Result = Service.GetCatalogAssignmentsFor(_selectedCategory?.CatalogRow.Id ?? Guid.Empty);

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
                                int index = GetGridSelectedIndex(gridAssignments, selected);
                                gridAssignments.CurrentCell = gridAssignments.Rows[index].Cells[2];

                            }
                            else
                            {
                                SetSelectedAssignment(null);
                            }

                        }
                    }
                }
            });
        }

        /// Will set the DataSource of the control. Disabling the event handlers will prevent unessesary triggers.
        private void SetCboSolutionsDataSource(object datasource)
        {
            cboSolutions.SelectedIndexChanged -= new EventHandler(cdsCboSolutions_SelectedIndexChanged);
            cboSolutions.DataSource = datasource;
            cboSolutions.SelectedIndexChanged += new EventHandler(cdsCboSolutions_SelectedIndexChanged);
        }

        
        private void SetCboCatalogDataSource(object datasource)
        {
            cboCatalog.SelectedIndexChanged -= new EventHandler(cdsCboCatalog_SelectedIndexChanged);
            cboCatalog.DataSource = datasource;
            cboCatalog.SelectedIndexChanged += new EventHandler(cdsCboCatalog_SelectedIndexChanged);
        }

        private void SetGridCategoriesDataSource(object datasource)
        {
            gridCategories.RecordEnter -= new CRMRecordEventHandler(cdsGridCategories_RecordEnter);
            gridCategories.DataSource = datasource;
            gridCategories.RecordEnter += new CRMRecordEventHandler(cdsGridCategories_RecordEnter);
        }

        private void SetGridAssignmentsDataSource(object datasource)
        {
            gridAssignments.RecordEnter -= new CRMRecordEventHandler(cdsGridAssigments_RecordEnter);
            gridAssignments.DataSource = datasource;
            gridAssignments.RecordEnter += new CRMRecordEventHandler(cdsGridAssigments_RecordEnter);
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
                btnEditCustomApi.Enabled = _selectedCatalog.CanCustomize;
                btnDeleteApi.Enabled = _selectedCatalog.CanCustomize;
                
            }

            imgGrpRootCatalog.Enabled = _selectedCatalog != null;
            imgGrpCategories.Enabled = _selectedCatalog != null;


            UpdateTreeView();

        }

        private void SetSelectedCategory(Entity catalog)
        {
            _selectedCategory = catalog != null ? new CatalogProxy(catalog) : null;



            txtCategoryUniqueName.Entity = _selectedCategory?.CatalogRow;
            txtCategoryName.Entity = _selectedCategory?.CatalogRow;
            txtCategoryDisplayName.Entity = _selectedCategory?.CatalogRow;
            txtCategoryDescription.Entity = _selectedCategory?.CatalogRow;
            txtCategoryIsCustomizable.Entity = _selectedCategory?.CatalogRow;

           
                
            btnEditCategory.Enabled = _selectedCategory != null;
            btnDeleteCategory.Enabled = _selectedCategory != null;


            


            LoadAssignments(_selectedCategory?.CatalogRow?.Id ?? Guid.Empty);


            imgGrpAssignments.Enabled = _selectedCategory != null;

            

        }

        private void SetSelectedAssignment(Entity catalogassignment)
        {
            _selectedCatalogAssignment = catalogassignment != null ? new CatalogAssignmentProxy(catalogassignment) : null;

            txtAssignmentName.Entity = _selectedCatalogAssignment?.CatalogAssignmentRow;
            txtAssignmentObject.Entity = _selectedCatalogAssignment?.CatalogAssignmentRow;
            txtAssignmentIsCustomizable.Entity = _selectedCatalogAssignment?.CatalogAssignmentRow;
            txtAssignmentType.Text = _selectedCatalogAssignment?.ObjectType;

            pictTable.Visible = txtAssignmentType.Text == "entity";
            pictAPI.Visible = txtAssignmentType.Text == "customapi";
            pictProcess.Visible = txtAssignmentType.Text == "workflow";

            btnUpdateAssignment.Enabled = _selectedCatalogAssignment != null;
            btnDeleteAssignment.Enabled = _selectedCatalogAssignment != null;

        }



        private void UpdateTreeView() 
        {
            treeCatalog.Nodes.Clear();
            
            if (_selectedCatalog != null) 
            {
                var fullcatalog = Service.GetFullCatalog(_selectedCatalog.CatalogRow.Id);
                var root = fullcatalog.Entities.First();

                var rootname = ((AliasedValue)root["root_name"])?.Value.ToString();

                var rootnode = treeCatalog.Nodes.Add(rootname);

                rootnode.ImageIndex = 0;
                rootnode.SelectedImageIndex = 0;


                var categories = fullcatalog.Entities.Where(e => e.Contains("category_catalogid")).GroupBy(e => ((AliasedValue)e["category_catalogid"]).Value);


                foreach (var categorygroup in categories)
                {
                    var category = categorygroup.First();
                    var categoryname = ((AliasedValue)category["category_name"])?.Value.ToString();
                    var categorynode = rootnode.Nodes.Add(categoryname);

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
                            var assignmentname = $"{((AliasedValue)assignment["assignment_name"])?.Value.ToString()} ({assignmenttype})";

                            var assignmentnode = categorynode.Nodes.Add(assignmentname);
                            
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

                //refresh catalog list and select newly created
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
                LoadAssignments(inputdlg.NewCatalogAssignmentId);
                UpdateTreeView();
            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
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

        private void UpdateCategoryDialog()
        {

            var inputdlg = new UpdateCatalogForm(Service, _selectedCategory);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.CatalogUpdated)
            {


                LoadCategories(_selectedCategory.CatalogRow.Id);
                UpdateTreeView();

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


                LoadAssignments(_selectedCatalogAssignment.CatalogAssignmentRow.Id);
                UpdateTreeView();

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
                LoadAssignments();
                UpdateTreeView();

                //LoadCategories(null);


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


                LoadAssignments();
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

        private void cdsGridCategories_RecordEnter(object sender, CRMRecordEventArgs e)
        {
            SetSelectedCategory(Service.GetCatalog(e.Entity.Id));

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategoryDialog();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            UpdateCategoryDialog();
        }

        private void cdsGridAssigments_RecordEnter(object sender, CRMRecordEventArgs e)
        {
            SetSelectedAssignment(Service.GetCatalogAssignment(e.Entity.Id));

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
    }
}