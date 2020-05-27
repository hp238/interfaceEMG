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
using System.Threading;
using System.IO;
using System.Web.Caching;
using DocumentFormat.OpenXml.EMMA;
using System.Numerics;
using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics;

namespace interfaceEMG
{
    public partial class formInterface : Form
    {

        private Boolean[] estado = new Boolean[8];
        private int taxa = 100;
        private int janela = 2;
        private int auxJan = 0;
        private int showGraph = 0;

        static int tamanho = 1000;                      // Tamanho do vetor de teste
        private double[] x = new double[tamanho];       // Eixo x
        private int taxaAmostragem = 2000;              // Taxa de amostragem do circuito
        private int graphIndexBiofeedback = 3;          // Gráfico que será usado no biofeedback

        private void inicializaVetor()
        {
            for (int i = 0; i < 100; i++)
            {
                this.x[i] = i;
            }
        }
        private Dictionary<int, Double[]> sinais = new Dictionary<int, double[]>()
        {
            {1, new double[tamanho] },
            {2, new double[tamanho] },
            {3, new double[tamanho] },
            {4, new double[tamanho] },
            {5, new double[tamanho] },
            {6, new double[tamanho] },
            {7, new double[tamanho] },
            {8, new double[tamanho] },
        }; // Eixo y dos 8 canais

        private Dictionary<int, Double[]> archiveData = new Dictionary<int, double[]>()
        {
            {1, new double[tamanho] },
            {2, new double[tamanho] },
            {3, new double[tamanho] },
            {4, new double[tamanho] },
            {5, new double[tamanho] },
            {6, new double[tamanho] },
            {7, new double[tamanho] },
            {8, new double[tamanho] },
        }; // Dados para salvar no arquivo

        private Dictionary<int, Double[]> retas = new Dictionary<int, double[]>(); // Retas entre canais

        public formInterface()
        {
            InitializeComponent();
            this.configurarInterface();
            timer2.Enabled = true;
            //this.atualizaListaCOMs();
        }

        // Configuração inicial da tela
        private void configurarInterface()
        {
            // Gráfico dos canais
            graphCanais.GraphPane.XAxis.IsVisible = false;
            graphCanais.GraphPane.YAxis.IsVisible = false;
            graphCanais.GraphPane.Title.IsVisible = false;
            graphCanais.GraphPane.Margin.All = 0;

            // Aba de biofeedback
            graphBars.GraphPane.XAxis.IsVisible = false;
            graphBars.GraphPane.YAxis.IsVisible = false;
            graphBars.GraphPane.Title.IsVisible = false;
            graphBars.GraphPane.Margin.All = 0;

            //Aba de FFT

            graphFFT.GraphPane.XAxis.IsVisible = false;
            graphFFT.GraphPane.YAxis.IsVisible = false;
            graphFFT.GraphPane.Title.IsVisible = false;
            graphFFT.GraphPane.Margin.All = 0;
        }

        // Atualiza listas de portas conectadas
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; // flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;


            // Se a quantidade de portas mudou
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

            // Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            // Adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            // Seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        // Botão conectar
        private void btmConectar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tamanho; i++)
            {
                x[i] = i;
            }
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

