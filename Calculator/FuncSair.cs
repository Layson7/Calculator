using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class FuncSair
    {
        public static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar sua calculadora!!");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("BYE BYE");
            Thread.Sleep(2000);
            Console.Clear();
            System.Environment.Exit(0);
        }
    }
}
