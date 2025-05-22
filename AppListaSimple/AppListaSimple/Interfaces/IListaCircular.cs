using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.Interfaces
{
    internal interface IListaCircular<T>
    {
        bool EsVacio();
        void AgregarFinal(T elemento);
        void AgregarInicio(T elemento);
        void RecorrerLista();
        bool EliminarElemento(T elemento);
    }
}
