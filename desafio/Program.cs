using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
             float idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7){
            Console.WriteLine("Você está na categoria Infantil A 5 - 7 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
                else if (idade >= 8 && idade <= 10){
                Console.WriteLine("Você está na categoria infantil B, 8 - 10 anos.");
                Console.WriteLine("\nCategorizador finalizado.");
                }
                    else if (idade >= 11 && idade <= 13){
                    Console.WriteLine("Você está na categoria Juvenil A, 11 - 13 anos.");
                    Console.WriteLine("\nCategorizador finalizado.");
                    }
                        else if (idade >= 14 && idade <= 17){
                        Console.WriteLine("Você está na categoria Juvenil B, 14 - 17 anos.");
                        Console.WriteLine("\nCategorizador finalizado.");
                        }
                            else if (idade >= 18){
                            Console.WriteLine("Você está na categoria sênior, maiores de 18 anos.");
                            Console.WriteLine("\nCategorizador finalizado.");
                            }
            else{
            Console.WriteLine("Você está enquadrado em nenhuma categoria, volte quando tiver no minimo 5 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
        }
    }
}
