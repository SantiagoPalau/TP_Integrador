using Entity;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDao
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }

        public ClienteEntity IngresarUsuario(string usuario, string contraseña)
        {

            try
            {
                using(AppDbContext appDbContext = getAppDbContext())
                {
                    Cliente Clienteaingresar= appDbContext.Clientes.Where(c=> c.Usuario== usuario && c.Contraseña == contraseña)


                }



            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
