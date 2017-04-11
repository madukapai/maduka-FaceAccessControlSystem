namespace FaceAccessController.Forms
{
    partial class frmCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapture));
            this.lblPicture = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblPersonGroup = new System.Windows.Forms.Label();
            this.cbxPersonGroup = new System.Windows.Forms.ComboBox();
            this.btnCam = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.plTag = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(6, 31);
            this.lblPicture.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(53, 12);
            this.lblPicture.TabIndex = 0;
            this.lblPicture.Text = "選擇照片";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(57, 30);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(382, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(439, 30);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(30, 19);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(472, 30);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(44, 19);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblPersonGroup
            // 
            this.lblPersonGroup.AutoSize = true;
            this.lblPersonGroup.Location = new System.Drawing.Point(6, 8);
            this.lblPersonGroup.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPersonGroup.Name = "lblPersonGroup";
            this.lblPersonGroup.Size = new System.Drawing.Size(53, 12);
            this.lblPersonGroup.TabIndex = 4;
            this.lblPersonGroup.Text = "比對群組";
            // 
            // cbxPersonGroup
            // 
            this.cbxPersonGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonGroup.FormattingEnabled = true;
            this.cbxPersonGroup.Location = new System.Drawing.Point(57, 6);
            this.cbxPersonGroup.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbxPersonGroup.Name = "cbxPersonGroup";
            this.cbxPersonGroup.Size = new System.Drawing.Size(58, 20);
            this.cbxPersonGroup.TabIndex = 5;
            this.cbxPersonGroup.SelectedIndexChanged += new System.EventHandler(this.cbxPersonGroup_SelectedIndexChanged);
            // 
            // btnCam
            // 
            this.btnCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCam.Location = new System.Drawing.Point(472, 6);
            this.btnCam.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(44, 19);
            this.btnCam.TabIndex = 7;
            this.btnCam.Text = "照像";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPerson.Location = new System.Drawing.Point(6, 345);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(517, 22);
            this.txtPerson.TabIndex = 8;
            // 
            // plTag
            // 
            this.plTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plTag.Location = new System.Drawing.Point(8, 57);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(515, 283);
            this.plTag.TabIndex = 9;
            this.plTag.Paint += new System.Windows.Forms.PaintEventHandler(this.plTag_Paint);
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.Location = new System.Drawing.Point(8, 373);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(515, 283);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // frmCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.plTag);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.btnCam);
            this.Controls.Add(this.cbxPersonGroup);
            this.Controls.Add(this.lblPersonGroup);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblPicture);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmCapture";
            this.Text = "frmCapture";
            this.Load += new System.EventHandler(this.frmCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblPersonGroup;
        private System.Windows.Forms.ComboBox cbxPersonGroup;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Panel plTag;
        private System.Windows.Forms.PictureBox picImage;
    }
}