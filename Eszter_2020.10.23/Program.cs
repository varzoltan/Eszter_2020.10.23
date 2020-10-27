using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eszter_2020._10._23
{
    class Program
    {
        static string[] kiserlet = new string[1000000];

        static void Main(string[] args)
        {
            //Fájl megnyítása
            //Létrehozok egy tömböt, amibe a fájlban lévő értékeket teszem.
            //string[] kiserlet = new string[1000000];
            //StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Downloads\kiserlet.txt");
            //Itt isjuk meg a megnyitás és bezárás között a programunkat!
            /*int szamlalo = 0;
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                kiserlet[szamlalo] = sor;
                szamlalo++;
            }
            
            olvas.Close();//Fájl bezárása
            //Pélfda fájl beolvasására
            //1. using (névtér) ki kell egészíteni egy új objektummal, melyne neve: System.IO
            for (int i = 0;i<101;i++)
            {
                Console.WriteLine(kiserlet[i]);
            }
            */
            Beolvas(@"C:\Users\Rendszergazda\Downloads\kiserlet.txt");
            Kiiras();
            Console.ReadKey();
        }

        static void Beolvas(string eleresi_ut)
        {
            //string[] kiserlet = new string[1000000];//Inicializáltuk a tómböt.
            StreamReader beolvas = new StreamReader(eleresi_ut);
            int szamlalo = 0;
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                kiserlet[szamlalo] = sor;
                szamlalo++;
            }
            beolvas.Close();
            Console.WriteLine("Beolvasás kész!!!");
        }

        static void Kiiras()
        {
            int szamlalo = 0;
            while (szamlalo < kiserlet.Length)
            {
                Console.WriteLine(kiserlet[szamlalo]);
                szamlalo++;
            }
        }
    }
}
