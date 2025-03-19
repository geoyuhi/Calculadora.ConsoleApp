namespace Calculadora.ConsoleApp;
using System;
using System.ComponentModel.Design;

internal class Program
{
    private static string opcao;

    private static void Main(string[] args)
    {
        string[] historicooperacoes = new string[100];
        int contadorhistorico = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Calculadora");
            Console.WriteLine("------------------------------");

            //v9-verificar historico de operacoes

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico de Operações");
            Console.WriteLine("S - Sair");
            Console.WriteLine("-----------------------------------------");

            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            if (opcao == "S")
                break;

            else if (opcao == "5")
            {
                Console.Write("Digite o número desejado: ");
                string strNumeroTabuada = Console.ReadLine();
                int numeroTabuada = Convert.ToInt32(strNumeroTabuada);

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
                }
                Console.ReadLine();
                continue;
            }

            else if (opcao == "6")
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Histórico de Operações");
                Console.WriteLine("-------------------------------");

                for (int contador = 0; contador < contadorhistorico; contador++)
                {
                    Console.WriteLine(historicooperacoes[contador]);
                }
                Console.ReadLine();
                continue;
            }

            Console.Write("Digite o primeiro número: ");
            string strprimeironumero = Console.ReadLine(); //texto
            decimal primeironumero = Convert.ToDecimal(strprimeironumero);

            Console.Write("Digite o segundo número: ");
            string strsegundonumero = Console.ReadLine();
            decimal segundonumero = Convert.ToDecimal(strsegundonumero);

            decimal resultado = 0;


            if (opcao == "1")
            {
                resultado = primeironumero + segundonumero;
                historicooperacoes[contadorhistorico] = $"{primeironumero} + {segundonumero} = {resultado}";

            }
            else if (opcao == "2")
            {
                resultado = primeironumero - segundonumero;
                historicooperacoes[contadorhistorico] = $"{primeironumero} - {segundonumero} = {resultado}";

            }
            else if (opcao == "3")
            {
                resultado = primeironumero * segundonumero;
                historicooperacoes[contadorhistorico] = $"{primeironumero} * {segundonumero} = {resultado}";

            }
            else if (opcao == "4")
            {
                while (segundonumero == 0)
                {
                    Console.Write("Digite o segundo número novamente: ");

                    segundonumero = Convert.ToDecimal(Console.ReadLine());
                }
                resultado = primeironumero / segundonumero;
                historicooperacoes[contadorhistorico] = $"{primeironumero} / {segundonumero} = {resultado}";

            }
            else
                continue;

            contadorhistorico++;

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadLine();
        }
    }
}