using System;

namespace Esforço
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int dia,mes,ano,idade;
            Console.Clear();
            Console.WriteLine("Qual seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o dia do seu nascimento? ");
            dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual o mes do seu nascimento? ");
            mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual o ano do seu nascimento? ");
            ano = Convert.ToInt16(Console.ReadLine());
            idade = 2021 - ano;
            if (idade <= 18)
             {
                Console.WriteLine("Uma sugestão de senha para você e: "+ nome+idade);
            }
            else
            {
                Console.WriteLine("Uma sugestão de senha para você e: " + idade+nome);
            }
        }
    }
}
