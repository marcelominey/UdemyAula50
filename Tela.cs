using System;
using System.Collections.Generic;
using System.Globalization;
using dominio;
using System.Text;

namespace UdemyAula50
{
    // Classe responsavel por conter operações que interagem com o usuário
    // no modo console

    class Tela
    {
        /// <summary>
        /// Essa função mostra o menu e as opções para seleção
        /// </summary>
        public static void mostrarMenu()
        {
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente*");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.Write("Digite uma opção: ");
        }
        /// <summary>
        /// Essa função mostra as marcas cadastradas
        /// </summary>
        public static void mostrarMarcas()
        {
            for (int i = 0; i < Program.marca.Count; i++)
            {
                Console.WriteLine(Program.marca[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Essa função mostra os carros de uma única marca
        /// </summary>
        public static void mostrarCarrosDeUmaMarca()
        {
            Console.Write("Digite o código da marca: ");
            int IdMarca = int.Parse(Console.ReadLine());

            int posicao = Program.carro.FindIndex(x => x.IdMarca == IdMarca);

            Console.WriteLine("Carros da marca " + Program.marca[posicao].Nome + ": ");
            Console.WriteLine();

            for (int i = 0; i < Program.carro.Count; i++)
            {
                if(IdMarca == Program.carro[i].IdMarca){
                    Console.WriteLine(Program.carro[i]);
                }
            }
            Console.WriteLine();
        }

        public static void CadastraMarca(){
                    
            Console.Write("insira o novo codigo da marca: ");
            int IdMarca = int.Parse(Console.ReadLine());

            Console.Write("insira o nome da marca: ");
            string Nome = Console.ReadLine();

            Console.Write("insira o país da marca: ");
            string Pais = Console.ReadLine();
                    
            Marca M = new Marca(IdMarca, Nome, Pais);
            Program.marca.Add(M);
        }

        public static void CadastrarCarro(){
                                      
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

            Program.carro.Add(C);
                    
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
                Console.WriteLine(Program.acessorio[pos]);
                Console.WriteLine();

                double PrecoAcessorio = Program.acessorio[pos].PrecoAcessorio;

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

        public static void CadastrarAcessorio(){
            Console.Write("Insira o nome do novo acessório: ");
            string NomeAcessorio = Console.ReadLine();

            Console.WriteLine("Insira o preço do acessório: ");
            double PrecoAcessorio = double.Parse(Console.ReadLine());

            Acessorio A = new Acessorio(NomeAcessorio, PrecoAcessorio);
            Program.acessorio.Add(A);
        }

        /// <summary>
        /// Essa função mostra os carros cadastrados
        /// </summary>
        public static void mostrarCarros(){

            Console.Write("Digite o código do carro: ");
            int IdCarro = int.Parse(Console.ReadLine());

            for (int i = 0; i < Program.carro.Count; i++)
            {
                if(IdCarro == Program.carro[i].IdCarro){
                    Console.WriteLine(Program.carro[i]);
                }
            }
            Console.WriteLine();
        }
    }
}