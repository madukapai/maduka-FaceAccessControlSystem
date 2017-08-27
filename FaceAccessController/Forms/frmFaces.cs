using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System.IO;

namespace FaceAccessController.Forms
{
    public partial class frmFaces : Base.BaseForm
    {
        FaceServiceClient face;
        public string PersonGroupId { get; set; }
        public string PersonId { get; set; }

        public frmFaces()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 載入人員臉部資料維護頁面的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFaces_Load(object sender, EventArgs e)
        {
            base.ReadConfig();
            face = new FaceServiceClient(base.SetupConfig.FaceApiKey);
            this.BindFace();
        }

        /// <summary>
        /// 點選打開檔案的對話視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        /// <summary>
        /// 點選檔案完成的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtPerson.Text = fileDialog.FileName;
        }

        /// <summary>
        /// 加入人臉的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAddFace_Click(object sender, EventArgs e)
        {
            byte[] data = File.ReadAllBytes(txtPerson.Text);
            MemoryStream stream = new MemoryStream(data);
            AddPersistedFaceResult result = await face.AddPersonFaceAsync(this.PersonGroupId, Guid.Parse(this.PersonId), stream);
            File.Copy(txtPerson.Text, @"Faces\" + result.PersistedFaceId.ToString(), true);
            txtPerson.Text = "";
            this.BindFace();
        }

        /// <summary>
        /// 刪除人臉的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDeleteFace_Click(object sender, EventArgs e)
        {
            picFace.Image.Dispose();
            picFace.Image = null;
            string strFaceId = ((Models.CognitiveModels.ListItem)lbxFace.SelectedItem).Value;
            await face.DeletePersonFaceAsync(this.PersonGroupId, Guid.Parse(this.PersonId), Guid.Parse(strFaceId));
            string strFilePath = @"Faces\" + strFaceId;
            File.Delete(strFilePath);
            btnDeleteFace.Enabled = false;
            this.BindFace();
        }

        /// <summary>
        /// 選擇要查看人臉的資料動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFaceId = ((Models.CognitiveModels.ListItem)lbxFace.SelectedItem).Value;
            picFace.Image = Image.FromFile(@"Faces\" + strFaceId);
            btnDeleteFace.Enabled = true;
        }

        /// <summary>
        /// 放入人員人臉照片的動作
        /// </summary>
        private async void BindFace()
        {
            Person objPer = await face.GetPersonAsync(this.PersonGroupId, Guid.Parse(this.PersonId));
            lbxFace.Items.Clear();

            for (int i = 0; i < objPer.PersistedFaceIds.Length; i++)
            {
                lbxFace.Items.Add(
                    new Models.CognitiveModels.ListItem()
                    {
                        Text = objPer.PersistedFaceIds[i].ToString(),
                        Value = objPer.PersistedFaceIds[i].ToString(),
                    });
            }
        }
    }
}
