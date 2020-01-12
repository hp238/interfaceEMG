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
        
        static int tamanho = 2000;
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

        private readonly Timer timer = new Timer();

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
            this.configurarCurvas(g1, 1, y1, x, false);
            this.configurarCurvas(g2, 2, y2, x, false);
            this.configurarCurvas(g3, 3, y3, x, false);
            this.configurarCurvas(g4, 4, y4, x, false);
            this.configurarCurvas(g5, 5, y5, x, false);
            this.configurarCurvas(g6, 6, y6, x, false);
            this.configurarCurvas(g7, 7, y7, x, false);
            this.configurarCurvas(g8, 8, y8, x, false);

            tabControl1.TabPages.Remove(c1);
            tabControl1.TabPages.Remove(c2);
            tabControl1.TabPages.Remove(c3);
            tabControl1.TabPages.Remove(c4);
            tabControl1.TabPages.Remove(c5);
            tabControl1.TabPages.Remove(c6);
            tabControl1.TabPages.Remove(c7);
            tabControl1.TabPages.Remove(c8);


        }







        //botão para adicionar novas abas
        //EM TESTE
        private void button1_Click_1(object sender, EventArgs e)
        {
            //variável para avaliar se nenhum box foi marcado
            Boolean aux = false;
            //verificando cada checkbox
            if (cbCanal1.Checked)
            {
                novaAba(y1,c1);
                aux = true;
            }
            if (cbCanal2.Checked)
            {
                novaAba(y2,c2);
                aux = true;
            }
            if (cbCanal3.Checked)
            {
                novaAba(y3,c3);
                aux = true;
            }
            if (cbCanal4.Checked)
            {
                novaAba(y4,c4);
                aux = true;
            }
            if (cbCanal5.Checked)
            {
                novaAba(y5,c5);
                aux = true;
            }
            if (cbCanal6.Checked)
            {
                novaAba(y6, c6);
                aux = true;
            }
            if (cbCanal7.Checked)
            {
                novaAba(y7, c7);
                aux = true;
            }
            if (cbCanal8.Checked)
            {
                novaAba(y8, c8);
                aux = true;
            }
            if (aux == false)
            {
                MessageBox.Show("Nenhum checkbox foi marcado.");
            }
            /* objForm?.Close();
             objForm = new box1
             {
                 TopLevel = false,
                 FormBorderStyle = FormBorderStyle.None,
                 Dock = DockStyle.Fill
             };
             */
            //Form1.CheckForIllegalCrossThreadCalls();
            //box1 tb = new box1();
            //tb.Show();
            //System.Threading.Tasks.Task.Delay(5000);
            //timer.Stop();
            //System.Threading.Thread.Sleep(1000);
            
            
            //if()
            
            //b = tb.canaisSelecionados();
            /*
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
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(canaisTab);
        }



        private void configurarCurvas(ZedGraph.ZedGraphControl gx, int n, double[] yx, double[] xx, Boolean b)
        {

            gx.GraphPane.AddCurve("minha curva", xx, yx, Color.Black, ZedGraph.SymbolType.None);
            
            if(b == false)
            {
                gx.GraphPane.XAxis.IsVisible = false;
                gx.GraphPane.Title.IsVisible = false;
                gx.GraphPane.YAxis.Title.FontSpec.Size = 50;
                gx.GraphPane.YAxis.Title.Text = "Sinal " + n;
                gx.GraphPane.Legend.IsVisible = false;
            }
            else
            {
                gx.GraphPane.YAxis.Title.Text = "Sinal " + n;
            }
            
            gx.GraphPane.AxisChange();
            

            gx.Refresh();
        }

        //nova aba
        private void novaAba(double[] yx, TabPage c)
        {
            String test = c.Name.Substring(1);
            int n = Int16.Parse(test);
            //string test2 = test.Substring(1);
            //MessageBox.Show(test2);

            tabControl1.TabPages.Add(c);
            configurarCurvas(aba1Graph, n, yx, x, true);

            /*
            aba1Graph.GraphPane.AddCurve(yx);
            aba1Graph.Refresh();
            */
            //String[] nome = new string[1];
            
            /*
            String nome = gx.Name;
            TabPage nTab = new TabPage();
            nTab.Text = nome;
            tabControl1.TabPages.Add(nTab);
            tabControl1.SelectTab(nTab);

            gx.Refresh();
            */
            //MessageBox.Show(nome);
        }

        //TESTES

        private void g1_Load_1(object sender, EventArgs e)
        {
            TabPage canal1Tab = new TabPage();
            canal1Tab.Text = "Nova Guia";
            tabControl1.TabPages.Add(canal1Tab);
            tabControl1.SelectTab(canal1Tab);

            ZedGraph.ZedGraphControl gn = new ZedGraph.ZedGraphControl();
            gn.Refresh();


        }

        private void g1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is definitely called");
            //box1 g1Jan = new box1();
            //g1Jan.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
