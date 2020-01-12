namespace interfaceEMG
{
    partial class box1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(12, 27);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(62, 17);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Canal 1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione os gráficos que deseja abrir:";
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Location = new System.Drawing.Point(111, 96);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(62, 17);
            this.cb8.TabIndex = 2;
            this.cb8.Text = "Canal 8";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Location = new System.Drawing.Point(111, 73);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(62, 17);
            this.cb7.TabIndex = 3;
            this.cb7.Text = "Canal 7";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Location = new System.Drawing.Point(111, 50);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(62, 17);
            this.cb6.TabIndex = 4;
            this.cb6.Text = "Canal 6";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(111, 27);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(62, 17);
            this.cb5.TabIndex = 5;
            this.cb5.Text = "Canal 5";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(12, 96);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(62, 17);
            this.cb4.TabIndex = 6;
            this.cb4.Text = "Canal 4";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(12, 73);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(62, 17);
            this.cb3.TabIndex = 7;
            this.cb3.Text = "Canal 3";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(12, 50);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(62, 17);
            this.cb2.TabIndex = 8;
            this.cb2.Text = "Canal 2";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 129);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 9;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(111, 129);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // box1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 172);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cb7);
            this.Controls.Add(this.cb8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb1);
            this.Name = "box1";
            this.Text = "Abas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btCancelar;
    }
}