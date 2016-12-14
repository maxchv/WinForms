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

namespace WinFormLesson14
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();
            //webBrowser1.Url = new Uri("http://itstep.dp.ua");
            //Text = webBrowser1.Version.Major.ToString() + "."
            //       + webBrowser1.Version.Minor;

            InitializeChrome();
        }

        private void InitializeChrome()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            chromeBrowser = new ChromiumWebBrowser("");
            
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;

            tabControl1.TabPages[0].Controls.Add(chromeBrowser);
        }

        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            Text = e.Title;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromeBrowser.Back();
            button2.Enabled = chromeBrowser.CanGoBack;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chromeBrowser.ShowDevTools();
        }
    }
}
