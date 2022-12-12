using System;
using System.Globalization;

namespace PrimeiroProjeto 
{
    class Program
    {
        static void Main(string[] args) {

          
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantas unidades você irá comprar? ");
            int unidades = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do produto: R$ ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor total da compra: R$ ");
            double total = unidades * valor;
            Console.WriteLine(total.ToString("F2"));

            Console.WriteLine(nome);
            Console.WriteLine(unidades);
            Console.WriteLine(valor);
            Console.WriteLine(total.ToString("F2"));
           

            Console.ReadLine();               

        }
    }
}
