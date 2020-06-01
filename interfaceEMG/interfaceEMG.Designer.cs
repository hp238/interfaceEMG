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
            this.btmConectar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.graphCanais = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphBars = new ZedGraph.ZedGraphControl();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.graphFFT = new ZedGraph.ZedGraphControl();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btmTeste = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.readFileButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.biofeedbackCheckBox = new System.Windows.Forms.CheckBox();
            this.FFTCheckBox = new System.Windows.Forms.CheckBox();
            this.btmPlay = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 115200;
            this.serialPort2.ReadTimeout = 1000;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(915, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btmConectar
            // 
            this.btmConectar.BackColor = System.Drawing.Color.Gainsboro;
            this.btmConectar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btmConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btmConectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmConectar.Location = new System.Drawing.Point(1017, 8);
            this.btmConectar.Name = "btmConectar";
            this.btmConectar.Size = new System.Drawing.Size(75, 23);
            this.btmConectar.TabIndex = 2;
            this.btmConectar.Text = "Conectar";
            this.btmConectar.UseVisualStyleBackColor = false;
            this.btmConectar.Click += new System.EventHandler(this.btmConectar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.graphCanais);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinais";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(6, 266);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(39, 13);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "Canal 4";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(6, 556);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(39, 13);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Canal 8";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(6, 486);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(39, 13);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Canal 7";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(6, 413);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 13);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Canal 6";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(6, 337);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 13);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Canal 5";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 13);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Canal 3";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 13);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Canal 2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Canal 1";
            // 
            // graphCanais
            // 
            this.graphCanais.BackColor = System.Drawing.Color.Coral;
            this.graphCanais.Location = new System.Drawing.Point(49, 10);
            this.graphCanais.Margin = new System.Windows.Forms.Padding(4);
            this.graphCanais.Name = "graphCanais";
            this.graphCanais.ScrollGrace = 0D;
            this.graphCanais.ScrollMaxX = 0D;
            this.graphCanais.ScrollMaxY = 0D;
            this.graphCanais.ScrollMaxY2 = 0D;
            this.graphCanais.ScrollMinX = 0D;
            this.graphCanais.ScrollMinY = 0D;
            this.graphCanais.ScrollMinY2 = 0D;
            this.graphCanais.Size = new System.Drawing.Size(1179, 592);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 590);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Biofeedback";
            // 
            // graphBars
            // 
            this.graphBars.BackColor = System.Drawing.Color.RosyBrown;
            this.graphBars.Location = new System.Drawing.Point(7, 7);
            this.graphBars.Margin = new System.Windows.Forms.Padding(4);
            this.graphBars.Name = "graphBars";
            this.graphBars.ScrollGrace = 0D;
            this.graphBars.ScrollMaxX = 0D;
            this.graphBars.ScrollMaxY = 0D;
            this.graphBars.ScrollMaxY2 = 0D;
            this.graphBars.ScrollMinX = 0D;
            this.graphBars.ScrollMinY = 0D;
            this.graphBars.ScrollMinY2 = 0D;
            this.graphBars.Size = new System.Drawing.Size(1198, 524);
            this.graphBars.TabIndex = 11;
            this.graphBars.UseExtendedPrintDialog = true;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(6, 413);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(39, 13);
            this.textBox9.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.graphFFT);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 590);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "FFT";
            // 
            // graphFFT
            // 
            this.graphFFT.BackColor = System.Drawing.Color.RosyBrown;
            this.graphFFT.Location = new System.Drawing.Point(3, 7);
            this.graphFFT.Margin = new System.Windows.Forms.Padding(4);
            this.graphFFT.Name = "graphFFT";
            this.graphFFT.ScrollGrace = 0D;
            this.graphFFT.ScrollMaxX = 0D;
            this.graphFFT.ScrollMaxY = 0D;
            this.graphFFT.ScrollMaxY2 = 0D;
            this.graphFFT.ScrollMinX = 0D;
            this.graphFFT.ScrollMinY = 0D;
            this.graphFFT.ScrollMinY2 = 0D;
            this.graphFFT.Size = new System.Drawing.Size(1201, 582);
            this.graphFFT.TabIndex = 12;
            this.graphFFT.UseExtendedPrintDialog = true;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(6, 189);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(39, 13);
            this.textBox10.TabIndex = 10;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btmTeste
            // 
            this.btmTeste.Location = new System.Drawing.Point(815, 10);
            this.btmTeste.Name = "btmTeste";
            this.btmTeste.Size = new System.Drawing.Size(75, 23);
            this.btmTeste.TabIndex = 3;
            this.btmTeste.Text = "Testar";
            this.btmTeste.UseVisualStyleBackColor = true;
            this.btmTeste.Click += new System.EventHandler(this.btmTeste_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1124, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(121, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(184, 10);
            this.readFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(75, 23);
            this.readFileButton.TabIndex = 5;
            this.readFileButton.Text = "Ler Arquivo";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(12, 12);
            this.fileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(168, 20);
            this.fileTextBox.TabIndex = 6;
            this.fileTextBox.TextChanged += new System.EventHandler(this.fileTextBox_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownWidth = 108;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(302, 11);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // biofeedbackCheckBox
            // 
            this.biofeedbackCheckBox.AutoSize = true;
            this.biofeedbackCheckBox.BackColor = System.Drawing.Color.Black;
            this.biofeedbackCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.biofeedbackCheckBox.Location = new System.Drawing.Point(412, 12);
            this.biofeedbackCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.biofeedbackCheckBox.Name = "biofeedbackCheckBox";
            this.biofeedbackCheckBox.Size = new System.Drawing.Size(86, 17);
            this.biofeedbackCheckBox.TabIndex = 10;
            this.biofeedbackCheckBox.Text = "Biofeedback";
            this.biofeedbackCheckBox.UseVisualStyleBackColor = false;
            this.biofeedbackCheckBox.CheckedChanged += new System.EventHandler(this.biofeedbackCheckBox_CheckedChanged);
            // 
            // FFTCheckBox
            // 
            this.FFTCheckBox.AutoSize = true;
            this.FFTCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FFTCheckBox.Location = new System.Drawing.Point(502, 12);
            this.FFTCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.FFTCheckBox.Name = "FFTCheckBox";
            this.FFTCheckBox.Size = new System.Drawing.Size(45, 17);
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
            this.btmPlay.Location = new System.Drawing.Point(660, 10);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(75, 23);
            this.btmPlay.TabIndex = 12;
            this.btmPlay.Text = "Play";
            this.btmPlay.UseVisualStyleBackColor = false;
            this.btmPlay.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(585, 11);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(69, 20);
            this.txtArquivo.TabIndex = 13;
            this.txtArquivo.Text = "Sinais";
            // 
            // formInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1260, 671);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.FFTCheckBox);
            this.Controls.Add(this.biofeedbackCheckBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btmTeste);
            this.Controls.Add(this.btmConectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formInterface";
            this.Text = "Interface EMG";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btmConectar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl graphCanais;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btmTeste;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ZedGraph.ZedGraphControl graphFFT;
        private ZedGraph.ZedGraphControl graphBars;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox biofeedbackCheckBox;
        private System.Windows.Forms.CheckBox FFTCheckBox;
        private System.Windows.Forms.Button btmPlay;
        private System.Windows.Forms.TextBox txtArquivo;
    }
}