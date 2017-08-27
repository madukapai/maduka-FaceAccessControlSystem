using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FaceAccessController.Forms
{
    public partial class frmVerify : Base.BaseForm
    {
        public frmVerify()
        {
            InitializeComponent();
            btnSend.Enabled = false;
            base.ReadConfig();
        }

        private void btnOpenPic1_Click(object sender, EventArgs e)
        {
            UploadPicture(txtPic1, pic1, txtFace1Guid);
        }

        private void btnOpenPic2_Click(object sender, EventArgs e)
        {
            UploadPicture(txtPic2, pic2, txtFace2Guid);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            // 兩個Guid送至伺服器進行比較
            FaceServiceClient objFaceVerfity = new FaceServiceClient(base.SetupConfig.FaceApiKey);
            var res = await objFaceVerfity.VerifyAsync(System.Guid.Parse(txtFace1Guid.Text), System.Guid.Parse(txtFace2Guid.Text));
            txtResult.Text = JsonConvert.SerializeObject(res);

            bool blIsIdentical = res.IsIdentical;
            double duConfidence = res.Confidence;

            string strMessage = "是否為同一人：" + blIsIdentical.ToString() + ", 相似度：" + duConfidence.ToString();
            MessageBox.Show(strMessage);

        }

        /// <summary>
        /// 上傳照片並取得Guid的動作
        /// </summary>
        /// <param name="txtPicturePath"></param>
        /// <param name="pic"></param>
        /// <param name="txtGuid"></param>
        private async void UploadPicture(TextBox txtPicturePath, PictureBox pic, TextBox txtGuid)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            txtPicturePath.Text = "";
            pic.Image = null;
            txtGuid.Text = "";

            if (res == DialogResult.OK)
            {
                string strFilePath = openFileDialog1.FileName;

                // 上傳第二張照片，並取得Guid
                FaceServiceClient objFaceSrv = new FaceServiceClient(base.SetupConfig.FaceApiKey);
                Face[] objFace = await objFaceSrv.DetectAsync(File.OpenRead(strFilePath), true, true);
                txtResult.Text = JsonConvert.SerializeObject(objFace);

                if (objFace.Length > 0)
                {
                    txtGuid.Text = objFace[0].FaceId.ToString();
                    txtPicturePath.Text = strFilePath;
                    pic.Load(strFilePath);
                }
                else
                {
                    MessageBox.Show("無法辨識，請重新選擇一張照片");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnSend.Enabled = (txtFace1Guid.Text != "" && txtFace2Guid.Text != "") ? true : false;
        }
    }
}
