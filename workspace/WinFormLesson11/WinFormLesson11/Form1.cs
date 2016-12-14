using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson11
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();

            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;

            // разрешить отсылать сообщения о измении прогресса
            worker.WorkerReportsProgress = true;
            // разрешить отменять фоновый поток
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Enabled = true;
            progressBar1.Value = 0;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync(10); // дополнительные аргументы для worker
            if(worker.IsBusy)
            {
                button1.Enabled = false;
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = (int)e.Argument; 
            //someWork();
            // эмуляция длительного процесса
            for (int i = 1; i <= count; i++)
            {
                if(worker.CancellationPending)
                {
                    break;
                }
                Thread.Sleep(1000);
                // уведмление о прогрессе
                worker.ReportProgress(i * 10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // уведмление о желании превать фоновый поток
            worker.CancelAsync();
        }
    }
}
