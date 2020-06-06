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
using System.Collections;
using System.Diagnostics;

namespace interfaceEMG
{
    public partial class formInterface : Form
    {

        double[] s1 = new double[]
        {
            100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              250,150,270,120,300,100,320,80,340,60,
              360,40,380,20,400,0,400,0,400,0,
              380,20,360,40,340,60,320,80,300,100,
              280,120,260,140,240,160,220,180,200,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              250,150,270,120,300,100,320,80,340,60,
              360,40,380,20,400,0,400,0,400,0,
              380,20,360,40,340,60,320,80,300,100,
              280,120,260,140,240,160,220,180,200,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200
        };
        double[] s2 = new double[]
        {
              100,200,100,200,100,200,100,200,100,200,
              250,150,270,120,300,100,320,80,340,60,
              360,40,380,20,400,0,400,0,400,0,
              380,20,360,40,340,60,320,80,300,100,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              280,120,260,140,240,160,220,180,200,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              250,150,270,120,300,100,320,80,340,60,
              360,40,380,20,400,0,400,0,400,0,
              380,20,360,40,340,60,320,80,300,100,
              280,120,260,140,240,160,220,180,200,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200,
              100,200,100,200,100,200,100,200,100,200
        };

        int k = 0;

        int contt = 0;

        private int limit = 0;
        private bool firstPoint = false;
        private bool showGraphTest = false;
        private bool showGraphConect = false;
        private bool showGraphRead = false;
        private bool showBiofeedback = false;
        private bool showFFT = false;
        private bool calcFFT = false;
        private bool readFile = false;
        private bool play = false;
        private bool firstPoints = false;
        private string fileName = "Sinais.csv";
        private int currentLine = 1;
        private int fileLength = 10000;                 // Para garantir que o programa nao entra em loop

        static int tamanho = 1000;                      // Tamanho do vetor de teste
        private double[] x = new double[tamanho];       // Eixo x
        private int taxaAmostragem = 2000;              // Taxa de amostragem do circuito
        private int graphIndex = 1;                     // Gráfico que será usado no biofeedback e FFT

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

        private Dictionary<int, Double[]> sinaisFFT = new Dictionary<int, Double[]>();

        public formInterface()
        {
            InitializeComponent();
            this.configurarInterface();
            timer2.Interval = taxaAmostragem/4;
            timer2.Enabled = true;

            
            this.configBox();
        }


        private void configBox()
        {
            // Adiciona todos os canais disponíveis para o biofeedback e FFT
            for(int i = 1 ; i < 9 ; i++)
            {
                string s = i.ToString(); 

                comboBox2.Items.Add(s);
            }
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

            graphFFT.GraphPane.XAxis.IsVisible = true;
            graphFFT.GraphPane.YAxis.IsVisible = true;
            graphFFT.GraphPane.Title.IsVisible = false;
            graphFFT.GraphPane.Margin.All = 0;
        }

        // Atualiza listas de portas conectadas
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; // Flag para sinalizar que a quantidade de portas mudou

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
                    serialPort2.Write("ok");
                    
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
                //this.readFirstPoints();
                //this.readPoints();
                //this.configurarCurvas();
                
