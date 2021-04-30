using System;

namespace tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você está no atendimento da empresa Vyolet, qual é o seu nome?");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Bom dia, " + nomePessoa + "!");

            Console.Write(nomePessoa + ", digite o seu salário: ");
            float salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu salário é de " + salario + " reais!");

            if (salario > 500)
            {
                // Executado se a condição é verdadeira
                Console.WriteLine("Você não tem direito à aumento!");
            } else{
                // Executado se a condição é falsa
                double aumento = salario * 1.3;
                Console.WriteLine("Parabéns! Seu salario atual é de: " + aumento + " reais!");
            }









        }
    }
}
