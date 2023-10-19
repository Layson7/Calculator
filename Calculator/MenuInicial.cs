using Calculator.OperacoesMatematicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MenuInicial
    {
       
        public static void Menu()
        {
            
            Console.Clear();
            Console.WriteLine(" ___________________________________");
            Console.WriteLine("|       O que deseja fazer?         |");
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|       Digite 1 para Soma          |");
            Console.WriteLine("|     Digite 2 para Subtração       |");
            Console.WriteLine("|    Digite 3 para Multiplicação    |");
            Console.WriteLine("|      Digite 4 para Divisão        |");
            Console.WriteLine("|       Digite 0 para sair          |");
            Console.WriteLine("|___________________________________|");

            int numeroDigitado;
            try
            {
                numeroDigitado = int.Parse(Console.ReadLine());


                if (numeroDigitado > 4 || numeroDigitado < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Numero invalido.. tente novamente");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Menu();
                }
                else
                {
                    switch (numeroDigitado)
                    {
                        case 1:
                            OpSoma.Soma();
                            break;
                        case 2:
                            OpSubtracao.Subtracao();
                            break;
                        case 3:
                            OpMultiplicacao.Multiplicacao();
                            break;
                        case 4:
                            OpDivisao.Divisao();
                            break;
                        case 0:
                            FuncSair.Sair();
                            break;
                    }
                }
            }catch (Exception ) 
            {
                Console.Clear();
                Console.WriteLine("A calculadora não aceita caracteres!!");
                Console.WriteLine("Por favor Digite um Numero");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Voltando ao menu...");
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
            }
        }


    }
}

