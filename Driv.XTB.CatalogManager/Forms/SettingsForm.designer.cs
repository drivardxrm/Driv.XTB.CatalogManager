namespace Driv.XTB.CatalogManager.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPublisherClear = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtLookupPublisher = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.btnLookupPublisher = new System.Windows.Forms.Button();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dlgLookupPublisher = new xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnPublisherClear);
            this.panel2.Controls.Add(this.lblConnection);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtPrefix);
            this.panel2.Controls.Add(this.txtLookupPublisher);
            this.panel2.Controls.Add(this.btnLookupPublisher);
            this.panel2.Controls.Add(this.lblPublisher);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 380);
            this.panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(464, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 109;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(336, 185);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(122, 32);
            this.btnOk.TabIndex = 108;
            this.btnOk.Text = "Save Changes";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(536, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 25);
            this.button1.TabIndex = 107;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 106;
            this.label12.Text = "Connection : ";
            // 
            // btnPublisherClear
            // 
            this.btnPublisherClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublisherClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisherClear.Image = ((System.Drawing.Image)(resources.GetObject("btnPublisherClear.Image")));
            this.btnPublisherClear.Location = new System.Drawing.Point(562, 156);
            this.btnPublisherClear.Name = "btnPublisherClear";
            this.btnPublisherClear.Size = new System.Drawing.Size(25, 25);
            this.btnPublisherClear.TabIndex = 105;
            this.btnPublisherClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublisherClear.UseVisualStyleBackColor = true;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(106, 81);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(111, 13);
            this.lblConnection.TabIndex = 104;
            this.lblConnection.Text = "{connectiondetail}";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(271, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Prefix";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Enabled = false;
            this.txtPrefix.Location = new System.Drawing.Point(310, 78);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(79, 20);
            this.txtPrefix.TabIndex = 102;
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
            this.txtLookupPublisher.Location = new System.Drawing.Point(269, 54);
            this.txtLookupPublisher.LogicalName = "plugintype";
            this.txtLookupPublisher.Name = "txtLookupPublisher";
            this.txtLookupPublisher.OrganizationService = null;
            this.txtLookupPublisher.Size = new System.Drawing.Size(232, 20);
            this.txtLookupPublisher.TabIndex = 99;
            // 
            // btnLookupPublisher
            // 
            this.btnLookupPublisher.Image = ((System.Drawing.Image)(resources.GetObject("btnLookupPublisher.Image")));
            this.btnLookupPublisher.Location = new System.Drawing.Point(505, 50);
            this.btnLookupPublisher.Name = "btnLookupPublisher";
            this.btnLookupPublisher.Size = new System.Drawing.Size(25, 25);
            this.btnLookupPublisher.TabIndex = 100;
            this.btnLookupPublisher.UseVisualStyleBackColor = true;
            this.btnLookupPublisher.Click += new System.EventHandler(this.btnLookupPublisher_Click);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(20, 57);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(234, 13);
            this.lblPublisher.TabIndex = 101;
            this.lblPublisher.Text = "Default Publisher for current connection";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 20);
            this.lblTitle.TabIndex = 98;
            this.lblTitle.Text = "Settings";
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(564, 238);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalog Manager - Settings";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private xrmtb.XrmToolBox.Controls.Controls.CDSLookupDialog dlgLookupPublisher;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPublisherClear;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrefix;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox txtLookupPublisher;
        private System.Windows.Forms.Button btnLookupPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblTitle;
    }
}