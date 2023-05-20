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

        public Division Division 
        { 
            get { return division; } 
            set { this.division = value; }
        }
        public Shift Shift 
        { 
            get { return shift; }
            set { this.shift = value; }
        }
        public Category Category 
        {
            get { return category; }
            set { this.category = value; }
        }
        public int Antiquity
        {
            get
            {
                return DateTime.Now.Year - this.EntryDate.Year;
            }
        }
        public int VacationDays
        {
            get
            {
                int antiquity = this.Antiquity;
                if (antiquity >= 1 && antiquity < 5)
                {
                    return 15;
                }
                else if (antiquity >= 5 && antiquity < 10)
                {
                    return 21;
                }
                else if (antiquity >= 10)
                {
                    return 31;
                }
                return 0;
            }
        }


        // TODO: Agregar atributos propio de Operator
        public Operator(int inputFileNumber, string inputUsername, string inputPassword) 
                 : base(inputFileNumber, inputUsername, inputPassword, false) { }
    }
}
