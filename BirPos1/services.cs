using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirPos1
{
    public static class services
    {
        public static void ShowSplashScreen(SplashScreenManager splashForm)
        {
            if (!splashForm.IsSplashFormVisible)
            {
                splashForm.ShowWaitForm();
            }
        }

        public static void HideSplashScreen(SplashScreenManager splashForm)
        {
            if (splashForm.IsSplashFormVisible)
            {
                splashForm.CloseWaitForm();
            }
        }

        public static void SetText(TextEdit text, TextBox box, string val)
        {
            //if (text == null || box == null || val == null) return;

            if(text != null)
                text.Text += val;

            if(box != null)
                box.Text += val;
        }

        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = @".\SQLExpress";

            builder.InitialCatalog = "YaqubTEST";

            builder.UserID = "Yaqub21";

            builder.Password = "123456789";

            builder.Pooling = true;

            builder.ApplicationName = "1POS";

            return builder.ConnectionString;
        }
        public static string RemoveLastChar(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return text.Substring(0, text.Length - 1);
            }
            return text; // boşdursa eyni qaytar
        }
        





        public enum Permission
        {
            [Display(Name = "Satış sənədin təsdiq edə bilər")]
            Sale = 1, //Satis ede biler
            [Display(Name = "Qaytarma sənədi yaza bilər")]
            Return, //Qayarma ede biler
            [Display(Name = "Sənədi növbəyə əlavə edə bilər")]
            AddQueue, //Novbeye elave ede biler
            [Display(Name = "Sənədi növbədən geri yükləyə bilər")]
            RestoreQueue, //Novbeden geri yukleye ede biler
            [Display(Name = "Müştəri seçimi edə bilər")]
            SelectContragent, //Musteri secimi ede biler
            [Display(Name = "Satıcı seçimi edə bilər")]
            SelectSeller, //Satici secimi ede biler
            [Display(Name = "Sətir silə bilər")]
            DeleteRow, //Setir sile ede biler
            [Display(Name = "Miqdar dəyişikliyi edə bilər")]
            ChangeQuntity, //Miqdar deyise ede biler
            [Display(Name = "Qiymət endirimi edə bilər")]
            PlusPrice, //Qiymet artimi ede biler
            [Display(Name = "Qiymət artımı edə bilər")]
            MinusPrice, //Qiymet Endirimi ede biler
            [Display(Name = "Məhsul axtarışı edə bilər")]
            SearchProduct, //Mehsul atarisi ede biler
            [Display(Name = "Tarixcəyə baxa bilər")]
            ViewHistory, //Tarixceye baxa bilsin
            [Display(Name = "Hesab fakturanı satışa edə bilər")]
            ConvertHfToSale, //HF satisa cevir
            [Display(Name = "Hesab fakturan çap edə bilər")]
            PrintHF, //HF satisa cevir
            [Display(Name = "Qiymət razılaşma çap edə bilər")]
            PrintQRP, //HF satisa cevir
            [Display(Name = "X çap edə bilər")]
            PrintX, //HF satisa cevir,
            [Display(Name = "Satışdan əvvəl müştəri borcu yoxlanmasın")]
            NotSaleBeforeContragentDebtRefresh, //Satisdan evvel borcu yoxla
            [Display(Name = "Sənədi ləğv edə bilər")]
            CancelDocument, //Cek legv ede biler
            [Display(Name = "Məhsul axtardan satışa məhsul əlavə edə bilsin")]
            AddProductToProductSearch
        }
        public enum DocumentType
        {
            Sale = 1,
            Return = 2,
            HF = 3,
            Queue = 4,
            Cancelled = 5
        }
        public enum LoginType
        {
            In = 1,
            Out = 2
        }
        public enum ApplyContragentType
        {
            All = 1,
            SelectApply = 2,
            NoSelectApply = 3
        }
        public enum CriteriaType
        {
            Product = 1,     // Məhsul səviyyəsində endirim
            Category = 2,    // Məhsul kateqoriyasına görə endirim
            Customer = 3,    // Müştəriyə görə (VIP, Loyal və s.)
            Invoice = 4      // Bütün səbət / çek üzrə endirim
        }
        public enum GifType
        {
            Percentage = 1,
            Amount = 2
        }
    }
}
