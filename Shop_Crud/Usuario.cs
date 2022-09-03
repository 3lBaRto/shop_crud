using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Crud
{
    class Usuario
    {
        private string nombre;
        private string Contra;

        private string documento;
        private string apellido;
        private string cargo;

        public Usuario(string nombre, string contra, string documento, string apellido, string cargo)
        {
            this.Nombre = nombre;
            Contra1 = contra;
            this.Documento = documento;
            this.Apellido = apellido;
            this.Cargo = cargo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contra1 { get => Contra; set => Contra = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
