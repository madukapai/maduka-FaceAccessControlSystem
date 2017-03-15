using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FaceAccessController.Forms
{
    using Microsoft.ProjectOxford.Face;
    using Microsoft.ProjectOxford.Face.Contract;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public partial class frmDetect : Base.BaseForm
    {
        FaceServiceClient face;

        public frmDetect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 載入視窗的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetect_Load(object sender, EventArgs e)
        {
            // 讀取設定檔
            base.ReadConfig();
            face = new FaceServiceClient(base.SetupConfig.FaceApiKey);
        }

        /// <summary>
        /// 點選開啟照片的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// 開啟照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string strImagePath = openFileDialog1.FileName;
            imgFace.Image = Image.FromFile(strImagePath);
            this.DetectFace(strImagePath, ImageSource.File);
        }

        /// <summary>
        /// Open Url的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            imgFace.Load(txtUrl.Text);
            this.DetectFace(txtUrl.Text, ImageSource.Url);
        }

        /// <summary>
        /// Detect Face
        /// </summary>
        /// <param name="strFilePath"></param>
        /// <returns></returns>
        private async Task DetectFace(string strFilePath, ImageSource objSource)
        {
            if (objSource == ImageSource.File)
            {
                using (Stream imageFileStream = File.OpenRead(strFilePath))
                {
                    Face[] objFaces = await face.DetectAsync(imageFileStream, true, true);
                    txtResult.Text = JsonConvert.SerializeObject(objFaces);
                }
            }
            else
            {
                Face[] objFaces = await face.DetectAsync(strFilePath, true, true);
                txtResult.Text = JsonConvert.SerializeObject(objFaces);
            }
        }

        enum ImageSource
        {
            File,
            Url,
        }

        /// <summary>
        /// 透過呼叫API的方式取得資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCallAPI_Click(object sender, EventArgs e)
        {
            QueryFace objQuery = new QueryFace() { url = txtUrl.Text };
            this.CallAPIAsync(JsonConvert.SerializeObject(objQuery));
        }

        public class QueryFace
        {
            public string url { get; set; }
        }

        /// <summary>
        /// 呼叫API取得內容
        /// </summary>
        /// <param name="strPostContent"></param>
        private async Task CallAPIAsync(string strPostContent)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", base.SetupConfig.FaceApiKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/detect?returnFaceId=true&returnFaceLandmarks=true";

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes(strPostContent);
            string strContent = "false";

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                if (response.StatusCode == HttpStatusCode.OK)
                    strContent = await response.Content.ReadAsStringAsync();
            }

            txtResult.Text = strContent;
        }
    }
}
