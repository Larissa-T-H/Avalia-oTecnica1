using System;

namespace Prova2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resp = 's';
            int contador1 = 0;
            int contador2 = 5;
            
            

            while (resp == 's')
            {
                contador1++;
                int sorteio = new Random().Next(1, 5);
                Console.WriteLine($"Você tem {contador2--} tentativa");
                Console.WriteLine("Tente descobrir o número que eu pensei entre 1 a 5: ");
                int chute = int.Parse(Console.ReadLine());

                if (chute < 1 || chute > 5)
                {
                    Console.WriteLine("Número invalido, escolha novamente!");
                    resp = 's';
                    
                }

                else if (sorteio == chute)
                {
                    Console.WriteLine("Parabéns, você acertou!!!");
                    Console.WriteLine($"Você tentou:{contador1} vezes!!");
                    Console.WriteLine("Deseja jogar novamnete?(s/n) ");
                    resp = char.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------");
                    contador1 = 0;
                    contador2 = 5;
                }
                else if (contador1 ==1) 
                {       
                    Console.WriteLine($"Passou longe, pensei em {sorteio}");
                    resp = 's';
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine(" ");
                }
                else if (contador1 == 2)
                {
                    Console.WriteLine($"Errou tente novamente, pensei em {sorteio}");
                    resp = 's';
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine(" ");
                }
                else if (contador1 == 3)
                {
                    Console.WriteLine($"Não está com sorte, pensei em {sorteio}");
                    resp = 's';
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine(" ");
                }
                else if (contador1 == 4)
                {
                    Console.WriteLine($"Hoje não o seu dia de sorte, pensei em {sorteio}");
                    resp = 's';
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine(" ");
                }
                else if (contador2 == 0)
                {
                    Console.WriteLine($"Não foi desta vez, pensei em {sorteio}");
                    Console.WriteLine("Suas tentativas acabou");
                    Console.WriteLine($"Você tentou:{contador1} vezes!!");
                    Console.WriteLine("Deseja jogar novamnete?(s/n) ");
                    resp = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Não foi desta vez, pensei em {sorteio}");
                    resp = 's';
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine(" ");
                }
           
            }
            


        }
    }
}
