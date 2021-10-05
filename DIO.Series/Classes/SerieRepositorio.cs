using DIO.Series.Interfaces;
using System.Collections.Generic;

namespace DIO.Series.Classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaserie = new List<Serie>();
        public void Atualiza(int Id, Serie entidade)
        {
            listaserie[Id] = entidade;
        }

        public void Exclui(int Id)
        {
            listaserie[Id].Excluir();
        }

        public void Insere(Serie Entidade)
        {
            listaserie.Add(Entidade);
        }

        public List<Serie> Lista()
        {
            return listaserie;
        }

        public int ProximoId()
        {
           return listaserie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaserie[id];
        }
    }
}
