using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceEMG
{
    static class tools
    {
        public static void offset(Dictionary<int, Double[]> sinais, int limit, int tamanho)
        {
            for (int y = 7; y >= 1; y--)
            {
                //Console.WriteLine(y);
                double max = sinais[y + 1].Max();
                for (int i = limit; i < tamanho; i++)
                {
                    sinais[y][i] += max;
                }

            }
        }

        public static void shift(Dictionary<int, Double[]> sinais, int limit, int taxa)
        {
            //Console.WriteLine(limit);
            for (int i = 0; i < limit; i++)
            {
                for (int y = 1; y < 9; y++)
                {
                    sinais[y][i] = sinais[y][i + taxa];
                }
            }
        }

        public static List<bool> concatFFT(Dictionary<int, Double[]> sinais, Dictionary<int, Double[]> sinaisFFT, Dictionary<int, Double[]> auxFFT, bool firstPoints, int tamanho, int taxa, bool play)
        {

            if (play == true)
            {

                if (firstPoints == false)
                {
                    for (int z = 1; z <= 8; z++)
                    {
                        Array.Copy(sinais[z], tamanho - taxa, auxFFT[z], 0, taxa);
                        sinaisFFT.Add(z, auxFFT[z]);
                        if (firstPoints == false) { firstPoints = true; }
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

            return new List<bool> { firstPoints, play };


        }


    }

}
