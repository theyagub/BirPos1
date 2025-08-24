using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            CurrentTextBox = txtBarcode;
            txtBarcode.Focus();
            this.WindowState = FormWindowState.Maximized;
            txtQuantity.Text = "1";
            txtQuantity.Text = txtBarcode.Text;

            btnDot.Text = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }
        TextEdit CurrentTextBox;

        public void AddText(string text)
        {
            CurrentTextBox.Text += text;
        }

        //private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsLetterOrDigit(e.KeyChar))
        //    {
        //        AddText(e.KeyChar.ToString());
        //        e.Handled = true;
        //    }
        //    else if (e.KeyChar == '.' || e.KeyChar == ',')
        //    {
        //        if (!CurrentTextBox.Text.Contains(".") && !CurrentTextBox.Text.Contains(","))
        //        {
        //            AddText(e.KeyChar.ToString());
        //            e.Handled = true;
        //        }
        //    }
        //    else if (e.KeyChar == (char)Keys.Back)
        //    {
        //        //RemoveText();
        //        e.Handled = true;
        //    }
        //}


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            CurrentTextBox.Text = services.RemoveLastChar(CurrentTextBox.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddText((sender as Button).Text);
        }

        private void txtBarcode_Click(object sender, EventArgs e)
        {
            CurrentTextBox = txtBarcode;
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            CurrentTextBox = txtQuantity;
        }

        private void btnVur_Click(object sender, EventArgs e)
        {

            //toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            //alertControl1.Show(this, "Məlumat", "Tələb uğurla təsdiq edildi.", true);


            try
            {
                txtQuantity.Text = Convert.ToDecimal(txtBarcode.Text).ToString();
            }
            catch (Exception)
            {
                txtQuantity.Text = "1";
            }

            txtBarcode.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            txtQuantity.Text = "1";
            txtBarcode.Text = "";
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtQuantity.Text = "1";
                txtBarcode.Text = "";
            }
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            //Klaviatura x = new Klaviatura(CurrentTextBox);
            //x.ShowDialog();

            Klaviatura x = new Klaviatura(CurrentTextBox);

            x.FormBorderStyle = FormBorderStyle.FixedDialog;
            x.MaximizeBox = false;
            x.MinimizeBox = false;
            x.StartPosition = FormStartPosition.Manual;

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            x.Left = (screenWidth - x.Width) / 2;
            x.Top = screenHeight - x.Height;

            x.ShowDialog();
        }
    }
}