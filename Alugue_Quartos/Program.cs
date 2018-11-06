using System;

namespace Alugue_Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] quartos = new Aluguel[10];

            Console.Write("Quantos registros deseja fazer?");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i<N; i++)
            {
                Console.WriteLine("Dados Do " + i + "º Aluguel: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int pos = int.Parse(Console.ReadLine());
                quartos[pos] = new Aluguel(nome, email);
            }

            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
