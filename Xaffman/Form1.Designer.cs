namespace Xaffman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.deploy = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cod = new System.Windows.Forms.Panel();
            this.decod = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblprogress1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label20 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeCod = new System.Windows.Forms.Label();
            this.lblprogress = new System.Windows.Forms.Label();
            this.koding = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.file = new System.Windows.Forms.Button();
            this.openFileDialogCod = new System.Windows.Forms.OpenFileDialog();
            this.workerCod = new System.ComponentModel.BackgroundWorker();
            this.workerDecod = new System.ComponentModel.BackgroundWorker();
            this.openFileDialogDecod = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cod.SuspendLayout();
            this.decod.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Кодировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 86);
            this.button2.TabIndex = 10;
            this.button2.Text = "Декодировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 40);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Статический алгоритм Хаффмана";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.deploy);
            this.panel3.Controls.Add(this.close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(880, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 40);
            this.panel3.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "–";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // deploy
            // 
            this.deploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.deploy.FlatAppearance.BorderSize = 0;
            this.deploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deploy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deploy.ForeColor = System.Drawing.Color.White;
            this.deploy.Location = new System.Drawing.Point(40, 0);
            this.deploy.Name = "deploy";
            this.deploy.Size = new System.Drawing.Size(40, 40);
            this.deploy.TabIndex = 10;
            this.deploy.Text = "☐";
            this.deploy.UseVisualStyleBackColor = false;
            this.deploy.Click += new System.EventHandler(this.deploy_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(80, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите файл для сжатия";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 494);
            this.panel1.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 5);
            this.panel6.TabIndex = 14;
            // 
            // cod
            // 
            this.cod.BackColor = System.Drawing.Color.LightGray;
            this.cod.Controls.Add(this.decod);
            this.cod.Controls.Add(this.label10);
            this.cod.Controls.Add(this.label9);
            this.cod.Controls.Add(this.label8);
            this.cod.Controls.Add(this.timeCod);
            this.cod.Controls.Add(this.lblprogress);
            this.cod.Controls.Add(this.koding);
            this.cod.Controls.Add(this.label7);
            this.cod.Controls.Add(this.label6);
            this.cod.Controls.Add(this.label5);
            this.cod.Controls.Add(this.label3);
            this.cod.Controls.Add(this.progressBar1);
            this.cod.Controls.Add(this.label4);
            this.cod.Controls.Add(this.panel7);
            this.cod.Controls.Add(this.panel5);
            this.cod.Controls.Add(this.file);
            this.cod.Controls.Add(this.label2);
            this.cod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cod.Location = new System.Drawing.Point(269, 40);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(731, 494);
            this.cod.TabIndex = 14;
            // 
            // decod
            // 
            this.decod.BackColor = System.Drawing.Color.LightGray;
            this.decod.Controls.Add(this.label12);
            this.decod.Controls.Add(this.label13);
            this.decod.Controls.Add(this.label14);
            this.decod.Controls.Add(this.lblprogress1);
            this.decod.Controls.Add(this.button3);
            this.decod.Controls.Add(this.label17);
            this.decod.Controls.Add(this.label18);
            this.decod.Controls.Add(this.label19);
            this.decod.Controls.Add(this.progressBar2);
            this.decod.Controls.Add(this.label20);
            this.decod.Controls.Add(this.panel8);
            this.decod.Controls.Add(this.panel9);
            this.decod.Controls.Add(this.button5);
            this.decod.Controls.Add(this.label21);
            this.decod.Location = new System.Drawing.Point(0, 0);
            this.decod.Name = "decod";
            this.decod.Size = new System.Drawing.Size(731, 494);
            this.decod.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(213, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 23);
            this.label12.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(219, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 23);
            this.label13.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(83, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 23);
            this.label14.TabIndex = 24;
            // 
            // lblprogress1
            // 
            this.lblprogress1.AutoSize = true;
            this.lblprogress1.BackColor = System.Drawing.Color.Transparent;
            this.lblprogress1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblprogress1.ForeColor = System.Drawing.Color.Black;
            this.lblprogress1.Location = new System.Drawing.Point(682, 222);
            this.lblprogress1.Name = "lblprogress1";
            this.lblprogress1.Size = new System.Drawing.Size(37, 23);
            this.lblprogress1.TabIndex = 23;
            this.lblprogress1.Text = "0%";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 47);
            this.button3.TabIndex = 22;
            this.button3.Text = "Декодировать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.dekoding_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(11, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(238, 28);
            this.label17.TabIndex = 20;
            this.label17.Text = "Выходной размер:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(11, 348);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 28);
            this.label18.TabIndex = 19;
            this.label18.Text = "Исходный размер:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(11, 303);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 28);
            this.label19.TabIndex = 18;
            this.label19.Text = "Время:";
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.White;
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.progressBar2.Location = new System.Drawing.Point(12, 248);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(707, 46);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(6, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(381, 34);
            this.label20.TabIndex = 16;
            this.label20.Text = "Процесс декодирования:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 489);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(731, 5);
            this.panel9.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(11, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 47);
            this.button5.TabIndex = 11;
            this.button5.Text = "Выбрать файл";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.fileDecod_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(6, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(529, 34);
            this.label21.TabIndex = 12;
            this.label21.Text = "Выберите файл для декодирования";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(190, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(207, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 23);
            this.label9.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(208, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 23);
            this.label8.TabIndex = 25;
            // 
            // timeCod
            // 
            this.timeCod.AutoSize = true;
            this.timeCod.BackColor = System.Drawing.Color.Transparent;
            this.timeCod.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeCod.ForeColor = System.Drawing.Color.Black;
            this.timeCod.Location = new System.Drawing.Point(87, 306);
            this.timeCod.Name = "timeCod";
            this.timeCod.Size = new System.Drawing.Size(0, 23);
            this.timeCod.TabIndex = 24;
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.BackColor = System.Drawing.Color.Transparent;
            this.lblprogress.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblprogress.ForeColor = System.Drawing.Color.Black;
            this.lblprogress.Location = new System.Drawing.Point(682, 222);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(37, 23);
            this.lblprogress.TabIndex = 23;
            this.lblprogress.Text = "0%";
            // 
            // koding
            // 
            this.koding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.koding.FlatAppearance.BorderSize = 0;
            this.koding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.koding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.koding.ForeColor = System.Drawing.Color.White;
            this.koding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.koding.Location = new System.Drawing.Point(11, 122);
            this.koding.Name = "koding";
            this.koding.Size = new System.Drawing.Size(238, 47);
            this.koding.TabIndex = 22;
            this.koding.Text = "Кодировать";
            this.koding.UseVisualStyleBackColor = false;
            this.koding.Click += new System.EventHandler(this.koding_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Степень сжатия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Выходной размер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Исходный размер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Время:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(707, 46);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "Процесс кодирования:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 489);
            this.panel7.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(731, 5);
            this.panel5.TabIndex = 13;
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.file.FlatAppearance.BorderSize = 0;
            this.file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file.ForeColor = System.Drawing.Color.White;
            this.file.Image = ((System.Drawing.Image)(resources.GetObject("file.Image")));
            this.file.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.file.Location = new System.Drawing.Point(11, 58);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(238, 47);
            this.file.TabIndex = 11;
            this.file.Text = "Выбрать файл";
            this.file.UseVisualStyleBackColor = false;
            this.file.Click += new System.EventHandler(this.fileCod_Click);
            // 
            // openFileDialogCod
            // 
            this.openFileDialogCod.FileName = "openFileDialogCod";
            // 
            // workerCod
            // 
            this.workerCod.WorkerReportsProgress = true;
            this.workerCod.WorkerSupportsCancellation = true;
            this.workerCod.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerCod_DoWork);
            this.workerCod.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerCod_ProgressChanged);
            // 
            // workerDecod
            // 
            this.workerDecod.WorkerReportsProgress = true;
            this.workerDecod.WorkerSupportsCancellation = true;
            this.workerDecod.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerDecod_DoWork);
            this.workerDecod.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerDecod_ProgressChanged);
            // 
            // openFileDialogDecod
            // 
            this.openFileDialogDecod.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cod.ResumeLayout(false);
            this.cod.PerformLayout();
            this.decod.ResumeLayout(false);
            this.decod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button deploy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel cod;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogCod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button koding;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblprogress;
        public System.ComponentModel.BackgroundWorker workerDecod;
        public System.ComponentModel.BackgroundWorker workerCod;
        private System.Windows.Forms.OpenFileDialog openFileDialogDecod;
        private System.Windows.Forms.Label timeCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel decod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblprogress1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

