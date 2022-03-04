using System;

namespace gestaodeequipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string[] nomesequipamentos = new string[10];
                decimal[] precosequipamentos = new decimal[10];
                int[] numerosSeries= new int[10];
                string[] datas = new string[10];
                string[] fabricantesequipamentos = new string[10];

            int posicaoequipamento = 0;

            for (int i = 0; i < 5; i++)
            {


                Console.Clear();
                Console.WriteLine("Gestão de equipamentos\n");

                Console.WriteLine("Digite 1 para cadastro de equipamentos.");
                Console.WriteLine("Digite 2 para controle de chamados.");
                Console.WriteLine("Digite s para sair.");
                string opcao = Console.ReadLine();

                if (opcao == "S" || opcao == "s")
                    break;

                if (opcao == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Gestão de equipamentos\n");

                    Console.WriteLine("Digite 1 para inserir um novo equipamento.");
                    Console.WriteLine("Digite 2 para vizualizar um equipamento.");
                    Console.WriteLine("Digite 3 para editar um equipamento.");
                    Console.WriteLine("Digite 4 para excluir um equipamento.");
                    Console.WriteLine("Digite s para sair.");

                    string opcaosubmenu = Console.ReadLine();
                    if (opcaosubmenu == "S" || opcaosubmenu == "s")
                        continue;
                    if (opcaosubmenu == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Gestão de equipamentos\n");

                        Console.Clear();
                        Console.WriteLine("Informe o nome do equipamento:");
                        string nome = Console.ReadLine();
                        nomesequipamentos[posicaoequipamento] = nome;

                        Console.WriteLine("Informe o preço:");
                        decimal preco = Convert.ToDecimal(Console.ReadLine());
                        precosequipamentos[posicaoequipamento] = preco;

                        Console.WriteLine("Informe o número de série:");
                        int numeroserie = Convert.ToInt32(Console.ReadLine());
                        numerosSeries[posicaoequipamento] = numeroserie;

                        Console.WriteLine("Informe a data de fabricação:");
                        string data = Console.ReadLine();
                        datas[posicaoequipamento] = data;

                        Console.WriteLine("Informe o nome do fabricante:");
                        string fabricante = Console.ReadLine();
                        fabricantesequipamentos[posicaoequipamento] = fabricante;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Equipamento cadastrado com sucesso!");
                        Console.ResetColor();

                        posicaoequipamento++;
                    }

                    else if (opcaosubmenu == "2")
                    {
                                Console.Clear();
                                Console.WriteLine("Gestão de equipamentos\n");

                                Console.WriteLine("Equipamentos:\n");

                                Console.WriteLine("Nome: " + nomesequipamentos[0]);
                                Console.WriteLine("Preço: " + precosequipamentos[0]);
                                Console.WriteLine("Número de série: " + numerosSeries[0]);
                                Console.WriteLine("Data de fabricação: " + datas[0]);
                                Console.WriteLine("Fabricante: " + fabricantesequipamentos[0]);
                        
                    }







                }

                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Gestão de equipamentos\n");

                    Console.WriteLine("Digite 1 para inserir um novo chamado.");
                    Console.WriteLine("Digite 2 para vizualizar um chamado.");
                    Console.WriteLine("Digite 3 para editar um chamado.");
                    Console.WriteLine("Digite 4 para excluir um chamado.");
                    Console.WriteLine("Digite s para sair.");

                    string opcaochamado = Console.ReadLine();
                    if (opcaochamado == "S" || opcaochamado == "s")
                        continue;
                }

                //Até aqui foi o que consequi fazer entendendo


                Console.ReadLine();
            }
            }
            
        }
    }

