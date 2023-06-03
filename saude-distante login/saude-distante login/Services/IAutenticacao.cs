using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Services
{
    internal interface IAutenticacao
    {
        bool Autenticar(string funcao, string email, string password);
        void AcessoPermitido();
    }
}
