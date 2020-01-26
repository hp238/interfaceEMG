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
            this.aba8Canais = new System.Windows.Forms.TabPage();
            this.btmTest = new System.Windows.Forms.Button();
            this.btmConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxCanal8 = new System.Windows.Forms.CheckBox();
            this.cbxCanal7 = new System.Windows.Forms.CheckBox();
            this.cbxCanal6 = new System.Windows.Forms.CheckBox();
            this.cbxCanal5 = new System.Windows.Forms.CheckBox();
            this.cbxCanal4 = new System.Windows.Forms.CheckBox();
            this.cbxCanal3 = new System.Windows.Forms.CheckBox();
            this.cbxCanal2 = new System.Windows.Forms.CheckBox();
            this.cbxCanal1 = new System.Windows.Forms.CheckBox();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmAdd = new System.Windows.Forms.Button();
            this.g8 = new ZedGraph.ZedGraphControl();
            this.g7 = new ZedGraph.ZedGraphControl();
            this.g6 = new ZedGraph.ZedGraphControl();
            this.g5 = new ZedGraph.ZedGraphControl();
            this.g4 = new ZedGraph.ZedGraphControl();
            this.g3 = new ZedGraph.ZedGraphControl();
            this.g2 = new ZedGraph.ZedGraphControl();
            this.g1 = new ZedGraph.ZedGraphControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.abaCanal1 = new System.Windows.Forms.TabPage();
            this.zedAba1 = new ZedGraph.ZedGraphControl();
            this.abaCanal2 = new System.Windows.Forms.TabPage();
            this.zedAba2 = new ZedGraph.ZedGraphControl();
            this.abaCanal3 = new System.Windows.Forms.TabPage();
            this.zedAba3 = new ZedGraph.ZedGraphControl();
            this.abaCanal4 = new System.Windows.Forms.TabPage();
            this.zedAba4 = new ZedGraph.ZedGraphControl();
            this.abaCanal5 = new System.Windows.Forms.TabPage();
            this.zedAba5 = new ZedGraph.ZedGraphControl();
            this.abaCanal6 = new System.Windows.Forms.TabPage();
            this.zedAba6 = new ZedGraph.ZedGraphControl();
            this.abaCanal7 = new System.Windows.Forms.TabPage();
            this.zedAba7 = new ZedGraph.ZedGraphControl();
            this.abaCanal8 = new System.Windows.Forms.TabPage();
            this.zedAba8 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.aba8Canais.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.abaCanal1.SuspendLayout();
            this.abaCanal2.SuspendLayout();
            this.abaCanal3.SuspendLayout();
            this.abaCanal4.SuspendLayout();
            this.abaCanal5.SuspendLayout();
            this.abaCanal6.SuspendLayout();
            this.abaCanal7.SuspendLayout();
            this.abaCanal8.SuspendLayout();
            this.SuspendLayout();
            // 
            // aba8Canais
            // 
            this.aba8Canais.Controls.Add(this.btmTest);
            this.aba8Canais.Controls.Add(this.btmConectar);
            this.aba8Canais.Controls.Add(this.comboBox1);
            this.aba8Canais.Controls.Add(this.cbxCanal8);
            this.aba8Canais.Controls.Add(this.cbxCanal7);
            this.aba8Canais.Controls.Add(this.cbxCanal6);
            this.aba8Canais.Controls.Add(this.cbxCanal5);
            this.aba8Canais.Controls.Add(this.cbxCanal4);
            this.aba8Canais.Controls.Add(this.cbxCanal3);
            this.aba8Canais.Controls.Add(this.cbxCanal2);
            this.aba8Canais.Controls.Add(this.cbxCanal1);
            this.aba8Canais.Controls.Add(this.btmLimpar);
            this.aba8Canais.Controls.Add(this.btmAdd);
            this.aba8Canais.Controls.Add(this.g8);
            this.aba8Canais.Controls.Add(this.g7);
            this.aba8Canais.Controls.Add(this.g6);
            this.aba8Canais.Controls.Add(this.g5);
            this.aba8Canais.Controls.Add(this.g4);
            this.aba8Canais.Controls.Add(this.g3);
            this.aba8Canais.Controls.Add(this.g2);
            this.aba8Canais.Controls.Add(this.g1);
            this.aba8Canais.Location = new System.Drawing.Point(4, 22);
            this.aba8Canais.Name = "aba8Canais";
            this.aba8Canais.Padding = new System.Windows.Forms.Padding(3);
            this.aba8Canais.Size = new System.Drawing.Size(1232, 794);
            this.aba8Canais.TabIndex = 0;
            this.aba8Canais.Text = "8 CANAIS";
            this.aba8Canais.UseVisualStyleBackColor = true;
            // 
            // btmTest
            // 
            this.btmTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btmTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmTest.Location = new System.Drawing.Point(709, 1);
            this.btmTest.Name = "btmTest";
            this.btmTest.Size = new System.Drawing.Size(107, 22);
            this.btmTest.TabIndex = 18;
            this.btmTest.Text = "Testar";
            this.btmTest.UseVisualStyleBackColor = true;
            this.btmTest.Click += new System.EventHandler(this.btmTest_Click);
            // 
            // btmConectar
            // 
            this.btmConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btmConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmConectar.Location = new System.Drawing.Point(1119, 3);
            this.btmConectar.Name = "btmConectar";
            this.btmConectar.Size = new System.Drawing.Size(107, 22);
            this.btmConectar.TabIndex = 17;
            this.btmConectar.Text = "Conectar";
            this.btmConectar.UseVisualStyleBackColor = true;
            this.btmConectar.Click += new System.EventHandler(this.btmConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(991, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // cbxCanal8
            // 
            this.cbxCanal8.AutoSize = true;
            this.cbxCanal8.Location = new System.Drawing.Point(3, 774);
            this.cbxCanal8.Name = "cbxCanal8";
            this.cbxCanal8.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal8.TabIndex = 15;
            this.cbxCanal8.UseVisualStyleBackColor = true;
            // 
            // cbxCanal7
            // 
            this.cbxCanal7.AutoSize = true;
            this.cbxCanal7.Location = new System.Drawing.Point(3, 679);
            this.cbxCanal7.Name = "cbxCanal7";
            this.cbxCanal7.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal7.TabIndex = 14;
            this.cbxCanal7.UseVisualStyleBackColor = true;
            // 
            // cbxCanal6
            // 
            this.cbxCanal6.AutoSize = true;
            this.cbxCanal6.Location = new System.Drawing.Point(3, 584);
            this.cbxCanal6.Name = "cbxCanal6";
            this.cbxCanal6.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal6.TabIndex = 13;
            this.cbxCanal6.UseVisualStyleBackColor = true;
            // 
            // cbxCanal5
            // 
            this.cbxCanal5.AutoSize = true;
            this.cbxCanal5.Location = new System.Drawing.Point(3, 489);
            this.cbxCanal5.Name = "cbxCanal5";
            this.cbxCanal5.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal5.TabIndex = 12;
            this.cbxCanal5.UseVisualStyleBackColor = true;
            // 
            // cbxCanal4
            // 
            this.cbxCanal4.AutoSize = true;
            this.cbxCanal4.Location = new System.Drawing.Point(3, 394);
            this.cbxCanal4.Name = "cbxCanal4";
            this.cbxCanal4.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal4.TabIndex = 11;
            this.cbxCanal4.UseVisualStyleBackColor = true;
            // 
            // cbxCanal3
            // 
            this.cbxCanal3.AutoSize = true;
            this.cbxCanal3.Location = new System.Drawing.Point(3, 299);
            this.cbxCanal3.Name = "cbxCanal3";
            this.cbxCanal3.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal3.TabIndex = 10;
            this.cbxCanal3.UseVisualStyleBackColor = true;
            // 
            // cbxCanal2
            // 
            this.cbxCanal2.AutoSize = true;
            this.cbxCanal2.Location = new System.Drawing.Point(3, 204);
            this.cbxCanal2.Name = "cbxCanal2";
            this.cbxCanal2.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal2.TabIndex = 9;
            this.cbxCanal2.UseVisualStyleBackColor = true;
            // 
            // cbxCanal1
            // 
            this.cbxCanal1.AutoSize = true;
            this.cbxCanal1.Location = new System.Drawing.Point(3, 109);
            this.cbxCanal1.Name = "cbxCanal1";
            this.cbxCanal1.Size = new System.Drawing.Size(15, 14);
            this.cbxCanal1.TabIndex = 8;
            this.cbxCanal1.UseVisualStyleBackColor = true;
            // 
            // btmLimpar
            // 
            this.btmLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btmLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLimpar.Location = new System.Drawing.Point(116, 6);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(107, 22);
            this.btmLimpar.TabIndex = 7;
            this.btmLimpar.Text = "Limpar Abas";
            this.btmLimpar.UseVisualStyleBackColor = true;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click_1);
            // 
            // btmAdd
            // 
            this.btmAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btmAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAdd.Location = new System.Drawing.Point(3, 6);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(107, 22);
            this.btmAdd.TabIndex = 6;
            this.btmAdd.Text = "Add Abas";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // g8
            // 
            this.g8.Location = new System.Drawing.Point(0, 696);
            this.g8.Margin = new System.Windows.Forms.Padding(0);
            this.g8.Name = "g8";
            this.g8.ScrollGrace = 0D;
            this.g8.ScrollMaxX = 0D;
            this.g8.ScrollMaxY = 0D;
            this.g8.ScrollMaxY2 = 0D;
            this.g8.ScrollMinX = 0D;
            this.g8.ScrollMinY = 0D;
            this.g8.ScrollMinY2 = 0D;
            this.g8.Size = new System.Drawing.Size(1240, 95);
            this.g8.TabIndex = 5;
            this.g8.UseExtendedPrintDialog = true;
            // 
            // g7
            // 
            this.g7.Location = new System.Drawing.Point(0, 601);
            this.g7.Margin = new System.Windows.Forms.Padding(0);
            this.g7.Name = "g7";
            this.g7.ScrollGrace = 0D;
            this.g7.ScrollMaxX = 0D;
            this.g7.ScrollMaxY = 0D;
            this.g7.ScrollMaxY2 = 0D;
            this.g7.ScrollMinX = 0D;
            this.g7.ScrollMinY = 0D;
            this.g7.ScrollMinY2 = 0D;
            this.g7.Size = new System.Drawing.Size(1240, 95);
            this.g7.TabIndex = 4;
            this.g7.UseExtendedPrintDialog = true;
            // 
            // g6
            // 
            this.g6.Location = new System.Drawing.Point(0, 506);
            this.g6.Margin = new System.Windows.Forms.Padding(0);
            this.g6.Name = "g6";
            this.g6.ScrollGrace = 0D;
            this.g6.ScrollMaxX = 0D;
            this.g6.ScrollMaxY = 0D;
            this.g6.ScrollMaxY2 = 0D;
            this.g6.ScrollMinX = 0D;
            this.g6.ScrollMinY = 0D;
            this.g6.ScrollMinY2 = 0D;
            this.g6.Size = new System.Drawing.Size(1240, 95);
            this.g6.TabIndex = 3;
            this.g6.UseExtendedPrintDialog = true;
            // 
            // g5
            // 
            this.g5.Location = new System.Drawing.Point(0, 411);
            this.g5.Margin = new System.Windows.Forms.Padding(0);
            this.g5.Name = "g5";
            this.g5.ScrollGrace = 0D;
            this.g5.ScrollMaxX = 0D;
            this.g5.ScrollMaxY = 0D;
            this.g5.ScrollMaxY2 = 0D;
            this.g5.ScrollMinX = 0D;
            this.g5.ScrollMinY = 0D;
            this.g5.ScrollMinY2 = 0D;
            this.g5.Size = new System.Drawing.Size(1240, 95);
            this.g5.TabIndex = 2;
            this.g5.UseExtendedPrintDialog = true;
            // 
            // g4
            // 
            this.g4.Location = new System.Drawing.Point(0, 316);
            this.g4.Margin = new System.Windows.Forms.Padding(0);
            this.g4.Name = "g4";
            this.g4.ScrollGrace = 0D;
            this.g4.ScrollMaxX = 0D;
            this.g4.ScrollMaxY = 0D;
            this.g4.ScrollMaxY2 = 0D;
            this.g4.ScrollMinX = 0D;
            this.g4.ScrollMinY = 0D;
            this.g4.ScrollMinY2 = 0D;
            this.g4.Size = new System.Drawing.Size(1240, 95);
            this.g4.TabIndex = 1;
            this.g4.UseExtendedPrintDialog = true;
            // 
            // g3
            // 
            this.g3.Location = new System.Drawing.Point(0, 221);
            this.g3.Margin = new System.Windows.Forms.Padding(0);
            this.g3.Name = "g3";
            this.g3.ScrollGrace = 0D;
            this.g3.ScrollMaxX = 0D;
            this.g3.ScrollMaxY = 0D;
            this.g3.ScrollMaxY2 = 0D;
            this.g3.ScrollMinX = 0D;
            this.g3.ScrollMinY = 0D;
            this.g3.ScrollMinY2 = 0D;
            this.g3.Size = new System.Drawing.Size(1240, 95);
            this.g3.TabIndex = 0;
            this.g3.UseExtendedPrintDialog = true;
            // 
            // g2
            // 
            this.g2.Location = new System.Drawing.Point(0, 126);
            this.g2.Margin = new System.Windows.Forms.Padding(0);
            this.g2.Name = "g2";
            this.g2.ScrollGrace = 0D;
            this.g2.ScrollMaxX = 0D;
            this.g2.ScrollMaxY = 0D;
            this.g2.ScrollMaxY2 = 0D;
            this.g2.ScrollMinX = 0D;
            this.g2.ScrollMinY = 0D;
            this.g2.ScrollMinY2 = 0D;
            this.g2.Size = new System.Drawing.Size(1240, 95);
            this.g2.TabIndex = 0;
            this.g2.UseExtendedPrintDialog = true;
            // 
            // g1
            // 
            this.g1.Location = new System.Drawing.Point(0, 31);
            this.g1.Margin = new System.Windows.Forms.Padding(0);
            this.g1.Name = "g1";
            this.g1.ScrollGrace = 0D;
            this.g1.ScrollMaxX = 0D;
            this.g1.ScrollMaxY = 0D;
            this.g1.ScrollMaxY2 = 0D;
            this.g1.ScrollMinX = 0D;
            this.g1.ScrollMinY = 0D;
            this.g1.ScrollMinY2 = 0D;
            this.g1.Size = new System.Drawing.Size(1240, 95);
            this.g1.TabIndex = 0;
            this.g1.UseExtendedPrintDialog = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.Controls.Add(this.aba8Canais);
            this.tabControl1.Controls.Add(this.abaCanal1);
            this.tabControl1.Controls.Add(this.abaCanal2);
            this.tabControl1.Controls.Add(this.abaCanal3);
            this.tabControl1.Controls.Add(this.abaCanal4);
            this.tabControl1.Controls.Add(this.abaCanal5);
            this.tabControl1.Controls.Add(this.abaCanal6);
            this.tabControl1.Controls.Add(this.abaCanal7);
            this.tabControl1.Controls.Add(this.abaCanal8);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 820);
            this.tabControl1.TabIndex = 0;
            // 
            // abaCanal1
            // 
            this.abaCanal1.Controls.Add(this.zedAba1);
            this.abaCanal1.Location = new System.Drawing.Point(4, 22);
            this.abaCanal1.Name = "abaCanal1";
            this.abaCanal1.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal1.TabIndex = 1;
            this.abaCanal1.Text = "Canal 1";
            this.abaCanal1.UseVisualStyleBackColor = true;
            // 
            // zedAba1
            // 
            this.zedAba1.EditButtons = System.Windows.Forms.MouseButtons.Middle;
            this.zedAba1.Location = new System.Drawing.Point(15, 4);
            this.zedAba1.Name = "zedAba1";
            this.zedAba1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.zedAba1.ScrollGrace = 0D;
            this.zedAba1.ScrollMaxX = 0D;
            this.zedAba1.ScrollMaxY = 0D;
            this.zedAba1.ScrollMaxY2 = 0D;
            this.zedAba1.ScrollMinX = 0D;
            this.zedAba1.ScrollMinY = 0D;
            this.zedAba1.ScrollMinY2 = 0D;
            this.zedAba1.Size = new System.Drawing.Size(1234, 794);
            this.zedAba1.TabIndex = 0;
            this.zedAba1.UseExtendedPrintDialog = true;
            // 
            // abaCanal2
            // 
            this.abaCanal2.Controls.Add(this.zedAba2);
            this.abaCanal2.Location = new System.Drawing.Point(4, 22);
            this.abaCanal2.Name = "abaCanal2";
            this.abaCanal2.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal2.TabIndex = 2;
            this.abaCanal2.Text = "Canal 2";
            this.abaCanal2.UseVisualStyleBackColor = true;
            // 
            // zedAba2
            // 
            this.zedAba2.Location = new System.Drawing.Point(0, 3);
            this.zedAba2.Name = "zedAba2";
            this.zedAba2.ScrollGrace = 0D;
            this.zedAba2.ScrollMaxX = 0D;
            this.zedAba2.ScrollMaxY = 0D;
            this.zedAba2.ScrollMaxY2 = 0D;
            this.zedAba2.ScrollMinX = 0D;
            this.zedAba2.ScrollMinY = 0D;
            this.zedAba2.ScrollMinY2 = 0D;
            this.zedAba2.Size = new System.Drawing.Size(1234, 794);
            this.zedAba2.TabIndex = 0;
            this.zedAba2.UseExtendedPrintDialog = true;
            // 
            // abaCanal3
            // 
            this.abaCanal3.Controls.Add(this.zedAba3);
            this.abaCanal3.Location = new System.Drawing.Point(4, 22);
            this.abaCanal3.Name = "abaCanal3";
            this.abaCanal3.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal3.TabIndex = 3;
            this.abaCanal3.Text = "Canal 3";
            this.abaCanal3.UseVisualStyleBackColor = true;
            // 
            // zedAba3
            // 
            this.zedAba3.Location = new System.Drawing.Point(3, 3);
            this.zedAba3.Name = "zedAba3";
            this.zedAba3.ScrollGrace = 0D;
            this.zedAba3.ScrollMaxX = 0D;
            this.zedAba3.ScrollMaxY = 0D;
            this.zedAba3.ScrollMaxY2 = 0D;
            this.zedAba3.ScrollMinX = 0D;
            this.zedAba3.ScrollMinY = 0D;
            this.zedAba3.ScrollMinY2 = 0D;
            this.zedAba3.Size = new System.Drawing.Size(1234, 794);
            this.zedAba3.TabIndex = 0;
            this.zedAba3.UseExtendedPrintDialog = true;
            // 
            // abaCanal4
            // 
            this.abaCanal4.Controls.Add(this.zedAba4);
            this.abaCanal4.Location = new System.Drawing.Point(4, 22);
            this.abaCanal4.Name = "abaCanal4";
            this.abaCanal4.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal4.TabIndex = 4;
            this.abaCanal4.Text = "Canal 4";
            this.abaCanal4.UseVisualStyleBackColor = true;
            // 
            // zedAba4
            // 
            this.zedAba4.Location = new System.Drawing.Point(0, 3);
            this.zedAba4.Name = "zedAba4";
            this.zedAba4.ScrollGrace = 0D;
            this.zedAba4.ScrollMaxX = 0D;
            this.zedAba4.ScrollMaxY = 0D;
            this.zedAba4.ScrollMaxY2 = 0D;
            this.zedAba4.ScrollMinX = 0D;
            this.zedAba4.ScrollMinY = 0D;
            this.zedAba4.ScrollMinY2 = 0D;
            this.zedAba4.Size = new System.Drawing.Size(1234, 794);
            this.zedAba4.TabIndex = 0;
            this.zedAba4.UseExtendedPrintDialog = true;
            // 
            // abaCanal5
            // 
            this.abaCanal5.Controls.Add(this.zedAba5);
            this.abaCanal5.Location = new System.Drawing.Point(4, 22);
            this.abaCanal5.Name = "abaCanal5";
            this.abaCanal5.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal5.TabIndex = 5;
            this.abaCanal5.Text = "Canal 5";
            this.abaCanal5.UseVisualStyleBackColor = true;
            // 
            // zedAba5
            // 
            this.zedAba5.Location = new System.Drawing.Point(3, 3);
            this.zedAba5.Name = "zedAba5";
            this.zedAba5.ScrollGrace = 0D;
            this.zedAba5.ScrollMaxX = 0D;
            this.zedAba5.ScrollMaxY = 0D;
            this.zedAba5.ScrollMaxY2 = 0D;
            this.zedAba5.ScrollMinX = 0D;
            this.zedAba5.ScrollMinY = 0D;
            this.zedAba5.ScrollMinY2 = 0D;
            this.zedAba5.Size = new System.Drawing.Size(1234, 794);
            this.zedAba5.TabIndex = 0;
            this.zedAba5.UseExtendedPrintDialog = true;
            // 
            // abaCanal6
            // 
            this.abaCanal6.Controls.Add(this.zedAba6);
            this.abaCanal6.Location = new System.Drawing.Point(4, 22);
            this.abaCanal6.Name = "abaCanal6";
            this.abaCanal6.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal6.TabIndex = 6;
            this.abaCanal6.Text = "Canal 6";
            this.abaCanal6.UseVisualStyleBackColor = true;
            // 
            // zedAba6
            // 
            this.zedAba6.Location = new System.Drawing.Point(3, 3);
            this.zedAba6.Name = "zedAba6";
            this.zedAba6.ScrollGrace = 0D;
            this.zedAba6.ScrollMaxX = 0D;
            this.zedAba6.ScrollMaxY = 0D;
            this.zedAba6.ScrollMaxY2 = 0D;
            this.zedAba6.ScrollMinX = 0D;
            this.zedAba6.ScrollMinY = 0D;
            this.zedAba6.ScrollMinY2 = 0D;
            this.zedAba6.Size = new System.Drawing.Size(1234, 794);
            this.zedAba6.TabIndex = 0;
            this.zedAba6.UseExtendedPrintDialog = true;
            // 
            // abaCanal7
            // 
            this.abaCanal7.Controls.Add(this.zedAba7);
            this.abaCanal7.Location = new System.Drawing.Point(4, 22);
            this.abaCanal7.Name = "abaCanal7";
            this.abaCanal7.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal7.TabIndex = 7;
            this.abaCanal7.Text = "Canal 7";
            this.abaCanal7.UseVisualStyleBackColor = true;
            // 
            // zedAba7
            // 
            this.zedAba7.Location = new System.Drawing.Point(3, 3);
            this.zedAba7.Name = "zedAba7";
            this.zedAba7.ScrollGrace = 0D;
            this.zedAba7.ScrollMaxX = 0D;
            this.zedAba7.ScrollMaxY = 0D;
            this.zedAba7.ScrollMaxY2 = 0D;
            this.zedAba7.ScrollMinX = 0D;
            this.zedAba7.ScrollMinY = 0D;
            this.zedAba7.ScrollMinY2 = 0D;
            this.zedAba7.Size = new System.Drawing.Size(1234, 794);
            this.zedAba7.TabIndex = 0;
            this.zedAba7.UseExtendedPrintDialog = true;
            // 
            // abaCanal8
            // 
            this.abaCanal8.Controls.Add(this.zedAba8);
            this.abaCanal8.Location = new System.Drawing.Point(4, 22);
            this.abaCanal8.Name = "abaCanal8";
            this.abaCanal8.Size = new System.Drawing.Size(1232, 794);
            this.abaCanal8.TabIndex = 8;
            this.abaCanal8.Text = "Canal 8";
            this.abaCanal8.UseVisualStyleBackColor = true;
            // 
            // zedAba8
            // 
            this.zedAba8.Location = new System.Drawing.Point(3, 3);
            this.zedAba8.Name = "zedAba8";
            this.zedAba8.ScrollGrace = 0D;
            this.zedAba8.ScrollMaxX = 0D;
            this.zedAba8.ScrollMaxY = 0D;
            this.zedAba8.ScrollMaxY2 = 0D;
            this.zedAba8.ScrollMinX = 0D;
            this.zedAba8.ScrollMinY = 0D;
            this.zedAba8.ScrollMinY2 = 0D;
            this.zedAba8.Size = new System.Drawing.Size(1234, 794);
            this.zedAba8.TabIndex = 0;
            this.zedAba8.UseExtendedPrintDialog = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 811);
            this.Controls.Add(this.tabControl1);
            this.Name = "formInterface";
            this.Text = "Interface EMG";
            this.aba8Canais.ResumeLayout(false);
            this.aba8Canais.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.abaCanal1.ResumeLayout(false);
            this.abaCanal2.ResumeLayout(false);
            this.abaCanal3.ResumeLayout(false);
            this.abaCanal4.ResumeLayout(false);
            this.abaCanal5.ResumeLayout(false);
            this.abaCanal6.ResumeLayout(false);
            this.abaCanal7.ResumeLayout(false);
            this.abaCanal8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ZedGraph.ZedGraphControl g8;
        private ZedGraph.ZedGraphControl g7;
        private ZedGraph.ZedGraphControl g6;
        private ZedGraph.ZedGraphControl g5;
        private ZedGraph.ZedGraphControl g4;
        private ZedGraph.ZedGraphControl g3;
        private ZedGraph.ZedGraphControl g2;
        private ZedGraph.ZedGraphControl g1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbxCanal2;
        private System.Windows.Forms.CheckBox cbxCanal1;
        private System.Windows.Forms.CheckBox cbxCanal8;
        private System.Windows.Forms.CheckBox cbxCanal7;
        private System.Windows.Forms.CheckBox cbxCanal6;
        private System.Windows.Forms.CheckBox cbxCanal5;
        private System.Windows.Forms.CheckBox cbxCanal4;
        private System.Windows.Forms.CheckBox cbxCanal3;
        private System.Windows.Forms.TabPage abaCanal1;
        private System.Windows.Forms.TabPage abaCanal2;
        private ZedGraph.ZedGraphControl zedAba1;
        private System.Windows.Forms.TabPage abaCanal3;
        private System.Windows.Forms.TabPage abaCanal4;
        private System.Windows.Forms.TabPage abaCanal5;
        private System.Windows.Forms.TabPage abaCanal6;
        private System.Windows.Forms.TabPage abaCanal7;
        private System.Windows.Forms.TabPage abaCanal8;
        private System.Windows.Forms.TabPage aba8Canais;
        private ZedGraph.ZedGraphControl zedAba2;
        private ZedGraph.ZedGraphControl zedAba3;
        private ZedGraph.ZedGraphControl zedAba4;
        private ZedGraph.ZedGraphControl zedAba5;
        private ZedGraph.ZedGraphControl zedAba6;
        private ZedGraph.ZedGraphControl zedAba7;
        private ZedGraph.ZedGraphControl zedAba8;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btmConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btmTest;
    }
}

