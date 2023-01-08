using System;

namespace Lab4supliment1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc doua numere de la tastatura. Scrieti un program care va calcula cel mai mare divizor comun al numerelor */

            Console.WriteLine("Introduceti primul numar: ");
            int primulNumar = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            int alDoileaNumar = int.Parse(Console.ReadLine());

            int cmmdc = CalculeazaCelMaiMareDivizorComun(primulNumar, alDoileaNumar);

            Console.WriteLine("Cel mai mare divizor comun pentru " + primulNumar + " si " + alDoileaNumar + " este " + cmmdc); 
        }

        static int CalculeazaCelMaiMareDivizorComun(int primulNumar, int alDoileaNumar)
        {
            int rest;
            while (alDoileaNumar != 0)
            {
                rest = primulNumar % alDoileaNumar;
                primulNumar = alDoileaNumar;
                alDoileaNumar = rest;
            }
            return primulNumar;
        }
    }
}
