using Microsoft.ProjectOxford.Face.Contract;
using Microsoft.ProjectOxford.Emotion.Contract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAccessController.ClassLibrary
{
    public class FacePanelUtility
    {
        List<Rectangle> rect = new List<Rectangle>();
        public Panel TargetPanel { get; set; }
        List<FaceRectangle> face = new List<FaceRectangle>();

        public void RenderFaceRectangle(Face[] results)
        {
            rect.Clear();
            face.Clear();

            if (results != null)
            {
                for (int i=0; i<results.Length; i++)
                    face.Add(results[i].FaceRectangle);

                this.RenderRectangle(face);
            }
        }

        public void RenderEmotionRectangle(Emotion[] results)
        {
            rect.Clear();
            face.Clear();

            if (results != null)
            {
                for (int i = 0; i < results.Length; i++)
                {
                    face.Add(
                        new FaceRectangle()
                        {
                            Height = results[i].FaceRectangle.Height,
                            Width = results[i].FaceRectangle.Width,
                            Left = results[i].FaceRectangle.Left,
                            Top = results[i].FaceRectangle.Top,
                        });
                }

                this.RenderRectangle(face);
            }
        }

        private void RenderRectangle(List<FaceRectangle> results)
        {
            float floPhysicalHeight = TargetPanel.BackgroundImage.PhysicalDimension.Height;
            float floPhysicalWidth = TargetPanel.BackgroundImage.PhysicalDimension.Width;

            // 取得事件的x,y以及height, width
            int intVedioWidth = TargetPanel.Width;
            int intVedioHeight = TargetPanel.Height;

            for (int i = 0; i < results.Count; i++)
            {

                // 找出方框出現的X與Y
                int intX = (int)(intVedioWidth * results[i].Left / floPhysicalWidth);
                int intY = (int)(intVedioHeight * results[i].Top / floPhysicalHeight);

                // 找出方框的高度與寬度
                int intHeight = (int)(intVedioHeight * results[i].Height / floPhysicalHeight);
                int intWidth = (int)(intVedioWidth * results[i].Width / floPhysicalWidth);

                rect.Add(new Rectangle(intX, intY, intHeight, intWidth));
            }

            TargetPanel.Invalidate();
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Green, 1))
            {
                for (int i = 0; i < rect.Count; i++)
                    e.Graphics.DrawRectangle(pen, rect[i]);
            }
        }

        public void Clear()
        {
            rect.Clear();
            TargetPanel.Invalidate();
        }
    }
}
