using DIO.Series.Classes;
using DIO.Series;
using System;
using System.Collections.Generic;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string itemSelecionado = Menu();

            while (itemSelecionado.ToUpper() != "x")
            {
                if (itemSelecionado == "1")
                {
                    ListarSries();
                }

                if (itemSelecionado == "2")
                {
                    InserirSerie();
                }

                if (itemSelecionado == "3")
                {
                    AtualizarSerie();
                }

                if (itemSelecionado == "4")
                {
                    ExcluirSerie();
                }

                if (itemSelecionado == "5")
                {
                    VisualizarSerie();
                }

                itemSelecionado = Menu();
            }
          
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o Id que deseja visualizar");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o Id que deseja atualizar");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Inserir Nova Série");
            Console.WriteLine("Digite o Id que deseja atualizar");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}: - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da Série");
            int anoInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Série");
            string descricaoSerie = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        Genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: anoInicio,
                                        descricao: descricaoSerie);
            repositorio.Atualiza(indiceSerie,atualizaSerie);
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir Nova Série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}: - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série");
            string entradaTitulo  = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da Série");
            int anoInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Série");
            string descricaoSerie = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        Genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: anoInicio,
                                        descricao: descricaoSerie);
            repositorio.Insere(novaSerie);
        }

        private static void ListarSries()
        {
            Console.WriteLine("lista de séries");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Lista cadastrada");
                return;
            }

            foreach (var serie in lista) {

                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            
            }
        }

        private static string Menu() {

            Console.WriteLine();
            Console.WriteLine("Dio, series a seu dispor");
            Console.WriteLine("Entre com a opção desejada");
            Console.WriteLine("1- Listar Series");
            Console.WriteLine("2- Inserir nova Serie");
            Console.WriteLine("3- Atualizar Serie");
            Console.WriteLine("4- Exluir Serie");
            Console.WriteLine("5- Visualizar Serie");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            string ItenMenu = Console.ReadLine().ToUpper();
          
            return ItenMenu;
        }
    }
}
