using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperacoesMatematicas
{
     public class OpMultiplicacao
    {
        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero para a multiplicação");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero para a multiplicação");
            double num2 = int.Parse(Console.ReadLine());

            double valorTotal = num1 * num2;
            Console.Clear();
            Console.WriteLine($"O total da multiplicação de {num1} vezes {num2} è: {valorTotal}");
            Console.WriteLine(" ");
            AposMultiplicacao();
        }

        public static void AposMultiplicacao() 
        {
            
            Console.WriteLine("_________________________________________");
            Console.WriteLine("|           O que deseja fazer?          |");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("|   Digite 1 para outra Multiplicação    |");
            Console.WriteLine("|      Digite 2 para voltar o Menu       |");
            Console.WriteLine("|           Digite 0 para sair           |");
            Console.WriteLine("|________________________________________|");

            int numeroDigitado;
            try
            {
                numeroDigitado = int.Parse(Console.ReadLine());


                if (numeroDigitado > 2 || numeroDigitado < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Numero invalido.. tente novamente");
                    Thread.Sleep(1500);
                    Console.Clear();
                    AposMultiplicacao();
                }
                else
                {
                    switch (numeroDigitado)
                    {
                        case 1:
                            Multiplicacao();
                            break;
                        case 2:
                            MenuInicial.Menu();
                            break;
                        case 0:
                            FuncSair.Sair();
                            break;
                    }
                }
            }
            catch (Exception )
            {
                Console.Clear();
                Console.WriteLine("A calculadora não aceita caracteres!!");
                Console.WriteLine("Por favor Digite um Numero");
                Thread.Sleep(3000);
                Console.Clear();
                AposMultiplicacao();
            }
        }
     }
    
}


