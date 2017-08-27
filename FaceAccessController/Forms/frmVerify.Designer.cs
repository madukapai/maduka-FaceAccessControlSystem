namespace FaceAccessController.Forms
{
    partial class frmVerify
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnOpenPic2 = new System.Windows.Forms.Button();
            this.btnOpenPic1 = new System.Windows.Forms.Button();
            this.txtPic2 = new System.Windows.Forms.TextBox();
            this.txtPic1 = new System.Windows.Forms.TextBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFace2Guid = new System.Windows.Forms.TextBox();
            this.txtFace1Guid = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 334);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(602, 23);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send Verify";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnOpenPic2
            // 
            this.btnOpenPic2.Location = new System.Drawing.Point(539, 280);
            this.btnOpenPic2.Name = "btnOpenPic2";
            this.btnOpenPic2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPic2.TabIndex = 12;
            this.btnOpenPic2.Text = "Open";
            this.btnOpenPic2.UseVisualStyleBackColor = true;
            this.btnOpenPic2.Click += new System.EventHandler(this.btnOpenPic2_Click);
            // 
            // btnOpenPic1
            // 
            this.btnOpenPic1.Location = new System.Drawing.Point(235, 280);
            this.btnOpenPic1.Name = "btnOpenPic1";
            this.btnOpenPic1.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPic1.TabIndex = 13;
            this.btnOpenPic1.Text = "Open";
            this.btnOpenPic1.UseVisualStyleBackColor = true;
            this.btnOpenPic1.Click += new System.EventHandler(this.btnOpenPic1_Click);
            // 
            // txtPic2
            // 
            this.txtPic2.Location = new System.Drawing.Point(316, 280);
            this.txtPic2.Name = "txtPic2";
            this.txtPic2.Size = new System.Drawing.Size(217, 22);
            this.txtPic2.TabIndex = 10;
            // 
            // txtPic1
            // 
            this.txtPic1.Location = new System.Drawing.Point(12, 280);
            this.txtPic1.Name = "txtPic1";
            this.txtPic1.Size = new System.Drawing.Size(217, 22);
            this.txtPic1.TabIndex = 8;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(316, 15);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(298, 259);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(12, 15);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(298, 259);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 6;
            this.pic1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFace2Guid
            // 
            this.txtFace2Guid.Enabled = false;
            this.txtFace2Guid.Location = new System.Drawing.Point(316, 306);
            this.txtFace2Guid.Name = "txtFace2Guid";
            this.txtFace2Guid.Size = new System.Drawing.Size(298, 22);
            this.txtFace2Guid.TabIndex = 11;
            // 
            // txtFace1Guid
            // 
            this.txtFace1Guid.Enabled = false;
            this.txtFace1Guid.Location = new System.Drawing.Point(12, 306);
            this.txtFace1Guid.Name = "txtFace1Guid";
            this.txtFace1Guid.Size = new System.Drawing.Size(298, 22);
            this.txtFace1Guid.TabIndex = 9;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResult.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(12, 363);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(602, 262);
            this.txtResult.TabIndex = 15;
            // 
            // frmVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 637);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnOpenPic2);
            this.Controls.Add(this.btnOpenPic1);
            this.Controls.Add(this.txtPic2);
            this.Controls.Add(this.txtPic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txtFace2Guid);
            this.Controls.Add(this.txtFace1Guid);
            this.Name = "frmVerify";
            this.Text = "frmVerify";
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnOpenPic2;
        private System.Windows.Forms.Button btnOpenPic1;
        private System.Windows.Forms.TextBox txtPic2;
        private System.Windows.Forms.TextBox txtPic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFace2Guid;
        private System.Windows.Forms.TextBox txtFace1Guid;
        private System.Windows.Forms.TextBox txtResult;
    }
}