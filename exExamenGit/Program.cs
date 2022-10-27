using System;

namespace exExamenGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demanar variables
            string operatiu;
            int a, b;
            int sol1, sol2, sol3, sol4;

            //Mostrar valors entrada
            Console.WriteLine("Demana l'operació: +, -, *, /");
            operatiu = Convert.ToInt32(Console.ReadLine();
            Console.WriteLine("Escriu el numero a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu el numero b");
            b = Convert.ToInt32(Console.ReadLine());
            //Algoritme
            if (operatiu == "+")
            {
                sol1 = Convert.ToInt32(a + b);
                Console.WriteLine(sol1);
            }
            else if (operatiu == "-")
            {
                sol2 = Convert.ToInt32(a - b);
                Console.WriteLine(sol2);
            }
            else if (operatiu == "*")
            {
                sol3 = Convert.ToInt32(a * b);
                Console.WriteLine(sol3);
            }
            else if (operatiu == "/")
            {
                sol4 = Convert.ToInt32(a / b);
                Console.WriteLine(sol4);
            }
            //Mostrar resultats sortida
        }
    }
}
