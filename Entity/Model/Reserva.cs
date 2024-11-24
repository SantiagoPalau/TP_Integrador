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
        public DateTime Horario { get; set; }
        [Required ]
        public double Seña {  get; set; }
        [Required ] 
        public int CantidadComensales {  get; set; }
         
        public int DNI {  get; set; }
        [ForeignKey("DNI")]
        [Required]
        public Cliente Cliente { get; set; }
        public int NumeroMesa { get; set; }
        [ForeignKey("NumeroMesa")]
        [Required]
        public Mesa Mesa { get; set; }


    }
}
