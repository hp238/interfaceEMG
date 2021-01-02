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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.mazeRightButton = new System.Windows.Forms.Button();
            this.mazeLeftButton = new System.Windows.Forms.Button();
            this.mazeDownButton = new System.Windows.Forms.Button();
            this.mazeUpButton = new System.Windows.Forms.Button();
            this.cleanMazeButton = new System.Windows.Forms.Button();
            this.createMazeButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.colsMazeTextBox = new System.Windows.Forms.TextBox();
            this.rowsMazeTextBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btmRead = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.biofeedbackCheckBox = new System.Windows.Forms.CheckBox();
            this.FFTCheckBox = new System.Windows.Forms.CheckBox();
            this.btmPlay = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.btmFFT = new System.Windows.Forms.Button();
            this.cbCanais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmostragem = new System.Windows.Forms.TextBox();
            this.cbJanela = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnvoltoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flappyBirdcheckBox = new System.Windows.Forms.CheckBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btmWIFI = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFlappy = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
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
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 115200;
            this.serialPort2.ReadTimeout = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btmConect
            // 
            this.btmConect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmConect.Enabled = false;
            this.btmConect.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btmConect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btmConect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmConect.Location = new System.Drawing.Point(8, 63);
            this.btmConect.Margin = new System.Windows.Forms.Padding(4);
            this.btmConect.Name = "btmConect";
            this.btmConect.Size = new System.Drawing.Size(157, 28);
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
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 112);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1712, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.graphCanais);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1704, 768);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinais";
            // 
            // graphCanais
            // 
            this.graphCanais.BackColor = System.Drawing.Color.Coral;
            this.graphCanais.Location = new System.Drawing.Point(9, 27);
            this.graphCanais.Margin = new System.Windows.Forms.Padding(5);
            this.graphCanais.Name = "graphCanais";
            this.graphCanais.ScrollGrace = 0D;
            this.graphCanais.ScrollMaxX = 0D;
            this.graphCanais.ScrollMaxY = 0D;
            this.graphCanais.ScrollMaxY2 = 0D;
            this.graphCanais.ScrollMinX = 0D;
            this.graphCanais.ScrollMinY = 0D;
            this.graphCanais.ScrollMinY2 = 0D;
            this.graphCanais.Size = new System.Drawing.Size(1680, 746);
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
            this.tabPage2.Size = new System.Drawing.Size(1704, 768);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Envoltória";
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
            this.tabPage3.Size = new System.Drawing.Size(1704, 768);
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
            this.tabPage4.BackColor = System.Drawing.Color.PaleTurquoise;
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
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1704, 768);
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
            this.bird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(67, 60);
            this.bird.TabIndex = 11;
            this.bird.TabStop = false;
            // 
            // h5
            // 
            this.h5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h5.Location = new System.Drawing.Point(1648, 0);
            this.h5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h5.Name = "h5";
            this.h5.Size = new System.Drawing.Size(200, 280);
            this.h5.TabIndex = 10;
            this.h5.TabStop = false;
            // 
            // h6
            // 
            this.h6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.h6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h6.Location = new System.Drawing.Point(1648, 450);
            this.h6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h6.Name = "h6";
            this.h6.Size = new System.Drawing.Size(200, 280);
            this.h6.TabIndex = 9;
            this.h6.TabStop = false;
            // 
            // h3
            // 
            this.h3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h3.Location = new System.Drawing.Point(860, 0);
            this.h3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(200, 280);
            this.h3.TabIndex = 8;
            this.h3.TabStop = false;
            // 
            // h4
            // 
            this.h4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h4.Location = new System.Drawing.Point(860, 450);
            this.h4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(200, 280);
            this.h4.TabIndex = 7;
            this.h4.TabStop = false;
            // 
            // h1
            // 
            this.h1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h1.Location = new System.Drawing.Point(180, 0);
            this.h1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(200, 280);
            this.h1.TabIndex = 6;
            this.h1.TabStop = false;
            // 
            // h2
            // 
            this.h2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.h2.Location = new System.Drawing.Point(180, 450);
            this.h2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(200, 280);
            this.h2.TabIndex = 5;
            this.h2.TabStop = false;
            // 
            // sand
            // 
            this.sand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sand.Location = new System.Drawing.Point(0, 596);
            this.sand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sand.Name = "sand";
            this.sand.Size = new System.Drawing.Size(1701, 134);
            this.sand.TabIndex = 0;
            this.sand.TabStop = false;
            // 
            // tree4
            // 
            this.tree4.BackColor = System.Drawing.Color.Transparent;
            this.tree4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree4.BackgroundImage")));
            this.tree4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree4.Location = new System.Drawing.Point(1324, 463);
            this.tree4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tree3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tree2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(85, 82);
            this.tree2.TabIndex = 2;
            this.tree2.TabStop = false;
            // 
            // tree1
            // 
            this.tree1.BackColor = System.Drawing.Color.Transparent;
            this.tree1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree1.BackgroundImage")));
            this.tree1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree1.Location = new System.Drawing.Point(61, 487);
            this.tree1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(135, 108);
            this.tree1.TabIndex = 1;
            this.tree1.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.mazeRightButton);
            this.tabPage5.Controls.Add(this.mazeLeftButton);
            this.tabPage5.Controls.Add(this.mazeDownButton);
            this.tabPage5.Controls.Add(this.mazeUpButton);
            this.tabPage5.Controls.Add(this.cleanMazeButton);
            this.tabPage5.Controls.Add(this.createMazeButton);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.colsMazeTextBox);
            this.tabPage5.Controls.Add(this.rowsMazeTextBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1704, 768);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Labirinto";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // mazeRightButton
            // 
            this.mazeRightButton.Location = new System.Drawing.Point(253, 620);
            this.mazeRightButton.Name = "mazeRightButton";
            this.mazeRightButton.Size = new System.Drawing.Size(97, 23);
            this.mazeRightButton.TabIndex = 10;
            this.mazeRightButton.Text = "DIREITA";
            this.mazeRightButton.UseVisualStyleBackColor = true;
            // 
            // mazeLeftButton
            // 
            this.mazeLeftButton.Location = new System.Drawing.Point(47, 620);
            this.mazeLeftButton.Name = "mazeLeftButton";
            this.mazeLeftButton.Size = new System.Drawing.Size(97, 23);
            this.mazeLeftButton.TabIndex = 9;
            this.mazeLeftButton.Text = "ESQUERDA";
            this.mazeLeftButton.UseVisualStyleBackColor = true;
            // 
            // mazeDownButton
            // 
            this.mazeDownButton.Location = new System.Drawing.Point(153, 683);
            this.mazeDownButton.Name = "mazeDownButton";
            this.mazeDownButton.Size = new System.Drawing.Size(97, 23);
            this.mazeDownButton.TabIndex = 8;
            this.mazeDownButton.Text = "DESCER";
            this.mazeDownButton.UseVisualStyleBackColor = true;
            // 
            // mazeUpButton
            // 
            this.mazeUpButton.Location = new System.Drawing.Point(153, 554);
            this.mazeUpButton.Name = "mazeUpButton";
            this.mazeUpButton.Size = new System.Drawing.Size(97, 23);
            this.mazeUpButton.TabIndex = 7;
            this.mazeUpButton.Text = "SUBIR";
            this.mazeUpButton.UseVisualStyleBackColor = true;
            // 
            // cleanMazeButton
            // 
            this.cleanMazeButton.Location = new System.Drawing.Point(39, 370);
            this.cleanMazeButton.Name = "cleanMazeButton";
            this.cleanMazeButton.Size = new System.Drawing.Size(159, 50);
            this.cleanMazeButton.TabIndex = 6;
            this.cleanMazeButton.Text = "Limpar Labirinto";
            this.cleanMazeButton.UseVisualStyleBackColor = true;
            this.cleanMazeButton.Click += new System.EventHandler(this.cleanMazeButton_Click);
            // 
            // createMazeButton
            // 
            this.createMazeButton.Location = new System.Drawing.Point(39, 306);
            this.createMazeButton.Name = "createMazeButton";
            this.createMazeButton.Size = new System.Drawing.Size(159, 50);
            this.createMazeButton.TabIndex = 5;
            this.createMazeButton.Text = "Gerar Labirinto";
            this.createMazeButton.UseVisualStyleBackColor = true;
            this.createMazeButton.Click += new System.EventHandler(this.createMazeButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Número de Colunas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Número de Linhas";
            // 
            // colsMazeTextBox
            // 
            this.colsMazeTextBox.Location = new System.Drawing.Point(36, 210);
            this.colsMazeTextBox.Name = "colsMazeTextBox";
            this.colsMazeTextBox.Size = new System.Drawing.Size(162, 22);
            this.colsMazeTextBox.TabIndex = 2;
            // 
            // rowsMazeTextBox
            // 
            this.rowsMazeTextBox.Location = new System.Drawing.Point(36, 117);
            this.rowsMazeTextBox.Name = "rowsMazeTextBox";
            this.rowsMazeTextBox.Size = new System.Drawing.Size(162, 22);
            this.rowsMazeTextBox.TabIndex = 1;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btmRead
            // 
            this.btmRead.Location = new System.Drawing.Point(209, 32);
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
            this.txtRead.Location = new System.Drawing.Point(13, 34);
            this.txtRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(185, 22);
            this.txtRead.TabIndex = 6;
            this.txtRead.Text = "Nome_ler";
            this.txtRead.TextChanged += new System.EventHandler(this.fileTextBox_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownWidth = 108;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "1";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // biofeedbackCheckBox
            // 
            this.biofeedbackCheckBox.AutoSize = true;
            this.biofeedbackCheckBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.biofeedbackCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.biofeedbackCheckBox.Location = new System.Drawing.Point(143, 14);
            this.biofeedbackCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.biofeedbackCheckBox.Name = "biofeedbackCheckBox";
            this.biofeedbackCheckBox.Size = new System.Drawing.Size(93, 21);
            this.biofeedbackCheckBox.TabIndex = 10;
            this.biofeedbackCheckBox.Text = "Envoltória";
            this.biofeedbackCheckBox.UseVisualStyleBackColor = false;
            this.biofeedbackCheckBox.CheckedChanged += new System.EventHandler(this.biofeedbackCheckBox_CheckedChanged);
            // 
            // FFTCheckBox
            // 
            this.FFTCheckBox.AutoSize = true;
            this.FFTCheckBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FFTCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FFTCheckBox.Location = new System.Drawing.Point(143, 43);
            this.FFTCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FFTCheckBox.Name = "FFTCheckBox";
            this.FFTCheckBox.Size = new System.Drawing.Size(55, 21);
            this.FFTCheckBox.TabIndex = 11;
            this.FFTCheckBox.Text = "FFT";
            this.FFTCheckBox.UseVisualStyleBackColor = false;
            this.FFTCheckBox.CheckedChanged += new System.EventHandler(this.FFTCheckBox_CheckedChanged);
            // 
            // btmPlay
            // 
            this.btmPlay.BackColor = System.Drawing.Color.Gainsboro;
            this.btmPlay.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btmPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btmPlay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btmPlay.Location = new System.Drawing.Point(208, 66);
            this.btmPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(100, 28);
            this.btmPlay.TabIndex = 12;
            this.btmPlay.Text = "Salvar";
            this.btmPlay.UseVisualStyleBackColor = false;
            this.btmPlay.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(13, 66);
            this.txtArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(185, 22);
            this.txtArquivo.TabIndex = 13;
            this.txtArquivo.Text = "Nome_salvar";
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
            // btmFFT
            // 
            this.btmFFT.Location = new System.Drawing.Point(197, 41);
            this.btmFFT.Margin = new System.Windows.Forms.Padding(4);
            this.btmFFT.Name = "btmFFT";
            this.btmFFT.Size = new System.Drawing.Size(100, 28);
            this.btmFFT.TabIndex = 15;
            this.btmFFT.Text = "Iniciar";
            this.btmFFT.UseVisualStyleBackColor = true;
            this.btmFFT.Click += new System.EventHandler(this.btmFFT_Click);
            // 
            // cbCanais
            // 
            this.cbCanais.FormattingEnabled = true;
            this.cbCanais.Location = new System.Drawing.Point(104, 69);
            this.cbCanais.Margin = new System.Windows.Forms.Padding(4);
            this.cbCanais.Name = "cbCanais";
            this.cbCanais.Size = new System.Drawing.Size(43, 24);
            this.cbCanais.TabIndex = 17;
            this.cbCanais.Text = "8";
            this.cbCanais.SelectedIndexChanged += new System.EventHandler(this.cbCanais_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Amostragem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Canais";
            // 
            // txtAmostragem
            // 
            this.txtAmostragem.Location = new System.Drawing.Point(104, 34);
            this.txtAmostragem.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmostragem.Name = "txtAmostragem";
            this.txtAmostragem.Size = new System.Drawing.Size(43, 22);
            this.txtAmostragem.TabIndex = 20;
            this.txtAmostragem.Text = "1000";
            // 
            // cbJanela
            // 
            this.cbJanela.FormattingEnabled = true;
            this.cbJanela.Location = new System.Drawing.Point(329, 37);
            this.cbJanela.Margin = new System.Windows.Forms.Padding(4);
            this.cbJanela.Name = "cbJanela";
            this.cbJanela.Size = new System.Drawing.Size(71, 24);
            this.cbJanela.TabIndex = 21;
            this.cbJanela.Text = "1000";
            this.cbJanela.SelectedIndexChanged += new System.EventHandler(this.cbJanela_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(209, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Janela Sinais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(209, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Janela Envoltória";
            // 
            // txtEnvoltoria
            // 
            this.txtEnvoltoria.Location = new System.Drawing.Point(329, 69);
            this.txtEnvoltoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnvoltoria.Name = "txtEnvoltoria";
            this.txtEnvoltoria.Size = new System.Drawing.Size(71, 22);
            this.txtEnvoltoria.TabIndex = 24;
            this.txtEnvoltoria.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(156, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(409, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "pontos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(409, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "pontos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(156, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "canais";
            // 
            // flappyBirdcheckBox
            // 
            this.flappyBirdcheckBox.AutoSize = true;
            this.flappyBirdcheckBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flappyBirdcheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.flappyBirdcheckBox.Location = new System.Drawing.Point(143, 71);
            this.flappyBirdcheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.flappyBirdcheckBox.Name = "flappyBirdcheckBox";
            this.flappyBirdcheckBox.Size = new System.Drawing.Size(101, 21);
            this.flappyBirdcheckBox.TabIndex = 29;
            this.flappyBirdcheckBox.Text = "Flappy Bird";
            this.flappyBirdcheckBox.UseVisualStyleBackColor = false;
            this.flappyBirdcheckBox.CheckedChanged += new System.EventHandler(this.flappyBirdcheckBox_CheckedChanged_1);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(67, 36);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(132, 22);
            this.tbIP.TabIndex = 30;
            this.tbIP.Text = "192.168.46.186";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(67, 69);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(132, 22);
            this.tbPort.TabIndex = 31;
            this.tbPort.Text = "8080";
            // 
            // btmWIFI
            // 
            this.btmWIFI.Location = new System.Drawing.Point(208, 37);
            this.btmWIFI.Margin = new System.Windows.Forms.Padding(4);
            this.btmWIFI.Name = "btmWIFI";
            this.btmWIFI.Size = new System.Drawing.Size(113, 57);
            this.btmWIFI.TabIndex = 32;
            this.btmWIFI.Text = "Conectar";
            this.btmWIFI.UseVisualStyleBackColor = true;
            this.btmWIFI.Click += new System.EventHandler(this.btmWIFI_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(4, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "COM PORT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(19, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(19, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Port";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btmPlay);
            this.panel1.Controls.Add(this.btmRead);
            this.panel1.Controls.Add(this.txtArquivo);
            this.panel1.Controls.Add(this.txtRead);
            this.panel1.Location = new System.Drawing.Point(16, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 98);
            this.panel1.TabIndex = 36;
            this.panel1.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ler e Salvar dados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.flappyBirdcheckBox);
            this.panel2.Controls.Add(this.txtFlappy);
            this.panel2.Controls.Add(this.biofeedbackCheckBox);
            this.panel2.Controls.Add(this.btmFFT);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.FFTCheckBox);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(356, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 98);
            this.panel2.TabIndex = 37;
            // 
            // txtFlappy
            // 
            this.txtFlappy.Location = new System.Drawing.Point(4, 66);
            this.txtFlappy.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlappy.Name = "txtFlappy";
            this.txtFlappy.Size = new System.Drawing.Size(103, 22);
            this.txtFlappy.TabIndex = 10;
            this.txtFlappy.Text = "2500";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-1, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 17);
            this.label17.TabIndex = 9;
            this.label17.Text = "Limiar Flappy Bird";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Canal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbCanais);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtAmostragem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbJanela);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtEnvoltoria);
            this.panel3.Location = new System.Drawing.Point(704, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 98);
            this.panel3.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Configuração Inicial";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.tbIP);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btmWIFI);
            this.panel4.Controls.Add(this.tbPort);
            this.panel4.Location = new System.Drawing.Point(1205, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 98);
            this.panel4.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Conexão WIFI";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.btmConect);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Location = new System.Drawing.Point(1557, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 98);
            this.panel5.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label15.Location = new System.Drawing.Point(5, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Conexão Serial";
            // 
            // formInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1744, 922);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

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
        private ZedGraph.ZedGraphControl graphFFT;
        private ZedGraph.ZedGraphControl graphBars;
        private System.Windows.Forms.Button btmRead;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox biofeedbackCheckBox;
        private System.Windows.Forms.CheckBox FFTCheckBox;
        private System.Windows.Forms.Button btmPlay;
        private System.Windows.Forms.TextBox txtArquivo;
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
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button btmFFT;
        private System.Windows.Forms.ComboBox cbCanais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmostragem;
        private System.Windows.Forms.ComboBox cbJanela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnvoltoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox flappyBirdcheckBox;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btmWIFI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFlappy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox colsMazeTextBox;
        private System.Windows.Forms.TextBox rowsMazeTextBox;
        private System.Windows.Forms.Button cleanMazeButton;
        private System.Windows.Forms.Button createMazeButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button mazeUpButton;
        private System.Windows.Forms.Button mazeLeftButton;
        private System.Windows.Forms.Button mazeDownButton;
        private System.Windows.Forms.Button mazeRightButton;
    }
}