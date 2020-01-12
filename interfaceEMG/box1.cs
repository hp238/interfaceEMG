using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceEMG
{
    public partial class box1 : Form
    {
        public Boolean g1 = false,g2= false, g3= false, g4 = false, g5 = false, g6 = false, g7 = false, g8 = false;

        public box1(bool[] b = null)
        {
            InitializeComponent();
        }

        //Botão para adicionar canais
        //EM TESTE
        private void button1_Click(object sender, EventArgs e)
        {
            //salvando estado dos canais
            g1 = cb1.Checked;
            g2 = cb2.Checked;
            g3 = cb3.Checked;
            g4 = cb4.Checked;
            g5 = cb5.Checked;
            g6 = cb6.Checked;
            g7 = cb7.Checked;
            g8 = cb8.Checked;

            this.Close();
        }

        //botão para cancelar a ação
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //função para retornar os valores dos canais selecionados
        //EM TESTE
        public bool[] canaisSelecionados()
        {
            bool[] b = new bool[8];
            b[0] = g1;
            b[1] = g2;
            b[2] = g3;
            b[3] = g4;
            b[4] = g5;
            b[5] = g6;
            b[6] = g7;
            b[7] = g8;

            return b;
            
        }

    }
}
