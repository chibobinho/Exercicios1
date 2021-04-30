using System;

namespace um
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Olá, " + nomePessoa + "!");

            Console.Write("Digite a sua idade: ");
            float idade = int.Parse(Console.ReadLine());

            float meses = idade * 12;
            float dias = meses * 30;
            float horas = dias * 24;
            float minutos = horas * 60;
            
            Console.WriteLine(nomePessoa + ", sua idade em meses é: " + Math.Round(meses, 1));
            Console.WriteLine("Em dias é: " + Math.Round(dias, 1));
            Console.WriteLine("Em horas é: " + Math.Round(horas, 1));
            Console.WriteLine("Em minutos é: " + Math.Round(minutos, 1));
        }
    }
}
