using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplovetorcomfor
{
    class Exemplo02
    {
        public Exemplo02()
        {
            int[] Level1NoLol = new int[5];
            for (int i = 0; i < Level1NoLol.Length; i++)
            {
                Console.WriteLine("Digite seu level no Lol: ");
                Level1NoLol[i] = Convert.ToInt32(Console.ReadLine());
            }
            int SomaLevels = 0;

            for (int i = 0; i < Level1NoLol.Length; i++)
            {
                SomaLevels = Level1NoLol[i] + SomaLevels;
            }

            double MediaLevels = SomaLevels / Level1NoLol.Length;
            Console.WriteLine(MediaLevels);
        }
    }
}
