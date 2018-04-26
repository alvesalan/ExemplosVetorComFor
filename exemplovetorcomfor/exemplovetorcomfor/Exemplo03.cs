using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplovetorcomfor
{
    class Exemplo03
    {
        public Exemplo03()
        {
            Console.WriteLine("Quantidade de registro: ");
            int QuantidadeR = Convert.ToInt32(Console.ReadLine());

            string[] Fazendas = new string[QuantidadeR];
            int[] QuantidadesPorcos = new int[QuantidadeR];

            for (int i = 0; i < Fazendas.Length; i++)
            {
                Console.Write("Nome da fazenda: ");
                Fazendas[i] = Console.ReadLine();

                Console.WriteLine("Quantidades suinos: ");
                QuantidadesPorcos[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Fazenda com maior quantidade de porco
            int MaiorQuantidadesuinos = int.MinValue;
            string FazendaMaiorQuantidadesuinos = "";
            for(int i = 0; i < QuantidadesPorcos.Length; i++)
            {
                if (QuantidadesPorcos[i] > MaiorQuantidadesuinos)
                {
                    MaiorQuantidadesuinos = QuantidadesPorcos[1];
                    FazendaMaiorQuantidadesuinos = Fazendas[i];
                }
            }

            Console.WriteLine("Fazenda com a maior quantidade de suinos: " + FazendaMaiorQuantidadesuinos + " contem " + MaiorQuantidadesuinos);

            //Fazenda com o menor nome

            string MenorNome = "";
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 ==0)
                {
                    MenorNome = MenorNome + "a";
                }
                else
                {
                    MenorNome = MenorNome + "e";

                }
            }

                for (int i = 0; i < Fazendas.Length; i++)
                {
                    if (Fazendas[i].Length < MenorNome.Length)
                    {
                        MenorNome = Fazendas[i];
                    }

                    Console.WriteLine("Fazenda com menor nome: " + MenorNome);
                }
        
            }
        }
    
}
