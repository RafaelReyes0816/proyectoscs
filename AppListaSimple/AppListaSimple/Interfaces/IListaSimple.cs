using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.Interfaces
{
    internal interface IListaSimple<T>
    {
        void InsertarElementoInicio(T elemento);
        void InsertarElementoFinal(T elemento);
        bool EsVacio();
        int BuscarElemento(T elemento);
        int Cantidad();
        string MostrarElementos();
        void ReemplazarValor(int indice, T elemento);
        void VaciarLista();
        T EliminarElemento(int indice);

        T BuscarPorIndice(int indice);
    }
}
