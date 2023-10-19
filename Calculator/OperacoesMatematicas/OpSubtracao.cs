using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperacoesMatematicas
{
    public class OpSubtracao
    {
        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero para a subtração");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero para a subtração");
            double num2 = int.Parse(Console.ReadLine());

            double valorTotal = num1 - num2;

            Console.Clear();
            Console.WriteLine($"O total da subtração de {num1} menos {num2} è: {valorTotal}");
            Console.WriteLine(" ");
            AposSubtracao();
        }

        static void AposSubtracao()
        {
           
            Console.WriteLine("______________________________________");
            Console.WriteLine("|         O que deseja fazer?         |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|    Digite 1 para outra Subtração    |");
            Console.WriteLine("|     Digite 2 para voltar o Menu     |");
            Console.WriteLine("|          Digite 0 para sair         |");
            Console.WriteLine("|_____________________________________|");

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
                    AposSubtracao();
                }
                else
                {
                    switch (numeroDigitado)
                    {
                        case 1:
                            Subtracao();
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
                AposSubtracao();
        }   }
    }
}
