using System;

namespace calculadoraMetodos
{
   class Program
   {
        static void Main(string[] args)
        {
            char resposta; 
            int opcao;
            bool repetir = true;
            float[] num;
            float resultado = 0f;
            do
            {
                Console.Clear();
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                    Console.WriteLine("Digite os valores para a soma:");
                    num = Array.ConvertAll(Console.ReadLine().Split(' ','+'),float.Parse);
                    resultado = somar(num);
                    Console.WriteLine($"O resultado da soma é: {resultado}");
                    repetir = sair();
                    break;

                    case 2:
                    Console.WriteLine("Digite os valores para a subtração:");
                    num = Array.ConvertAll(Console.ReadLine().Split(' ','-'),float.Parse);
                    resultado = subtrair(num);
                    Console.WriteLine($"O resultado da subtração é: {resultado}");
                    repetir = sair();
                    break;

                    case 3:
                    Console.WriteLine("digite os valores para a multiplicação:");
                    num = Array.ConvertAll(Console.ReadLine().Split(' ', 'x','X','*'),float.Parse);
                    resultado = multiplicar(num);
                    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                    repetir = sair();
                    break;

                    case 4:
                    Console.WriteLine("digite os valores para a divisão:");
                    num = Array.ConvertAll(Console.ReadLine().Split(' ','/'),float.Parse);
                    resultado = dividir(num);
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                    repetir = sair();
                    break;

                    case 5:
                    repetir = sair();
                    break;
                    
                    default:
                    Console.WriteLine("Opção inválida");
                    break;
                }
            } while (repetir == true);
        }

        static int menu()
        {
            Console.WriteLine("Selecione um operador pelo número correspondente:");
            Console.WriteLine("1.Adição 2.Subtração 3.Multiplicação 4.Divisão 5.Sair do Programa");
            return int.Parse(Console.ReadLine());
        }

        static bool sair()
        {
            Console.WriteLine("Deseja sair do programa? s/n");
            char resposta = char.Parse(Console.ReadLine().ToLower());
            if (resposta == 's')
            {
                Console.WriteLine("Fim do programa");
                return false;
            }
            else if (resposta == 'n')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Resposta inválida!");
                return false;
            }
        }

        static float somar(float[] numeros)
        {
            float somaArray = 0f;
            for (int i = 0; i < numeros.Length; i++)
            {
                somaArray += numeros[i];
            }
            return somaArray;
        }

        static float subtrair(float[] numeros)
        {
            float subArray = 0f;
            subArray = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                subArray -= numeros[i];
            }
            return subArray;
        }

        static float multiplicar(float[] numeros)
        {
            float multArray = 1f;
            for (int i = 0; i < numeros.Length; i++)
            {
                multArray *= numeros[i];
            }
            return multArray;
        }

        static float dividir(float[] numeros)
        {
            float divArray = 0f;
            divArray = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    Console.WriteLine("Impossível dividir por zero");
                    return 0f;
                }
                divArray /= numeros[i];
            }
            return divArray;
        }
   } 
}