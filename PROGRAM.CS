using System;
using System.Collections.Generic;
using System.Globalization;
using dominio;
using System.Text;

namespace UdemyAula50
{   
    class Program
   {
        //Cria a lista que será preenchida com as infos dos carros, em linha/string
        public static List<Carro> carro = new List<Carro>();
        
        //Cria a lista que será preenchida com os códigos dos filmes
        //public static List<int> codigofilmes = new List<int>();
        //não sei pq eu criei uma lista só com os códigos dos filmes, mas de qualquer forma

        //Cria a lista que será preenchida com as infos das marcas, em linha/string
        public static List<Marca> marca = new List<Marca>();

        //Cria a lista que será preenchida com as infos de cada acessório, em linha/string
        public static List<Acessorio> acessorio = new List<Acessorio>();

        static void Main(string[] args){

            int opcao = 0;

            //Cadastro dos carros obrigatórios do exercício
            carro.Add(new Carro(101, 1001, "Fusca", 1980, 50000.00));
            carro.Add(new Carro(102, 1001, "Golf", 2016, 60000.00));
            carro.Add(new Carro(103, 1001, "Fox", 2017, 30000.00));
            carro.Add(new Carro(104, 1002, "Cruze", 2016, 30000.00));
            carro.Add(new Carro(105, 1002, "Cobalt", 2015, 25000.00));
            carro.Add(new Carro(106, 1002, "Cobalt", 2017, 35000.00));
            
            //Cadastro das marcas obrigatórias do exercício
            marca.Add(new Marca(1001, "Volkswagen", "Alemanha"));
            marca.Add(new Marca(1002, "General Motors", "Estados Unidos"));

            //Cadastro dos acessórios obrigatórios do exercício
            acessorio.Add(new Acessorio("Engate", 200.00));
            acessorio.Add(new Acessorio("Antena", 100.00));

            //Mostra o menu de opções
            Tela.mostrarMenu();

            while (opcao != 7)
            {
                Console.WriteLine();
                Console.Write("Digite a opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    //Mostra as marcas cadastradas na lista até o momento
                    Tela.mostrarMarcas();
                }
                else if (opcao == 2)
                {
                    //Mostra os carros de uma única marca
                    Console.Write("Digite o código da marca: ");
                    int IdMarca = int.Parse(Console.ReadLine());

                    int pos = Program.marca.FindIndex(x => x.IdMarca == IdMarca);

                    Console.WriteLine("Carros da marca " + marca[pos].Nome + ": ");
                    Console.WriteLine();

                    Tela.mostrarCarrosDeUmaMarca();
                }
                else if (opcao == 3)
                {
                    Console.Write("insira o novo codigo da marca: ");
                    int IdMarca = int.Parse(Console.ReadLine());

                    Console.Write("insira o nome da marca: ");
                    string Nome = Console.ReadLine();

                    Console.Write("insira o país da marca: ");
                    string Pais = Console.ReadLine();
                    
                    Marca M = new Marca(IdMarca, Nome, Pais);
                    marca.Add(M);

                }
                else if (opcao == 4)
                {
                    
                    Console.Write("insira o novo codigo do carro: ");
                    int IdCarro = int.Parse(Console.ReadLine());

                    //codigofilmes.Add(CodigoFilme);                    
                    
                    Console.Write("insira o codigo da marca: ");
                    int IdMarca = int.Parse(Console.ReadLine());

                    Console.Write("insira o modelo do carro: ");
                    string Modelo = Console.ReadLine();
                    
                    Console.Write("insira o ano do carro: ");
                    int Ano = int.Parse(Console.ReadLine());

                    Console.Write("insira o preço básico do carro, sem os acessórios: ");
                    double precoBasico = double.Parse(Console.ReadLine());

                    Carro C = new Carro(IdCarro, IdMarca, Modelo, Ano, precoBasico);

                    
                    Console.Write("Quantos acessórios tem o carro? ");
                    int quantidadeAcessorios = int.Parse(Console.ReadLine());

                    double totalAcessorios = 0;
                    List<int> itens = new List<int>();

                    for(int i = 0; i < quantidadeAcessorios; i++)
                    {
                        Console.Write("Informe o nome do acessório: ");
                        string NomeAcessorio = Console.ReadLine();

                        int pos = Program.acessorio.FindIndex(x => x.NomeAcessorio == NomeAcessorio);

                        Console.WriteLine();
                        Console.WriteLine(acessorio[pos]);
                        Console.WriteLine();

                        double PrecoAcessorio = acessorio[pos].PrecoAcessorio;

                        Console.Write("O preço do acessório é: " + PrecoAcessorio);
                        

                        Acessorio A = new Acessorio(NomeAcessorio, PrecoAcessorio);
                        
                        totalAcessorios = totalAcessorios + PrecoAcessorio;

                        
                        //double X = A.precoTotal();

                    //F.Part.Add(I);

                        //totalPedido = totalPedido + X;
                        //itens.Add(i);
                    }

                    double X = precoBasico + totalAcessorios;

                    Console.WriteLine();
                    Console.WriteLine("O preço total é R$" + C.precoTotal());
                    Console.WriteLine();




                    //filmes.Add(F);

                    //Console.WriteLine("O valor total do pedido eh R$ " + totalPedido);

            Console.ReadLine();

                }
                else if (opcao == 5)
                {
                    Console.Write("Insira o nome do novo acessório: ");
                    string NomeAcessorio = Console.ReadLine();

                    Console.WriteLine("Insira o preço do acessório: ");
                    double PrecoAcessorio = double.Parse(Console.ReadLine());

                    Acessorio A = new Acessorio(NomeAcessorio, PrecoAcessorio);
                    acessorio.Add(A);
                }
                else if (opcao == 6)
                {
                    //Mostra os carros cadastrados na lista até o momento
                    Tela.mostrarCarros();
                }
                else if (opcao == 7)
                {
                    Console.WriteLine("Fim do programa.");
                }
                else
                {
                    Console.WriteLine("Comando inválido");
                }
            }

            Console.ReadLine();
        

        }
    }
}



