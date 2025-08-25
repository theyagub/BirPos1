using BirPos1.DBModelEF_Main;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirPos1
{
    public partial class Qaralama : DevExpress.XtraEditors.XtraForm
    {
        public Qaralama()
        {
            InitializeComponent();


            splashScreen = new SplashScreenManager(this, typeof(WaitForm), true, true);

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
        

        private string CustomDecrypt(string encodedString)
        {
            // Base64 decode
            byte[] data = Convert.FromBase64String(encodedString);
            // Simple XOR decryption with a key (for demonstration purposes)
            byte key = 0x5A; // Example key
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key;
            }
            return Encoding.UTF8.GetString(data);
        }

        private async void button22_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var configuration = new Migrations.Configuration
                    {
                        AutomaticMigrationsEnabled = true,
                        AutomaticMigrationDataLossAllowed = true
                    };
                    var migrator = new DbMigrator(configuration);

                    await Task.Run(() => migrator.Update());
                    MessageBox.Show("Database ugurla yaradildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Database yaradilmadi.");
            }
        }
    }
}
