namespace FaceAccessController.Forms
{
    partial class frmCognitive
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
            this.lblEmotionKey = new System.Windows.Forms.Label();
            this.lblFaceApiKey = new System.Windows.Forms.Label();
            this.txtEmotionApiKey = new System.Windows.Forms.TextBox();
            this.txtFaceApiKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmotionKey
            // 
            this.lblEmotionKey.AutoSize = true;
            this.lblEmotionKey.Location = new System.Drawing.Point(12, 15);
            this.lblEmotionKey.Name = "lblEmotionKey";
            this.lblEmotionKey.Size = new System.Drawing.Size(173, 24);
            this.lblEmotionKey.TabIndex = 0;
            this.lblEmotionKey.Tag = ":";
            this.lblEmotionKey.Text = "Emotion API Key";
            // 
            // lblFaceApiKey
            // 
            this.lblFaceApiKey.AutoSize = true;
            this.lblFaceApiKey.Location = new System.Drawing.Point(46, 59);
            this.lblFaceApiKey.Name = "lblFaceApiKey";
            this.lblFaceApiKey.Size = new System.Drawing.Size(139, 24);
            this.lblFaceApiKey.TabIndex = 1;
            this.lblFaceApiKey.Text = "Face API Key";
            // 
            // txtEmotionApiKey
            // 
            this.txtEmotionApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmotionApiKey.Location = new System.Drawing.Point(191, 12);
            this.txtEmotionApiKey.Name = "txtEmotionApiKey";
            this.txtEmotionApiKey.Size = new System.Drawing.Size(777, 36);
            this.txtEmotionApiKey.TabIndex = 2;
            // 
            // txtFaceApiKey
            // 
            this.txtFaceApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFaceApiKey.Location = new System.Drawing.Point(191, 56);
            this.txtFaceApiKey.Name = "txtFaceApiKey";
            this.txtFaceApiKey.Size = new System.Drawing.Size(777, 36);
            this.txtFaceApiKey.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(772, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(873, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCognitive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 159);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFaceApiKey);
            this.Controls.Add(this.txtEmotionApiKey);
            this.Controls.Add(this.lblFaceApiKey);
            this.Controls.Add(this.lblEmotionKey);
            this.MinimizeBox = false;
            this.Name = "frmCognitive";
            this.Text = "frmCognitive";
            this.Load += new System.EventHandler(this.frmCognitive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmotionKey;
        private System.Windows.Forms.Label lblFaceApiKey;
        private System.Windows.Forms.TextBox txtEmotionApiKey;
        private System.Windows.Forms.TextBox txtFaceApiKey;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}