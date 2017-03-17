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
        List<Rectangle> rect = new List<Rectangle>();

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
            plTag.BackgroundImage = Image.FromFile(strImagePath);
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
                this.RenderRectangle(objEmotions);
            }
        }

        private void RenderRectangle(Emotion[] results)
        {
            rect.Clear();

            float floPhysicalHeight = plTag.BackgroundImage.PhysicalDimension.Height;
            float floPhysicalWidth = plTag.BackgroundImage.PhysicalDimension.Width;

            // 取得事件的x,y以及height, width
            int intVedioWidth = plTag.Width;
            int intVedioHeight = plTag.Height;

            for (int i = 0; i < results.Length; i++)
            {

                // 找出方框出現的X與Y
                int intX = (int)(intVedioWidth * results[i].FaceRectangle.Left / floPhysicalWidth);
                int intY = (int)(intVedioHeight * results[i].FaceRectangle.Top / floPhysicalHeight);
                //intX = axWindowsMediaPlayer1.Left + intX;
                //intY = axWindowsMediaPlayer1.Top + intY;

                // 找出方框的高度與寬度
                int intHeight = (int)(intVedioHeight * results[i].FaceRectangle.Height / floPhysicalHeight);
                int intWidth = (int)(intVedioWidth * results[i].FaceRectangle.Width / floPhysicalWidth);

                rect.Add(new Rectangle(intX, intY, intHeight, intWidth));
            }
            plTag.Invalidate();
        }

        private void plTag_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Green, 1))
            {
                for (int i = 0; i < rect.Count; i++)
                    e.Graphics.DrawRectangle(pen, rect[i]);
            }
        }
    }
}
