using System;

namespace INSS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sai se você é aposentavel ou não");
            Console.WriteLine("-------------");

            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha um gênero");
            Console.WriteLine("1 - Masculino | 2 - Feminino");
            short genero = short.Parse(Console.ReadLine());

            switch (genero)
            {
                case 1: masculino(); break;
                case 2: feminino(); break;
                default: Menu(); break;
            }
        }

        static void masculino()
        {
            Console.Clear();

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos de contribuição?");
            int AnosDeContribuicao = int.Parse(Console.ReadLine());

            if (idade >= 65 && AnosDeContribuicao >= 10 || idade >= 63 && AnosDeContribuicao >= 15)
            {
                Console.WriteLine("Aposentavel");
            }
            else
            {
                Console.WriteLine("Não Aposentável");
            }
        }
        static void feminino()
        {
            Console.Clear();

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos de contribuição?");
            int AnosDeContribuicao = int.Parse(Console.ReadLine());

            if (idade >= 63 && AnosDeContribuicao >= 10 || idade >= 61 && AnosDeContribuicao >= 15)
            {
                Console.WriteLine("Aposentavel");
            }
            else
            {
                Console.WriteLine("Não Aposentável");
            }
        }

    }
}