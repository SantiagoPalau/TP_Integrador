using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Cliente
    {
        [ Key]
        [Required ]
        public int DNI { get; set; }
        [Required ]
        [MinLength(5) ]
        public string Usuario { get; set; }

        [ Required]
        [MinLength(5) ]
        public string Contraseña {  get; set; }
        [Required]
        public bool Admin {  get; set; }

        [Required]
        public string Nombre {  get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Telefono {  get; set; }
        [Required]
        public string Direccion {  get; set; }



    }
}
