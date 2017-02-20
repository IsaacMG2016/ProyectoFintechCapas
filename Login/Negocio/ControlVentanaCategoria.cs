using System;
using System.Data;

namespace Login
{
    public class ControlVentanaCategoria
    {
        private DAOCategoria dao_categoria;

        public ControlVentanaCategoria(DAOCategoria dao_categoria)
        {
            this.dao_categoria = dao_categoria;
        }

        // para el combo box  de busqueda en la ventana principal
        // campos -- id y nombre
        public DataTable Dame_categorias()
        {
            return dao_categoria.categorias_busqueda();
        }
    }
}