using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BirPos1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();


            splashScreen = new SplashScreenManager(this, typeof(WaitForm1), true, true);

            CurrentTextBox = txtSifre;
        }

        SplashScreenManager splashScreen;
        TextEdit CurrentTextBox;

        public void AddText(string text)
        {
            CurrentTextBox.Text += text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddText("7");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //services.ShowSplashScreen(splashScreen);



            //services.HideSplashScreen(splashScreen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //services.HideSplashScreen(splashScreen);
            CurrentTextBox.Text = CurrentTextBox.Text.Substring(0, CurrentTextBox.Text.Length - 1);
        }

        private void txtSifre_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            CurrentTextBox = txtSifre;
        }

        private void txtNo_Click(object sender, EventArgs e)
        {
            CurrentTextBox = txtNo;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddText("0");
            //LoadingForm ll = new LoadingForm(CurrentTextBox);
            //ll.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddText("1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddText("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddText("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddText("4");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddText("5");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddText("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddText("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddText("9");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
