using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloPonavljanje4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tenisac> tenisaci = new List<Tenisac>();
            for (int i = 0; i < 32; i++)
            {
                Tenisac tenis = new Tenisac(); ;
                Console.WriteLine("Upisi Ime Tenisaca");
                tenis.Ime = Console.ReadLine();
                Console.WriteLine("Upisi Prezime Tenisaca");
                tenis.Prezime = Console.ReadLine();
                tenisaci.Add(tenis);
            }
            int j = 0;
            List<Tenisac> grupaA = new List<Tenisac>();
            List<Tenisac> grupaB = new List<Tenisac>();
            foreach (Tenisac denis in tenisaci)
            {
                if (j % 2 == 0)
                {
                    grupaA.Add(denis);
                }
                else
                {
                    grupaB.Add(denis);
                }
            }
            for (int i = 0; i < grupaA.Count; i++)
            {
                Console.WriteLine(grupaA + " vs " + grupaB);
            }
        }
    }
}