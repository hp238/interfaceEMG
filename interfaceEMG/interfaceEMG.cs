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
        private double[] x = new double[tamanho]; //eixo x

        
        private Dictionary<int, Double[]> sinais = new Dictionary<int, double[]>(); //eixo y dos 8 canais
        private Dictionary<int, ZedGraph.ZedGraphControl> zedSinais;    //zedgraph dos 8 canais
        private Dictionary<int, ZedGraph.ZedGraphControl> zedCanais;    //zedgraph de cada aba
        private Dictionary<int, CheckBox> cbxCanais;    //checkbox de cana canal
        private Dictionary<int, TabPage> tabCanais;     //tab de cada canal
        //private SerialPort serialPort1;
        int valor;

        //TESTE
        private readonly Timer timer = new Timer();
        String RxString;


        public formInterface()
        {

            InitializeComponent();
            this.configurarInterface();
            timer1.Enabled = true;

        }

        private void configurarInterface()
        {
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

            zedCanais = new Dictionary<int, ZedGraph.ZedGraphControl>()
            {
                {1,zedAba1},
                {2,zedAba2 },
                {3,zedAba3 },
                {4,zedAba4 },
                {5,zedAba5 },
                {6,zedAba6 },
                {7,zedAba7 },
                {8,zedAba8 }
            };

            cbxCanais = new Dictionary<int, CheckBox>()
            {
                {1,cbxCanal1 },
                {2,cbxCanal2 },
                {3,cbxCanal3 },
                {4,cbxCanal4 },
                {5,cbxCanal5 },
                {6,cbxCanal6 },
                {7,cbxCanal7 },
                {8,cbxCanal8 }
            };

            tabCanais = new Dictionary<int, TabPage>()
            {
                {1,abaCanal1 },
                {2,abaCanal2 },
                {3,abaCanal3 },
                {4,abaCanal4 },
                {5,abaCanal5 },
                {6,abaCanal6 },
                {7,abaCanal7 },
                {8,abaCanal8 }
            };

            for(int i = 1; i <= 8; i++)
            {
                tabControl1.TabPages.Remove(tabCanais[i]);
            }
        }


        /// <summary>
        /// CONEXÃO
        /// </summary>
        /// 

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;


            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
            /*
            if (serialPort2.IsOpen==true)
            {
                valor = (int)(Math.Round(Convert.ToDecimal(serialPort2.ReadLine()), 0));
                MessageBox.Show(valor.ToString());
                MessageBox.Show(serialPort2.ReadExisting());
                MessageBox.Show("22");
            }
            */

            if (serialPort2.IsOpen == true)
            {
                //String a = serialPort2.ReadExisting();
                //MessageBox.Show(a);

                String a = serialPort2.ReadLine();
                MessageBox.Show(a);
            }




        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort2.ReadExisting();              //le o dado disponível na serial
            valor = (int)(Math.Round(Convert.ToDecimal(serialPort2.ReadLine()), 0));
            MessageBox.Show(valor.ToString());
            MessageBox.Show(serialPort2.ReadExisting());
        }



        /// <summary>
        /// BOTÕES
        /// </summary>
        /// 

        private void btmConectar_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen == false)
            {
                try
                {
                    serialPort2.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort2.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort2.IsOpen)
                {
                    btmConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                    
                }
            }
            else
            {

                try
                {
                    serialPort2.Close();
                    comboBox1.Enabled = true;
                    btmConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void btmTest_Click(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {
                gerarCurvas();

                //plot cada canal
                for (int i = 1; i <= 8; i++)
                {
                    this.configurarCurvas(zedSinais[i], i, sinais[i], x, false);
                }    
            }
            else
            {
                MessageBox.Show("Conectado a porta serial.");
            }
            
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            Boolean aux = false;     //variável para avaliar se nenhum box foi marcado
            //verificando cada checkbox
            for (int i = 1; i <= 8; i++)
            {
                if (cbxCanais[i].Checked && !estado[i - 1])
                {
                    novaAba(sinais[i], tabCanais[i], i);
                    aux = true;
                    estado[i - 1] = true;
                    cbxCanais[i].Enabled = false;   //desabilitar textbox marcado
                }
            }
            if (aux == false)
            {
                MessageBox.Show("Nenhum checkbox foi marcado.");
            }
        }

        private void btmLimpar_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(aba8Canais);
            for (int i = 1; i <= 8; i++)
            {
                cbxCanais[i].Enabled = true;
                estado[i - 1] = false;
            }
        }


        /// <summary>
        /// TESTAR CURVAS
        /// </summary>
        /// 

        private void gerarCurvas()
        {
            //código para sortear os valores de Y dos 8 canais
            Random numAl = new Random();

            for (int y = 1; y <= 8; y++)
            {
                Double[] aux = new double[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    x[i] = i;
                    aux[i] = numAl.Next(1, 101);
                }
                sinais.Add(y, aux);


            }
        }

        //nova aba
        private void novaAba(double[] yx, TabPage c, int n)
        {
            String test = c.Name.Substring(1);
            //int n = Int16.Parse(test);
            tabControl1.TabPages.Add(c);
            configurarCurvas(zedCanais[n], n, yx, x, true);
        }


        //b false -> 8 canais
        //b true -> 1 canal
        private void configurarCurvas(ZedGraph.ZedGraphControl gx, int n, double[] yx, double[] xx, Boolean b)
        {
            gx.GraphPane.AddCurve("minha curva", xx, yx, System.Drawing.Color.Black, ZedGraph.SymbolType.None);
            if (b == false)
            {
                gx.GraphPane.XAxis.IsVisible = false;
                gx.GraphPane.Title.IsVisible = false;
                gx.GraphPane.YAxis.Title.FontSpec.Size = 50;
                gx.GraphPane.YAxis.Title.Text = "Sinal";

                gx.GraphPane.Legend.IsVisible = false;
                gx.GraphPane.AxisChange();
            }
            else
            {
                gx.GraphPane.YAxis.Title.Text = "Sinal " + n;
                gx.GraphPane.Title.IsVisible = false;
                gx.GraphPane.Legend.IsVisible = false;
                gx.GraphPane.YAxis.Scale.Min = yx.Min() - 10;
                gx.GraphPane.YAxis.Scale.Max = yx.Max() + 10;
                gx.GraphPane.AxisChange();
            }
            gx.Refresh();
        }

        
    }
}

