using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            CurrentTextBox = txtSifre;

            splashScreen = new SplashScreenManager(this, typeof(WaitForm), true, true);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void XtraForm1_Resize(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        TextEdit CurrentTextBox;
        private SplashScreenManager splashScreen;

        public void AddText(string text)
        {
            CurrentTextBox.Text += text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CurrentTextBox.Text.Length > 0)
            {
                CurrentTextBox.Text = CurrentTextBox.Text.Substring(0, CurrentTextBox.Text.Length - 1);
            }
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            CurrentTextBox = txtSifre;
        }

        private void txtNo_Click(object sender, EventArgs e)
        {
            CurrentTextBox = txtNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            services.ShowSplashScreen(splashScreen);

            // Cari forma görə overlay göstər

        }
    }
}