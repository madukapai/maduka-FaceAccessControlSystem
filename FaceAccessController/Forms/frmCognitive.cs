using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAccessController.Forms
{
    public partial class frmCognitive : Base.BaseForm
    {
        public frmCognitive()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 載入金鑰的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCognitive_Load(object sender, EventArgs e)
        {
            // 讀取設定檔
            base.ReadConfig();

            txtEmotionApiKey.Text = base.SetupConfig.EmotionApiKey;
            txtFaceApiKey.Text = base.SetupConfig.FaceApiKey;
            txtInterval.Text = base.SetupConfig.WebCamInterval.ToString();
            txtVisionApiKey.Text = base.SetupConfig.VisionApiKey;
            txtFaceApiUrl.Text = base.SetupConfig.FaceApiUrl;
        }

        /// <summary>
        /// 儲存金鑰的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            base.SetupConfig.EmotionApiKey = txtEmotionApiKey.Text;
            base.SetupConfig.FaceApiKey = txtFaceApiKey.Text;
            base.SetupConfig.VisionApiKey = txtVisionApiKey.Text;
            base.SetupConfig.WebCamInterval = int.Parse(txtInterval.Text);
            base.SetupConfig.FaceApiUrl = txtFaceApiUrl.Text;
            base.WriteConfig();
            this.Close();
        }

        /// <summary>
        /// 取消離開
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
