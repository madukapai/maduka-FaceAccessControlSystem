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

namespace FaceAccessController.Forms
{
    public partial class frmUsers : Base.BaseForm
    {
        FaceServiceClient face;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            base.ReadConfig();
            face = new FaceServiceClient(base.SetupConfig.FaceApiKey, base.SetupConfig.FaceApiUrl);
            this.BindPersonGroups();
        }

        #region // PersonGroup
        /// <summary>
        /// 加入人員群組的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAddPersonGroup_Click(object sender, EventArgs e)
        {
            string strPersonGroupGuid = Guid.NewGuid().ToString();
            await face.CreatePersonGroupAsync(strPersonGroupGuid, txtPersonGroup.Text);
            this.BindPersonGroups();
            txtPersonGroup.Text = "";
        }

        /// <summary>
        /// 點選人員群組的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxPersonGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindPersons();
            btnAddPerson.Enabled = true;
            btnDeletePersonGroup.Enabled = true;
            btnPersonGroupTrain.Enabled = true;
        }

        /// <summary>
        /// 刪除人員群組的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDeletePersonGroup_Click(object sender, EventArgs e)
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)lbxPersonGroup.SelectedItem).Value;
            await face.DeletePersonGroupAsync(strPersonGroupId);
            this.BindPersonGroups();
            btnDeletePersonGroup.Enabled = false;
            btnPersonGroupTrain.Enabled = false;
            btnAddPerson.Enabled = false;
        }

        /// <summary>
        /// 針對人員群組進行訓練的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnPersonGroupTrain_Click(object sender, EventArgs e)
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)lbxPersonGroup.SelectedItem).Value;
            await face.TrainPersonGroupAsync(strPersonGroupId);
            this.BindPersonGroups();
            btnDeletePersonGroup.Enabled = false;
            btnPersonGroupTrain.Enabled = false;
        }
        #endregion

        #region // Person
        /// <summary>
        /// 加入人員的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAddPerson_Click(object sender, EventArgs e)
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)lbxPersonGroup.SelectedItem).Value;
            await face.CreatePersonAsync(strPersonGroupId, txtPerson.Text);
            this.BindPersons();
            txtPerson.Text = "";
        }

        /// <summary>
        /// 刪除人員的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDeletePerson_Click(object sender, EventArgs e)
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)lbxPersonGroup.SelectedItem).Value;
            string strPersonId = ((Models.CognitiveModels.ListItem)lbxPerson.SelectedItem).Value;
            await face.DeletePersonAsync(strPersonGroupId, Guid.Parse(strPersonId));
            this.BindPersons();
            btnDeletePerson.Enabled = false;
            btnPersonEditFace.Enabled = false;
        }

        /// <summary>
        /// 點選人員項目的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeletePerson.Enabled = true;
            btnPersonEditFace.Enabled = true;
        }

        /// <summary>
        /// 點選查看人員人臉資料視窗的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersonEditFace_Click(object sender, EventArgs e)
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)lbxPersonGroup.SelectedItem).Value;
            string strPersonId = ((Models.CognitiveModels.ListItem)lbxPerson.SelectedItem).Value;
            frmFaces objFace = new frmFaces()
            {
                PersonGroupId = strPersonGroupId,
                PersonId = strPersonId,
            };

            objFace.Show(this);
        }
        #endregion

        /// <summary>
        /// 放入人員群組的動作
        /// </summary>
        private async void BindPersonGroups()
        {
            lbxPersonGroup.Items.Clear();

            PersonGroup[] objPersonGroups = await face.ListPersonGroupsAsync();
            for (int i=0; i<objPersonGroups.Length; i++)
            {
                lbxPersonGroup.Items.Add(
                    new Models.CognitiveModels.ListItem()
                    {
                            Text = objPersonGroups[i].Name,
                            Value = objPersonGroups[i].PersonGroupId,
                    });
            }
        }

        /// <summary>
        /// 放入人員清單的動作
        /// </summary>
        private async void BindPersons()
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)lbxPersonGroup.SelectedItem).Value;
            lbxPerson.Items.Clear();
            Person[] objPersons = await face.GetPersonsAsync(strPersonGroupId);

            for (int i = 0; i < objPersons.Length; i++)
            {
                lbxPerson.Items.Add(
                    new Models.CognitiveModels.ListItem()
                    {
                        Text = objPersons[i].Name,
                        Value = objPersons[i].PersonId.ToString(),
                    });
            }
        }
    }
}
