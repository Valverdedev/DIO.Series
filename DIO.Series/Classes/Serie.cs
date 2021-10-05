using DIO.Series;
using System;

namespace DIO.Series
{
   public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }
        private bool Excluido  { get; set; }
    public Serie(int id, Genero Genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "descricao: " + this.Descricao + Environment.NewLine;
            retorno += "ano: " + this.Ano + Environment.NewLine;
            retorno += "excluido: " + this.Excluido + Environment.NewLine;


            return retorno;

        }
        public string retornaTitulo()
        {

            return this.Titulo;
        }

        internal int retornaId()
        {

            return this.Id;
        }

        public void Excluir() {

            this.Excluido = true;

        
        }

    }
}
