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
          
            int opcao = 0;
            while (opcao != 7)
            {
                Console.WriteLine();
                Console.Write("Digite a opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) {Tela.mostrarMarcas();}
                else if (opcao == 2) {Tela.mostrarCarrosDeUmaMarca();}
                else if (opcao == 3) {Tela.CadastraMarca();}
                else if (opcao == 4) {Tela.CadastrarCarro();}
                else if (opcao == 5) {Tela.CadastrarAcessorio();}
                else if (opcao == 6) {Tela.mostrarCarros();}
                else if (opcao == 7) {Console.WriteLine("Fim do programa.");}
                else {Console.WriteLine("Comando inválido");}
            }
            Console.ReadLine();
        }
    }
}