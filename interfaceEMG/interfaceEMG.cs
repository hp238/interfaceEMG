﻿using System;
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

namespace interfaceEMG
{
    public partial class formInterface : Form
    {

        private Boolean[] estado = new Boolean[8];
        static int tamanho = 1000; //tamanho do vetor de teste
        private double[] x = new double[tamanho]; //eixo x
        private int taxa = 100;
        private int janela = 2;
        private int auxJan = 0;

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
        }; //eixo y dos 8 canais
        private Dictionary<int, Double[]> retas = new Dictionary<int, double[]>();  //retas entre canais

        public formInterface()
        {
            InitializeComponent();
            this.configurarInterface();
            timer2.Enabled = true;
            //this.atualizaListaCOMs();
        }

        //configuração inicial da tela
        private void configurarInterface()
        {
            graphCanais.GraphPane.XAxis.IsVisible = false;
            graphCanais.GraphPane.YAxis.IsVisible = false;
            graphCanais.GraphPane.Title.IsVisible = false;
            graphCanais.GraphPane.Margin.All = 0;
        }

        //atualiza listas de portas conectadas
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

        //botão conectar
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
                while (true)
                {
                    Thread.Sleep(1000);
                    //this.ler8Dados();
                    this.read();
                    this.configurarCurvas();
                }
                //this.lerDados();
                //this.configurarCurvas();
            }
        }

        //ler dados da porta serial
        private void lerDados()
        {
            MessageBox.Show("t1");
            progressBar1.Visible = true;    //barra de progresso
            progressBar1.Maximum = tamanho;
            progressBar1.Value = 0;
            serialPort2.ReadLine(); //teste
            serialPort2.ReadLine(); //teste
            Random numAl = new Random();    //teste
            MessageBox.Show("t2");
            //ler valores de cada canal
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

            //calculando os valores de máximo dos sinais para determinar a posição das linhas horizontais
            double[] maxs = new double[8];
            for (int y = 1; y <= 8; y++)
            {
                maxs[y - 1] = sinais[y].Max();
            }
            double offset = maxs.Max();
            double offsetInic = offset;

            //varrer canais para adicionar um offset aos sinais para o posicionamento da tela
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

        private void ler8Dados()
        {
            retas.Clear();
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            progressBar1.Visible = true;    //barra de progresso
            progressBar1.Maximum = tamanho;
            progressBar1.Value = 0;
            serialPort2.ReadLine(); //teste
            serialPort2.ReadLine(); //teste
            Random numAl = new Random();    //teste
            //ler valores de cada canal
            for (int y = 1; y <= 8; y++)
            {
                try
                {

                    double aux = Convert.ToDouble(serialPort2.ReadLine()) / 100;
                    //MessageBox.Show(Convert.ToString(aux));

                    /*for(int j = 0; j<99; j++)
                    {
                        sinais[y][j] = sinais[y][j + 1];
                    }*/
                    sinais[y][99] = aux * numAl.Next(1, 101);
                    Console.WriteLine(sinais[y][99] + "\n");
                }
                catch
                {
                    y--;
                }
            }

            progressBar1.Value = tamanho;

            //calculando os valores de máximo dos sinais para determinar a posição das linhas horizontais
            double[] maxs = new double[8];
            for (int y = 1; y <= 8; y++)
            {
                maxs[y - 1] = sinais[y].Max();
            }
            double offset = maxs.Max();
            double offsetInic = offset;

            //varrer canais para adicionar um offset aos sinais para o posicionamento da tela
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

        //
        private void read()
        {
            retas.Clear();
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            //Permitir atualização do gráfico
            //código para sortear os valores de Y dos 8 canais
            Random numAl = new Random();
            double max = 0;

            Double[] aux = new double[tamanho];

            for (int y = 8; y >= 1; y--)
            {
                aux = sinais[y];
                for (int k = 0; k < tamanho - taxa; k++)
                {
                    aux[k] = aux[k + 100];
                }
                for (int i = tamanho - taxa; i < tamanho; i++)
                {
                    try
                    {
                        //aux[i] = numAl.Next(1, 101)

                        aux[i] = (Convert.ToDouble(serialPort2.ReadLine()) / 100) * numAl.Next(1, 101) + max;
                        //Console.WriteLine(i + " " + aux[i] + " = " + aux[i+1] + "\n");
                        Console.WriteLine(max + "\n");

                        //aux[99] = Convert.ToDouble(serialPort2.ReadLine()) / 100;
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

        //gerar curvas aleatoriamente para testes
        private void gerarCurvas()
        {
            retas.Clear();
            graphCanais.GraphPane.CurveList.Clear();
            graphCanais.GraphPane.GraphObjList.Clear();
            //Permitir atualização do gráfico
            //código para sortear os valores de Y dos 8 canais
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
                //

                retas.Add(y, ret);

            }
        }

        //configurar plot
        private void configurarCurvas()
        {
            //Cores das curvas
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
            //adicionar cada curva
            for (int i = 1; i <= 8; i++)
            {
                graphCanais.GraphPane.AddCurve("minha curva", x, sinais[i], cores[i], ZedGraph.SymbolType.None);
                if (i != 1)
                {
                    graphCanais.GraphPane.AddCurve("minha curva", x, retas[i], System.Drawing.Color.Black, ZedGraph.SymbolType.None);
                }

                graphCanais.GraphPane.Legend.IsVisible = false;
            }
            //configurando limites
            graphCanais.GraphPane.YAxis.Scale.Max = sinais[1].Max() + 10;
            graphCanais.GraphPane.YAxis.Scale.Min = sinais[8].Min() - 10;
            graphCanais.GraphPane.XAxis.Scale.Max = x.Length;
            graphCanais.GraphPane.AxisChange();
            graphCanais.Refresh();
        }

        //botão para gerar curvas aleatoriamente
        private void btmTeste_Click(object sender, EventArgs e)
        {
            this.gerarCurvas();

            //String a = serialPort2.ReadLine();
            //MessageBox.Show("a");
            this.configurarCurvas();
        }

        //timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
    }

}

