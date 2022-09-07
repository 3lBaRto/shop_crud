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

        public Producto(string nom_producto, int precio, string descrip)
        {
            this.nom_producto = nom_producto;
            this.precio = precio;
            this.descrip = descrip;
        }

        public string Nom_producto { get => nom_producto; set => nom_producto = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descrip { get => descrip; set => descrip = value; }
    }
}