                //this.writePointsCSV(0);      //tirar
                /*
                while (true)
                {
                    this.readPoints();
                    this.configurarCurvas();
                    //this.writePointsCSV(tamanho - (taxaAmostragem / 8));    //tirar
                }*/
                this.showGraphConect = !this.showGraphConect;
            }
        }


        private static void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //Console.WriteLine(indata);
        }

        // Ler os pontos dos 8 canais de acordo com a taxa de amostragem
        private void readPoints()
        {

            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            this.cleanGraph();
            
            progressBar1.Visible = true;
            progressBar1.Maximum = tamanho*8;
            progressBar1.Value = 0;
            int taxa = taxaAmostragem / 8;


            this.limit = tamanho - taxa;

            Console.WriteLine("taxa: " + taxa);
            Console.WriteLine("Limit: " + limit);
            Console.WriteLine("---------");


            for (int i = 0; i < limit; i++)
            {
                for (int y = 1; y < 9; y++)
                {
                    sinais[y][i] = sinais[y][i + taxa];
                }
            }
            Dictionary<int, Double[]> auxFFT = new Dictionary<int, double[]>()
            {
                {1, new double[taxa] },
                {2, new double[taxa] },
                {3, new double[taxa] },
                {4, new double[taxa] },
                {5, new double[taxa] },
                {6, new double[taxa] },
                {7, new double[taxa] },
                {8, new double[taxa] },
            };

            for (int i = limit; i < tamanho; i++)
            {
                //double max = sinais[8].Max();
                for (int y = 1; y < 9; y++)
                {
                    try
                    {
                        int fator = 1;
                        double aux = Convert.ToDouble(serialPort2.ReadLine())/fator;
                        sinais[y][i] = aux;
                        archiveData[y][i] = aux;
                    }
                    catch
                    {
                        y--;
                    }
                }
                progressBar1.Value = i*8;

            }
            progressBar1.Value = tamanho*8;
            
            for(int y = 7; y >= 1; y--)
            {
                //Console.WriteLine(y);
                double max = sinais[y + 1].Max();
                for (int i = limit; i < tamanho; i++)
                {
                    sinais[y][i] += max;
                }
                
            }
            
            if (play == true)
            {
                if (contt == 0)
                {
                    for (int z = 1; z <= 8; z++)
                    {
                        Array.Copy(sinais[z], tamanho - taxa, auxFFT[z], 0, taxa);
                        sinaisFFT.Add(z, auxFFT[z]);
                        if (contt == 0) { contt++; }
                    }
                }
                else
                {
                    Double[] aux3;
                    for (int z = 1; z <= 8; z++)
                    {
                        Array.Copy(sinais[z], tamanho - taxa, auxFFT[z], 0, taxa);
                        aux3 = sinaisFFT[z];
                        aux3.Concat(auxFFT[z]);
                        sinaisFFT.Remove(z);
                        sinaisFFT.Add(z, aux3);
                    }
                }
            }

            //stopwatch.Stop();
            //Console.WriteLine($"4ª parte: {stopwatch.ElapsedMilliseconds}ms");
            
            //stopwatch.Stop();
            //Console.WriteLine($"Tempo passado: {stopwatch.ElapsedMilliseconds}ms");

        }



        // Gerar curvas aleatoriamente para testes
        private void gerarCurvas()
        {
           // MessageBox.Show("aa");
            this.cleanGraph();

            int a = 0;
            for (int y = 8; y >= 1; y--)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    if (k == 0)
                    {
                        if (y % 2 == 0)
                        {
                            sinais[y][i] = s1[a];
                        }
                        else
                        {
                            sinais[y][i] = s2[a];
                        }
                        a++;
                        if (a == 249)
                        {
                            a = 0;
                        }
                        
                    }
                    else if(k > 1)
                    {
                        if (y % 2 == 0)
                        {
                            sinais[y][i] = s1[a]/10;
                        }
                        else
                        {
                            sinais[y][i] = s2[a]/10;
                        }
                        a++;
                        if (a == 249)
                        {
                            a = 0;
                        }
                    }
                }

                //MessageBox.Show("aa");


                if (play == true)
                {
                    if (firstPoints == false)
                    {
                        sinaisFFT.Remove(y);
                        sinaisFFT.Add(y, sinais[y]);
                        if (y == 1)
                        {
                            //firstPoints = true; 
                        }
                    }
                    else
                    {
                        //MessageBox.Show("OPA");
                        Double[] aux3 = sinaisFFT[y];
                        aux3.Concat(sinais[y]);
                        sinaisFFT.Remove(y);
                        sinaisFFT.Add(y, aux3);
                    }

                }

                
            }

            k++;
            if (k == 4)
            {
                k = 0;
            }

            for (int y = 7; y >= 1; y--)
            {
                //Console.WriteLine(y);
                double max = sinais[y + 1].Max();
                for (int i = 0; i < tamanho; i++)
                {
                    x[i] = i;
                    sinais[y][i] += max;
                }

            }
            //MessageBox.Show(sinais[1][0].ToString());

            /* ANTIGO
            //progressBar1.Visible = true;
            //progressBar1.Maximum = tamanho*8;
            // progressBar1.Value = 0;
            // Código para sortear os valores de Y dos 8 canais


            
            Random numAl = new Random();
            double max = 0;
            int aux2 = 0;
            for (int y = 8; y >= 1; y--)
            {
                //MessageBox.Show(y.ToString());
                Double[] aux = new double[tamanho];
                //var watch = new System.Diagnostics.Stopwatch();
                

                //stopwatch.Start();
                for (int i = 0; i < tamanho; i++)
                {
                    try
                    {
                        aux2++;
                        x[i] = i;
                        //aux[i] = Math.Sin(i);
                        
                        if (aux2 < 100)
                        {
                            aux[i] = numAl.Next(1, 101) + max;
                        }
                        else if(aux2 >= 100)
                        {
                            aux[i] = numAl.Next(1, 201) + max;
                            if (aux2 == 200)
                            {
                                aux2=0;
                            }
                        }
                        archiveData[y][i] = aux[i] - max;
                    }
                    catch
                    {
                        i--;
                    }
                    //progressBar1.Value = y*i;
                }

                sinais[y] = aux;

                max = sinais[y].Max() + 5;
                double[] ret = new double[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    ret[i] = max;
                }

                retas.Add(y, ret);

                //adiciona os pontos ao vetor para o cálculo da FFT do intervalo
                if (play == true){
                    if (firstPoints == false)
                    {
                        sinaisFFT.Remove(y);
                        sinaisFFT.Add(y, aux);
                        if (y == 1) { 
                            //firstPoints = true; 
                        }
                    }
                    else
                    {
                        //MessageBox.Show("OPA");
                        Double[] aux3 = sinaisFFT[y];
                        aux3.Concat(aux);
                        sinaisFFT.Remove(y);
                        sinaisFFT.Add(y, aux3);
                    }
                    
                }

                
            }

    */
            //progressBar1.Value = tamanho * 8;
        }

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
                //Console.WriteLine(max);
            }
            
            return (output);
        }

        // Fast Fourier Transform 
        private (double[], double[]) FFT(double[] sinal)
        {
            //double[] sinal = sinal1.
            double[] mag = new double[tamanho];         // Magnitude
            double[] freq = new double[tamanho/2];        // Frequencia
            Complex[] aux = new Complex[tamanho];
            int numSamples = sinal.Length;

            // Transformando o sinal em número complexo
            for (int i = 0; i < sinal.Length; i++)
            {
                aux[i] = new Complex(sinal[i], 0);
            }

            // FFT
            Fourier.Forward(aux);

            // Magnitude do sinal
            mag[0] = 0;
            for (int i = 0; i < sinal.Length; i++)
            {
                if (i != 0) mag[i] = (Math.Abs(Math.Sqrt(Math.Pow(aux[i].Real, 2) + Math.Pow(aux[i].Imaginary, 2))));
            }

            int hzPerSample = taxaAmostragem / numSamples;
            // Frequência 

            //freq = x;   // teste
            //Console.WriteLine(hzPerSample);
            double[] mag2 = new double[tamanho/2];
            for (int n = 0; n < tamanho / 2; n++)
            {
                freq[n] = x[n] * hzPerSample;
                mag2[n] = mag[n];
            }

            return (freq, mag2);
        }

        // Configurar plot
        private void configurarCurvas()
        {
            // Cores das curvas
            Dictionary<int, System.Drawing.Color> cores = new Dictionary<int, System.Drawing.Color>()
            {
                {1,System.Drawing.Color.Red },
                {2,System.Drawing.Color.Brown },
                {3,System.Drawing.Color.Fuchsia },
                {4,System.Drawing.Color.BlueViolet },
                {5,System.Drawing.Color.Gold },
                {6,System.Drawing.Color.Cyan },
                {7,System.Drawing.Color.Green },
                {8,System.Drawing.Color.DarkOrange }
            };

            // Adicionar cada curva
            for (int i = 1; i <= 8; i++)
            {

                graphCanais.GraphPane.AddCurve("Canal  "+i, x, sinais[i], cores[i], ZedGraph.SymbolType.None);

                //if (i != 1)
                //{
                //    graphCanais.GraphPane.AddCurve("minha curva", x, retas[i], System.Drawing.Color.Black, ZedGraph.SymbolType.None);
                //}

                graphCanais.GraphPane.Legend.IsVisible = true;
                //graphCanais.GraphPane.Legend.posit
            }

            // Configurando limites
            double max = 0;
            for(int i = 1; i <= 8; i++)
            {
                max += sinais[i].Max();
            }
            graphCanais.GraphPane.YAxis.Scale.Max = sinais[1].Max() + sinais[1].Max()*0.05;
            //graphCanais.GraphPane.YAxis.Scale.Max = max;
            graphCanais.GraphPane.YAxis.Scale.Min = sinais[8].Min() - sinais[8].Min()*0.05;
            graphCanais.GraphPane.XAxis.Scale.Max = x.Length;
            graphCanais.GraphPane.AxisChange();
            graphCanais.Refresh();

            if (this.showBiofeedback)
            {
                double[] biofeedback = BF(sinais[graphIndex]);
                graphBars.GraphPane.AddCurve("Barras", x, biofeedback, cores[graphIndex], ZedGraph.SymbolType.None);

                // Configurando limites
                graphBars.GraphPane.Legend.IsVisible = false;
                graphBars.GraphPane.YAxis.Scale.Max = biofeedback.Max() + 10;
                graphBars.GraphPane.YAxis.Scale.Min = biofeedback.Min() - 10;
                graphBars.GraphPane.XAxis.Scale.Max = x.Length;
                graphBars.GraphPane.AxisChange();
                graphBars.Refresh();
            }

            if (this.showFFT && this.calcFFT)
            {
                // Sinal com transformada de Fourier
                (double[] frequencia, double[] mag) fft = FFT(sinaisFFT[graphIndex].ToArray());
                graphFFT.GraphPane.AddCurve("FFT", fft.Item1, fft.Item2, cores[graphIndex], ZedGraph.SymbolType.None);
                graphFFT.GraphPane.Legend.IsVisible = false;

                // Configurando limites
                graphFFT.GraphPane.YAxis.Scale.Max = fft.Item2.Max() + 10;
                graphFFT.GraphPane.YAxis.Scale.Min = fft.Item2.Min() - 10;
                graphFFT.GraphPane.XAxis.Scale.Max = fft.Item1.Length;
                //graphFFT.GraphPane.XAxis.MA
                graphFFT.GraphPane.AxisChange();
                graphFFT.Refresh();
            }

        }


        // Salva pontos no arquivo CSV
        private void writePointsCSV(int start)
        {

            // Nome do arquivo - salvo em interfaceEMG\bin\Debug\Sinais.csv
            //string fileName = "Sinais.csv";

            // Criando arquivo
            if (!System.IO.File.Exists(fileName))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(fileName))
                {
                    //Console.WriteLine("Arquivo {0} criado!", fileName);
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
                //Console.WriteLine("O arquivo {0} já existe em interfaceEMG\\bin\\Debug\\!", fileName);
            }

            // //Console.WriteLine(Path.GetFullPath(fileName));   // Diretorio completo do arquivo

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
            //string fileName = ((fileTextBox.Text == "") ? "SinaisN.csv" : fileTextBox.Text);
            string fileName = txtArquivo.Text+".csv";
            
            // Arquivo inexistente
            if (!System.IO.File.Exists(fileName))
            {
                
                this.readFile = false;
                MessageBox.Show("Arquivo não encontrado.", "Erro");
                return;
            }

            this.cleanGraph();

            // Leitura do arquivo 
            using (TextReader tr = new StreamReader(fileName, Encoding.Default))
            {
                int countLine = 0;
                string line = null;
                int index = 0;

                for (int i = 1; i < this.currentLine; i++)              // Ignora as linhas anteriores a currentLine
                {
                    tr.ReadLine();
                }

                if(this.currentLine==1) line = tr.ReadLine();           // Cabeçalho edit: so roda na primeira lida
                line = null;

                this.progressBar1.Visible = true;
                this.progressBar1.Maximum = tamanho;
                this.progressBar1.Value = 0;

                // Primeiros pontos do arquivo 
                while (index < tamanho && this.currentLine < tamanho)   // A segunda parte do AND eh necessaria para a 1a iteracao
                {
                    if ((line = tr.ReadLine()) == null)
                    {
                        this.readFile = false;
                        break;
                    }
                    countLine++;                                        // Evita que entre no while que vira em breve while(countLine < tamanho)
                    this.currentLine = this.currentLine + 1;
                    string[] lineSplit = line.Split(';');

                    for (int y = 0; y < lineSplit.Length - 1; y++)
                    {
                        this.sinais[y + 1][index] = Convert.ToDouble(lineSplit[y]) + (7 - y) * 100;
                        //this.sinais[y + 1][index] = Convert.ToDouble(lineSplit[y]);
                    }

                    

                    this.progressBar1.Value = index;
                    index++;
                    
                }


                this.progressBar1.Value = tamanho;

                // Plot 
                this.configurarCurvas();

                line = null;
                int taxa = taxaAmostragem / 8;
                int limit = tamanho - taxa;

                this.progressBar1.Visible = true;
                this.progressBar1.Maximum = tamanho;
                this.progressBar1.Value = 0;

                // Pontos restantes
                while (index < tamanho)                                 // Garante que so leia "tamanho" linhas de cada vez
                {
                    this.cleanGraph();

                    // Shift dos pontos
                    for (int i = 0; i < limit; i++)
                    {
                        for (int y = 1; y < 9; y++)
                        {
                            sinais[y][i] = sinais[y][i + 250];
                        }

                        this.progressBar1.Value = i;
                    }

                    index = limit;

                    while (index < tamanho)
                    {
                        if ((line = tr.ReadLine()) == null)
                        {
                            this.readFile = false;
                            break;
                        }
                        this.currentLine = this.currentLine + 1;        // O programa registra que leu mais uma linha
                        countLine++;                                    // Vamos por limite de "tamanho" para esse contador
                        string[] lineSplit = line.Split(';');

                        // Leitura dos pontos 
                        for (int y = 0; y < lineSplit.Length - 1; y++)
                        {
                            this.sinais[y + 1][index] = Convert.ToDouble(lineSplit[y])+ (7 - y) * 100;
                        }
                        this.progressBar1.Value = index;
                        index++;
                    }
                    this.progressBar1.Value = tamanho;



                    // Plot
                    this.configurarCurvas();
                }

                tr.Close();
            }
        }

        // Permitir atualização do gráfico
        private void cleanGraph()
        {
            retas.Clear();
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            graphBars.GraphPane.CurveList.Clear();
            graphBars.GraphPane.GraphObjList.Clear();
            graphFFT.GraphPane.CurveList.Clear();
            graphFFT.GraphPane.GraphObjList.Clear();
        }

        // Botão para gerar curvas aleatoriamente
        private void btmTeste_Click(object sender, EventArgs e)
        {

            this.showGraphTest = !this.showGraphTest;
            this.readFile = false;
            this.currentLine = 1;
        }

        // Timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            atualizaListaCOMs();
            if (this.showGraphRead){
                this.configurarCurvas();
            }
            if (this.showGraphConect)
            {
                
                this.readPoints();
                this.configurarCurvas();
            }
            if (this.showGraphTest)
            {
                this.gerarCurvas();
                this.configurarCurvas();
            }
            if (play == true)
            {
                this.writePointsCSV(0);
                this.writePointsCSV(tamanho - (taxaAmostragem / 8));
            }
            if (this.readFile==true && (this.currentLine < this.fileLength))
            {
                this.readCSV();         // Le o csv e ja plota
            }

            
        }

        // Botão para ler arquivo
        private void readFileButton_Click(object sender, EventArgs e)
        {
            this.readFile = !this.readFile;
            this.showGraphTest = false;
            //this.showGraphRead = true;
            
        }

        // Text Box do arquivo a ser lido
        private void fileTextBox_TextChanged(object sender, EventArgs e)
        {
            this.readFile = false;
            this.currentLine = 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Index para biofeedback e FFT
            int aux = Convert.ToInt32(comboBox2.Items[comboBox2.SelectedIndex]);

            if (aux > 0 && aux < 9)
            {
                graphIndex = aux;
            }
        }

        private void biofeedbackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.showBiofeedback = !this.showBiofeedback;
        }

        private void FFTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.showFFT = !this.showFFT;
        }

        private void graphCanais_Load(object sender, EventArgs e)
        {

        }

        //botão para começar a salvar os dados
        private void btmPlay_Click(object sender, EventArgs e)
        {
            if (play == false)
            {
                fileName = txtArquivo.Text+".csv";
                play = true;
                btmPlay.Text = "Stop";
                btmPlay.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                sinaisFFT.Clear();
                firstPoints = false;
                calcFFT = false;
            }
            else
            {
                play = false;
                btmPlay.Text = "Play";
                btmPlay.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                calcFFT = true;
            }
            
        }


    }


}
