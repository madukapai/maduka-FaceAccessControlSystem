using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FaceAccessController.ClassLibrary;

namespace FaceAccessController.Forms
{
    public partial class frmCam : Base.BaseForm
    {
        WebCam oWebCam;

        public frmCam()
        {
            InitializeComponent();
        }

        private void frmCam_Load(object sender, EventArgs e)
        {
            oWebCam = new WebCam();
            oWebCam.Container = picWebCam;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            oWebCam.OpenConnection();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            oWebCam.Dispose();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            oWebCam.SaveImage();
        }
    }
}
