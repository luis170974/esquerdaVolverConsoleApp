using System;

namespace EsquerdaVolverConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeMovimentos;
            char direcaoAtual;
            string movimentosVolver;
            direcaoAtual = 'N';



            Console.WriteLine("Vamos soldado Volver!");

            Console.WriteLine("Digite a quantidade de movimentos");

            quantidadeMovimentos = int.Parse(Console.ReadLine());





            //movimento MMDDMMMEE
            Console.WriteLine("Digite um movimento: ");

            movimentosVolver = Console.ReadLine().ToUpper();

            char[] vetorOpcao = movimentosVolver.ToCharArray();// [m, m , m ,d, e]


            
            if(vetorOpcao.Length == quantidadeMovimentos) { 

            for (int p = 0; p < vetorOpcao.Length; p++)
            {
                   
                    char opcao = vetorOpcao[p];



                        switch (opcao)
                        {// >
                            case 'D':
                                switch (direcaoAtual)
                                {
                                    case 'N':
                                        direcaoAtual = 'L';
                                        break;

                                    case 'S':
                                        direcaoAtual = 'O';
                                        break;

                                    case 'O':
                                        direcaoAtual = 'N';
                                        break;

                                    case 'L':
                                        direcaoAtual = 'S';
                                        break;

                                }
                                break;

                            //<
                            case 'E':
                                switch (direcaoAtual)
                                {
                                    case 'N':
                                        direcaoAtual = 'O';
                                        break;

                                    case 'S':
                                        direcaoAtual = 'L';
                                        break;

                                    case 'O':
                                        direcaoAtual = 'S';
                                        break;

                                    case 'L':
                                        direcaoAtual = 'N';
                                        break;

                                }
                                break;

                            //^
                            case 'N':
                                switch (direcaoAtual)
                                {
                                    case 'N':
                                        direcaoAtual = 'N';
                                        break;

                                    case 'S':
                                        direcaoAtual = 'S';
                                        break;

                                    case 'O':
                                        direcaoAtual = 'O';
                                        break;

                                    case 'L':
                                        direcaoAtual = 'L';
                                        break;

                                }
                                break;

                            //V
                            case 'S':
                                switch (direcaoAtual)
                                {
                                    case 'N':
                                        direcaoAtual = 'S';
                                        break;

                                    case 'S':
                                        direcaoAtual = 'N';
                                        break;

                                    case 'O':
                                        direcaoAtual = 'L';
                                        break;

                                    case 'L':
                                        direcaoAtual = 'O';
                                        break;

                                }
                                break;

                        }

                       
                
                

            }
            }
            else
            {
                Console.WriteLine("Opção Invalida!");
                Console.ReadLine();
                Console.Clear();
                
            }

            if (vetorOpcao.Length == 0 && quantidadeMovimentos == 0)
            {
                Console.WriteLine("Opção Invalida, pois a quantidade é = 0");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                //Concatenar Variaveis
                Console.WriteLine("Volver olhando para " + direcaoAtual);
                Console.ReadLine();
            }
            
        }

        }
        }

    
