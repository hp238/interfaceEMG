namespace interfaceEMG
{
    partial class formInterface
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInterface));
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btmConect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.graphCanais = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphBars = new ZedGraph.ZedGraphControl();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.graphFFT = new ZedGraph.ZedGraphControl();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.startButton = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.h5 = new System.Windows.Forms.PictureBox();
            this.h6 = new System.Windows.Forms.PictureBox();
            this.h3 = new System.Windows.Forms.PictureBox();
            this.h4 = new System.Windows.Forms.PictureBox();
            this.h1 = new System.Windows.Forms.PictureBox();
            this.h2 = new System.Windows.Forms.PictureBox();
            this.sand = new System.Windows.Forms.PictureBox();
            this.tree4 = new System.Windows.Forms.PictureBox();
            this.tree3 = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.tree1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btmTest = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btmRead = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.biofeedbackCheckBox = new System.Windows.Forms.CheckBox();
            this.FFTCheckBox = new System.Windows.Forms.CheckBox();
            this.btmPlay = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.offsetCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 2000000;
            this.serialPort2.ReadTimeout = 100;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1273, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btmConect
            // 
            this.btmConect.BackColor = System.Drawing.Color.Gainsboro;
            this.btmConect.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btmConect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btmConect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmConect.Location = new System.Drawing.Point(1391, 7);
            this.btmConect.Margin = new System.Windows.Forms.Padding(4);
            this.btmConect.Name = "btmConect";
            this.btmConect.Size = new System.Drawing.Size(100, 28);
            this.btmConect.TabIndex = 2;
            this.btmConect.Text = "Conectar";
            this.btmConect.UseVisualStyleBackColor = false;
            this.btmConect.Click += new System.EventHandler(this.btmConectar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 48);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1653, 762);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.graphCanais);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1645, 730);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinais";
            // 
            // graphCanais
            // 
            this.graphCanais.BackColor = System.Drawing.Color.Coral;
            this.graphCanais.Location = new System.Drawing.Point(9, 12);
            this.graphCanais.Margin = new System.Windows.Forms.Padding(5);
            this.graphCanais.Name = "graphCanais";
            this.graphCanais.ScrollGrace = 0D;
            this.graphCanais.ScrollMaxX = 0D;
            this.graphCanais.ScrollMaxY = 0D;
            this.graphCanais.ScrollMaxY2 = 0D;
            this.graphCanais.ScrollMinX = 0D;
            this.graphCanais.ScrollMinY = 0D;
            this.graphCanais.ScrollMinY2 = 0D;
            this.graphCanais.Size = new System.Drawing.Size(1628, 703);
            this.graphCanais.TabIndex = 0;
            this.graphCanais.UseExtendedPrintDialog = true;
            this.graphCanais.Load += new System.EventHandler(this.graphCanais_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.graphBars);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1645, 730);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Biofeedback";
            // 
            // graphBars
            // 
            this.graphBars.BackColor = System.Drawing.Color.RosyBrown;
            this.graphBars.Location = new System.Drawing.Point(9, 9);
            this.graphBars.Margin = new System.Windows.Forms.Padding(5);
            this.graphBars.Name = "graphBars";
            this.graphBars.ScrollGrace = 0D;
            this.graphBars.ScrollMaxX = 0D;
            this.graphBars.ScrollMaxY = 0D;
            this.graphBars.ScrollMaxY2 = 0D;
            this.graphBars.ScrollMinX = 0D;
            this.graphBars.ScrollMinY = 0D;
            this.graphBars.ScrollMinY2 = 0D;
            this.graphBars.Size = new System.Drawing.Size(1597, 645);
            this.graphBars.TabIndex = 11;
            this.graphBars.UseExtendedPrintDialog = true;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(8, 508);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(52, 15);
            this.textBox9.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.graphFFT);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1645, 730);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "FFT";
            // 
            // graphFFT
            // 
            this.graphFFT.BackColor = System.Drawing.Color.RosyBrown;
            this.graphFFT.Location = new System.Drawing.Point(4, 9);
            this.graphFFT.Margin = new System.Windows.Forms.Padding(5);
            this.graphFFT.Name = "graphFFT";
            this.graphFFT.ScrollGrace = 0D;
            this.graphFFT.ScrollMaxX = 0D;
            this.graphFFT.ScrollMaxY = 0D;
            this.graphFFT.ScrollMaxY2 = 0D;
            this.graphFFT.ScrollMinX = 0D;
            this.graphFFT.ScrollMinY = 0D;
            this.graphFFT.ScrollMinY2 = 0D;
            this.graphFFT.Size = new System.Drawing.Size(1601, 716);
            this.graphFFT.TabIndex = 12;
            this.graphFFT.UseExtendedPrintDialog = true;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(8, 233);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(52, 15);
            this.textBox10.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Aqua;
            this.tabPage4.Controls.Add(this.startButton);
            this.tabPage4.Controls.Add(this.restartButton);
            this.tabPage4.Controls.Add(this.ScoreLabel);
            this.tabPage4.Controls.Add(this.GameOverLabel);
            this.tabPage4.Controls.Add(this.bird);
            this.tabPage4.Controls.Add(this.h5);
            this.tabPage4.Controls.Add(this.h6);
            this.tabPage4.Controls.Add(this.h3);
            this.tabPage4.Controls.Add(this.h4);
            this.tabPage4.Controls.Add(this.h1);
            this.tabPage4.Controls.Add(this.h2);
            this.tabPage4.Controls.Add(this.sand);
            this.tabPage4.Controls.Add(this.tree4);
            this.tabPage4.Controls.Add(this.tree3);
            this.tabPage4.Controls.Add(this.tree2);
            this.tabPage4.Controls.Add(this.tree1);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1645, 730);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Flappy Bird";
            this.tabPage4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick_FlappyBird);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Window;
            this.startButton.Location = new System.Drawing.Point(700, 229);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(194, 97);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.BackColor = System.Drawing.Color.Black;
            this.restartButton.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.restartButton.Location = new System.Drawing.Point(669, 450);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(260, 97);
            this.restartButton.TabIndex = 15;
            this.restartButton.Text = "Restart";
            this.restartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Black;
            this.ScoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ScoreLabel.Location = new System.Drawing.Point(3, 11);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 40);
            this.ScoreLabel.TabIndex = 13;
            this.ScoreLabel.Text = "Score: ";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Black;
            this.GameOverLabel.Location = new System.Drawing.Point(612, 331);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(364, 97);
            this.GameOverLabel.TabIndex = 12;
            this.GameOverLabel.Text = "Game Over";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bird.BackgroundImage")));
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Location = new System.Drawing.Point(61, 331);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(67, 60);
            this.bird.TabIndex = 11;
            this.bird.TabStop = false;
            // 
            // h5
            // 
            this.h5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h5.Location = new System.Drawing.Point(1520, 0);
            this.h5.Name = "h5";
            this.h5.Size = new System.Drawing.Size(200, 280);
            this.h5.TabIndex = 10;
            this.h5.TabStop = false;
            // 
            // h6
            // 
            this.h6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.h6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h6.Location = new System.Drawing.Point(1520, 450);
            this.h6.Name = "h6";
            this.h6.Size = new System.Drawing.Size(200, 280);
            this.h6.TabIndex = 9;
            this.h6.TabStop = false;
            // 
            // h3
            // 
            this.h3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h3.Location = new System.Drawing.Point(860, 0);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(200, 280);
            this.h3.TabIndex = 8;
            this.h3.TabStop = false;
            // 
            // h4
            // 
            this.h4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h4.Location = new System.Drawing.Point(860, 450);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(200, 280);
            this.h4.TabIndex = 7;
            this.h4.TabStop = false;
            // 
            // h1
            // 
            this.h1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h1.Location = new System.Drawing.Point(180, 0);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(200, 280);
            this.h1.TabIndex = 6;
            this.h1.TabStop = false;
            // 
            // h2
            // 
            this.h2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h2.Location = new System.Drawing.Point(180, 450);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(200, 280);
            this.h2.TabIndex = 5;
            this.h2.TabStop = false;
            // 
            // sand
            // 
            this.sand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sand.Location = new System.Drawing.Point(0, 596);
            this.sand.Name = "sand";
            this.sand.Size = new System.Drawing.Size(1645, 134);
            this.sand.TabIndex = 0;
            this.sand.TabStop = false;
            // 
            // tree4
            // 
            this.tree4.BackColor = System.Drawing.Color.Transparent;
            this.tree4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree4.BackgroundImage")));
            this.tree4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree4.Location = new System.Drawing.Point(1324, 463);
            this.tree4.Name = "tree4";
            this.tree4.Size = new System.Drawing.Size(147, 133);
            this.tree4.TabIndex = 4;
            this.tree4.TabStop = false;
            // 
            // tree3
            // 
            this.tree3.BackColor = System.Drawing.Color.Transparent;
            this.tree3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree3.BackgroundImage")));
            this.tree3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree3.Location = new System.Drawing.Point(965, 498);
            this.tree3.Name = "tree3";
            this.tree3.Size = new System.Drawing.Size(101, 98);
            this.tree3.TabIndex = 3;
            this.tree3.TabStop = false;
            // 
            // tree2
            // 
            this.tree2.BackColor = System.Drawing.Color.Transparent;
            this.tree2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree2.BackgroundImage")));
            this.tree2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree2.Location = new System.Drawing.Point(568, 514);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(86, 82);
            this.tree2.TabIndex = 2;
            this.tree2.TabStop = false;
            // 
            // tree1
            // 
            this.tree1.BackColor = System.Drawing.Color.Transparent;
            this.tree1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree1.BackgroundImage")));
            this.tree1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree1.Location = new System.Drawing.Point(61, 488);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(135, 108);
            this.tree1.TabIndex = 1;
            this.tree1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btmTest
            // 
            this.btmTest.Location = new System.Drawing.Point(1165, 7);
            this.btmTest.Margin = new System.Windows.Forms.Padding(4);
            this.btmTest.Name = "btmTest";
            this.btmTest.Size = new System.Drawing.Size(100, 28);
            this.btmTest.TabIndex = 3;
            this.btmTest.Text = "Testar";
            this.btmTest.UseVisualStyleBackColor = true;
            this.btmTest.Click += new System.EventHandler(this.btmTeste_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1499, 7);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(161, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // btmRead
            // 
            this.btmRead.Location = new System.Drawing.Point(208, 12);
            this.btmRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmRead.Name = "btmRead";
            this.btmRead.Size = new System.Drawing.Size(100, 28);
            this.btmRead.TabIndex = 5;
            this.btmRead.Text = "Ler Arquivo";
            this.btmRead.UseVisualStyleBackColor = true;
            this.btmRead.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(16, 15);
            this.txtRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(185, 22);
            this.txtRead.TabIndex = 6;
            this.txtRead.Text = "Sinais";
            this.txtRead.TextChanged += new System.EventHandler(this.fileTextBox_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownWidth = 108;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(403, 14);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // biofeedbackCheckBox
            // 
            this.biofeedbackCheckBox.AutoSize = true;
            this.biofeedbackCheckBox.BackColor = System.Drawing.Color.Black;
            this.biofeedbackCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.biofeedbackCheckBox.Location = new System.Drawing.Point(549, 15);
            this.biofeedbackCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.biofeedbackCheckBox.Name = "biofeedbackCheckBox";
            this.biofeedbackCheckBox.Size = new System.Drawing.Size(108, 21);
            this.biofeedbackCheckBox.TabIndex = 10;
            this.biofeedbackCheckBox.Text = "Biofeedback";
            this.biofeedbackCheckBox.UseVisualStyleBackColor = false;
            this.biofeedbackCheckBox.CheckedChanged += new System.EventHandler(this.biofeedbackCheckBox_CheckedChanged);
            // 
            // FFTCheckBox
            // 
            this.FFTCheckBox.AutoSize = true;
            this.FFTCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FFTCheckBox.Location = new System.Drawing.Point(669, 15);
            this.FFTCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FFTCheckBox.Name = "FFTCheckBox";
            this.FFTCheckBox.Size = new System.Drawing.Size(55, 21);
            this.FFTCheckBox.TabIndex = 11;
            this.FFTCheckBox.Text = "FFT";
            this.FFTCheckBox.UseVisualStyleBackColor = true;
            this.FFTCheckBox.CheckedChanged += new System.EventHandler(this.FFTCheckBox_CheckedChanged);
            // 
            // btmPlay
            // 
            this.btmPlay.BackColor = System.Drawing.Color.Gainsboro;
            this.btmPlay.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btmPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btmPlay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btmPlay.Location = new System.Drawing.Point(1015, 7);
            this.btmPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(100, 28);
            this.btmPlay.TabIndex = 12;
            this.btmPlay.Text = "Iniciar";
            this.btmPlay.UseVisualStyleBackColor = false;
            this.btmPlay.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(872, 10);
            this.txtArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(133, 22);
            this.txtArquivo.TabIndex = 13;
            this.txtArquivo.Text = "Sinais";
            // 
            // offsetCheckBox
            // 
            this.offsetCheckBox.AutoSize = true;
            this.offsetCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.offsetCheckBox.Location = new System.Drawing.Point(737, 14);
            this.offsetCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.offsetCheckBox.Name = "offsetCheckBox";
            this.offsetCheckBox.Size = new System.Drawing.Size(68, 21);
            this.offsetCheckBox.TabIndex = 14;
            this.offsetCheckBox.Text = "Offset";
            this.offsetCheckBox.UseVisualStyleBackColor = true;
            this.offsetCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // formInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1680, 843);
            this.Controls.Add(this.offsetCheckBox);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.FFTCheckBox);
            this.Controls.Add(this.biofeedbackCheckBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.btmRead);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btmTest);
            this.Controls.Add(this.btmConect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formInterface";
            this.Text = "Interface EMG";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btmConect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl graphCanais;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btmTest;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ZedGraph.ZedGraphControl graphFFT;
        private ZedGraph.ZedGraphControl graphBars;
        private System.Windows.Forms.Button btmRead;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox biofeedbackCheckBox;
        private System.Windows.Forms.CheckBox FFTCheckBox;
        private System.Windows.Forms.Button btmPlay;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.CheckBox offsetCheckBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox sand;
        private System.Windows.Forms.PictureBox tree4;
        private System.Windows.Forms.PictureBox tree3;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.PictureBox tree1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox h1;
        private System.Windows.Forms.PictureBox h2;
        private System.Windows.Forms.PictureBox h5;
        private System.Windows.Forms.PictureBox h6;
        private System.Windows.Forms.PictureBox h3;
        private System.Windows.Forms.PictureBox h4;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label restartButton;
        private System.Windows.Forms.Label startButton;
    }
}