namespace FaceAccessController.Forms
{
    partial class frmDetect
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
            this.btnOpenPicture = new System.Windows.Forms.Button();
            this.imgFace = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.btnCallAPI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgFace)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Location = new System.Drawing.Point(4, 176);
            this.btnOpenPicture.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(177, 17);
            this.btnOpenPicture.TabIndex = 0;
            this.btnOpenPicture.Text = "Open Picture";
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenPicture_Click);
            // 
            // imgFace
            // 
            this.imgFace.Location = new System.Drawing.Point(4, 5);
            this.imgFace.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.imgFace.Name = "imgFace";
            this.imgFace.Size = new System.Drawing.Size(177, 168);
            this.imgFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFace.TabIndex = 1;
            this.imgFace.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(183, 5);
            this.txtResult.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(162, 190);
            this.txtResult.TabIndex = 2;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(4, 195);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(340, 22);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.Text = "https://scontent-tpe1-1.xx.fbcdn.net/v/t1.0-9/16508650_10154095052461930_29227692" +
    "86729865131_n.jpg?oh=6c1b4cfa4be48d1df3c607ffb273a2b8&oe=595D7966";
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenUrl.Location = new System.Drawing.Point(4, 215);
            this.btnOpenUrl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(177, 17);
            this.btnOpenUrl.TabIndex = 4;
            this.btnOpenUrl.Text = "Open Url";
            this.btnOpenUrl.UseVisualStyleBackColor = true;
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // btnCallAPI
            // 
            this.btnCallAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCallAPI.Location = new System.Drawing.Point(183, 215);
            this.btnCallAPI.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCallAPI.Name = "btnCallAPI";
            this.btnCallAPI.Size = new System.Drawing.Size(159, 18);
            this.btnCallAPI.TabIndex = 5;
            this.btnCallAPI.Text = "Call API";
            this.btnCallAPI.UseVisualStyleBackColor = true;
            this.btnCallAPI.Click += new System.EventHandler(this.btnCallAPI_Click);
            // 
            // frmDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 247);
            this.Controls.Add(this.btnCallAPI);
            this.Controls.Add(this.btnOpenUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.imgFace);
            this.Controls.Add(this.btnOpenPicture);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmDetect";
            this.Text = "frmDetect";
            this.Load += new System.EventHandler(this.frmDetect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPicture;
        private System.Windows.Forms.PictureBox imgFace;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.Button btnCallAPI;
    }
}