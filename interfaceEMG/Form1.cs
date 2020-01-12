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
    public partial class Form1 : Form
    {
        
        static int tamanho = 1500;
        //eixo x
        double[] x = new double[tamanho];
        //eixo y dos 8 canais
        double[] y1 = new double[tamanho];
        double[] y2 = new double[tamanho];
        double[] y3 = new double[tamanho];
        double[] y4 = new double[tamanho];
        double[] y5 = new double[tamanho];
        double[] y6 = new double[tamanho];
        double[] y7 = new double[tamanho];
        double[] y8 = new double[tamanho];
        //TESTE
        bool[] b = new bool[8];

        //private TabControl tabControl1;

        public Form1()
        {
            InitializeComponent();
            //código para sortear os valores de Y dos 8 canais
            Random numAl = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                x[i] = i;
                y1[i] = numAl.Next(1, 101);
                y2[i] = numAl.Next(1, 101);
                y3[i] = numAl.Next(1, 101);
                y4[i] = numAl.Next(1, 101);
                y5[i] = numAl.Next(1, 101);
                y6[i] = numAl.Next(1, 101);
                y7[i] = numAl.Next(1, 101);
                y8[i] = numAl.Next(1, 101);
            }

            //plot cada canal
            this.configurarCurvas(g1, 1, y1, x);
            this.configurarCurvas(g2, 2, y2, x);
            this.configurarCurvas(g3, 3, y3, x);
            this.configurarCurvas(g4, 4, y4, x);
            this.configurarCurvas(g5, 5, y5, x);
            this.configurarCurvas(g6, 6, y6, x);
            this.configurarCurvas(g7, 7, y7, x);
            this.configurarCurvas(g8, 8, y8, x);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void configurarCurvas(ZedGraph.ZedGraphControl gx, int n, double[] yx, double[] xx)
        {
            gx.GraphPane.AddCurve("minha curva", xx, yx, Color.Black, ZedGraph.SymbolType.None);
            gx.GraphPane.XAxis.IsVisible = false;
            gx.GraphPane.Title.IsVisible = false;
            gx.GraphPane.YAxis.Title.FontSpec.Size = 50;
            gx.GraphPane.YAxis.Title.Text = "Sinal "+n;
            gx.GraphPane.AxisChange();
            gx.GraphPane.Legend.IsVisible = false;

            gx.Refresh();
        }

       


        //botão para adicionar novas abas
        //EM TESTE
        private void button1_Click_1(object sender, EventArgs e)
        {
            box1 tb = new box1();
            tb.Show();

            //if()
            /*
            //b = tb.canaisSelecionados();
            b[0] = tb.g1;
            
            if (b[0] == true)
            {
                MessageBox.Show("TRUE");
            }
            else
            {
                MessageBox.Show("FALSE");
            }
            */
        }

        //botão para remover todas as abas adicionadas
        //EM TESTE
        private void button2_Click(object sender, EventArgs e)
        {
            if (b[0] == true)
            {
                MessageBox.Show("TRUE");
            }
            else
            {
                MessageBox.Show("FALSE");
            }
        }

        //TESTES

        private void g1_Load_1(object sender, EventArgs e)
        {
            TabPage canal1Tab = new TabPage();
            canal1Tab.Text = "Nova Guia";
            tabControl2.TabPages.Add(canal1Tab);
            tabControl2.SelectTab(canal1Tab);

            ZedGraph.ZedGraphControl gn = new ZedGraph.ZedGraphControl();
            gn.Refresh();


        }

        private void g1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is definitely called");
            box1 g1Jan = new box1();
            g1Jan.Show();
        }


    }
}
