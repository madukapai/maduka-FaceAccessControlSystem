using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceAccessController.Models
{
    public class CognitiveModels
    {
        public class Setup
        {
            public string EmotionApiKey { get; set; }
            public string FaceApiKey { get; set; }
            public string VisionApiKey { get; set; }
            public int WebCamInterval { get; set; }
            public string FaceApiUrl { get; set; }
        }

        public class ListItem
        {
            public string Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return this.Text;
            }
        }
    }
}
