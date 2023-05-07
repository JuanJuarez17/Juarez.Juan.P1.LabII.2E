using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_APP
{
    public class Operator : User
    {
        // TODO: Agregar atributos propio de Operator
        public Operator(string user, string password) : base(user, password, false) { }
    }
}
