using Entity;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ReservaMapper
    {

        public static Reserva map(ReservaEntity r)
        {

            return new Reserva()
            {
                IdReserva = r.IdReserva,
                Horario = r.Horario,
                Seña = r.Seña,
                CantidadComensales = r.CantidadComensales,
                Mesa = MesaMapper.map(r.Mesa),
                Cliente = ClienteMapper.map(r.Cliente)



            };

        }
        public static ReservaEntity map(Reserva r)
        {

            return new ReservaEntity()
            {
                IdReserva = r.IdReserva,
                Horario = r.Horario,
                Seña = r.Seña,
                CantidadComensales = r.CantidadComensales,
                Mesa = MesaMapper.map(r.Mesa),
                Cliente = ClienteMapper.map(r.Cliente)



            };

        }




    }
}
