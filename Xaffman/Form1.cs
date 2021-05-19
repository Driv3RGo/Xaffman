using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xaffman
{
    public partial class Form1 : Form
    {       
        private ProcessMethod xuffmanCod;   //Статический алгоритм Хаффмана – кодер
        private ProcessMethod xuffmanDecod; //Статический алгоритм Хаффмана – декодер
        private string filename;            //Путь к файлу
        private long start_size, end_size;  //Размер файла до/после
        private DateTime start, end;

        public Form1()
        {
            InitializeComponent();
            openFileDialogCod.Filter = "All files(*.*)|*.*";
            openFileDialogDecod.Filter = "Xuf files(*.xuf)|*.xuf";
            decod.Visible = false;
            start_size = end_size = 0;
        }

        /* Окно для кодирования */
        private void button1_Click(object sender, EventArgs e)
        {
            decod.Visible = false;
        }

        /* Кнопка для кодирования */
        private void koding_Click(object sender, EventArgs e)
        {
            if (filename != null)
            {
                file.Enabled = false;
                koding.Enabled = false;
                timeCod.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                lblprogress.Text = "0%";
                progressBar1.Value = 0;
                start_size = end_size = 0;
                timer1.Enabled = true;
                workerCod.RunWorkerAsync();
            }
        }

        /* Окно для декодирования */
        private void button2_Click(object sender, EventArgs e)
        {
            decod.Visible = true;
        }

        /* Кнопка для декодирования */
        private void dekoding_Click(object sender, EventArgs e)
        {
            if (filename != null)
            {
                button5.Enabled = false;
                button3.Enabled = false;
                label14.Text = "";
                label13.Text = "";
                label12.Text = "";
                lblprogress1.Text = "0%";
                progressBar2.Value = 0;
                start_size = end_size = 0;
                timer2.Enabled = true;
                workerDecod.RunWorkerAsync();
            }
        }

        /* Выбрать файл для кодирования */
        private void fileCod_Click(object sender, EventArgs e)
        {
            if (openFileDialogCod.ShowDialog() == DialogResult.Cancel)
                return; 
            filename = openFileDialogCod.FileName;                //Получаем путь выбранного файла           
        }

        /* Выбрать файл для декодирования */
        private void fileDecod_Click(object sender, EventArgs e)
        {
            if (openFileDialogDecod.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialogDecod.FileName;   //Получаем путь выбранного файла           
        }

        /* Поток для кодера */
        private void workerCod_DoWork(object sender, DoWorkEventArgs e)
        {
            xuffmanCod = new ProcessMethod(this);
            xuffmanCod.Setfilename(filename);
            start = DateTime.Now;
            xuffmanCod.CreateTable();
            xuffmanCod.Koding();           //Кодирование текста
            end = DateTime.Now;
            start_size = xuffmanCod.start_size;
            end_size = xuffmanCod.end_size;
            workerCod.ReportProgress(100);
        }

        /* Поток для декодера */
        private void workerDecod_DoWork(object sender, DoWorkEventArgs e)
        {
            xuffmanDecod = new ProcessMethod(this);
            xuffmanDecod.Setfilename(filename);
            start = DateTime.Now;
            xuffmanDecod.RecoveryTable();   //Декодирование
            end = DateTime.Now;
            start_size = xuffmanDecod.start_size;
            end_size = xuffmanDecod.end_size;
            workerDecod.ReportProgress(100);
        }


        /* Прогресс для кодера */
        private void workerCod_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblprogress.Text = progressBar1.Value.ToString() + "%";
        }

        /* Прогресс для декодера */
        private void workerDecod_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            lblprogress1.Text = progressBar2.Value.ToString() + "%";
        }


        private String BytesToString(long byteCount)
        {
            string[] suf = { "Byt", "KB", "MB", "GB", "TB", "PB", "EB" }; 
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
        /* Закрыть окно */
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool cl = false;    //Флаг для проверки в каком сейчас режиме окно
        /* Масштабировать окно */
        private void deploy_Click(object sender, EventArgs e)
        {
            if (!cl)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            cl = !cl;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                TimeSpan span = end - start;
                timeCod.Text = Math.Round(span.TotalSeconds, 1).ToString() + " cек.";
                label8.Text = BytesToString(start_size);
                label9.Text = BytesToString(end_size);
                label10.Text = ((start_size - end_size) * 100 / start_size).ToString() + " %";
                timer1.Enabled = false;
                file.Enabled = true;
                koding.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                TimeSpan span = end - start;
                label14.Text = Math.Round(span.TotalSeconds, 1).ToString() + " cек.";
                label13.Text = BytesToString(start_size);
                label12.Text = BytesToString(end_size);
                timer2.Enabled = false;
                button5.Enabled = true;
                button3.Enabled = true;
            }
        }

        /* Свернуть окно */
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
