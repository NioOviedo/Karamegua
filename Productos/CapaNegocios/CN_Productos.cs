using System;
using System.Data;
using TuNamespace.CapaDatos;

namespace TuNamespace.CapaNegocios
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            return objetoCD.BuscarProductos();
        }

        public void InsertarProd(string nombre, string desc, string marca, string precio, string stock)
        {
            objetoCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProd(string id, string nombre, string desc, string marca, string precio, string stock)
        {
            objetoCD.Editar(Convert.ToInt32(id),nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
