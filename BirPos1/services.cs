using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void SetText(TextEdit text, string val)
        {
            text.Text += val;
        }
    }
}
