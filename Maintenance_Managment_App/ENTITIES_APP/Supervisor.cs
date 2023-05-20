using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_APP
{
    public class Supervisor : User
    {
        // TODO: Agregar atributos propio de Supervisor
        public Supervisor(int inputFileNumber, string inputUsername, string inputPassword) 
                   : base(inputFileNumber, inputUsername, inputPassword, true) { }
    }
}
