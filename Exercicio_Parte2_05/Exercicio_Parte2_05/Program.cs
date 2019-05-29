using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0; //Variável que fica o primeiro valor
            int segundoNumero = 0; //Variável que fica o segundo valor
            int somaValores = 0; //Variável que armazena a resultado da SOMA
            int multiplicacaoValores = 0; //Variável que armazena a resultado da MULTIPLICAÇÃO
            double divisaoValores = 0; //Variável que armazena a resultado da DIVISÃO

            //Informa ao usuario para informar o primeiro número
            Console.Write("Digite o valor do Primeiro Número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            //Informa ao usuário para informar o segundo número
            Console.Write("Digite o valor do Segundo Número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            //Depois de ter pegado os dois valores o programa vai somar os dois e mostrar o resultado na tela
            somaValores = primeiroNumero + segundoNumero;
            Console.WriteLine("O Valor da SOMA é: {0}", somaValores);

            //Depois ele vai multiplicar os dois Números e mostrar o valor na tela
            multiplicacaoValores = primeiroNumero * segundoNumero;
            Console.WriteLine("O Valor da MULTIPLICAÇÃO é: {0}", multiplicacaoValores);

            //Depois ele vai dividir os dois Números e mostrar o valor na tela
            divisaoValores = Convert.ToDouble(primeiroNumero) / Convert.ToDouble(segundoNumero);
            Console.WriteLine("O Valor da DIVISÃO é: {0}", divisaoValores);
        }
    }
}
