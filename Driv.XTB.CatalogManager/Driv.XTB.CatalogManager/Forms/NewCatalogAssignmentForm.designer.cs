namespace Driv.XTB.CatalogManager.Forms
{
    partial class NewCatalogAssignmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCatalogAssignmentForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLookupProcess = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.btnLookupProcess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLookupCustomAPI = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.btnLookupCustomAPI = new System.Windows.Forms.Button();
            this.lblCustomAPI = new System.Windows.Forms.Label();
            this.cboEntities = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cdsTextCategory = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cdsTextParentCatalog = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.lblParentCatalog = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.dlgCustomAPI = new xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog();
            this.dlgProcess = new xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLookupProcess);
            this.panel2.Controls.Add(this.btnLookupProcess);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtLookupCustomAPI);
            this.panel2.Controls.Add(this.btnLookupCustomAPI);
            this.panel2.Controls.Add(this.lblCustomAPI);
            this.panel2.Controls.Add(this.cboEntities);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.cdsTextCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cdsTextParentCatalog);
            this.panel2.Controls.Add(this.lblParentCatalog);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 370);
            this.panel2.TabIndex = 5;
            // 
            // txtLookupProcess
            // 
            this.txtLookupProcess.BackColor = System.Drawing.SystemColors.Window;
            this.txtLookupProcess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLookupProcess.DisplayFormat = "{{name}}";
            this.txtLookupProcess.Entity = null;
            this.txtLookupProcess.EntityReference = null;
            this.txtLookupProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLookupProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLookupProcess.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.txtLookupProcess.Location = new System.Drawing.Point(104, 294);
            this.txtLookupProcess.LogicalName = "workflow";
            this.txtLookupProcess.Name = "txtLookupProcess";
            this.txtLookupProcess.OrganizationService = null;
            this.txtLookupProcess.Size = new System.Drawing.Size(232, 20);
            this.txtLookupProcess.TabIndex = 92;
            // 
            // btnLookupProcess
            // 
            this.btnLookupProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnLookupProcess.Image")));
            this.btnLookupProcess.Location = new System.Drawing.Point(342, 293);
            this.btnLookupProcess.Name = "btnLookupProcess";
            this.btnLookupProcess.Size = new System.Drawing.Size(23, 23);
            this.btnLookupProcess.TabIndex = 91;
            this.btnLookupProcess.UseVisualStyleBackColor = true;
            this.btnLookupProcess.Click += new System.EventHandler(this.btnLookupProcess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Table";
            this.ttInfo.SetToolTip(this.label2, "A reference to the plug-in type that provides the main operation for this Custom " +
        "API");
            // 
            // txtLookupCustomAPI
            // 
            this.txtLookupCustomAPI.BackColor = System.Drawing.SystemColors.Window;
            this.txtLookupCustomAPI.Clickable = true;
            this.txtLookupCustomAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLookupCustomAPI.DisplayFormat = "{{name}} - ({{uniquename}})";
            this.txtLookupCustomAPI.Entity = null;
            this.txtLookupCustomAPI.EntityReference = null;
            this.txtLookupCustomAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.txtLookupCustomAPI.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLookupCustomAPI.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.txtLookupCustomAPI.Location = new System.Drawing.Point(104, 323);
            this.txtLookupCustomAPI.LogicalName = "customapi";
            this.txtLookupCustomAPI.Name = "txtLookupCustomAPI";
            this.txtLookupCustomAPI.OrganizationService = null;
            this.txtLookupCustomAPI.Size = new System.Drawing.Size(232, 20);
            this.txtLookupCustomAPI.TabIndex = 88;
            // 
            // btnLookupCustomAPI
            // 
            this.btnLookupCustomAPI.Image = ((System.Drawing.Image)(resources.GetObject("btnLookupCustomAPI.Image")));
            this.btnLookupCustomAPI.Location = new System.Drawing.Point(342, 322);
            this.btnLookupCustomAPI.Name = "btnLookupCustomAPI";
            this.btnLookupCustomAPI.Size = new System.Drawing.Size(23, 23);
            this.btnLookupCustomAPI.TabIndex = 87;
            this.btnLookupCustomAPI.UseVisualStyleBackColor = true;
            this.btnLookupCustomAPI.Click += new System.EventHandler(this.btnLookupCustomAPI_Click);
            // 
            // lblCustomAPI
            // 
            this.lblCustomAPI.AutoSize = true;
            this.lblCustomAPI.Location = new System.Drawing.Point(26, 326);
            this.lblCustomAPI.Name = "lblCustomAPI";
            this.lblCustomAPI.Size = new System.Drawing.Size(62, 13);
            this.lblCustomAPI.TabIndex = 86;
            this.lblCustomAPI.Text = "Custom API";
            this.ttInfo.SetToolTip(this.lblCustomAPI, "A reference to the plug-in type that provides the main operation for this Custom " +
        "API");
            // 
            // cboEntities
            // 
            this.cboEntities.AutoLoadData = false;
            this.cboEntities.LanguageCode = 1033;
            this.cboEntities.Location = new System.Drawing.Point(104, 259);
            this.cboEntities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEntities.Name = "cboEntities";
            this.cboEntities.Service = null;
            this.cboEntities.Size = new System.Drawing.Size(293, 25);
            this.cboEntities.SolutionFilter = null;
            this.cboEntities.TabIndex = 85;
            this.cboEntities.SelectedItemChanged += new System.EventHandler(this.cboEntities_SelectedItemChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Name";
            this.ttInfo.SetToolTip(this.label4, "The primary name of the catalog assignment.");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 83;
            // 
            // cdsTextCategory
            // 
            this.cdsTextCategory.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTextCategory.DisplayFormat = "{{name}} - ({{uniquename}}";
            this.cdsTextCategory.Entity = null;
            this.cdsTextCategory.EntityReference = null;
            this.cdsTextCategory.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTextCategory.Location = new System.Drawing.Point(104, 72);
            this.cdsTextCategory.LogicalName = "catalog";
            this.cdsTextCategory.Name = "cdsTextCategory";
            this.cdsTextCategory.OrganizationService = null;
            this.cdsTextCategory.Size = new System.Drawing.Size(232, 20);
            this.cdsTextCategory.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Category";
            this.ttInfo.SetToolTip(this.label1, "The primary name of the catalog");
            // 
            // cdsTextParentCatalog
            // 
            this.cdsTextParentCatalog.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTextParentCatalog.DisplayFormat = "{{name}} - ({{uniquename}}";
            this.cdsTextParentCatalog.Entity = null;
            this.cdsTextParentCatalog.EntityReference = null;
            this.cdsTextParentCatalog.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTextParentCatalog.Location = new System.Drawing.Point(104, 51);
            this.cdsTextParentCatalog.LogicalName = "catalog";
            this.cdsTextParentCatalog.Name = "cdsTextParentCatalog";
            this.cdsTextParentCatalog.OrganizationService = null;
            this.cdsTextParentCatalog.Size = new System.Drawing.Size(232, 20);
            this.cdsTextParentCatalog.TabIndex = 78;
            // 
            // lblParentCatalog
            // 
            this.lblParentCatalog.AutoSize = true;
            this.lblParentCatalog.Location = new System.Drawing.Point(26, 55);
            this.lblParentCatalog.Name = "lblParentCatalog";
            this.lblParentCatalog.Size = new System.Drawing.Size(69, 13);
            this.lblParentCatalog.TabIndex = 77;
            this.lblParentCatalog.Text = "Root Catalog";
            this.ttInfo.SetToolTip(this.lblParentCatalog, "The primary name of the catalog");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(275, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 13);
            this.label17.TabIndex = 75;
            this.label17.Text = "Fields that cannot be modified after creation";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.InitialImage")));
            this.pictureBox13.Location = new System.Drawing.Point(258, 13);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(20, 19);
            this.pictureBox13.TabIndex = 74;
            this.pictureBox13.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 20);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Create Catalog Assignment";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(605, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(605, 214);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 32);
            this.btnOk.TabIndex = 72;
            this.btnOk.Text = "Create";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 10000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.ReshowDelay = 100;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Attribute Info";
            // 
            // dlgCustomAPI
            // 
            this.dlgCustomAPI.Entity = null;
            this.dlgCustomAPI.LogicalName = "customapi";
            this.dlgCustomAPI.LogicalNames = new string[] {
        "customapi"};
            this.dlgCustomAPI.Service = null;
            this.dlgCustomAPI.Title = "Custom API";
            // 
            // dlgProcess
            // 
            this.dlgProcess.Entity = null;
            this.dlgProcess.LogicalName = "workflow";
            this.dlgProcess.LogicalNames = new string[] {
        "workflow"};
            this.dlgProcess.Service = null;
            this.dlgProcess.Title = "Process";
            // 
            // NewCatalogAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(720, 440);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCatalogAssignmentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalog Manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Label lblParentCatalog;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTextParentCatalog;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTextCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog dlgCustomAPI;
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl cboEntities;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox txtLookupCustomAPI;
        private System.Windows.Forms.Button btnLookupCustomAPI;
        private System.Windows.Forms.Label lblCustomAPI;
        private System.Windows.Forms.Label label2;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox txtLookupProcess;
        private System.Windows.Forms.Button btnLookupProcess;
        private System.Windows.Forms.Label label3;
        private xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog dlgProcess;
    }
}