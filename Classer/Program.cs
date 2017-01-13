using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖVNING 1
            /*
            Porsche info = new Porsche();
            Console.WriteLine("Hur många dörrar?");
            info.dörrar = Console.ReadLine();
            Console.WriteLine("Hur många knappar?");
            info.knappar = Console.ReadLine();
            Console.WriteLine("Hur många fönster");
            info.fönster = Console.ReadLine();
            Console.WriteLine(info.utskrift);
            Console.ReadKey();
            */
            //ÖVNING 2
            /*
            Namn info = new Namn();
            Console.WriteLine("Förnamn?");
            info.förnamn = Console.ReadLine();
            Console.WriteLine("Efternamn?");
            info.efternamn = Console.ReadLine();
            Console.WriteLine(info.utskrift);
            Console.ReadKey();
            */
            //ÖVNING 3
            Namn info = new Namn();
            Console.WriteLine("Förnamn?");
            info.förnamn = Console.ReadLine();
            Console.WriteLine("Efternamn?");
            info.efternamn = Console.ReadLine();
            Console.WriteLine(info.utskrift);
            Console.WriteLine("När föddes du? (ÅÅÅÅ)");

            ÅlderCheck(Console.ReadLine());
            info.datum = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
