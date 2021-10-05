using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T Entidade);

        void Exclui(int Id);

        void Atualiza(int Id, T entidade);

        int ProximoId();
    }
}
