using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Reserva
    {

        [ Key]
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReserva {  get; set; }
        [Required ]
        public DateTime horario { get; set; }
    }
}
