using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MesaEntity
    {
        private int numeroMesa;
        private int cantidadAsientos;
        private bool disponible;
        private DateTime horarioDisponibilidad;

        public int NumeroMesa { get => numeroMesa; set => numeroMesa = value; }
        public int CantidadAsientos { get => cantidadAsientos; set => cantidadAsientos = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public DateTime HorarioDisponibilidad { get => horarioDisponibilidad; set => horarioDisponibilidad = value; }
    }
}
