using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAndHtml
{
    class CefCustomObject
    {
        private Form baseForm;
        private ChromiumWebBrowser browser;

        public CefCustomObject(Form form, ChromiumWebBrowser browser)
        {
            baseForm = form;
            this.browser = browser;
        }

        public void showDevTools()
        {
            browser.ShowDevTools();
        }

        public void showCommandLine()
        {
            ProcessStartInfo cmd = new ProcessStartInfo("cmd.exe", "/c pause");
            Process.Start(cmd);
        }
    }
}
