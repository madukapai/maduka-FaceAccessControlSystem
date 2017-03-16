using FaceAccessController.ClassLibrary;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace FaceAccessController.Forms
{
    public partial class frmIdentify : Base.BaseForm
    {
        FaceServiceClient face;
        IDictionary DicPerson;

        public frmIdentify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 頁面載入的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIdentify_Load(object sender, EventArgs e)
        {
            base.ReadConfig();
            face = new FaceServiceClient(base.SetupConfig.FaceApiKey);
            new CognitiveUtility().BindPersonGroup(cbxPersonGroup, face, "");
        }

        /// <summary>
        /// 點選打開檔案讀取的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        /// <summary>
        /// 決定選好的照片的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtFileName.Text = fileDialog.FileName;
            picImage.Image = Image.FromFile(txtFileName.Text);
        }

        /// <summary>
        /// 將人員群組的人員資料放入到字典檔中的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void cbxPersonGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)cbxPersonGroup.SelectedItem).Value;
            DicPerson = new Hashtable();
            Person[] objPersons = await face.GetPersonsAsync(strPersonGroupId);

            for (int i = 0; i < objPersons.Length; i++)
                DicPerson.Add(objPersons[i].PersonId.ToString().Replace("{", "").Replace("}", ""), objPersons[i].Name);
        }

        /// <summary>
        /// 點選上傳的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnUpload_Click(object sender, EventArgs e)
        {
            using (Stream imageFileStream = File.OpenRead(txtFileName.Text))
            {
                Face[] faces = await face.DetectAsync(imageFileStream);
                await this.DetectFace(faces);
            }
        }

        private async Task DetectFace(Face[] faces)
        {
            // 將照片中的臉，與指定的PersonGroup進行比對
            if (faces != null)
            {
                Guid[] faceGuids = faces.Select(x => x.FaceId).ToArray();
                if (faceGuids.Length > 0)
                {
                    string strPersonGroup = ((Models.CognitiveModels.ListItem)cbxPersonGroup.SelectedItem).Value;
                    IdentifyResult[] result = await face.IdentifyAsync(strPersonGroup, faceGuids);
                    txtResult.Text = JsonConvert.SerializeObject(result);

                    // 取得照片中的人臉
                    string strPersonNameLabel = "";
                    for (int i = 0; i < result.Length; i++)
                    {
                        for (int p = 0; p < result[i].Candidates.Length; p++)
                        {
                            string strPersonId = result[i].Candidates[p].PersonId.ToString();
                            string strPersonName = (DicPerson.Contains(strPersonId)) ? DicPerson[strPersonId].ToString() : "";
                            strPersonNameLabel += strPersonName + ",";
                        }
                    }
                    txtPerson.Text = strPersonNameLabel;
                }
            }
        }
    }
}