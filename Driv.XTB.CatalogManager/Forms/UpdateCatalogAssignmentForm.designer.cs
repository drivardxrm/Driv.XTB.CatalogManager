namespace Driv.XTB.CatalogManager.Forms
{
    partial class UpdateCatalogAssignmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCatalogAssignmentForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAssignmentObject = new System.Windows.Forms.TextBox();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.txtAssignmentType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomizable = new System.Windows.Forms.Label();
            this.chkIsCustomizable = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAssignmentObject);
            this.panel2.Controls.Add(this.txtAssignmentName);
            this.panel2.Controls.Add(this.txtAssignmentType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCustomizable);
            this.panel2.Controls.Add(this.chkIsCustomizable);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 186);
            this.panel2.TabIndex = 5;
            // 
            // txtAssignmentObject
            // 
            this.txtAssignmentObject.Location = new System.Drawing.Point(185, 75);
            this.txtAssignmentObject.Name = "txtAssignmentObject";
            this.txtAssignmentObject.ReadOnly = true;
            this.txtAssignmentObject.Size = new System.Drawing.Size(252, 20);
            this.txtAssignmentObject.TabIndex = 109;
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentName.Location = new System.Drawing.Point(78, 49);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(359, 20);
            this.txtAssignmentName.TabIndex = 108;
            // 
            // txtAssignmentType
            // 
            this.txtAssignmentType.Location = new System.Drawing.Point(78, 75);
            this.txtAssignmentType.Name = "txtAssignmentType";
            this.txtAssignmentType.ReadOnly = true;
            this.txtAssignmentType.Size = new System.Drawing.Size(101, 20);
            this.txtAssignmentType.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Name";
            // 
            // lblCustomizable
            // 
            this.lblCustomizable.AutoSize = true;
            this.lblCustomizable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomizable.Location = new System.Drawing.Point(25, 108);
            this.lblCustomizable.Name = "lblCustomizable";
            this.lblCustomizable.Size = new System.Drawing.Size(77, 13);
            this.lblCustomizable.TabIndex = 102;
            this.lblCustomizable.Text = "IsCustomizable";
            this.ttInfo.SetToolTip(this.lblCustomizable, "Controls whether the Catalog can be customized or deleted.");
            // 
            // chkIsCustomizable
            // 
            this.chkIsCustomizable.AutoSize = true;
            this.chkIsCustomizable.Location = new System.Drawing.Point(108, 107);
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
            this.lblTitle.Size = new System.Drawing.Size(234, 20);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Update Catalog Assignment";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(369, 127);
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
            this.btnOk.Location = new System.Drawing.Point(278, 127);
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
            this.pictureBox3.Location = new System.Drawing.Point(443, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 10000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.ReshowDelay = 100;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Attribute Info";
            // 
            // UpdateCatalogAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 179);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCatalogAssignmentForm";
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomizable;
        private System.Windows.Forms.CheckBox chkIsCustomizable;
        private System.Windows.Forms.TextBox txtAssignmentObject;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.TextBox txtAssignmentType;
    }
}