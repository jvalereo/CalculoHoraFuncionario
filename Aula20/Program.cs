using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula20, Calculo, salario do funcionario, tipo int, double
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo int, double

            int funcinario, horasTr;
            double valorHora, salario;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o número de funcionário: ");
            funcinario = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de horas trabalhadas: ");
            horasTr = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de horas trabalhadas: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();


            //Declarando a variavel salario

            salario = (valorHora * horasTr);

            //Declarando a variavel 

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("Número de funcionário; " + funcinario);
          
            Console.WriteLine("Salário do funcionário = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Teste de novo!!!");


            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa


        }
    }
}
