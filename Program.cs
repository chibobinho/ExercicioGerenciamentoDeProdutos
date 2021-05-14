using System;

namespace GerenciamentoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "n";
            int tamanhoArrays = 10;
            string[] nomes = new string[tamanhoArrays];
            float[] preco = new float[tamanhoArrays];
            string[] promocao = new string[tamanhoArrays];
            int i = 0;
            bool condicao = false;

            do
            {
                Console.WriteLine(@"
=============================
|Selecione uma opção abaixo:|
|                           |
|1 - Cadastrar produtos     |
|2 - Listar produtos        |
|0 - Sair                   |
=============================
                    ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        do
                        {
                            if (i < 10)
                            {
                                Console.WriteLine("Digite o nome do produto:");
                            nomes[i] = Console.ReadLine();

                            Console.WriteLine("Digite o preço do produto:");
                            preco[i] = int.Parse(Console.ReadLine());

                            Console.WriteLine("O produto está em promoção?");
                            promocao[i] = Console.ReadLine();

                            Console.WriteLine("Voce quer cadastrar mais um produto? (s/n)");
                            resposta = Console.ReadLine();

                            Console.WriteLine(nomes[i]);
                            Console.WriteLine(preco[i]);
                            Console.WriteLine(promocao[i]);

                            i++;
                            }else
                            {
                                Console.WriteLine("Você atingiu o limite da lista, volte outro dia :(");
                                resposta = "n";
                            }    
                        } while (resposta == "s");
                        break;

                    case "2":
                        Console.Clear();
                        for (var c = 0; c < i; c++)
                        {
                            Console.WriteLine(@$"
|Nome do produto: {nomes[c]}  
|Preço: R${preco[c]}            
|Em promoção: {promocao[c]}   
");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Obrigado e até a próxima!");
                        condicao = true;
                        break;

                    default:
                        break;
                }
            } while (!condicao);
        }
    }
}

