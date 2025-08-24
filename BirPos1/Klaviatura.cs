using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Senders;
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
    public partial class Klaviatura : DevExpress.XtraEditors.XtraForm
    {
        public Klaviatura(TextEdit textt)
        {
            InitializeComponent();

            CurrentEdit = textt;
        }

        public TextEdit CurrentEdit;

        private void button19_Click(object sender, EventArgs e)
        {
            services.SetText(CurrentEdit, null, (sender as Button).Text);
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            BindKeyboardButtons();
        }


        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            // Hərf əlavə et
            services.SetText(CurrentEdit, null, btn.Text);
        }

        private void BindKeyboardButtons()
        {
            foreach (Control ctrl in layoutControl1.Controls)
            {
                if (ctrl is Button btn && btn.Text != "Enter" && btn.Text != "UP" && btn.Text != "Sil")
                {
                    btn.Click += KeyboardButton_Click;
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CurrentEdit.Text = services.RemoveLastChar(CurrentEdit.Text);
            //services.RemoveLastChar(CurrentEdit.Text);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in layoutControl1.Controls)
            {
                if (ctrl is Button btn && btn.Text != "UP" && btn.Text != "Enter" && btn.Text != "Sil")
                {
                    if (btn.Text == btn.Text.ToUpper())
                        btn.Text = btn.Text.ToLower();
                    else
                        btn.Text = btn.Text.ToUpper();
                }
            }
            btnUp.BackColor = btnUp.BackColor == Color.Gray ? Color.GhostWhite : Color.Gray;
        }
    }
}