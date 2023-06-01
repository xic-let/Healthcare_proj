using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    internal class Administrador : Colaborador
    {
       


        public Admin()
        {

        }

        public Admin(double vencimento, char equipa, string viatura)
            : base(vencimento, equipa, viatura)
        {

        }

        public void AddItemInventario(ItemInventario item)
        {
            inventario.Add(item);
        }
    }
}
