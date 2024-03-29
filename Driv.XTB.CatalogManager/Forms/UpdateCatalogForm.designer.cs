﻿namespace Driv.XTB.CatalogManager.Forms
{
    partial class UpdateCatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCatalogForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustomizable = new System.Windows.Forms.Label();
            this.chkIsCustomizable = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUniqueName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.txtParentCatalog = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.lblParentCatalog = new System.Windows.Forms.Label();
            this.pictParentCatalog = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictParentCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictParentCatalog);
            this.panel2.Controls.Add(this.txtParentCatalog);
            this.panel2.Controls.Add(this.lblParentCatalog);
            this.panel2.Controls.Add(this.lblCustomizable);
            this.panel2.Controls.Add(this.chkIsCustomizable);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.pictureBox3);
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
            this.panel2.Size = new System.Drawing.Size(500, 267);
            this.panel2.TabIndex = 5;
            // 
            // lblCustomizable
            // 
            this.lblCustomizable.AutoSize = true;
            this.lblCustomizable.Location = new System.Drawing.Point(26, 198);
            this.lblCustomizable.Name = "lblCustomizable";
            this.lblCustomizable.Size = new System.Drawing.Size(77, 13);
            this.lblCustomizable.TabIndex = 102;
            this.lblCustomizable.Text = "IsCustomizable";
            this.ttInfo.SetToolTip(this.lblCustomizable, "Controls whether the Catalog can be customized or deleted.");
            // 
            // chkIsCustomizable
            // 
            this.chkIsCustomizable.AutoSize = true;
            this.chkIsCustomizable.Location = new System.Drawing.Point(104, 198);
            this.chkIsCustomizable.Name = "chkIsCustomizable";
            this.chkIsCustomizable.Size = new System.Drawing.Size(15, 14);
            this.chkIsCustomizable.TabIndex = 101;
            this.chkIsCustomizable.UseVisualStyleBackColor = true;
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
            this.lblTitle.Size = new System.Drawing.Size(135, 20);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Update Catalog";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(383, 212);
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
            this.btnOk.Location = new System.Drawing.Point(299, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 32);
            this.btnOk.TabIndex = 72;
            this.btnOk.Text = "Update";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(465, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Display Name";
            this.ttInfo.SetToolTip(this.label10, "Localized display name for this Custom API. \r\nFor use when the message is exposed" +
        " to be called in an app.");
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(104, 117);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(359, 20);
            this.txtDisplayName.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Unique Name";
            this.ttInfo.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // txtUniqueName
            // 
            this.txtUniqueName.Enabled = false;
            this.txtUniqueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniqueName.Location = new System.Drawing.Point(104, 65);
            this.txtUniqueName.Name = "txtUniqueName";
            this.txtUniqueName.Size = new System.Drawing.Size(359, 20);
            this.txtUniqueName.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Name";
            this.ttInfo.SetToolTip(this.label4, "The primary name of the custom API. \r\nThis will display in the list of custom api" +
        "s when viewed in the solution.");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 20);
            this.txtName.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Description";
            this.ttInfo.SetToolTip(this.label3, "Localized description for this Custom API. \r\nFor use when the message is exposed " +
        "to be called in an app. \r\nFor example, as a ToolTip.");
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 143);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(359, 49);
            this.txtDescription.TabIndex = 38;
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 10000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.ReshowDelay = 100;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Attribute Info";
            // 
            // txtParentCatalog
            // 
            this.txtParentCatalog.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentCatalog.DisplayFormat = "{{name}} - ({{uniquename}})";
            this.txtParentCatalog.Entity = null;
            this.txtParentCatalog.EntityReference = null;
            this.txtParentCatalog.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.txtParentCatalog.Location = new System.Drawing.Point(104, 38);
            this.txtParentCatalog.LogicalName = "catalog";
            this.txtParentCatalog.Name = "txtParentCatalog";
            this.txtParentCatalog.OrganizationService = null;
            this.txtParentCatalog.Size = new System.Drawing.Size(232, 20);
            this.txtParentCatalog.TabIndex = 104;
            // 
            // lblParentCatalog
            // 
            this.lblParentCatalog.AutoSize = true;
            this.lblParentCatalog.Location = new System.Drawing.Point(26, 42);
            this.lblParentCatalog.Name = "lblParentCatalog";
            this.lblParentCatalog.Size = new System.Drawing.Size(77, 13);
            this.lblParentCatalog.TabIndex = 103;
            this.lblParentCatalog.Text = "Parent Catalog";
            this.ttInfo.SetToolTip(this.lblParentCatalog, "The primary name of the catalog");
            // 
            // pictParentCatalog
            // 
            this.pictParentCatalog.Image = ((System.Drawing.Image)(resources.GetObject("pictParentCatalog.Image")));
            this.pictParentCatalog.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictParentCatalog.InitialImage")));
            this.pictParentCatalog.Location = new System.Drawing.Point(342, 39);
            this.pictParentCatalog.Name = "pictParentCatalog";
            this.pictParentCatalog.Size = new System.Drawing.Size(20, 19);
            this.pictParentCatalog.TabIndex = 105;
            this.pictParentCatalog.TabStop = false;
            // 
            // UpdateCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 267);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCatalogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalog Manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictParentCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUniqueName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Label lblCustomizable;
        private System.Windows.Forms.CheckBox chkIsCustomizable;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox txtParentCatalog;
        private System.Windows.Forms.Label lblParentCatalog;
        private System.Windows.Forms.PictureBox pictParentCatalog;
    }
}