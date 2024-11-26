using Entity;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class ClienteMapper
    {
        public static Cliente map(ClienteEntity c)
        {
            return new Cliente()
            {

                Apellido = c.Apellido,
                Nombre = c.Nombre,
                DNI = c.DNI,
                Admin= c.Admin,
                Contraseña = c.Contraseña,
                Usuario = c.Usuario,
                Direccion = c.Direccion,
                Telefono = c.Telefono,



            };



        }
        public static ClienteEntity map(Cliente c)
        {
            return new ClienteEntity()
            {

                Apellido = c.Apellido,
                Nombre = c.Nombre,
                DNI = c.DNI,
                Admin = c.Admin,
                Contraseña = c.Contraseña,
                Usuario = c.Usuario,
                Direccion = c.Direccion,
                Telefono = c.Telefono,



            };



        }
    }
}
