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
using FftSharp;
//using Complex = FftSharp.Complex;
using Comples = System.Numerics.Complex;
using Complex = System.Numerics.Complex;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Net.Sockets;
using System.Net;

namespace interfaceEMG
{
    public partial class formInterface : Form
    {


        #region Variáveis

        private int k = 0;                              // utilizado no gerar curvas para variar o tipo de onda gerado
        private bool auxReadCSV = false;                // quando true dar um offset nos primeiros sinais lidos
        private bool auxWriteCSV = false;               // para verificar apenas uma vez se o arquivo .csv já existe
        private int limit = 0;                          // variável auxiliar equivalente a tamanho-taxa
        private bool showGraphWIFI = false;
        private bool showGraphBluetooth = false;        // true para mostrar as curvas lidas pela comunicação serial/bluetooth
        private bool showGraphRead = false;             // true para mostrar as curvas lidas do arquivos .cvs
        private bool showEnvoltoria = false;            // true para mostrar as curvas da aba de biofeedback
        private bool showFFT = false;                   // true para mostrar as curvas da aba de FFT (controlado pelo botão Play)
        private bool calcFFT = false;                   // true para calcular o FFT de cada sinal do intervalo selecionado pelo botão Play
        private bool readFile = false;                  // true para iniciar a leitura do arquivo .csv
        private bool play = false;                      // true para iniciar a salvar os pontos e plotar a FFT
        private bool firstPoints = false;               // false para indicar que os primeiros "taxa" pontos foram lidos na comunicação serial/bluetooth
                                                        // true para indicar que os demais "taxa" pontos lidos devem ser concatenados ao pontos lidos anteriormente
        private string fileName = "Sinais.csv";         // nome padrão do arquivo .csv que será salvo
        private int currentLine = 1;                    // indica a linha que está sendo lida pelo readfile
        static int tamanho = 500;                       // Tamanho do vetor de teste
        private double[] x;                             // Eixo x
        private double taxaAmostragem = 1000;           // Taxa de amostragem do circuito em Hz
        private int graphIndex = 1;                     // Gráfico que será usado no biofeedback e FFT
        private int canais = 8;                         // Número de canais
        private bool offsetType = false;                // define o tipo de offset
                                                        // true para um offset igual para todos os canais
                                                        // true para um offset ajustável
        private bool finishFFT = false;
        private int janENV = 100;
        private bool auxGraphs = false;
        UdpClient udpClient;
        double[] output;

        private int canal = 1;
        private double limiarBird = 2500;
        private bool flappyBird = false;
        
        // Flappy Bird Variables
        private int score = 0;
        private int scoreAux = 0;
        private bool startFlag = false;

        private Dictionary<int, Double[]> sinais = new Dictionary<int, double[]>();

        private Dictionary<int, Double[]> archiveData = new Dictionary<int, double[]>();

        private Dictionary<int, Double[]> sinaisFFT = new Dictionary<int, double[]>();           // Dados para o cálculo da FFT

        #endregion


        #region Inicialização
        //Inicialização da Interface
        public formInterface()
        {
            InitializeComponent();
            this.configBox();

            this.inicializarDicionarios();
            this.configurarInterface();
            
            //timer2.Interval = 1;
            timer2.Enabled = true;
            
            // Setando botões e labels do Flappy Bird
            startButton.Visible = true;
            startButton.Enabled = true;

            restartButton.Visible = false;
            restartButton.Enabled = false;

            GameOverLabel.Visible = false;
            ScoreLabel.Visible = true;
            ScoreLabel.Text = "Score: 0s";

            this.createMaze();

        }

        //eixo x
        private void inicializaVetor()
        {
            double d = 1 / taxaAmostragem;
            //Console.WriteLine(tamanho);
            x = new double[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                this.x[i] = i*d;
            }  
        }

        private void inicializarDicionarios()
        {
            sinais.Clear();
            archiveData.Clear();
            //vetor sinais
            for (int i = 1; i <= canais; i++)
            {
                sinais.Add(i, new double[tamanho]);
                archiveData.Add(i, new double[tamanho]);
            }
        }

        #endregion


        #region  Aquisição de sinais


