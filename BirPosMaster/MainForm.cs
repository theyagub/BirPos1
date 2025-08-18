using BirPosMaster.Melumatlar;
using BirPosMaster.Senedler;
using BirPosMaster.Sistem;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BirPosMaster
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private ContainerControl fluentDesignFormContainer1;

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }
        void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();


                    return;
                }
            }

            Form f = (Form)Activator.CreateInstance(typeForm);


            f.MdiParent = this;
            f.Show();
        }


        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Musteriler));
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            documentManager1.MdiParent = this;
            documentManager1.View = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            documentManager1.ContainerControl = fluentDesignFormContainer1; // ✅ Düzgün host control
        }

        private void btnKassirler_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Kassirler));
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void btnMehsullar_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Mehsullar));
        }

        private void btnBarkodlar_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Barkodlar));
        }

        private void btnSatisQiymetleri_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(SatisQiymetleri));
        }

        private void btnSaticilar_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Saticilar));
        }

        private void btnMelumatGonderilmesi_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(MelumatGonderilmesi));
        }

        private void btnProqramVersiyasi_Click(object sender, EventArgs e)
        {
            //OpenForm(typeof());
        }

        private void btnSirketler_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Sirketler));
        }

        private void btnSobeler_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Sobeler));
        }

        private void btnKassalar_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Kassalar));
        }

        private void btnKassirIcazeQruplari_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(KassirIcazeQruplari));
        }

        private void btnKompanyalar_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(Kompanyalar));
        }

        private void btnCapFormalari_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(CapFormalari));
        }

        private void btnXususiQiymetler_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(XususiQiymetler));
        }

        private void btnMehsulXususiKodlari_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(MehsulXususiQiymetleri));
        }

        private void btnSatisSenedleri_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(SatisSenedleri));
        }

        private void btnQaytarmaSenedleri_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(QaytarmaSenedleri));
        }

        private void btnHFveQRPsenedleri_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(HFveQRPsenedleri));
        }

        private void btnLegvEdilmisSenedler_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(LegvEdilmisSenedler));
        }

        private void btnDaxiliIstifadeAktlari_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(DaxiliIstifadeAktlari));
        }

        private void fluentDesignFormContainer1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupAndSortDockPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
