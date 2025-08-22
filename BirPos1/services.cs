using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
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
    }
}