            if (serialPort2.IsOpen == true)
            {
                this.inicializaVetor();

                this.readFirstPoints();
                this.configurarCurvas();
                this.writePointsCSV(0);

                while (true)
                {
                    this.readPoints();
                    this.configurarCurvas();
                    this.writePointsCSV(tamanho - (taxaAmostragem / 8));
                }
            }
        }

        // Ler os primeiros (tamanho) pontos de cada canal
        private void readFirstPoints()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = tamanho;
            progressBar1.Value = 0;
            Random numAl = new Random();    //teste

            for (int i = 0; i < tamanho; i++)
            {
                for (int y = 1; y < 9; y++)
                {
                    try
                    {
                        double aux = Convert.ToDouble(serialPort2.ReadLine()) / 100;
                        sinais[y][i] = aux + (8 - y) * (100);
                        archiveData[y][i] = aux;
                    }
                    catch
                    {
                        y--;
                    }
                }
                progressBar1.Value = i;
            }
            progressBar1.Value = tamanho;
        }

        // Ler os pontos dos 8 canais de acordo com a taxa de amostragem
        private void readPoints()
        {
            // Permitir atualização do gráfico
            retas.Clear();
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            graphBars.GraphPane.CurveList.Clear();
            graphBars.GraphPane.GraphObjList.Clear();
            graphFFT.GraphPane.CurveList.Clear();
            graphFFT.GraphPane.GraphObjList.Clear();

            progressBar1.Visible = true;
            progressBar1.Maximum = tamanho;
            progressBar1.Value = 0;

            int taxa = taxaAmostragem / 8;
            int limit = tamanho - taxa;

            for (int i = 0; i < limit; i++)
            {
                for (int y = 1; y < 9; y++)
                {
                    sinais[y][i] = sinais[y][i + 1];
                }
            }

            for (int i = limit; i < tamanho; i++)
            {
                for (int y = 1; y < 9; y++)
                {
                    try
                    {
                        double aux = Convert.ToDouble(serialPort2.ReadLine()) / 100;
                        sinais[y][i] = aux + (8 - y) * 100;
                        archiveData[y][i] = aux;
                    }
                    catch
                    {
                        y--;
                    }
                }
                progressBar1.Value = i;
            }
            progressBar1.Value = tamanho;

        }

        // Ler dados da porta serial
        private void lerDados()
        {
            // Permitir atualização do gráfico
            retas.Clear();
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            graphBars.GraphPane.CurveList.Clear();
            graphBars.GraphPane.GraphObjList.Clear();
            graphFFT.GraphPane.CurveList.Clear();
            graphFFT.GraphPane.GraphObjList.Clear();

            MessageBox.Show("t1");
            progressBar1.Visible = true;        // barra de progresso
            progressBar1.Maximum = tamanho;
            progressBar1.Value = 0;
            serialPort2.ReadLine();             // teste
            serialPort2.ReadLine();             // teste
            Random numAl = new Random();        // teste
            MessageBox.Show("t2");

            // Ler valores de cada canal
            for (int i = 0; i < tamanho; i++)
            {
                x[i] = i;
                for (int y = 1; y <= 8; y++)
                {
                    try
                    {
                        double aux = Convert.ToDouble(serialPort2.ReadLine()) / 100;
                        //MessageBox.Show(Convert.ToString(aux));
                        sinais[y][i] = aux;
                    }
                    catch
                    {
                        y--;
                    }
                }
                progressBar1.Value = i;
            }
            progressBar1.Value = tamanho;

            // Calculando os valores de máximo dos sinais para determinar a posição das linhas horizontais
            double[] maxs = new double[8];
            for (int y = 1; y <= 8; y++)
            {
                maxs[y - 1] = sinais[y].Max();
            }
            double offset = maxs.Max();
            double offsetInic = offset;

            // Varrer canais para adicionar um offset aos sinais para o posicionamento da tela
            for (int y = 1; y <= 8; y++)
            {
                double[] ret = new double[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    sinais[y][i] += offsetInic * (8 - y) + offsetInic;
                    ret[i] = offset;

                }
                offset += offsetInic;
                if (y != 1)
                {
                    retas.Add(y, ret);
                }

            }
        }

        // Gerar curvas aleatoriamente para testes
        private void gerarCurvas()
        {
            // Permitir atualização do gráfico
            retas.Clear();
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            graphBars.GraphPane.CurveList.Clear();
            graphBars.GraphPane.GraphObjList.Clear();
            graphFFT.GraphPane.CurveList.Clear();
            graphFFT.GraphPane.GraphObjList.Clear();

            // Código para sortear os valores de Y dos 8 canais
            Random numAl = new Random();
            double max = 0;

            for (int y = 8; y >= 1; y--)
            {
                Double[] aux = new double[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    try
                    {
                        x[i] = i;
                        aux[i] = numAl.Next(1, 101) + max;
                        archiveData[y][i] = aux[i] - max;
                    }
                    catch
                    {
                        i--;
                    }

                }

                sinais[y] = aux;

                max = sinais[y].Max() + 5;
                double[] ret = new double[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    ret[i] = max;
                }

                retas.Add(y, ret);

            }
        }

        //
        // Extracao de envelope 
        private double[] BF(double[] sinal)
        {
            double[] output = new double[tamanho];
            for(int i = 0; i < tamanho/20; i++)
            {
                double max = 0;
                for(int j = 0; j < 20; j++)
                {
                    if (sinal[i * 20 + j] > max) max = sinal[i * 20 + j];
                }
                for(int k = 0; k < 20; k++)
                {
                    output[i * 20 + k] = max;
                }
                Console.WriteLine(max);
            }
            
            return (output);
        }

        // Fast Fourier Transform 
        private (double[], double[]) FFT(double[] sinal)
        {
            double[] mag = new double[tamanho];         // Magnitude
            double[] freq = new double[tamanho];        // Frequencia
            Complex[] aux = new Complex[tamanho];

            // Transformando o sinal em número complexo
            for (int i = 0; i < tamanho; i++)
            {
                aux[i] = new Complex(sinal[i], 0);
            }

            // FFT
            Fourier.Forward(aux);

            // Magnitude do sinal
            mag[0] = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (i != 0) mag[i] = (Math.Abs(Math.Sqrt(Math.Pow(aux[i].Real, 2) + Math.Pow(aux[i].Imaginary, 2))));
            }

            // Frequência 

            freq = x;   // teste 

            return (freq, mag);
        }

        // Configurar plot
        private void configurarCurvas()
        {
            // Cores das curvas
            Dictionary<int, System.Drawing.Color> cores = new Dictionary<int, System.Drawing.Color>()
            {
                {1,System.Drawing.Color.Aqua },
                {2,System.Drawing.Color.Yellow },
                {3,System.Drawing.Color.Coral },
                {4,System.Drawing.Color.Green },
                {5,System.Drawing.Color.HotPink },
                {6,System.Drawing.Color.Maroon },
                {7,System.Drawing.Color.Red },
                {8,System.Drawing.Color.Tomato }
            };

            // Adicionar cada curva
            for (int i = 1; i <= 8; i++)
            {

                graphCanais.GraphPane.AddCurve("minha curva", x, sinais[i], cores[i], ZedGraph.SymbolType.None);

                //if (i != 1)
                //{
                //    graphCanais.GraphPane.AddCurve("minha curva", x, retas[i], System.Drawing.Color.Black, ZedGraph.SymbolType.None);
                //}

                graphCanais.GraphPane.Legend.IsVisible = false;
            }
            

            // Sinal com transformada de Fourier
            (double[] frequencia, double[] mag) fft = FFT(sinais[graphIndexBiofeedback]);
            double[] biofeedback = BF(sinais[graphIndexBiofeedback]);

            graphBars.GraphPane.AddCurve("Barras", x, biofeedback, cores[graphIndexBiofeedback], ZedGraph.SymbolType.None);
            graphBars.GraphPane.Legend.IsVisible = false;

            graphFFT.GraphPane.AddCurve("FFT", fft.Item1, fft.Item2, cores[graphIndexBiofeedback], ZedGraph.SymbolType.None);
            graphFFT.GraphPane.Legend.IsVisible = false;

            // Configurando limites
            graphCanais.GraphPane.YAxis.Scale.Max = sinais[1].Max() + 10;
            graphCanais.GraphPane.YAxis.Scale.Min = sinais[8].Min() - 10;
            graphCanais.GraphPane.XAxis.Scale.Max = x.Length;
            graphCanais.GraphPane.AxisChange();
            graphCanais.Refresh();

            graphBars.GraphPane.YAxis.Scale.Max = biofeedback.Max() + 10;
            graphBars.GraphPane.YAxis.Scale.Min = biofeedback.Min() - 10;
            graphBars.GraphPane.XAxis.Scale.Max = x.Length;
            graphBars.GraphPane.AxisChange();
            graphBars.Refresh();

            graphFFT.GraphPane.YAxis.Scale.Max = fft.Item2.Max() + 10;
            graphFFT.GraphPane.YAxis.Scale.Min = fft.Item2.Min() - 10;
            graphFFT.GraphPane.XAxis.Scale.Max = fft.Item1.Length;
            graphFFT.GraphPane.AxisChange();
            graphFFT.Refresh();

        }


        // Salva pontos no arquivo CSV
        private void writePointsCSV(int start)
        {

            // Nome do arquivo - salvo em interfaceEMG\bin\Debug\Sinais.csv
            string fileName = "Sinais.csv";

            // Criando arquivo
            if (!System.IO.File.Exists(fileName))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(fileName))
                {
                    Console.WriteLine("Arquivo {0} criado!", fileName);
                }

                // Cabeçalho
                using (TextWriter tw = new StreamWriter(fileName, false, Encoding.Default))
                {
                    tw.Write("Sinal 1;Sinal 2;Sinal 3;Sinal 4; Sinal 5;Sinal 6;Sinal 7;Sinal 8;");
                    tw.Write("\n");
                    tw.Close();
                }
            }
            else
            {
                Console.WriteLine("O arquivo {0} já existe!", fileName);
            }

            // Console.WriteLine(Path.GetFullPath(fileName));   // Diretorio completo do arquivo

            // Escrever dados no arquivo
            using (TextWriter tw = new StreamWriter(fileName, true, Encoding.Default))
            {
                for (int i = start; i < tamanho; i++)
                {
                    string line = "";

                    for (int y = 1; y < 9; y++)
                    {
                        string aux = String.Format("{0};", archiveData[y][i]);
                        line += aux;
                    }
                    tw.Write(line + "\n");
                }
                tw.Close();
            }
        }

        // Ler os pontos de um arquivo CSV
        private void readCSV()
        {
            string fileName = ((fileTextBox.Text == "") ? "Sinais.csv" : fileTextBox.Text);

            // Arquivo inexistente
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Arquivo não encontrado.", "Erro");
                return;
            }

            // Leitura do arquivo 
            using (TextReader tr = new StreamReader(fileName, Encoding.Default))
            {
                string line = null;
                int index = 0;

                line = tr.ReadLine();       // Cabeçalho
                line = null;

                progressBar1.Visible = true;
                progressBar1.Maximum = tamanho;
                progressBar1.Value = 0;

                // Primeiros pontos do arquivo 
                while (index < tamanho)
                {
                    if ((line = tr.ReadLine()) == null)
                    {
                        break;
                    }

                    string[] lineSplit = line.Split(';');

                    for (int y = 0; y < lineSplit.Length - 1; y++)
                    {
                        sinais[y + 1][index] = Convert.ToDouble(lineSplit[y]) + (7 - y) * 100;
                    }
                    progressBar1.Value = index;
                    index++;
                }
                progressBar1.Value = tamanho;

                // Plot 
                this.configurarCurvas();

                line = null;
                int taxa = taxaAmostragem / 8;
                int limit = tamanho - taxa;
                bool finish = false;

                progressBar1.Visible = true;
                progressBar1.Maximum = tamanho;
                progressBar1.Value = 0;

                // Pontos restantes
                while (!finish)
                {
                    // Delay de 1s
                    Thread.Sleep(1000);

                    // Permitir atualização do gráfico
                    graphCanais.GraphPane.CurveList.Clear();
                    graphCanais.GraphPane.GraphObjList.Clear();
                    graphBars.GraphPane.CurveList.Clear();
                    graphBars.GraphPane.GraphObjList.Clear();
                    graphFFT.GraphPane.CurveList.Clear();
                    graphFFT.GraphPane.GraphObjList.Clear();

                    // Shift dos pontos
                    for (int i = 0; i < limit; i++)
                    {
                        for (int y = 1; y < 9; y++)
                        {
                            sinais[y][i] = sinais[y][i + 1];
                        }

                        progressBar1.Value = i;
                    }

                    index = limit;

                    while (index < tamanho)
                    {
                        if ((line = tr.ReadLine()) == null)
                        {
                            finish = true;
                            break;
                        }

                        string[] lineSplit = line.Split(';');

                        // Leitura dos pontos 
                        for (int y = 0; y < lineSplit.Length - 1; y++)
                        {
                            sinais[y + 1][index] = Convert.ToDouble(lineSplit[y]) + (7 - y) * 100;
                        }
                        progressBar1.Value = index;
                        index++;
                    }
                    progressBar1.Value = tamanho;

                    // Plot
                    this.configurarCurvas();
                }

                tr.Close();
            }
        }

        // Botão para gerar curvas aleatoriamente
        private void btmTeste_Click(object sender, EventArgs e)
        {
            if (this.showGraph == 1) this.showGraph = 0;
            else this.showGraph = 1;
            //this.savePoints(0);
            //String a = serialPort2.ReadLine();
            //MessageBox.Show("a");
        }

        // Timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
            if (this.showGraph == 1)
            {
                this.gerarCurvas();
                this.configurarCurvas();
            }
        }

        // Botão para ler arquivo
        private void readFileButton_Click(object sender, EventArgs e)
        {
            // Permitir atualização do gráfico
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            graphBars.GraphPane.CurveList.Clear();
            graphBars.GraphPane.GraphObjList.Clear();
            graphFFT.GraphPane.CurveList.Clear();
            graphFFT.GraphPane.GraphObjList.Clear();

            this.readCSV();
        }

        // Text Box do arquivo a ser lido
        private void fileTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}