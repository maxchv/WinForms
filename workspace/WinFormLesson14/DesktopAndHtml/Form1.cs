using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAndHtml
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();
            InitializeBrowser();
            FormClosing += Form1_FormClosing;
            chromeBrowser.RegisterJsObject("cefObject", 
                new CefCustomObject(this, chromeBrowser));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void InitializeBrowser()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            string html = $@"{Application.StartupPath}\html-resources\index.html";

            chromeBrowser = new ChromiumWebBrowser(html);
            
            Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            browserSettings.FileAccessFromFileUrls = CefState.Enabled;
            chromeBrowser.BrowserSettings = browserSettings;
        }
    }
}
