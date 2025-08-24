using BirPos1.DbModelEF;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            this.WindowState = FormWindowState.Maximized;
            splashScreen = new SplashScreenManager(this, typeof(WaitForm), true, true);
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 saniyə
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private SplashScreenManager splashScreen;

        TextEdit CurrentTextBox;

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

        private async void button3_Click(object sender, EventArgs e)
        {

            //if (CurrentTextBox.Text.Length > 0)
            //{
            //    CurrentTextBox.Text = CurrentTextBox.Text.Substring(0, CurrentTextBox.Text.Length - 1);
            //}
            // bunu services.cs-e yazdim RemoveLastChar adinda


            CurrentTextBox.Text = services.RemoveLastChar(CurrentTextBox.Text);

            //DATABASE YARATMAQ BELEDIR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //try
            //{
            //    using (var context = new DataContext())
            //    {
            //        var configuration = new Migrations.Configuration
            //        {
            //            AutomaticMigrationsEnabled = true,
            //            AutomaticMigrationDataLossAllowed = true
            //        };
            //        var migrator = new DbMigrator(configuration);

            //        await Task.Run(() => migrator.Update());
            //        MessageBox.Show("Database ugurla yaradildi.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show("Database yaradilmadi.");
            //}


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
            if (txtSifre.Text == "Yaqub" && txtNo.Text == "1234")
            {
                this.DialogResult = DialogResult.OK;
                MainForm mainForm = new MainForm();
                mainForm.Show();
                //alertControl1.Show(this, "Məlumat", "Siz Yaqub adi ile daxil oldunuz", true);
                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
                services.HideSplashScreen(splashScreen);
                this.Hide();
            }
            else if (txtSifre.Text == "1" && txtNo.Text == "1")
            {
                CreatePOS createPOS = new CreatePOS();
                createPOS.Show();
                //alertControl1.Show(this, "Məlumat", "Siz kassa qeydiyyat formuna daxil oldunuz", true);
                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[1]);
                alertControl1.Show(this, "Məlumat", "Siz Yaqub adi ile daxil oldunuz", true);
                services.HideSplashScreen(splashScreen);
                this.Hide();
            }
            else
            {
                services.HideSplashScreen(splashScreen);
                //alertControl1.Show(this, "Məlumat", "Yanlis parol", true);
                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[2]);

                //XtraMessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoginDate.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}