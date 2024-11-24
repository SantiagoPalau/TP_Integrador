using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Mesa
    {
        [ Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity) ]
        public int NumeroMesa { get; set; }
        [Required ]
       
        public int CantidadAsientos {  get; set; }
        [Required ]
        public bool Disponible { get; set; }
        [Required ]
        public DateTime HorarioDisponibilidad { get; set; }

    }
}
