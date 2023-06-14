using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv11pr2
{
    internal class Program
    {


        static void Main()
        {
            //atv1

            //int[] numeros = new int[1000];
            //Random random = new Random();

            //for (int i = 0; i < 1000; i++)
            //{
            //    numeros[i] = random.Next(1, 1001);
            //}

            //Console.WriteLine("Tente adivinhar um número entre 1000 números.");

            //while (true)
            //{
            //    Console.Write("Digite um número: ");
            //    int palpite;

            //    if (int.TryParse(Console.ReadLine(), out palpite))
            //    {
            //        if (Array.IndexOf(numeros, palpite) != -1)
            //        {
            //            Console.WriteLine("Parabéns! Você adivinhou o número corretamente.");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Número incorreto. Tente novamente.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entrada inválida. Digite um número válido.");
            //    }
            //}

            //Console.ReadLine();

            //atv2
            {
                //int[] numeros = new int[20000];
                //Random random = new Random();

                //for (int i = 0; i < 20000; i++)
                //{
                //    numeros[i] = random.Next(1, 1001); // Gera um número aleatório entre 1 e 1000
                //}

                //Console.Write("Digite um número para contar quantas vezes ele aparece no vetor: ");
                //int numeroEscolhido;

                //if (int.TryParse(Console.ReadLine(), out numeroEscolhido))
                //{
                //    int contador = 0;

                //    foreach (int numero in numeros)
                //    {
                //        if (numero == numeroEscolhido)
                //        {
                //            contador++;
                //        }
                //    }

                //    Console.WriteLine($"O número {numeroEscolhido} aparece {contador} vezes no vetor.");
                //}
                //else
                //{
                //    Console.WriteLine("Entrada inválida. Digite um número válido.");
                //}

                //Console.ReadLine();


                //atv3

                {
                    //            int[] vetor1 = new int[10];
                    //            int[] vetor2 = new int[10];

                    //            Console.WriteLine("Digite 10 números inteiros e positivos:");

                    //            for (int i = 0; i < 10; i++)
                    //            {
                    //                int numero;

                    //                while (true)
                    //                {
                    //                    Console.Write($"Digite o {i + 1}º número: ");

                    //                    if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
                    //                    {
                    //                        vetor1[i] = numero;
                    //                        break;
                    //                    }
                    //                    else
                    //                    {
                    //                        Console.WriteLine("Número inválido. Digite um número inteiro e positivo.");
                    //                    }
                    //                }
                    //            }

                    //            for (int i = 0; i < 10; i++)
                    //            {
                    //                if (i % 2 == 0)
                    //                {
                    //                    vetor2[i] = vetor1[i] / 2;
                    //                }
                    //                else
                    //                {
                    //                    vetor2[i] = vetor1[i] * 3;
                    //                }
                    //            }

                    //            Console.WriteLine("\nVetor 1: ");
                    //            ImprimirVetor(vetor1);

                    //            Console.WriteLine("\nVetor 2: ");
                    //            ImprimirVetor(vetor2);

                    //            Console.ReadLine();
                    //        }

                    //    }

                    //}

                    //private static void ImprimirVetor(int[] vetor)
                    //{
                    //    for (int i = 0; i < vetor.Length; i++)
                    //    {
                    //        Console.Write($"{vetor[i]} ");
                    //    }
                    //    Console.WriteLine();


                    //atv4


                    {
                        int[] vetor = new int[5000];

                        Console.WriteLine("Digite 5000 números:");

                        for (int i = 0; i < 5000; i++)
                        {
                            int numero;

                            while (true)
                            {
                                Console.Write($"Digite o {i + 1}º número: ");

                                if (int.TryParse(Console.ReadLine(), out numero))
                                {
                                    vetor[i] = numero;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Número inválido. Digite um número inteiro válido.");
                                }
                            }
                        }

                        Console.WriteLine("\nNúmeros primos encontrados:");

                        for (int i = 0; i < 5000; i++)
                        {
                            if (EhPrimo(vetor[i]))
                            {
                                Console.Write($"{vetor[i]} ");
                            }
                        }

                        Console.ReadLine();
                    }

                    static bool EhPrimo(int numero)
                    {
                        if (numero < 2)
                        {
                            return false;
                        }

                        for (int i = 2; i <= Math.Sqrt(numero); i++)
                        {
                            if (numero % i == 0)
                            {
                                return false;
                            }
                        }

                        return true;
                    }
                }
            }
        }
    }
}


    


        

    


