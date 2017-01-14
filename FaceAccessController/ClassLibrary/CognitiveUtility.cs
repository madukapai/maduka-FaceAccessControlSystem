using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FaceAccessController.ClassLibrary
{
    public class CognitiveUtility
    {
        /// <summary>
        /// 放入人員群組的資料
        /// </summary>
        public async void BindPersonGroup(System.Windows.Forms.ComboBox cbx, FaceServiceClient face, string strSelectItemValue)
        {
            cbx.Items.Clear();
            PersonGroup[] objGroup = await face.ListPersonGroupsAsync();
            int intChoiceIndex = 0;

            for (int i = 0; i < objGroup.Length; i++)
            {
                Models.CognitiveModels.ListItem item = new Models.CognitiveModels.ListItem()
                {
                    Text = objGroup[i].Name,
                    Value = objGroup[i].PersonGroupId,
                };

                cbx.Items.Add(item);

                if (strSelectItemValue == item.Value)
                    intChoiceIndex = i;
            }

            if (objGroup.Length > 0)
                cbx.SelectedIndex = intChoiceIndex;
        }

        /// <summary>
        /// 透過WebAPI進行人臉比對的動作
        /// </summary>
        /// <param name="ms"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> FaceDetect(MemoryStream ms, string strFaceApiKey)
        {
            var client = new HttpClient();

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", strFaceApiKey);
            var uri = "https://api.projectoxford.ai/face/v1.0/detect";

            HttpResponseMessage response = null;

            // Request body
            byte[] bytes = ms.ToArray();

            using (var content = new ByteArrayContent(bytes))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                try
                {
                    response = await client.PostAsync(uri, content);
                }
                catch (Exception ex)
                {
                    string strErr = ex.Message;
                }
            }

            return response;
        }
    }
}
