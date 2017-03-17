namespace FaceAccessController.Forms
{
    partial class frmEmotion
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.imgFace = new System.Windows.Forms.PictureBox();
            this.btnOpenPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgFace)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(325, 10);
            this.txtResult.Margin = new System.Windows.Forms.Padding(1);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(404, 379);
            this.txtResult.TabIndex = 5;
            // 
            // imgFace
            // 
            this.imgFace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFace.Location = new System.Drawing.Point(10, 10);
            this.imgFace.Margin = new System.Windows.Forms.Padding(1);
            this.imgFace.Name = "imgFace";
            this.imgFace.Size = new System.Drawing.Size(313, 344);
            this.imgFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFace.TabIndex = 4;
            this.imgFace.TabStop = false;
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPicture.Location = new System.Drawing.Point(10, 356);
            this.btnOpenPicture.Margin = new System.Windows.Forms.Padding(1);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(313, 33);
            this.btnOpenPicture.TabIndex = 3;
            this.btnOpenPicture.Text = "Open Picture";
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmEmotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 399);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.imgFace);
            this.Controls.Add(this.btnOpenPicture);
            this.Name = "frmEmotion";
            this.Text = "frmEmotion";
            ((System.ComponentModel.ISupportInitialize)(this.imgFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox imgFace;
        private System.Windows.Forms.Button btnOpenPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}