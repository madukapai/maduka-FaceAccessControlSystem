namespace FaceAccessController.Forms
{
    partial class frmFaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaces));
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnAddFace = new System.Windows.Forms.Button();
            this.btnDeleteFace = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lbxFace = new System.Windows.Forms.ListBox();
            this.lblFace = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPerson.Location = new System.Drawing.Point(71, 12);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(517, 22);
            this.txtPerson.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(594, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(30, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnAddFace
            // 
            this.btnAddFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFace.Location = new System.Drawing.Point(627, 12);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Size = new System.Drawing.Size(75, 23);
            this.btnAddFace.TabIndex = 3;
            this.btnAddFace.Text = "Add";
            this.btnAddFace.UseVisualStyleBackColor = true;
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // btnDeleteFace
            // 
            this.btnDeleteFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFace.Enabled = false;
            this.btnDeleteFace.Location = new System.Drawing.Point(627, 322);
            this.btnDeleteFace.Name = "btnDeleteFace";
            this.btnDeleteFace.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFace.TabIndex = 4;
            this.btnDeleteFace.Text = "Delete";
            this.btnDeleteFace.UseVisualStyleBackColor = true;
            this.btnDeleteFace.Click += new System.EventHandler(this.btnDeleteFace_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 17);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(53, 12);
            this.lblFilePath.TabIndex = 5;
            this.lblFilePath.Text = "上傳照片";
            // 
            // lbxFace
            // 
            this.lbxFace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxFace.FormattingEnabled = true;
            this.lbxFace.ItemHeight = 12;
            this.lbxFace.Location = new System.Drawing.Point(71, 40);
            this.lbxFace.Name = "lbxFace";
            this.lbxFace.Size = new System.Drawing.Size(266, 304);
            this.lbxFace.TabIndex = 6;
            this.lbxFace.SelectedIndexChanged += new System.EventHandler(this.lbxFace_SelectedIndexChanged);
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Location = new System.Drawing.Point(12, 40);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(53, 12);
            this.lblFace.TabIndex = 7;
            this.lblFace.Text = "照片列表";
            // 
            // picFace
            // 
            this.picFace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFace.Location = new System.Drawing.Point(343, 40);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(281, 305);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFace.TabIndex = 8;
            this.picFace.TabStop = false;
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // frmFaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 354);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.lblFace);
            this.Controls.Add(this.lbxFace);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnDeleteFace);
            this.Controls.Add(this.btnAddFace);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtPerson);
            this.Name = "frmFaces";
            this.Text = "frmFaces";
            this.Load += new System.EventHandler(this.frmFaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnAddFace;
        private System.Windows.Forms.Button btnDeleteFace;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.ListBox lbxFace;
        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}