using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ReservaEntity
    {
        private int idReserva;
        private DateTime horario;
        private double seña;
        private int cantidadComensales;
        private MesaEntity mesa;
        private ClienteEntity cliente;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public DateTime Horario { get => horario; set => horario = value; }
        public double Seña { get => seña; set => seña = value; }
        public int CantidadComensales { get => cantidadComensales; set => cantidadComensales = value; }
        public MesaEntity Mesa { get => mesa; set => mesa = value; }
        public ClienteEntity Cliente { get => cliente; set => cliente = value; }
    }
}
