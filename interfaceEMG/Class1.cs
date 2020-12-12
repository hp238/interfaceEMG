using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceEMG
{
    static class tools
    {
        //offset ajustável
        public static void offset(Dictionary<int, Double[]> sinais, int limit, int tamanho, int canais)
        {
            for (int y = canais-1; y >= 1; y--) //canais-1 para ignorar o canal 8
            {
                double max = sinais[y + 1].Max();
                for (int i = limit; i < tamanho; i++)
                {
                    sinais[y][i] += max;
                }

            }
        }

        //offset constante
        public static void offsetNorm(Dictionary<int, Double[]> sinais, int limit, int tamanho, int canais)
        {
            
            double[] max = new double[canais];
            double aux = 0;
            for (int y = canais; y >= 1; y--)
            {
                for (int i = limit; i < tamanho; i++)
                {
                    if(sinais[y][i] > aux)
                    {
                        aux = sinais[y][i];
                    }
                }
                max[y - 1] = aux;
            }
            double maxi = 4000;// max.Max();
            /*Console.WriteLine(maxi * 8);
            Console.WriteLine(maxi * 7);
            Console.WriteLine(maxi * 6);
            Console.WriteLine(maxi * 5);
            Console.WriteLine(maxi * 4);
            Console.WriteLine(maxi * 3);
            Console.WriteLine(maxi * 2);
            Console.WriteLine(maxi * 1);*/
            for (int y = canais; y >= 1; y--)
            {
                for (int i = limit; i < tamanho; i++)
                {
                    sinais[y][i] += (maxi)*(canais-y);
                }
            }
        }

        public static void shift(Dictionary<int, Double[]> sinais, int limit, int taxa, int canais)
        {
            //Console.WriteLine(limit);
            for (int i = 0; i < limit; i++)
            {
                for (int y = 1; y <= canais; y++)
                {
                    sinais[y][i] = sinais[y][i + taxa];
                }
            }
        }

        public static void shiftEnvoltoria(double[] sinal, int limit, int taxa)
        {
            for (int i = 0; i < limit; i++)
            {
                sinal[i] = sinal[i + taxa];
            }
        }

        public static List<bool> concatFFT(Dictionary<int, Double[]> sinais, Dictionary<int, Double[]> sinaisFFT, Dictionary<int, Double[]> auxFFT, bool firstPoints, int tamanho, int taxa, bool play, int canais)
        {

            if (play == true)
            {

                if (firstPoints == false)
                {
                    for (int z = 1; z <= canais; z++)
                    {
                        Console.WriteLine(z);
                        double[] a = auxFFT[z];
                        Array.Copy(sinais[z], tamanho - taxa, auxFFT[z], 0, taxa);
                        sinaisFFT.Add(z, auxFFT[z]);
                        if (firstPoints == false) { firstPoints = true; }
                    }
                }
                else
                {
                    Double[] aux3;
                    for (int z = 1; z <= canais; z++)
                    {
                        Array.Copy(sinais[z], tamanho - taxa, auxFFT[z], 0, taxa);
                        aux3 = sinaisFFT[z];
                        aux3.Concat(auxFFT[z]);
                        sinaisFFT.Remove(z);
                        sinaisFFT.Add(z, aux3);
                    }
                }
            }

            return new List<bool> { firstPoints, play };


        }


    }

}
