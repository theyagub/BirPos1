using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirPos1
{
    public partial class LoadingForm : DevExpress.XtraEditors.XtraForm
    {
        //TextEdit CurrentTextBox;
        //public LoadingForm(TextEdit text)
        //{
        //    InitializeComponent();
        //    //CurrentTextBox = text;
        //}
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }

        //private void progressBarControl1_EditValueChanged(object sender, EventArgs e)
        //{
        //progressBarControl1.Properties.Minimum = 0;
        //progressBarControl1.Properties.Maximum = 100;

        //for (int i = 0; i <= 100; i++)
        //{
        //    progressBarControl1.Position = i;
        //    Thread.Sleep(20); // proses imitasiya olunur
        //    Application.DoEvents(); // Ekranı yeniləmək üçün
        //}
        //label1.Text = progressBarControl1.Position + "%";
        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    services.SetText(CurrentTextBox, "1");
        //}

        //private void LoadingForm_Load(object sender, EventArgs e)
        //{

        //}
    }
}