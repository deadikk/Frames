namespace Frames
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.video = new AForge.Controls.VideoSourcePlayer();
            this.button3 = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.picture = new AForge.Controls.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.intervalNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.frameTxt = new System.Windows.Forms.TextBox();
            this.nextFrame = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.videoHeight = new System.Windows.Forms.TextBox();
            this.videoWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalFrames = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.framesFPS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.videoCodec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.frameOffset = new System.Windows.Forms.NumericUpDown();
            this.playImages = new System.Windows.Forms.Button();
            this.fromTheBeginning = new System.Windows.Forms.Button();
            this.viewbox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.firstFrameNum = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lastFrameNum = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.currentFrame = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.brightnessValue = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOffset)).BeginInit();
            this.viewbox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstFrameNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFrameNum)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1360, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVideo,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openVideo
            // 
            this.openVideo.Name = "openVideo";
            this.openVideo.Size = new System.Drawing.Size(156, 22);
            this.openVideo.Text = "Открыть видео";
            this.openVideo.Click += new System.EventHandler(this.openVideo_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1360, 580);
            this.splitContainer1.SplitterDistance = 672;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.video);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(672, 555);
            this.splitContainer2.SplitterDistance = 394;
            this.splitContainer2.TabIndex = 1;
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video.Location = new System.Drawing.Point(0, 0);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(672, 394);
            this.video.TabIndex = 0;
            this.video.Text = "videoSourcePlayer1";
            this.video.VideoSource = null;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.openVideo_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(6, 77);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(6, 48);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа с видео";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.picture);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Panel2.Controls.Add(this.process);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Panel2.Controls.Add(this.viewbox);
            this.splitContainer3.Size = new System.Drawing.Size(684, 555);
            this.splitContainer3.SplitterDistance = 394;
            this.splitContainer3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Работа с фото";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Image = null;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(684, 394);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.stopBtn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Видео";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frameTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.intervalNum);
            this.groupBox2.Location = new System.Drawing.Point(164, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Утановки";
            // 
            // intervalNum
            // 
            this.intervalNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intervalNum.Location = new System.Drawing.Point(6, 40);
            this.intervalNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intervalNum.Name = "intervalNum";
            this.intervalNum.Size = new System.Drawing.Size(95, 20);
            this.intervalNum.TabIndex = 0;
            this.intervalNum.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.intervalNum.ValueChanged += new System.EventHandler(this.intervalNum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Интервал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кадр";
            // 
            // frameTxt
            // 
            this.frameTxt.Location = new System.Drawing.Point(24, 92);
            this.frameTxt.Name = "frameTxt";
            this.frameTxt.ReadOnly = true;
            this.frameTxt.Size = new System.Drawing.Size(100, 20);
            this.frameTxt.TabIndex = 5;
            // 
            // nextFrame
            // 
            this.nextFrame.Location = new System.Drawing.Point(30, 58);
            this.nextFrame.Name = "nextFrame";
            this.nextFrame.Size = new System.Drawing.Size(108, 26);
            this.nextFrame.TabIndex = 6;
            this.nextFrame.Text = "Кадр";
            this.nextFrame.UseVisualStyleBackColor = true;
            this.nextFrame.Click += new System.EventHandler(this.nextFrame_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.videoCodec);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.framesFPS);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.totalFrames);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.videoWidth);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.videoHeight);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(332, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 128);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кадр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Высота";
            // 
            // videoHeight
            // 
            this.videoHeight.Location = new System.Drawing.Point(9, 40);
            this.videoHeight.Name = "videoHeight";
            this.videoHeight.ReadOnly = true;
            this.videoHeight.Size = new System.Drawing.Size(72, 20);
            this.videoHeight.TabIndex = 6;
            // 
            // videoWidth
            // 
            this.videoWidth.Location = new System.Drawing.Point(9, 80);
            this.videoWidth.Name = "videoWidth";
            this.videoWidth.ReadOnly = true;
            this.videoWidth.Size = new System.Drawing.Size(72, 20);
            this.videoWidth.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ширина";
            // 
            // totalFrames
            // 
            this.totalFrames.Location = new System.Drawing.Point(103, 39);
            this.totalFrames.Name = "totalFrames";
            this.totalFrames.ReadOnly = true;
            this.totalFrames.Size = new System.Drawing.Size(73, 20);
            this.totalFrames.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Кадров в файле";
            // 
            // framesFPS
            // 
            this.framesFPS.Location = new System.Drawing.Point(103, 79);
            this.framesFPS.Name = "framesFPS";
            this.framesFPS.ReadOnly = true;
            this.framesFPS.Size = new System.Drawing.Size(73, 20);
            this.framesFPS.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Частота кадров";
            // 
            // videoCodec
            // 
            this.videoCodec.Location = new System.Drawing.Point(205, 39);
            this.videoCodec.Name = "videoCodec";
            this.videoCodec.ReadOnly = true;
            this.videoCodec.Size = new System.Drawing.Size(73, 20);
            this.videoCodec.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Кодировка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Интервал";
            // 
            // frameOffset
            // 
            this.frameOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.frameOffset.Location = new System.Drawing.Point(30, 32);
            this.frameOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frameOffset.Name = "frameOffset";
            this.frameOffset.Size = new System.Drawing.Size(108, 20);
            this.frameOffset.TabIndex = 7;
            this.frameOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // playImages
            // 
            this.playImages.Location = new System.Drawing.Point(30, 90);
            this.playImages.Name = "playImages";
            this.playImages.Size = new System.Drawing.Size(108, 26);
            this.playImages.TabIndex = 9;
            this.playImages.Text = "Слайдшоу";
            this.playImages.UseVisualStyleBackColor = true;
            this.playImages.Click += new System.EventHandler(this.playImages_Click);
            // 
            // fromTheBeginning
            // 
            this.fromTheBeginning.Location = new System.Drawing.Point(30, 122);
            this.fromTheBeginning.Name = "fromTheBeginning";
            this.fromTheBeginning.Size = new System.Drawing.Size(108, 26);
            this.fromTheBeginning.TabIndex = 10;
            this.fromTheBeginning.Text = "С первого кадра";
            this.fromTheBeginning.UseVisualStyleBackColor = true;
            this.fromTheBeginning.Click += new System.EventHandler(this.fromTheBeginning_Click);
            // 
            // viewbox
            // 
            this.viewbox.Controls.Add(this.fromTheBeginning);
            this.viewbox.Controls.Add(this.nextFrame);
            this.viewbox.Controls.Add(this.playImages);
            this.viewbox.Controls.Add(this.frameOffset);
            this.viewbox.Controls.Add(this.label10);
            this.viewbox.Location = new System.Drawing.Point(14, 3);
            this.viewbox.Name = "viewbox";
            this.viewbox.Size = new System.Drawing.Size(169, 154);
            this.viewbox.TabIndex = 11;
            this.viewbox.TabStop = false;
            this.viewbox.Text = "Просмотр кадров";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.currentFrame);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lastFrameNum);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.firstFrameNum);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(205, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 149);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выбор промежутка";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // firstFrameNum
            // 
            this.firstFrameNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.firstFrameNum.Location = new System.Drawing.Point(6, 32);
            this.firstFrameNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.firstFrameNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstFrameNum.Name = "firstFrameNum";
            this.firstFrameNum.Size = new System.Drawing.Size(108, 20);
            this.firstFrameNum.TabIndex = 9;
            this.firstFrameNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "С какого кадра";
            // 
            // lastFrameNum
            // 
            this.lastFrameNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lastFrameNum.Location = new System.Drawing.Point(6, 80);
            this.lastFrameNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.lastFrameNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lastFrameNum.Name = "lastFrameNum";
            this.lastFrameNum.Size = new System.Drawing.Size(108, 20);
            this.lastFrameNum.TabIndex = 11;
            this.lastFrameNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "По какой кадр";
            // 
            // currentFrame
            // 
            this.currentFrame.Location = new System.Drawing.Point(6, 126);
            this.currentFrame.Name = "currentFrame";
            this.currentFrame.ReadOnly = true;
            this.currentFrame.Size = new System.Drawing.Size(108, 20);
            this.currentFrame.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Текущий кадр";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(557, 13);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(115, 62);
            this.process.TabIndex = 13;
            this.process.Text = "Наложение кадров";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // progress
            // 
            this.progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(500, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress,
            this.processLabel});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1360, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.brightnessValue);
            this.groupBox5.Location = new System.Drawing.Point(393, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 131);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройка картинок";
            // 
            // brightnessValue
            // 
            this.brightnessValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.brightnessValue.Location = new System.Drawing.Point(6, 42);
            this.brightnessValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessValue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Size = new System.Drawing.Size(120, 20);
            this.brightnessValue.TabIndex = 0;
            this.brightnessValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Яркость";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сохранить результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = false;
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(100, 15);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 626);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOffset)).EndInit();
            this.viewbox.ResumeLayout(false);
            this.viewbox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstFrameNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFrameNum)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private AForge.Controls.VideoSourcePlayer video;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private AForge.Controls.PictureBox picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem openVideo;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button nextFrame;
        private System.Windows.Forms.TextBox frameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intervalNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox framesFPS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalFrames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox videoWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox videoHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox videoCodec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown frameOffset;
        private System.Windows.Forms.Button playImages;
        private System.Windows.Forms.Button fromTheBeginning;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown lastFrameNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown firstFrameNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox viewbox;
        private System.Windows.Forms.TextBox currentFrame;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown brightnessValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel processLabel;

    }
}

