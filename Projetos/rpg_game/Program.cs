using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Personagens;

namespace rpg_game
{
    class Program
    {
        static void Main(string[] args)
        {
            principal[] principals = new principal[6];
            var indicePrincipal = 0;
            string menu = ObterOpcaoMenu();

            while(menu.ToUpper() != "X")
            {
                switch(menu)
                {
                    case "1":
                        principal principal = new principal();

                            principal.Nome = ObterNome();
                            principal.Categoria = ObterCategoria();

                        Console.WriteLine("Informe os atributos do personagem:");

                            Console.Write("Insira a vida do personagem: ");
                                principal.Vida = obterAtributos();
                            Console.Write("Insira a magia do personagem: ");
                                principal.Magia = obterAtributos();
                            Console.WriteLine();

                            Console.Write("Insira a força do personagem: ");
                                principal.Força = obterAtributos();
                            Console.Write("Insira a agilidade do personagem: ");
                                principal.Agilidade = obterAtributos();
                            Console.Write("Insira a inteligência do personagem: ");
                                principal.Inteligencia = obterAtributos();
                            Console.Write("Insira o carisma do personagem: ");
                                principal.Carisma = obterAtributos();

                        Console.WriteLine();
                        Console.Write("Insira S para salvar: ");
                        string save = Console.ReadLine();

                        if(save.ToUpper() == "S")
                        {
                            principals[indicePrincipal] = principal;
                            indicePrincipal++;
                        }
                        else{Console.Clear();break;}

                        Console.Clear();

                        break;

                    case "2":
                        int teste_01 = lançarDado_6(); Console.WriteLine($"Lançar dado 1: {teste_01}");
                        int teste_02 = lançarDado_6(); Console.WriteLine($"Lançar dado 2: {teste_02}");
                        Console.WriteLine();
                        Console.WriteLine($"Total dos dados: {teste_01+teste_02}");
                        Console.Write("Pressione enter para continuar");Console.Read();
                        Console.Clear();

                        break;
                    case "3":


                        break;
                    case "9":
                        ObterLista(principals);

                        break;
                    default:

                        break;
                }

                menu = ObterOpcaoMenu();
            }
        }
        private static string ObterOpcaoMenu()
        {
            Console.WriteLine("Menu principal: ");
            Console.WriteLine("1 - Criar personagem");
            Console.WriteLine("2 - Executar testes");
            Console.WriteLine("3 - Executar ação");
            Console.WriteLine("9 - Lista de personagens");
            Console.WriteLine("X - Sair");
            Console.WriteLine();


            Console.Write("Insira a opção desejada: "); string menu = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            return menu;
        }
        private static string ObterNome()
        {
            Console.Write("Insira o nome do personagem: ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            return nome;
        }
        private static string ObterCategoria()
        {
            Console.WriteLine("1 - Ninja");
            Console.WriteLine();
            Console.Write("Escolha a categoria do personagem: ");

            string categoria = Console.ReadLine();
            Console.WriteLine();

            switch(categoria)
            {
                case "1":
                    categoria = "Ninja";
                    break;

            }

            return categoria;
        }
        private static int obterAtributos()
        {
            if(int.TryParse(Console.ReadLine(), out int atributos))
            {
                return atributos;
            }
            else
            {
                throw new ArgumentException("Valor de tributos deve ser inteiro");
            }
        }
        private static void ObterLista(principal[] principals)
        {
            Console.WriteLine("Lista de personagens: \n");
            foreach (var p in principals)
            {
                if (!string.IsNullOrEmpty(p.Nome))
                {
                    Console.WriteLine($"Nome: {p.Nome} | Categoria: {p.Categoria}");
                    Console.WriteLine($"Vida: {p.Vida} | Magia: {p.Magia} | Força: {p.Força} | Agilidade: {p.Agilidade} | Inteligência: {p.Agilidade} | Carisma: {p.Carisma}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.Write("Pressione enter para continuar");
            Console.Read();
            Console.Clear();
        }
        private static int lançarDado_6()
        {
            Random random = new Random();
            int dado_6 = random.Next(1, 6);

            return dado_6;
        }
    }
}
