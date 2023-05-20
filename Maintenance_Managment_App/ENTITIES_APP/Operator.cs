using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_APP
{
    public class Operator : User
    {
        private Division division;
        private Shift shift;
        private Category category;


        // TODO: Agregar atributos propio de Operator
        public Operator(int inputFileNumber, string inputUsername, string inputPassword) 
                 : base(inputFileNumber, inputUsername, inputPassword, false) { }
    }
}
