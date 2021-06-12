namespace Driv.XTB.CatalogManager.Forms
{
    partial class NewCatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCatalogForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtLookupPublisher = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.btnLookupPublisher = new System.Windows.Forms.Button();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUniqueName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dlgLookupPublisher = new xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.txtPrefix);
            this.panel2.Controls.Add(this.txtLookupPublisher);
            this.panel2.Controls.Add(this.btnLookupPublisher);
            this.panel2.Controls.Add(this.lblPublisher);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtDisplayName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtUniqueName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 328);
            this.panel2.TabIndex = 5;
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
            this.lblTitle.Size = new System.Drawing.Size(169, 20);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Create New Catalog";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(385, 252);
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
            this.btnOk.Location = new System.Drawing.Point(278, 252);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 32);
            this.btnOk.TabIndex = 72;
            this.btnOk.Text = "Create";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(463, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // txtPrefix
            // 
            this.txtPrefix.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrefix.Location = new System.Drawing.Point(104, 96);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(55, 20);
            this.txtPrefix.TabIndex = 62;
            // 
            // txtLookupPublisher
            // 
            this.txtLookupPublisher.BackColor = System.Drawing.SystemColors.Window;
            this.txtLookupPublisher.Clickable = true;
            this.txtLookupPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLookupPublisher.DisplayFormat = "{{friendlyname}}";
            this.txtLookupPublisher.Entity = null;
            this.txtLookupPublisher.EntityReference = null;
            this.txtLookupPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.txtLookupPublisher.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLookupPublisher.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.txtLookupPublisher.Location = new System.Drawing.Point(104, 48);
            this.txtLookupPublisher.LogicalName = "plugintype";
            this.txtLookupPublisher.Name = "txtLookupPublisher";
            this.txtLookupPublisher.OrganizationService = null;
            this.txtLookupPublisher.Size = new System.Drawing.Size(232, 20);
            this.txtLookupPublisher.TabIndex = 61;
            // 
            // btnLookupPublisher
            // 
            this.btnLookupPublisher.Image = ((System.Drawing.Image)(resources.GetObject("btnLookupPublisher.Image")));
            this.btnLookupPublisher.Location = new System.Drawing.Point(342, 46);
            this.btnLookupPublisher.Name = "btnLookupPublisher";
            this.btnLookupPublisher.Size = new System.Drawing.Size(23, 23);
            this.btnLookupPublisher.TabIndex = 60;
            this.btnLookupPublisher.UseVisualStyleBackColor = true;
            this.btnLookupPublisher.Click += new System.EventHandler(this.btnLookupPublisher_Click);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(26, 49);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 59;
            this.lblPublisher.Text = "Publisher";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Display Name";
            this.ttInfo.SetToolTip(this.label10, "\tLocalized display name for catalog instances");
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(104, 148);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(359, 20);
            this.txtDisplayName.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Unique Name";
            this.ttInfo.SetToolTip(this.label6, "Unique name for the catalog.\r\nThis value must include a customization prefix that" +
        " matches the prefix set for your solution publisher.\r\nCannot be changed after it" +
        " is saved.");
            // 
            // txtUniqueName
            // 
            this.txtUniqueName.Location = new System.Drawing.Point(161, 96);
            this.txtUniqueName.Name = "txtUniqueName";
            this.txtUniqueName.Size = new System.Drawing.Size(302, 20);
            this.txtUniqueName.TabIndex = 45;
            this.txtUniqueName.Leave += new System.EventHandler(this.txtUniqueName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Name";
            this.ttInfo.SetToolTip(this.label4, "The primary name of the catalog");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 20);
            this.txtName.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Description";
            this.ttInfo.SetToolTip(this.label3, "Localized description for catalog instances");
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 174);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(359, 49);
            this.txtDescription.TabIndex = 38;
            // 
            // dlgLookupPublisher
            // 
            this.dlgLookupPublisher.Entity = null;
            this.dlgLookupPublisher.LogicalName = "publisher";
            this.dlgLookupPublisher.LogicalNames = new string[] {
        "publisher"};
            this.dlgLookupPublisher.Service = null;
            this.dlgLookupPublisher.Title = null;
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 10000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.ReshowDelay = 100;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Attribute Info";
            // 
            // NewCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 326);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCatalogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalog Manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUniqueName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog dlgLookupPublisher;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox txtLookupPublisher;
        private System.Windows.Forms.Button btnLookupPublisher;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}