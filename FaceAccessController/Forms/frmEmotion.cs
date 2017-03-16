using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using System.IO;
using Newtonsoft.Json;

namespace FaceAccessController.Forms
{
    public partial class frmEmotion : Base.BaseForm
    {
        EmotionServiceClient objEmotion;

        public frmEmotion()
        {
            InitializeComponent();
            base.ReadConfig();
            objEmotion = new EmotionServiceClient(base.SetupConfig.EmotionApiKey);
        }

        /// <summary>
        /// 開啟照片的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// 開啟照片的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string strImagePath = openFileDialog1.FileName;
            imgFace.Image = Image.FromFile(strImagePath);
            this.GetEmotion(openFileDialog1.FileName);
        }

        /// <summary>
        /// 進行分析的動作
        /// </summary>
        /// <param name="strFilePath"></param>
        private async Task GetEmotion(string strFilePath)
        {
            Microsoft.ProjectOxford.Common.Rectangle[] objAngles;

            using (Stream imageFileStream = File.OpenRead(strFilePath))
            {
                Emotion[] objEmotions = await objEmotion.RecognizeAsync(imageFileStream, null);
                txtResult.Text = JsonConvert.SerializeObject(objEmotions);
            }
        }
    }
}
