using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using DocumentFormat.OpenXml.Spreadsheet;

namespace interfaceEMG
{
    public partial class formInterface : Form
    {

        private Boolean[] estado = new Boolean[8];
        static int tamanho = 600; //tamanho do vetor de teste
        double[] x = new double[tamanho]; //eixo x

        //eixo y dos 8 canais
        Dictionary<int, Double[]> sinais = new Dictionary<int, double[]>();
        private Dictionary<int, ZedGraph.ZedGraphControl> zedSinais;

        //TESTE

        private readonly Timer timer = new Timer();

        //private TabControl tabControl1;

        private void gerarCurvas()
        {
            //código para sortear os valores de Y dos 8 canais
            Random numAl = new Random();

            for(int y = 1; y<=8; y++)
            {
                Double[] aux = new double[tamanho];
                for(int i = 0; i < tamanho; i++)
                {
                    x[i] = i;
                    aux[i] = numAl.Next(1, 101);
                }
                sinais.Add(y, aux);
                

            }
        }
        //SerialPort serialPort1
        public formInterface(SerialPort serialPort1)
        {
            InitializeComponent();
            
           // serialPort1.ReadExisting();
            gerarCurvas();

            zedSinais = new Dictionary<int, ZedGraph.ZedGraphControl>()
            {
                {1,g1 },
                {2,g2 },
                {3,g3 },
                {4,g4 },
                {5,g5 },
                {6,g6 },
                {7,g7 },
                {8,g8 }
            };

            //plot cada canal
            for (int i = 1; i <= 8; i++)
            {
                this.configurarCurvas(zedSinais[i],1, sinais[i],x,false);
            }

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
                novaAba(sinais[1], c1);
                aux = true;
            }
            if (cbCanal2.Checked)
            {
                novaAba(sinais[2], c2);
                aux = true;
            }
            if (cbCanal3.Checked)
            {
                novaAba(sinais[3], c3);
                aux = true;
            }
            if (cbCanal4.Checked)
            {
                novaAba(sinais[4], c4);
                aux = true;
            }
            if (cbCanal5.Checked)
            {
                novaAba(sinais[5], c5);
                aux = true;
            }
            if (cbCanal6.Checked)
            {
                novaAba(sinais[6], c6);
                aux = true;
            }
            if (cbCanal7.Checked)
            {
                novaAba(sinais[7], c7);
                aux = true;
            }
            if (cbCanal8.Checked)
            {
                novaAba(sinais[8], c8);
                aux = true;
            }
            if (aux == false)
            {
                MessageBox.Show("Nenhum checkbox foi marcado.");
            }
            
        }

        //botão para remover todas as abas adicionadas
        //EM TESTE
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(canaisTab);
        }


        //b false -> 8 canais
        //b true -> 1 canal
        private void configurarCurvas(ZedGraph.ZedGraphControl gx, int n, double[] yx, double[] xx, Boolean b)
        {
            gx.GraphPane.AddCurve("minha curva", xx, yx, System.Drawing.Color.Black, ZedGraph.SymbolType.None);
            if(b == false)
            {
                gx.GraphPane.XAxis.IsVisible = false;
                gx.GraphPane.Title.IsVisible = false;
                gx.GraphPane.YAxis.Title.FontSpec.Size = 50;
                gx.GraphPane.YAxis.Title.Text = "Sinal " + n;
                gx.GraphPane.Legend.IsVisible = false;
                gx.GraphPane.AxisChange();
            }
            else
            {
                gx.GraphPane.YAxis.Title.Text = "Sinal " + n;
                gx.GraphPane.YAxis.Scale.Min = yx.Min()-10;
                gx.GraphPane.YAxis.Scale.Max = yx.Max()+10;
                gx.GraphPane.AxisChange();
            }
            gx.Refresh();
        }

        //nova aba
        private void novaAba(double[] yx, TabPage c)
        {
            String test = c.Name.Substring(1);
            int n = Int16.Parse(test);
            tabControl1.TabPages.Add(c);
            configurarCurvas(aba1Graph, n, yx, x, true);
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
