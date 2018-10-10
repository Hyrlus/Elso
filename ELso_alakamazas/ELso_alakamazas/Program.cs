using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELso_alakamazas
{
    class Program
    {
        public static int[] szamok = new int[10];
        static void Main(string[] args)
        {
            
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("Kérem adjon meg egy számot: ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
                
                
            }
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
        }
    }
}
