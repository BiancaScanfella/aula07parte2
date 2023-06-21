using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rifa = new Random();

            int numer;
            int sorteamento = rifa.Next(1, 9);


            Console.WriteLine("Bem-vindo ao 21zinho");
            Console.WriteLine("Escolha um número de 1 à 9");
            Console.WriteLine("Digite o número:");
            numer = int.Parse(Console.ReadLine());

            if (numer <21 || numer >21 )
            {
                Console.WriteLine("Deseja continuar: Sim ou Não");
                Console.ReadLine();
                
                
            }
            if (numer == sorteamento)
            {
                Console.WriteLine("Parabens você venceu o jogo!");
                Console.WriteLine("Você acertou o número " +sorteamento+ "");
                Console.ReadKey();
                Main(null);
            }
            Console.WriteLine("Você errou! Tente novamente");
            Main(null);

            return;
            //&& -> E -> junção de condições
            //Todas as condições precisam ser satisfeita
            // || -> OU -> independencia das condições
            // Ao menos uma condição precisa ser satisfeita
            Random sorteador = new Random();


           


            int numero;
            int sorteio = sorteador.Next(8,11);
            Console.WriteLine("Bem-vindo a Conradito Jogos\n!");
            Console.WriteLine("Adivinhe o número entre 1 e 10");
            Console.WriteLine("Digite o número:");
            numero = int.Parse(Console.ReadLine());
           
            if (numero < 1 || numero > 10)
            {
                Console.WriteLine("Digite um número válido");
                Main(null);
                return;
            }
           if (numero == sorteio)
            {
                Console.WriteLine("Parabens você venceu o jogo!");
                Console.WriteLine("Você acertou o número " + sorteio + "");
                Console.ReadKey();
                Main(null);
            }
            Console.WriteLine("Você errou! Tente novamente");
            Main(null);

            Console.ReadKey();
        }
    }
}