        // Ler os pontos dos 8 canais de acordo com a taxa de amostragem
        private void readPoints()
        {

            this.cleanGraph();

            int taxa = 100;// taxaAmostragem / canais;

            //salva os dados parciais para o cálculo da FFT
            Dictionary<int, Double[]> auxFFT = new Dictionary<int, double[]>();
            for (int i = 1; i <= canais; i++)
            {
                auxFFT.Add(i, new double[taxa]);
            }

            //progressBar1.Visible = true;
            //progressBar1.Maximum = tamanho * canais;
            //progressBar1.Value = 0;

            this.limit = tamanho - taxa;
            tools.shift(sinais, limit, taxa, canais);

            double[] auxFlappy = new double[100];

            int n = 0;
            if (showGraphBluetooth)
            {
                Console.WriteLine("ssssssssssssssss");
                for (int i = limit; i < tamanho; i++)
                {
                    //Console.WriteLine("-------------");
                    for (int y = 1; y <= canais; y++)
                    {
                        double aux = 0;
                        try
                        {
                            int fator = 1;
                            aux = Convert.ToDouble(serialPort2.ReadLine()) / fator;
                            sinais[y][i] = aux;
                            archiveData[y][i] = aux;
                            //Console.WriteLine("---------");
                            //Console.WriteLine(aux);
                            //double aux = 0;
                            //double aux = 0;

                        }
                        catch
                        {
                            y--;
                        }
                        
                        if (y == canal && flappyBird == true)
                        {
                            auxFlappy[n] = sinais[y][i];
                            n++;
                            if (n == 500)
                            {
                                n = 0;
                                for (int m = 0; m < 500; m++)
                                {
                                    Console.WriteLine(auxFlappy[m]);
                                    if (auxFlappy[m] > limiarBird)
                                    {
                                        bird.Top += -50;
                                        m = 500;
                                    }

                                }
                            }
                        }
                    }
                    // progressBar1.Value = i * canais;

                }
            }
            else if (showGraphWIFI)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = limit; i < tamanho; i++)
                {
                    

                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string[] dados = returnData.Split('-');
                    //Console.WriteLine(returnData);
                    //Console.WriteLine(dados[0]);
                    //Console.WriteLine(dados[14]);
                    //Console.WriteLine(dados[15]);

                    for (int k = 0; k < 1;k++)
                    {
                        for (int y = 1; y <= canais; y++)
                        {
                            //Console.WriteLine((y - 1) + k * 8);
                            sinais[y][i] = Convert.ToDouble(dados[(y - 1)+k*8]);
                            archiveData[y][i] = Convert.ToDouble(dados[(y - 1)+k*8]);
                            //Console.WriteLine(sinais[y][i]);
                            if (y == canal && flappyBird == true)
                            {
                                auxFlappy[n] = sinais[y][i];
                                n++;
                                if (n == 100)
                                {
                                    n = 0;
                                    for (int m = 0; m < 100; m++)
                                    {
                                        //Console.WriteLine(auxFlappy[m]);
                                        if (auxFlappy[m] > limiarBird)
                                        {
                                            bird.Top += -50;
                                            m = 100;
                                        }

                                    }
                                }
                            }

                        }
                        if (k < 0){
                            i++;
                        }
                        
                    }

                    
                }
                stopwatch.Stop();
                //Console.WriteLine($"tempo: { stopwatch.Elapsed}");

                // double aux = 0;
                // Console.WriteLine(returnData);
                // aux = Convert.ToDouble(returnData);


            }
            // progressBar1.Value = tamanho * canais;

            tools.offsetNorm(sinais, limit, tamanho, canais);
            /*
            if (!offsetType)
            {
                tools.offset(sinais, limit, tamanho, canais);
            }
            else
            {
                tools.offsetNorm(sinais, limit, tamanho, canais);
            }
            */


            List<bool> auxb = tools.concatFFT(sinais, sinaisFFT, auxFFT, firstPoints, tamanho, taxa, calcFFT, canais);
            firstPoints = (bool)auxb[0];
            this.calcFFT = (bool)auxb[1];
            //play = (bool)auxb[1];

