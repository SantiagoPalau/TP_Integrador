using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public  class ClienteEntity
    {
        private int dNI;
        private string usuario;
        private string nombre;
        private string apellido;
        private bool admin;
        private string contraseña;
        private string telefono;
        private string direccion;

        public int DNI { get => dNI; set => dNI = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Admin { get => admin; set => admin = value; }
    }
}
