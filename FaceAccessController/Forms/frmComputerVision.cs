using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ProjectOxford.Vision;
using Microsoft.ProjectOxford.Vision.Contract;
using System.IO;
using Newtonsoft.Json;

namespace FaceAccessController.Forms
{
    public partial class frmComputerVision : Base.BaseForm
    {
        VisionServiceClient objVision;

        public frmComputerVision()
        {
            InitializeComponent();
            base.ReadConfig();
            objVision = new VisionServiceClient(base.SetupConfig.VisionApiKey);
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
            this.GetVision(openFileDialog1.FileName);
        }

        /// <summary>
        /// 進行分析的動作
        /// </summary>
        /// <param name="strFilePath"></param>
        private async Task GetVision(string strFilePath)
        {
            string[] strFeatures = { "Categories", "Tags", "Description", "Faces", "ImageType", "Color", "Adult" };

            using (Stream imageFileStream = File.OpenRead(strFilePath))
            {
                AnalysisResult objResult = await objVision.AnalyzeImageAsync(imageFileStream, strFeatures);
                txtResult.Text = JsonConvert.SerializeObject(objResult);
                MessageBox.Show(objResult.Description.Captions[0].Text);
            }
        }
    }
}