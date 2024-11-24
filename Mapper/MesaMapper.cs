using Entity.Model;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MesaMapper
    {
        public static Mesa map(MesaEntity m)
        {
            return new Mesa()
            {

              CantidadAsientos=m.CantidadAsientos,
              Disponible=m.Disponible,
              HorarioDisponibilidad=m.HorarioDisponibilidad,
              NumeroMesa=m.NumeroMesa,



            };



        }
        public static MesaEntity map(Mesa m)
        {
            return new MesaEntity()
            {

                CantidadAsientos = m.CantidadAsientos,
                Disponible = m.Disponible,
                HorarioDisponibilidad = m.HorarioDisponibilidad,
                NumeroMesa = m.NumeroMesa,



            };



        }





    }
}
