using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemState
{
    public partial class Form1 : Form
    {
        FileSystemWatcher watcher = new FileSystemWatcher();

        public Form1()
        {
            MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
            InitializeComponent();

            watcher.Renamed += Watcher_Renamed;
            watcher.Changed += Watcher_Log;
            watcher.Created += Watcher_Log;
            watcher.Deleted += Watcher_Log;

            //watcher.NotifyFilter =   NotifyFilters.CreationTime | NotifyFilters.Attributes 
            //                       | NotifyFilters.DirectoryName | NotifyFilters.LastAccess
            //                       | NotifyFilters.LastWrite | NotifyFilters.Security
            //                       | NotifyFilters.Security;
            watcher.IncludeSubdirectories = true;
        }

        private void Watcher_Log(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
            textBox1.Text += $"[{e.ChangeType}] {e.Name}\r\n";
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            textBox1.Text += $"[{e.ChangeType}] renamed from {e.OldName} to {e.Name}\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                watcher.Path = dlg.SelectedPath;
                watcher.EnableRaisingEvents = true;
            }
        }
    }
}
