namespace FaceAccessController.Forms
{
    partial class frmIdentify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdentify));
            this.cbxPersonGroup = new System.Windows.Forms.ComboBox();
            this.lblPersonGroup = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.plTag = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbxPersonGroup
            // 
            this.cbxPersonGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonGroup.FormattingEnabled = true;
            this.cbxPersonGroup.Location = new System.Drawing.Point(60, 4);
            this.cbxPersonGroup.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbxPersonGroup.Name = "cbxPersonGroup";
            this.cbxPersonGroup.Size = new System.Drawing.Size(58, 20);
            this.cbxPersonGroup.TabIndex = 14;
            this.cbxPersonGroup.SelectedIndexChanged += new System.EventHandler(this.cbxPersonGroup_SelectedIndexChanged);
            this.cbxPersonGroup.Click += new System.EventHandler(this.cbxPersonGroup_SelectedIndexChanged);
            // 
            // lblPersonGroup
            // 
            this.lblPersonGroup.AutoSize = true;
            this.lblPersonGroup.Location = new System.Drawing.Point(5, 6);
            this.lblPersonGroup.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPersonGroup.Name = "lblPersonGroup";
            this.lblPersonGroup.Size = new System.Drawing.Size(53, 12);
            this.lblPersonGroup.TabIndex = 13;
            this.lblPersonGroup.Text = "比對群組";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(621, 28);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(44, 19);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(588, 28);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(30, 19);
            this.btnOpenFile.TabIndex = 11;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(60, 28);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(526, 22);
            this.txtFileName.TabIndex = 10;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(5, 29);
            this.lblPicture.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(53, 12);
            this.lblPicture.TabIndex = 9;
            this.lblPicture.Text = "選擇照片";
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPerson.Location = new System.Drawing.Point(7, 358);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(348, 22);
            this.txtPerson.TabIndex = 17;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(358, 58);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(306, 324);
            this.txtResult.TabIndex = 18;
            // 
            // plTag
            // 
            this.plTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plTag.BackColor = System.Drawing.Color.Transparent;
            this.plTag.Location = new System.Drawing.Point(6, 58);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(348, 296);
            this.plTag.TabIndex = 19;
            // 
            // frmIdentify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 391);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cbxPersonGroup);
            this.Controls.Add(this.lblPersonGroup);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.plTag);
            this.Name = "frmIdentify";
            this.Text = "frmIdentify";
            this.Load += new System.EventHandler(this.frmIdentify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxPersonGroup;
        private System.Windows.Forms.Label lblPersonGroup;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel plTag;
    }
}