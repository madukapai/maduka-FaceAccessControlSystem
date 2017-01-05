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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFaceApiKey = new System.Windows.Forms.TextBox();
            this.txtEmotionApiKey = new System.Windows.Forms.TextBox();
            this.lblFaceApiKey = new System.Windows.Forms.Label();
            this.lblEmotionKey = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInteval = new System.Windows.Forms.Label();
            this.lblVisionApiKey = new System.Windows.Forms.Label();
            this.txtVisionApiKey = new System.Windows.Forms.TextBox();
            this.txtFaceApiUrl = new System.Windows.Forms.TextBox();
            this.lblFaceApiUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(403, 139);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 19);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(356, 139);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 19);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFaceApiKey
            // 
            this.txtFaceApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFaceApiKey.Location = new System.Drawing.Point(100, 32);
            this.txtFaceApiKey.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtFaceApiKey.Name = "txtFaceApiKey";
            this.txtFaceApiKey.Size = new System.Drawing.Size(349, 22);
            this.txtFaceApiKey.TabIndex = 3;
            // 
            // txtEmotionApiKey
            // 
            this.txtEmotionApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmotionApiKey.Location = new System.Drawing.Point(100, 6);
            this.txtEmotionApiKey.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEmotionApiKey.Name = "txtEmotionApiKey";
            this.txtEmotionApiKey.Size = new System.Drawing.Size(349, 22);
            this.txtEmotionApiKey.TabIndex = 2;
            // 
            // lblFaceApiKey
            // 
            this.lblFaceApiKey.AutoSize = true;
            this.lblFaceApiKey.Location = new System.Drawing.Point(25, 35);
            this.lblFaceApiKey.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFaceApiKey.Name = "lblFaceApiKey";
            this.lblFaceApiKey.Size = new System.Drawing.Size(69, 12);
            this.lblFaceApiKey.TabIndex = 1;
            this.lblFaceApiKey.Text = "Face API Key";
            // 
            // lblEmotionKey
            // 
            this.lblEmotionKey.AutoSize = true;
            this.lblEmotionKey.Location = new System.Drawing.Point(6, 9);
            this.lblEmotionKey.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmotionKey.Name = "lblEmotionKey";
            this.lblEmotionKey.Size = new System.Drawing.Size(88, 12);
            this.lblEmotionKey.TabIndex = 0;
            this.lblEmotionKey.Tag = ":";
            this.lblEmotionKey.Text = "Emotion API Key";
            // 
            // txtInterval
            // 
            this.txtInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInterval.Location = new System.Drawing.Point(100, 84);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(349, 22);
            this.txtInterval.TabIndex = 3;
            // 
            // lblInteval
            // 
            this.lblInteval.AutoSize = true;
            this.lblInteval.Location = new System.Drawing.Point(53, 87);
            this.lblInteval.Name = "lblInteval";
            this.lblInteval.Size = new System.Drawing.Size(41, 12);
            this.lblInteval.TabIndex = 6;
            this.lblInteval.Text = "Interval";
            // 
            // lblVisionApiKey
            // 
            this.lblVisionApiKey.AutoSize = true;
            this.lblVisionApiKey.Location = new System.Drawing.Point(16, 61);
            this.lblVisionApiKey.Name = "lblVisionApiKey";
            this.lblVisionApiKey.Size = new System.Drawing.Size(78, 12);
            this.lblVisionApiKey.TabIndex = 7;
            this.lblVisionApiKey.Text = "Vision API Key";
            // 
            // txtVisionApiKey
            // 
            this.txtVisionApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisionApiKey.Location = new System.Drawing.Point(100, 58);
            this.txtVisionApiKey.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtVisionApiKey.Name = "txtVisionApiKey";
            this.txtVisionApiKey.Size = new System.Drawing.Size(349, 22);
            this.txtVisionApiKey.TabIndex = 8;
            // 
            // txtFaceApiUrl
            // 
            this.txtFaceApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFaceApiUrl.Location = new System.Drawing.Point(100, 110);
            this.txtFaceApiUrl.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtFaceApiUrl.Name = "txtFaceApiUrl";
            this.txtFaceApiUrl.Size = new System.Drawing.Size(349, 22);
            this.txtFaceApiUrl.TabIndex = 3;
            // 
            // lblFaceApiUrl
            // 
            this.lblFaceApiUrl.AutoSize = true;
            this.lblFaceApiUrl.Location = new System.Drawing.Point(29, 113);
            this.lblFaceApiUrl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFaceApiUrl.Name = "lblFaceApiUrl";
            this.lblFaceApiUrl.Size = new System.Drawing.Size(65, 12);
            this.lblFaceApiUrl.TabIndex = 9;
            this.lblFaceApiUrl.Text = "Face API Url";
            // 
            // frmCognitive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 165);
            this.Controls.Add(this.lblFaceApiUrl);
            this.Controls.Add(this.txtVisionApiKey);
            this.Controls.Add(this.lblVisionApiKey);
            this.Controls.Add(this.lblInteval);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtFaceApiUrl);
            this.Controls.Add(this.txtFaceApiKey);
            this.Controls.Add(this.txtEmotionApiKey);
            this.Controls.Add(this.lblFaceApiKey);
            this.Controls.Add(this.lblEmotionKey);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MinimizeBox = false;
            this.Name = "frmCognitive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInteval;
        private System.Windows.Forms.Label lblVisionApiKey;
        private System.Windows.Forms.TextBox txtVisionApiKey;
        private System.Windows.Forms.TextBox txtFaceApiUrl;
        private System.Windows.Forms.Label lblFaceApiUrl;
    }
}