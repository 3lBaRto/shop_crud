using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Crud
{
    internal class Producto
    {
        private string nom_producto;
        private int precio;
        private string descrip;
        private string seccion;

        public Producto(string nom_producto, int precio, string descrip, string seccion)
        {
            this.Nom_producto = nom_producto;
            this.Precio = precio;
            this.Descrip = descrip;
            this.Seccion = seccion;
        }

        public string Nom_producto { get => nom_producto; set => nom_producto = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public string Seccion { get => seccion; set => seccion = value; }
    }
}
