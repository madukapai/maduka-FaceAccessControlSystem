using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;

namespace FaceAccessController
{
    public partial class frmMain : Base.BaseForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表單讀取的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 離開的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 設定Microsoft Cognitive的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mCognitive_Click(object sender, EventArgs e) => OpenForm(new Forms.frmCognitive());

        /// <summary>
        /// 開啟WebCam的畫面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mWebCam_Click(object sender, EventArgs e) => OpenForm(new Forms.frmCam());

        /// <summary>
        /// 點選設定人員與群組的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mPeopleControl_Click(object sender, EventArgs e) => OpenForm(new Forms.frmUsers());

        /// <summary>
        /// 照片上傳的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mCapture_Click(object sender, EventArgs e) => OpenForm(new Forms.frmCapture());

        /// <summary>
        /// Demo Detect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mDetect_Click(object sender, EventArgs e) => OpenForm(new Forms.frmDetect());

        /// <summary>
        /// Demo Verify
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mVerify_Click(object sender, EventArgs e)=>OpenForm(new Forms.frmVerify());

        /// <summary>
        /// Demo Identify
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mIdentify_Click(object sender, EventArgs e) => OpenForm(new Forms.frmIdentify());

        /// <summary>
        /// 開啟指定的表單物件
        /// </summary>
        /// <param name="objFrm"></param>
        private void OpenForm(Form objFrm)
        {
            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }
    }
}
