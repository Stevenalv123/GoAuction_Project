using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoAuction.Models
{
    public class Administrator : User
    {
        public Administrator(int id_user, string name, string mail, string password, DateTime creationDate, bool active) : base(id_user, name, mail, password, creationDate, active)
        {
        }

        public override bool PuedeComprar => true;
                                            
        public override bool PuedeVender => true;

        public override bool EsAdministrador => true;

        public void GestionarUsuarios()
        {
            // Lógica para gestionar usuarios
        }

        public void GestionarSubastas()
        {
            // Lógica para gestionar subastas
        }
    }
}
