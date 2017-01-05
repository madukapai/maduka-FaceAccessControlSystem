using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace FaceAccessController.Base
{
    public class BaseForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// 設定內容的物件
        /// </summary>
        public Models.CognitiveModels.Setup SetupConfig { get; set; }
        /// <summary>
        /// 設定檔存放的路徑
        /// </summary>
        public string ConfigurationFile { get { return ConfigurationManager.AppSettings["ConfigurationFilePath"].ToString(); } }

        /// <summary>
        /// 讀取設定檔的動作
        /// </summary>
        public void ReadConfig()
        {
            // 如果檔案不存在就建立空檔
            if (!File.Exists(this.ConfigurationFile))
                File.WriteAllText(this.ConfigurationFile, "");

            this.SetupConfig = new Models.CognitiveModels.Setup()
            {
                EmotionApiKey = "",
                FaceApiKey = "",
                VisionApiKey = "",
                FaceApiUrl = "",
            };

            string strConfig = File.ReadAllText(this.ConfigurationFile);
            if (strConfig != "")
                this.SetupConfig = JsonConvert.DeserializeObject<Models.CognitiveModels.Setup>(strConfig);
        }

        /// <summary>
        /// 寫入設定檔的動作
        /// </summary>
        public void WriteConfig()
        {
            string strConfig = JsonConvert.SerializeObject(this.SetupConfig);
            File.WriteAllText(this.ConfigurationFile, strConfig);
        }
    }
}