            //this.configurarCurvas();
            /*for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("------------------");
            }*/
            //}

        }

        #endregion


        #region Timer


        // Timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();

            if (this.showGraphBluetooth)
            {
                this.readPoints();
                this.configurarCurvas();
            }

            if (this.showGraphWIFI)
            {
                this.readPoints();
                this.configurarCurvas();
            }

            if (this.showGraphRead)
            {
                this.readCSV();         // Le o csv e ja plota
                
            }

            if (play == true)
            {
                this.writePointsCSV(tamanho - 100);// ((int)taxaAmostragem / canais));
            }

            if (auxGraphs)
            {
                this.cleanGraph();
                this.configurarCurvas();
            }
            /*
            if (this.flappyBird == true)
            {
                this.emgFlappyBird(sinais[canal], canal);
            }*/

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
        #endregion


        #region CSV


        // Salva pontos no arquivo CSV
        private void writePointsCSV(int start)
        {

            // Nome do arquivo - salvo em interfaceEMG\bin\Debug\Sinais.csv
            //string fileName = "Sinais.csv";
            /*if (File.Exists(fileName) && (this.auxWriteCSV == false))
            {
                File.Delete(fileName);
                MessageBox.Show("a");
                this.auxWriteCSV = true;
            }*/
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

                //Console.WriteLine("O arquivo {0} já existe em interfaceEMG\\bin\\Debug\\!", fileName);
            }

            // //Console.WriteLine(Path.GetFullPath(fileName));   // Diretorio completo do arquivo

            // Escrever dados no arquivo
            using (TextWriter tw = new StreamWriter(fileName, true, Encoding.Default))
            {
                for (int i = start; i < tamanho; i++)
                {
                    string line = "";

                    for (int y = 1; y <= canais; y++)
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
            this.cleanGraph();
            
            //string fileName = ((fileTextBox.Text == "") ? "SinaisN.csv" : fileTextBox.Text);
            string fileName = txtRead.Text + ".csv";


            // Arquivo inexistente
            if (!System.IO.File.Exists(fileName))
            {
                this.showGraphRead = false;
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

                if (this.currentLine == 1) line = tr.ReadLine();           // Cabeçalho edit: so roda na primeira lida
                line = null;

                //this.progressBar1.Visible = true;
                //this.progressBar1.Maximum = tamanho;
                // this.progressBar1.Value = 0;

                // Primeiros pontos do arquivo 
                while (index < tamanho && this.currentLine < tamanho)   // A segunda parte do AND eh necessaria para a 1a iteracao
                {
                    //int a = 0;
                    line = tr.ReadLine();

                    countLine++;                                        // Evita que entre no while que vira em breve while(countLine < tamanho)
                    this.currentLine = this.currentLine + 1;
                    string[] lineSplit = line.Split(';');

                    for (int y = 0; y < lineSplit.Length - 1; y++)
                    {
                        this.sinais[y + 1][index] = Convert.ToDouble(lineSplit[y]);// + (7 - y) * 100;
                    }
                    //this.progressBar1.Value = index;
                    index++;
                }
                //this.progressBar1.Value = tamanho;

                //dar offset apenas nos primeiros pontos
                if (auxReadCSV == false)
                {
                    //tools.offset(sinais, 0, tamanho, canais);
                    if (!offsetType)
                    {
                        tools.offset(sinais, 0, tamanho, canais);
                    }
                    else
                    {
                        tools.offsetNorm(sinais, 0, tamanho, canais);
                    }

                    this.inicializaVetor();
                    this.configurarCurvas();
                    auxReadCSV = true;
                }

                line = null;
                int taxa = 100;// (int)taxaAmostragem / canais;
                int limit = tamanho - taxa;

                //this.progressBar1.Visible = true;
                //this.progressBar1.Maximum = tamanho;
                //this.progressBar1.Value = 0;

                // Pontos restantes
                while (index < tamanho - taxa)                                 // Garante que so leia "tamanho" linhas de cada vez
                {
                    this.cleanGraph();

                    // Shift dos pontos
                    tools.shift(sinais, limit, taxa, canais);

                    index = limit;

                    while (index < tamanho)
                    {
                        if ((line = tr.ReadLine()) == null)
                        {
                            Console.WriteLine("stop");
                            this.readFile = false;
                            this.showGraphRead = false;
                            //this.play = false;
                            break;
                        }
                        this.currentLine = this.currentLine + 1;        // O programa registra que leu mais uma linha
                        countLine++;                                    // Vamos por limite de "tamanho" para esse contador
                        string[] lineSplit = line.Split(';');



                        // Leitura dos pontos 
                        for (int y = 0; y < lineSplit.Length - 1; y++)
                        {
                            this.sinais[y + 1][index] = Convert.ToDouble(lineSplit[y]);// + (7 - y) * 100;
                        }
                        //this.progressBar1.Value = index;
                        index++;
                    }
                    //this.progressBar1.Value = tamanho;

                    // FFT
                    Dictionary<int, Double[]> auxFFT = new Dictionary<int, double[]>();
                    for (int i = 1; i <= canais; i++)
                    {
                        auxFFT.Add(i, new double[taxa]);
                    }
                    //play = true;
                    List<bool> auxb = tools.concatFFT(sinais, sinaisFFT, auxFFT, firstPoints, tamanho, taxa, showGraphRead, canais);
                    firstPoints = (bool)auxb[0];

                    if (!offsetType)
                    {
                        tools.offset(sinais, limit, tamanho, canais);
                    }
                    else
                    {
                        tools.offsetNorm(sinais, limit, tamanho, canais);
                    }

                    //Plot
                    this.configurarCurvas();
                }
                tr.Close();
                
            }
            //calcFFT = true;
            //showGraphRead = false;
            if (!this.showGraphRead)
            {
                calcFFT = true;
                auxGraphs = true;
            }
        }

        #endregion


        #region Outras abas
        private void configBox()
        {

            //configura numero de canais
            cbCanais.Items.Add(1);
            cbCanais.Items.Add(4);
            cbCanais.Items.Add(8);
            cbCanais.Items.Add(16);

            //configura janela sinais
            cbJanela.Items.Add(300);
            cbJanela.Items.Add(500);
            cbJanela.Items.Add(700);
            cbJanela.Items.Add(1000);
            cbJanela.Items.Add(1500);
            cbJanela.Items.Add(2000);
            cbJanela.Items.Add(3000);
            cbJanela.Items.Add(4000);
            cbJanela.Items.Add(6000);
            cbJanela.Items.Add(7000);
            cbJanela.Items.Add(8000);


            // Adiciona todos os canais disponíveis para o biofeedback e FFT
            for (int i = 1; i <= canais; i++)
            {
                string s = i.ToString();

                comboBox2.Items.Add(s);

            }

        }

        // Extracao de envelope 
        private void envoltoria(double[] sinal, int can)
        {
            //int jan= 25;
            
            //janENV = 300;
            int taxa = 100;
            Console.WriteLine(limit);
            //Console.WriteLine(tamanho);
            for (int i = 0; i < limit; i++)
            {
                //Console.WriteLine(i + taxa);
                output[i] = output[i + taxa];
            }

            for (int i = limit; i < tamanho; i++)
            {
                //Console.WriteLine(sinal[i]);
                output[i] = sinal[i] - 4000 * (canais - can);
                Console.WriteLine(output[i]);
            }

            for (int i=limit; i < tamanho; i++)
            {
                if (output[i]<2000)
                {
                    //Console.WriteLine(output[i]);
                    output[i] = 2000 + (2000 - output[i]);
                    //Console.WriteLine(output[i]);
                    //Console.WriteLine("-----------");
                }
                
                //output[i] = Math.Abs(sinal[i]-3000*(9-can));
            }

            for(int i = limit; i<tamanho; i++)
            {
                int e = i - janENV / 2;
                int d = i + janENV / 2;
                if (e < 0)
                {
                    e = 0;
                }
                if (d >= tamanho)
                {
                    d = tamanho - 1;
                }
                int cont = 0;
                double sum = 0;
                for(int n = e; n < d; n++)
                {
                    
                    sum += output[n];
                    cont++;
                    
                    
                }
                output[i] = (sum / cont);
                
            }


            //return (output);
        }

        // Fast Fourier Transform 
        private (double[], double[]) FFT(double[] sinal)
        {

            //double[] sinal = sinal1.
            int p = 2;
            //Complex[] aux = new Complex[tamanho];
            int numSamples = sinal.Length;

            // Transformando o sinal em número complexo
            /*for (int i = 0; i < sinal.Length; i++)
            {
                aux[i] = new Complex(sinal[i], 0);
            }
            */
            Complex[] samples = new Complex[numSamples];

            /*
            double[] fundamental = Generate.Sinusoidal(numSamples, taxaAmostragem, 60, 10.0);
            double[] second = Generate.Sinusoidal(numSamples, taxaAmostragem, 120, secondHarm, 0.0, secondPH);
            double[] third = Generate.Sinusoidal(numSamples, taxaAmostragem, 120, thirdHarm, 0.0, thirdPH);*/

            for(int i=0; i< numSamples; i++)
            {
                samples[i] = new Complex(sinal[i], 0);
            }

            double[] mag = new double[samples.Length / p];         // Magnitude
            double[] freq = new double[samples.Length / p];        // Frequencia
            // FFT
            Fourier.Forward(samples, FourierOptions.NoScaling);

            // Magnitude do sinal
            mag[0] = 0;
            for (int i = 1; i < samples.Length/p; i++)
            {
                mag[i] = (2.0/numSamples)*(Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) + Math.Pow(samples[i].Imaginary, 2))));
            }

            // Frequência 
            int hzPerSample = (int)taxaAmostragem / numSamples;
            //Console.WriteLine(hzPerSample);

            //double[] mag2 = new double[tamanho / 2];
            for (int n = 0; n < samples.Length / p; n++)
            {
                freq[n] = n * hzPerSample;
                //mag2[n] = mag[n];
            }
            
            return (freq, mag);
            
            
            //double[] audio = FftSharp.SampleData.SampleAudio1();
            /*
            double[] audio = sinal;

            // convert the data to an array of complex numbers
            FftSharp.Complex[] buffer = new FftSharp.Complex[audio.Length];
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = new FftSharp.Complex(audio[i], 0);

            // compute the FFT in-place
            FftSharp.Transform.FFT(buffer);

            double[] fftMag = FftSharp.Transform.FFTmagnitude(sinal);

            double[] window = FftSharp.Window.Hanning(audio.Length);
            /*
            Console.WriteLine(sinaisFFT.);

            return (FftSharp.Transform.FFTfreq(taxaAmostragem, sinaisFFT.Length, true), FftSharp.Transform.FFTmagnitude(sinaisFFT));*/
            /*
            double[] fft = new double[sinal.Length];
            System.Numerics.Complex[] fftComplex = new System.Numerics.Complex[sinal.Length];
            for (int i = 0; i < sinal.Length; i++)
                fftComplex[i] = new System.Numerics.Complex(sinal[i], 0.0);
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);

            ILNumerics.fft

            BufferedWaveProvider bwp;

            int BUFFERSIZE = (int)Math.Pow(2, 11);
            int frameSize = BUFFERSIZE;
            var audioBytes = new byte[frameSize];
            //bwp.Read(audioBytes, 0, frameSize);

            int BYTES_PER_POINT = 1;
            int graphPointCount = audioBytes.Length / BYTES_PER_POINT;

            double pcmPointSpacingMs = taxaAmostragem / 1000;
            double fftMaxFreq = taxaAmostragem / 2;
            double fftPointSpacingHz = fftMaxFreq / graphPointCount;
            double[] fftX = new double[sinal.Length];

            for (int i = 0; i < sinal.Length; i++) {
                fft[i] = fftComplex[i].Magnitude;
                fftX[i] = i * fftPointSpacingHz;
            }

            return (fftX, fft);*/
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

            if (aux > 0 && aux <= canais)
            {
                graphIndex = aux;
            }
        }

        private void biofeedbackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.showEnvoltoria = !this.showEnvoltoria;
            output = new double[tamanho];
        }

        private void FFTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.showFFT = !this.showFFT;
        }

        #endregion


        #region  Gráficos


        // Permitir atualização do gráfico
        private void cleanGraph()
        {
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            graphBars.GraphPane.CurveList.Clear();
            graphBars.GraphPane.GraphObjList.Clear();
            graphFFT.GraphPane.CurveList.Clear();
            graphFFT.GraphPane.GraphObjList.Clear();
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
                {8,System.Drawing.Color.DarkOrange },
                {9,System.Drawing.Color.Black },
                {10,System.Drawing.Color.Chartreuse },
                {11,System.Drawing.Color.DarkOrange },
                {12,System.Drawing.Color.LightSeaGreen },
                {13,System.Drawing.Color.MidnightBlue },
                {14,System.Drawing.Color.Olive },
                {15,System.Drawing.Color.Orchid },
                {16,System.Drawing.Color.RoyalBlue }
            };

            // Adicionar cada curva
            for (int i = 1; i <= canais; i++)
            {

                graphCanais.GraphPane.AddCurve("Canal  " + i, x, sinais[i], cores[i], ZedGraph.SymbolType.None);

                graphCanais.GraphPane.Legend.IsVisible = true;
                //graphCanais.GraphPane.Legend.posit
            }

            // Configurando limites
            graphCanais.GraphPane.YAxis.Scale.Max = sinais[1].Max() + sinais[1].Max() * 0.05;
            //graphCanais.GraphPane.YAxis.Scale.Max = max;
            graphCanais.GraphPane.YAxis.Scale.Min = sinais[canais].Min() - sinais[canais].Min() * 0.05;
            graphCanais.GraphPane.XAxis.Scale.Min = x.Min();
            graphCanais.GraphPane.XAxis.Scale.Max = x.Max();
            graphCanais.GraphPane.XAxis.Title.Text = "Tempo (s)";
            graphCanais.GraphPane.AxisChange();
            graphCanais.Refresh();

            if (this.showEnvoltoria)
            {
                envoltoria(sinais[graphIndex], graphIndex);
                double[] envolt = output;
                graphBars.GraphPane.AddCurve("Barras", x, envolt, cores[graphIndex], ZedGraph.SymbolType.None);

                // Configurando limites
                graphBars.GraphPane.Legend.IsVisible = false;
                graphBars.GraphPane.YAxis.Scale.Max = envolt.Max() + 10;
                graphBars.GraphPane.YAxis.Scale.Min = envolt.Min() - 10;
                graphBars.GraphPane.XAxis.Scale.Min = x.Min();
                graphBars.GraphPane.XAxis.Scale.Max = x.Max();
                graphBars.GraphPane.AxisChange();
                graphBars.Refresh();
            }

            if (this.showFFT && this.finishFFT)
            {
                // Sinal com transformada de Fourier
                //Console.WriteLine(graphIndex);
                (double[] frequencia, double[] mag) fft = FFT(sinaisFFT[graphIndex].ToArray());
                graphFFT.GraphPane.AddCurve("FFT", fft.Item1, fft.Item2, cores[graphIndex], ZedGraph.SymbolType.None);
                graphFFT.GraphPane.Legend.IsVisible = false;

                // Configurando limites
                graphFFT.GraphPane.YAxis.Scale.Max = fft.Item2.Max() + 10;
                graphFFT.GraphPane.YAxis.Scale.Min = fft.Item2.Min() - 10;
                graphFFT.GraphPane.XAxis.Scale.Max = fft.Item1.Max();
                //graphFFT.GraphPane.XAxis.MA
                graphFFT.GraphPane.AxisChange();
                graphFFT.Refresh();
            }

        }

        // Configuração inicial da tela
        private void configurarInterface()
        {
            // Gráfico dos canais
            graphCanais.GraphPane.XAxis.IsVisible = true;
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
            graphFFT.GraphPane.XAxis.Title.Text = "Frequência (Hz)";
            graphFFT.GraphPane.YAxis.IsVisible = true;
            graphFFT.GraphPane.YAxis.Title.Text = "Magnitude";
            graphFFT.GraphPane.Title.IsVisible = false;
            graphFFT.GraphPane.Margin.All = 0;
        }

        
        //define o tipo de offset
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.offsetType = true;
        }
        
        private void graphCanais_Load(object sender, EventArgs e)
        {

        }
        #endregion


        #region Botões
        private void btmFFT_Click(object sender, EventArgs e)
        {
            if(this.calcFFT == false)
            {
                this.calcFFT = true;
                btmFFT.Text = "Parar";
                btmFFT.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                sinaisFFT.Clear();
                firstPoints = false;
            }
            else
            {
                this.calcFFT = false;
                this.finishFFT = true;
                btmFFT.Text = "Iniciar";
                btmFFT.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            }
        }
        
        // Botão conectar
        private void btmConectar_Click(object sender, EventArgs e)
        {
            
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
                    btmConect.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    this.showGraphBluetooth = !this.showGraphBluetooth;
                    serialPort2.Close();
                    comboBox1.Enabled = true;
                    btmConect.Text = "Conectar";
                    btmConect.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                    this.auxGraphs = true;

                    cbCanais.Enabled = true;
                    cbJanela.Enabled = true;
                    txtAmostragem.Enabled = true;
                    txtEnvoltoria.Enabled = true;

                    cbCanais.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                    cbJanela.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                    txtAmostragem.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                    txtEnvoltoria.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                    
                }
                catch
                {
                    return;
                }

            }

            if (serialPort2.IsOpen == true)
            {
                Console.WriteLine("iniciado");
                taxaAmostragem = Convert.ToDouble(txtAmostragem.Text);
                janENV = Convert.ToInt32(txtEnvoltoria.Text);
                limiarBird = Convert.ToInt32(txtFlappy.Text);
                try
                {
                    tamanho = Convert.ToInt32(cbJanela.SelectedItem.ToString());
                }
                catch
                {
                    tamanho = 1000;
                }
                try
                {
                    canais = Convert.ToInt32(cbCanais.SelectedItem.ToString());
                }
                catch
                {
                    canais = 8;
                }
                try
                {
                    canal = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                }
                catch
                {
                    canal = 1;
                }

                Console.WriteLine("iniciado");
                btmConect.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                this.inicializaVetor();
                this.inicializarDicionarios();
                this.showGraphBluetooth = !this.showGraphBluetooth;
                this.showGraphRead = false;

                cbCanais.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                cbCanais.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                cbJanela.BackColor =  System.Drawing.Color.FromArgb(255, 0, 0);
                txtAmostragem.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                txtEnvoltoria.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                txtFlappy.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);

                cbCanais.Enabled = false;
                cbJanela.Enabled = false;
                txtAmostragem.Enabled = false;
                txtEnvoltoria.Enabled = false;

                Console.WriteLine("as");
                this.configurarInterface();

                this.readPoints();
            }
        }

        //botão para começar a salvar os dados
        private void btmPlay_Click(object sender, EventArgs e)
        {
            if (this.play == false)
            {
                fileName = txtArquivo.Text + ".csv";
                this.play = true;
                btmPlay.Text = "Parar";
                btmPlay.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                sinaisFFT.Clear();
                firstPoints = false;
                //calcFFT = false;

                //exclui o arquivo caso ele exista
                if (!this.auxWriteCSV && File.Exists(fileName))
                {
                    File.Delete(fileName);
                    this.auxWriteCSV = true;
                }
            }
            else
            {
                this.play = false;
                btmPlay.Text = "Play";
                btmPlay.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                //calcFFT = true;
            }

        }

        // Botão para ler arquivo
        private void readFileButton_Click(object sender, EventArgs e)
        {
            this.readFile = !this.readFile;
            
            this.showGraphBluetooth = false;

            if (!this.showGraphRead)
            {
                this.inicializarDicionarios();
                btmRead.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                this.showGraphRead = true;
            }
            else
            {
                btmRead.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                this.showGraphRead = false;
            }
        }
        

        private void btmWIFI_Click(object sender, EventArgs e)
        {
            
            if (!this.showGraphWIFI)
            {
                Console.WriteLine("iniciado");
                taxaAmostragem = Convert.ToDouble(txtAmostragem.Text);
                janENV = Convert.ToInt32(txtEnvoltoria.Text);
                limiarBird = Convert.ToInt32(txtFlappy.Text);
                try
                {
                    tamanho = Convert.ToInt32(cbJanela.SelectedItem.ToString());
                }
                catch
                {
                    tamanho = 1000;
                }
                try
                {
                    canais = Convert.ToInt32(cbCanais.SelectedItem.ToString());
                }
                catch
                {
                    canais = 8;
                }
                try
                {
                    canal = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                }
                catch
                {
                    canal = 1;
                }

                cbCanais.Enabled = false;
                cbJanela.Enabled = false;
                txtAmostragem.Enabled = false;
                txtEnvoltoria.Enabled = false;

                cbCanais.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                cbJanela.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                txtAmostragem.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                txtEnvoltoria.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                txtFlappy.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);

                UdpClient udpClientSend = new UdpClient();
                udpClientSend.Connect(tbIP.Text, Convert.ToInt16(tbPort.Text));
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClientSend.Send(senddata, senddata.Length);
                btmWIFI.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                btmWIFI.Text = "Desconectar";

                this.showGraphWIFI = true;
                //AddressFamily a = 8080;
                udpClient = new UdpClient(8080); //tbPort.Text
                this.inicializaVetor();
                this.inicializarDicionarios();
            }
            else
            {
                /*
                UdpClient udpClientSend = new UdpClient();
                udpClient.Connect(tbIP.Text, Convert.ToInt16(tbPort.Text));
                Byte[] senddata = Encoding.ASCII.GetBytes("n");
                udpClientSend.Send(senddata, senddata.Length);*/

                btmWIFI.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
                btmWIFI.Text = "Conectar";
                this.showGraphWIFI = false;
                udpClient.Close();
                this.showEnvoltoria = false;
                

            }

        }

        #endregion


        #region Flappy bird
        // Timer to Flappy Bird Update the Scenario 
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (startFlag)
            {
                moveTrees(10);
                moveHurdles(10);
                GameOver();

                ScoreLabel.Visible = true;
                string aux = "Score: " + score.ToString() + "s";
                ScoreLabel.Text = aux;
            }
            
        }

        Random r = new Random();

        // Move the hurdles
        void moveHurdles(int speed)
        {

            if (h1.Left >= 0) 
            { 
                h1.Left += -speed; 
            }
            else 
            {
                h1.Height = r.Next(150, 250);
                h1.Left = 1650; 
            }

            if (h2.Left >= 0)
            {
                h2.Left += -speed;
            }
            else
            {
                h2.Height = r.Next(300, 400);
                h2.Left = 1650;
            }

            if (h3.Left >= 0)
            {
                h3.Left += -speed;
            }
            else
            {
                h3.Height = r.Next(150, 250);
                h3.Left = 1650;
            }

            if (h4.Left >= 0)
            {
                h4.Left += -speed;
            }
            else
            {
                h4.Height = r.Next(350, 400);
                h4.Left = 1650;
            }

            if (h5.Left >= 0)
            {
                h5.Left += -speed;
            }
            else
            {
                h5.Height = r.Next(150, 250);
                h5.Left = 1650;
            }

            if (h6.Left >= 0)
            {
                h6.Left += -speed;
            }
            else
            {
                h6.Height = r.Next(300, 400);
                h6.Left = 1650;
            }

        }

        // Move trees
        void moveTrees(int speed)
        {
            if (tree1.Left >= 0) { tree1.Left += -speed; }         
            else { tree1.Left = 1650; }

            if (tree2.Left >= 0) { tree2.Left += -speed; }
            else { tree2.Left = 1650; }

            if (tree3.Left >= 0) { tree3.Left += -speed; }
            else { tree3.Left = 1650; }

            if (tree4.Left >= 0) { tree4.Left += -speed; }
            else { tree4.Left = 1650; }

        }

        // Timer to Update the Bird (Player)
        private void timer3_Tick(object sender, EventArgs e)
        {
            if(bird.Top <= 500 && startFlag)
            { 
                bird.Top += 10;
                
                scoreAux++;
                if(scoreAux == 10)
                {
                    scoreAux = 0;
                    score++;
                }
            }
            if (flappyBird == true) {
                /*
                for (int i = 0; i < tamanho / janENV; i++)
                {
                    double max = 0;
                    for (int j = 0; j < janENV; j++)
                    {
                        if (sinais[canal][i * janENV + j] > max) max = sinais[canal][i * janENV + j];
                        if (max > limiarBird)
                        {
                            bird.Top += -50;
                            j = janENV;
                            i = tamanho / janENV;
                        }
                    }

                }*/
            }
        }

        void GameOver()
        {
            if (bird.Bounds.IntersectsWith(h1.Bounds) || bird.Bounds.IntersectsWith(h2.Bounds) || bird.Bounds.IntersectsWith(h3.Bounds) || bird.Bounds.IntersectsWith(h4.Bounds) || bird.Bounds.IntersectsWith(h5.Bounds) || bird.Bounds.IntersectsWith(h6.Bounds))
            {               
                // Desabilitar os timers - Travar o jogo
                timer1.Enabled = false;
                timer3.Enabled = false;

                GameOverLabel.Visible = true;
                restartButton.Visible = true;
                restartButton.Enabled = true;

                startFlag = false;
            }
        }

        // Click to Update the Y of Bird (Player)
        private void MouseClick_FlappyBird(object sender, MouseEventArgs e)
        {
            if (startFlag)
            {
                bird.Top += -50;
            }
        }

        //
        private void emgFlappyBird(double[] sinal, int can)
        {
            double[] output = new double[tamanho];
            for (int i=0; i < tamanho / janENV; i++)
            {
                double max = 0;
                for(int j=0; j<janENV; j++)
                {
                    if (sinal[i * janENV + j] > max) max = sinal[i * janENV + j];
                    if(max > limiarBird)
                    {
                        bird.Top += -50;
                        j = janENV;
                        i = tamanho / janENV;
                    }
                }
                
                //Console.WriteLine(max);
                //Console.WriteLine("--------------");
                /*if (max > limiarBird)
                {
                    bird.Top += -50;
                }*/
            }
        }

        // Start Button clicked
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer3.Enabled = true;

            startFlag = true;
            startButton.Visible = false;
            startButton.Enabled = false;

            GameOverLabel.Visible = false;
            restartButton.Visible = false;
            restartButton.Enabled = false;

        }

        // Restart Button clicked
        private void restartButton_Click(object sender, EventArgs e)
        {
            startFlag = false;
            startButton.Visible = true;
            startButton.Enabled = true;

            restartButton.Visible = false;
            restartButton.Enabled = false;
            GameOverLabel.Visible = false;

            ScoreLabel.Text = "Score: 0s";
            resetScenario();
            score = 0;

        }

        // Reset scenario to initial positions
        private void resetScenario()
        {
            h1.Height = 280;
            h1.Width = 200;

            h2.Size = h1.Size;
            h3.Size = h1.Size;
            h4.Size = h1.Size;
            h5.Size = h1.Size;
            h6.Size = h1.Size;

            bird.Left = 61;
            bird.Top = 331;

            h1.Left = 180;
            h1.Top = 0;
            h2.Left = 180;
            h2.Top = 450;

            h3.Left = 860;
            h3.Top = 0;
            h4.Left = 860;
            h4.Top = 450;

            h5.Left = 1520;
            h5.Top = 0;
            h6.Left = 1520;
            h6.Top = 450;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCanais_SelectedIndexChanged(object sender, EventArgs e)
        {
            canais = Convert.ToInt32(cbCanais.Items[cbCanais.SelectedIndex]);
        }

        private void cbJanela_SelectedIndexChanged(object sender, EventArgs e)
        {
            tamanho = Convert.ToInt32(cbJanela.Items[cbJanela.SelectedIndex]);
        }

        private void flappyBirdcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            this.flappyBird = true;
        }

        #endregion

        #region Labiriton

        private void createMaze()
        {
            int w = 10, h = 10;

            Maze m = new Maze(w, h);
            int[,] matrix = m.Generate();

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
        #endregion
    }
}
