namespace Driv.XTB.CatalogManager
{
    partial class CatalogManagerControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogManagerControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.menuRefresh = new System.Windows.Forms.ToolStripButton();
            this.menuNewApi = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslAbout = new System.Windows.Forms.ToolStripLabel();
            this.grpCatalog = new System.Windows.Forms.GroupBox();
            this.cdsTxtDescription = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsTxtDisplayName = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomizableWarning = new System.Windows.Forms.TextBox();
            this.grpStatusApi = new System.Windows.Forms.GroupBox();
            this.cdsTxtIsManaged = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cdsTxtIsCustomizable = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.btnDeleteApi = new System.Windows.Forms.Button();
            this.lblInfoLock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEditCustomApi = new System.Windows.Forms.Button();
            this.cdsTxtName = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsTxtUniqueName = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnNewApi = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cdsCboSolutions = new xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox();
            this.rbSolution = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.cdsCboCatalog = new xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenu.SuspendLayout();
            this.grpCatalog.SuspendLayout();
            this.grpStatusApi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh,
            this.menuNewApi,
            this.tssSeparator1,
            this.tslAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1129, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // menuRefresh
            // 
            this.menuRefresh.Image = ((System.Drawing.Image)(resources.GetObject("menuRefresh.Image")));
            this.menuRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(139, 28);
            this.menuRefresh.Text = "Refresh Catalog List";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // menuNewApi
            // 
            this.menuNewApi.Image = ((System.Drawing.Image)(resources.GetObject("menuNewApi.Image")));
            this.menuNewApi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNewApi.Name = "menuNewApi";
            this.menuNewApi.Size = new System.Drawing.Size(140, 28);
            this.menuNewApi.Text = "Create New Catalog";
            this.menuNewApi.Click += new System.EventHandler(this.menuNewApi_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tslAbout
            // 
            this.tslAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslAbout.Image = ((System.Drawing.Image)(resources.GetObject("tslAbout.Image")));
            this.tslAbout.IsLink = true;
            this.tslAbout.Name = "tslAbout";
            this.tslAbout.Size = new System.Drawing.Size(113, 28);
            this.tslAbout.Text = "by David Rivard";
            this.tslAbout.Click += new System.EventHandler(this.tslAbout_Click);
            // 
            // grpCatalog
            // 
            this.grpCatalog.Controls.Add(this.cdsTxtDescription);
            this.grpCatalog.Controls.Add(this.cdsTxtDisplayName);
            this.grpCatalog.Controls.Add(this.label3);
            this.grpCatalog.Controls.Add(this.label10);
            this.grpCatalog.Controls.Add(this.txtCustomizableWarning);
            this.grpCatalog.Controls.Add(this.grpStatusApi);
            this.grpCatalog.Controls.Add(this.btnDeleteApi);
            this.grpCatalog.Controls.Add(this.pictureBox3);
            this.grpCatalog.Controls.Add(this.btnEditCustomApi);
            this.grpCatalog.Controls.Add(this.cdsTxtName);
            this.grpCatalog.Controls.Add(this.cdsTxtUniqueName);
            this.grpCatalog.Controls.Add(this.label4);
            this.grpCatalog.Controls.Add(this.label6);
            this.grpCatalog.Enabled = false;
            this.grpCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCatalog.Location = new System.Drawing.Point(3, 117);
            this.grpCatalog.Name = "grpCatalog";
            this.grpCatalog.Size = new System.Drawing.Size(1113, 614);
            this.grpCatalog.TabIndex = 6;
            this.grpCatalog.TabStop = false;
            this.grpCatalog.Text = "Root Catalog";
            // 
            // cdsTxtDescription
            // 
            this.cdsTxtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtDescription.DisplayFormat = "description";
            this.cdsTxtDescription.Entity = null;
            this.cdsTxtDescription.EntityReference = null;
            this.cdsTxtDescription.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtDescription.Location = new System.Drawing.Point(100, 128);
            this.cdsTxtDescription.LogicalName = "customapi";
            this.cdsTxtDescription.Multiline = true;
            this.cdsTxtDescription.Name = "cdsTxtDescription";
            this.cdsTxtDescription.OrganizationService = null;
            this.cdsTxtDescription.Size = new System.Drawing.Size(242, 40);
            this.cdsTxtDescription.TabIndex = 93;
            // 
            // cdsTxtDisplayName
            // 
            this.cdsTxtDisplayName.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtDisplayName.DisplayFormat = "displayname";
            this.cdsTxtDisplayName.Entity = null;
            this.cdsTxtDisplayName.EntityReference = null;
            this.cdsTxtDisplayName.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtDisplayName.Location = new System.Drawing.Point(100, 103);
            this.cdsTxtDisplayName.LogicalName = "customapi";
            this.cdsTxtDisplayName.Name = "cdsTxtDisplayName";
            this.cdsTxtDisplayName.OrganizationService = null;
            this.cdsTxtDisplayName.Size = new System.Drawing.Size(242, 20);
            this.cdsTxtDisplayName.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Description";
            this.ttInfo.SetToolTip(this.label3, "Localized description for this Custom API. \r\nFor use when the message is exposed " +
        "to be called in an app. \r\nFor example, as a ToolTip.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 91;
            this.label10.Text = "Display Name";
            this.ttInfo.SetToolTip(this.label10, "Localized display name for this Custom API. \r\nFor use when the message is exposed" +
        " to be called in an app.");
            // 
            // txtCustomizableWarning
            // 
            this.txtCustomizableWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCustomizableWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomizableWarning.Location = new System.Drawing.Point(22, 254);
            this.txtCustomizableWarning.Multiline = true;
            this.txtCustomizableWarning.Name = "txtCustomizableWarning";
            this.txtCustomizableWarning.ReadOnly = true;
            this.txtCustomizableWarning.Size = new System.Drawing.Size(187, 32);
            this.txtCustomizableWarning.TabIndex = 89;
            this.txtCustomizableWarning.Text = "Warning : Status makes this API not customizable.";
            this.txtCustomizableWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomizableWarning.Visible = false;
            // 
            // grpStatusApi
            // 
            this.grpStatusApi.Controls.Add(this.cdsTxtIsManaged);
            this.grpStatusApi.Controls.Add(this.label23);
            this.grpStatusApi.Controls.Add(this.label28);
            this.grpStatusApi.Controls.Add(this.cdsTxtIsCustomizable);
            this.grpStatusApi.Location = new System.Drawing.Point(22, 184);
            this.grpStatusApi.Name = "grpStatusApi";
            this.grpStatusApi.Size = new System.Drawing.Size(183, 64);
            this.grpStatusApi.TabIndex = 88;
            this.grpStatusApi.TabStop = false;
            this.grpStatusApi.Text = "Status";
            // 
            // cdsTxtIsManaged
            // 
            this.cdsTxtIsManaged.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIsManaged.DisplayFormat = "ismanaged";
            this.cdsTxtIsManaged.Entity = null;
            this.cdsTxtIsManaged.EntityReference = null;
            this.cdsTxtIsManaged.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIsManaged.Location = new System.Drawing.Point(95, 12);
            this.cdsTxtIsManaged.LogicalName = "catalog";
            this.cdsTxtIsManaged.Name = "cdsTxtIsManaged";
            this.cdsTxtIsManaged.OrganizationService = null;
            this.cdsTxtIsManaged.Size = new System.Drawing.Size(68, 20);
            this.cdsTxtIsManaged.TabIndex = 83;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 84;
            this.label23.Text = "IsManaged";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 38);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 13);
            this.label28.TabIndex = 86;
            this.label28.Text = "IsCustomizable";
            // 
            // cdsTxtIsCustomizable
            // 
            this.cdsTxtIsCustomizable.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIsCustomizable.DisplayFormat = "iscustomizable";
            this.cdsTxtIsCustomizable.Entity = null;
            this.cdsTxtIsCustomizable.EntityReference = null;
            this.cdsTxtIsCustomizable.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIsCustomizable.Location = new System.Drawing.Point(95, 35);
            this.cdsTxtIsCustomizable.LogicalName = "catalog";
            this.cdsTxtIsCustomizable.Name = "cdsTxtIsCustomizable";
            this.cdsTxtIsCustomizable.OrganizationService = null;
            this.cdsTxtIsCustomizable.Size = new System.Drawing.Size(68, 20);
            this.cdsTxtIsCustomizable.TabIndex = 85;
            // 
            // btnDeleteApi
            // 
            this.btnDeleteApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteApi.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteApi.Image")));
            this.btnDeleteApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteApi.Location = new System.Drawing.Point(224, 15);
            this.btnDeleteApi.Name = "btnDeleteApi";
            this.btnDeleteApi.Size = new System.Drawing.Size(118, 29);
            this.btnDeleteApi.TabIndex = 82;
            this.btnDeleteApi.Text = "Delete Catalog";
            this.btnDeleteApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteApi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteApi.UseVisualStyleBackColor = true;
            this.btnDeleteApi.Click += new System.EventHandler(this.btnDeleteApi_Click);
            // 
            // lblInfoLock
            // 
            this.lblInfoLock.AutoSize = true;
            this.lblInfoLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLock.Location = new System.Drawing.Point(719, 85);
            this.lblInfoLock.Name = "lblInfoLock";
            this.lblInfoLock.Size = new System.Drawing.Size(213, 13);
            this.lblInfoLock.TabIndex = 53;
            this.lblInfoLock.Text = "Fields that cannot be modified after creation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(696, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 19);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(342, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // btnEditCustomApi
            // 
            this.btnEditCustomApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomApi.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomApi.Image")));
            this.btnEditCustomApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomApi.Location = new System.Drawing.Point(100, 15);
            this.btnEditCustomApi.Name = "btnEditCustomApi";
            this.btnEditCustomApi.Size = new System.Drawing.Size(108, 29);
            this.btnEditCustomApi.TabIndex = 19;
            this.btnEditCustomApi.Text = "Edit Catalog";
            this.btnEditCustomApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomApi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCustomApi.UseVisualStyleBackColor = true;
            this.btnEditCustomApi.Click += new System.EventHandler(this.btnEditCustomApi_Click);
            // 
            // cdsTxtName
            // 
            this.cdsTxtName.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtName.DisplayFormat = "name";
            this.cdsTxtName.Entity = null;
            this.cdsTxtName.EntityReference = null;
            this.cdsTxtName.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtName.Location = new System.Drawing.Point(100, 77);
            this.cdsTxtName.LogicalName = "customapi";
            this.cdsTxtName.Name = "cdsTxtName";
            this.cdsTxtName.OrganizationService = null;
            this.cdsTxtName.Size = new System.Drawing.Size(242, 20);
            this.cdsTxtName.TabIndex = 42;
            // 
            // cdsTxtUniqueName
            // 
            this.cdsTxtUniqueName.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtUniqueName.DisplayFormat = "uniquename";
            this.cdsTxtUniqueName.Entity = null;
            this.cdsTxtUniqueName.EntityReference = null;
            this.cdsTxtUniqueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdsTxtUniqueName.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtUniqueName.Location = new System.Drawing.Point(100, 51);
            this.cdsTxtUniqueName.LogicalName = "customapi";
            this.cdsTxtUniqueName.Name = "cdsTxtUniqueName";
            this.cdsTxtUniqueName.OrganizationService = null;
            this.cdsTxtUniqueName.Size = new System.Drawing.Size(242, 20);
            this.cdsTxtUniqueName.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            this.ttInfo.SetToolTip(this.label4, "The primary name of the custom API. \r\nThis will display in the list of custom api" +
        "s when viewed in the solution.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unique Name";
            this.ttInfo.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.label22);
            this.grpFilter.Controls.Add(this.btnNewApi);
            this.grpFilter.Controls.Add(this.label17);
            this.grpFilter.Controls.Add(this.cdsCboSolutions);
            this.grpFilter.Controls.Add(this.rbSolution);
            this.grpFilter.Controls.Add(this.rbAll);
            this.grpFilter.Controls.Add(this.cdsCboCatalog);
            this.grpFilter.Controls.Add(this.label12);
            this.grpFilter.Location = new System.Drawing.Point(3, 36);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(688, 75);
            this.grpFilter.TabIndex = 21;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Select Catalog";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 84;
            this.label22.Text = "Filter";
            // 
            // btnNewApi
            // 
            this.btnNewApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewApi.Image = ((System.Drawing.Image)(resources.GetObject("btnNewApi.Image")));
            this.btnNewApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewApi.Location = new System.Drawing.Point(518, 26);
            this.btnNewApi.Name = "btnNewApi";
            this.btnNewApi.Size = new System.Drawing.Size(152, 29);
            this.btnNewApi.TabIndex = 83;
            this.btnNewApi.Text = "Create New Catalog";
            this.btnNewApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewApi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewApi.UseVisualStyleBackColor = true;
            this.btnNewApi.Click += new System.EventHandler(this.btnNewApi_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(479, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Or";
            // 
            // cdsCboSolutions
            // 
            this.cdsCboSolutions.DisplayFormat = "{{friendlyname}} ({{P.customizationprefix}})";
            this.cdsCboSolutions.Enabled = false;
            this.cdsCboSolutions.FormattingEnabled = true;
            this.cdsCboSolutions.Location = new System.Drawing.Point(166, 13);
            this.cdsCboSolutions.Name = "cdsCboSolutions";
            this.cdsCboSolutions.OrganizationService = null;
            this.cdsCboSolutions.Size = new System.Drawing.Size(295, 21);
            this.cdsCboSolutions.TabIndex = 40;
            this.cdsCboSolutions.SelectedIndexChanged += new System.EventHandler(this.cdsCboSolutions_SelectedIndexChanged);
            // 
            // rbSolution
            // 
            this.rbSolution.AutoSize = true;
            this.rbSolution.Location = new System.Drawing.Point(89, 15);
            this.rbSolution.Name = "rbSolution";
            this.rbSolution.Size = new System.Drawing.Size(78, 17);
            this.rbSolution.TabIndex = 39;
            this.rbSolution.TabStop = true;
            this.rbSolution.Text = "By Solution";
            this.rbSolution.UseVisualStyleBackColor = true;
            this.rbSolution.CheckedChanged += new System.EventHandler(this.rbSolution_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(50, 15);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 38;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // cdsCboCatalog
            // 
            this.cdsCboCatalog.DisplayFormat = "{{displayname}}  :  ({{uniquename}})";
            this.cdsCboCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdsCboCatalog.FormattingEnabled = true;
            this.cdsCboCatalog.Location = new System.Drawing.Point(128, 41);
            this.cdsCboCatalog.Name = "cdsCboCatalog";
            this.cdsCboCatalog.OrganizationService = null;
            this.cdsCboCatalog.Size = new System.Drawing.Size(333, 21);
            this.cdsCboCatalog.TabIndex = 24;
            this.cdsCboCatalog.SelectedIndexChanged += new System.EventHandler(this.cdsCboCatalog_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Select Root Catalog";
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 10000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.ReshowDelay = 100;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Attribute Info";
            // 
            // CatalogManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.grpCatalog);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblInfoLock);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CatalogManagerControl";
            this.Size = new System.Drawing.Size(1129, 741);
            this.ttInfo.SetToolTip(this, "Localized display name for this Custom API. \r\nFor use when the message is exposed" +
        " to be called in an app.");
            this.Load += new System.EventHandler(this.CustomApiManagerControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.grpCatalog.ResumeLayout(false);
            this.grpCatalog.PerformLayout();
            this.grpStatusApi.ResumeLayout(false);
            this.grpStatusApi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripLabel tslAbout;
        private System.Windows.Forms.GroupBox grpCatalog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditCustomApi;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label label12;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsCboCatalog;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtUniqueName;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtName;
        private System.Windows.Forms.Label lblInfoLock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDeleteApi;
        private System.Windows.Forms.Button btnNewApi;
        private System.Windows.Forms.ToolStripButton menuRefresh;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbSolution;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsCboSolutions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripButton menuNewApi;
        private System.Windows.Forms.Label label23;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIsManaged;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIsCustomizable;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox grpStatusApi;
        private System.Windows.Forms.TextBox txtCustomizableWarning;
        private System.Windows.Forms.ToolTip ttInfo;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtDescription;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
    }
}
