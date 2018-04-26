using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplovetorcomfor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            string[] MortesDoFilme = new string[5];

            //forma old
            // mortesDoFilme[0] = "Tony stark";

            // Armazena as informaçoes no vetor

            for (int i = 0; i < MortesDoFilme.Length; i++)
            {
                Console.WriteLine("Digite o nome de quem morreu:");
                MortesDoFilme[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Pessoas cadastradas: ");

            //Apresentar as informaçoes do vetor
            for (int i = 0; i < MortesDoFilme.Length; i++)
            {
                Console.WriteLine("Nome: " + MortesDoFilme[i]);
            }
        }
    }
}
