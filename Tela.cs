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
        /// Essa função mostra os carros cadastrados
        /// </summary>
        public static void mostrarCarros()
        {
            for (int i = 0; i < Program.carro.Count; i++)
            {
                Console.WriteLine(Program.carro[i]);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Essa função mostra os carros de uma única marca, preciso apagar essa e fazer ainda
        /// </summary>
        public static void mostrarCarrosDeUmaMarca()
        {
            for (int i = 0; i < Program.carro.Count; i++)
            {
                Console.WriteLine(Program.carro[i]);
            }
            Console.WriteLine();
        }
    }
}