using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirPos1
{
    public partial class CreatePOS : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CreatePOS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CreatePOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}