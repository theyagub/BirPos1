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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1(TextEdit textt)
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

        }
    }
}