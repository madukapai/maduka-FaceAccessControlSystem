namespace FaceAccessController
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mWebCam = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mPeopleControl = new System.Windows.Forms.ToolStripMenuItem();
            this.mCognitive = new System.Windows.Forms.ToolStripMenuItem();
            this.mVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demoToolStripMenuItem,
            this.mFile,
            this.mSetup});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mMenu.Size = new System.Drawing.Size(567, 24);
            this.mMenu.TabIndex = 1;
            this.mMenu.Text = "menuStrip1";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDetect,
            this.mVerify});
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.demoToolStripMenuItem.Text = "Demo";
            // 
            // mDetect
            // 
            this.mDetect.Name = "mDetect";
            this.mDetect.Size = new System.Drawing.Size(152, 22);
            this.mDetect.Text = "Detect";
            this.mDetect.Click += new System.EventHandler(this.mDetect_Click);
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCapture,
            this.mWebCam,
            this.mExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(43, 22);
            this.mFile.Text = "檔案";
            // 
            // mCapture
            // 
            this.mCapture.Name = "mCapture";
            this.mCapture.Size = new System.Drawing.Size(122, 22);
            this.mCapture.Text = "照片上傳";
            this.mCapture.Click += new System.EventHandler(this.mCapture_Click);
            // 
            // mWebCam
            // 
            this.mWebCam.Name = "mWebCam";
            this.mWebCam.Size = new System.Drawing.Size(122, 22);
            this.mWebCam.Text = "影像偵測";
            this.mWebCam.Click += new System.EventHandler(this.mWebCam_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(122, 22);
            this.mExit.Text = "離開";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mSetup
            // 
            this.mSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPeopleControl,
            this.mCognitive});
            this.mSetup.Name = "mSetup";
            this.mSetup.Size = new System.Drawing.Size(43, 22);
            this.mSetup.Text = "設定";
            // 
            // mPeopleControl
            // 
            this.mPeopleControl.Name = "mPeopleControl";
            this.mPeopleControl.Size = new System.Drawing.Size(185, 22);
            this.mPeopleControl.Text = "群組與人員清單";
            this.mPeopleControl.Click += new System.EventHandler(this.mPeopleControl_Click);
            // 
            // mCognitive
            // 
            this.mCognitive.Name = "mCognitive";
            this.mCognitive.Size = new System.Drawing.Size(185, 22);
            this.mCognitive.Text = "Microsoft Cognitive";
            this.mCognitive.Click += new System.EventHandler(this.mCognitive_Click);
            // 
            // mVerify
            // 
            this.mVerify.Name = "mVerify";
            this.mVerify.Size = new System.Drawing.Size(152, 22);
            this.mVerify.Text = "Verify";
            this.mVerify.Click += new System.EventHandler(this.mVerify_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 404);
            this.Controls.Add(this.mMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmMain";
            this.Text = "FaceAccessController";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mSetup;
        private System.Windows.Forms.ToolStripMenuItem mPeopleControl;
        private System.Windows.Forms.ToolStripMenuItem mCognitive;
        private System.Windows.Forms.ToolStripMenuItem mWebCam;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mCapture;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDetect;
        private System.Windows.Forms.ToolStripMenuItem mVerify;
    }
}

