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

        public Operator(int inputFileNumber, string inputUsername, string inputPassword) : base(inputFileNumber, inputUsername, inputPassword, false) { }
       
        public override string WriteAsText()
        {
            string baseParse = base.WriteAsText();
            string[] attributes = new string[3];
            attributes[0] = this.Division.ToString();
            attributes[1] = this.Shift.ToString();
            attributes[2] = this.Category.ToString();
            return baseParse + $",{attributes[0]},{attributes[1]},{attributes[2]}";
        }

        public static explicit operator string(Operator inputOperator)
        {
            string[] attributes = new string[9];

            attributes[0] = inputOperator.Active.ToString();
            attributes[1] = inputOperator.FileNumber.ToString();
            attributes[2] = inputOperator.Username;
            attributes[3] = inputOperator.Password;
            attributes[4] = inputOperator.Admin.ToString();
            attributes[5] = inputOperator.Name;
            attributes[6] = inputOperator.Surname;
            attributes[7] = inputOperator.Age.ToString();
            attributes[8] = inputOperator.EntryDate.ToString("yyyy/MM/dd");

            return $"{attributes[0]},{attributes[1]},{attributes[2]},{attributes[3]},{attributes[4]},{attributes[5]},{attributes[6]},{attributes[7]},{attributes[8]}";
        }
    }
}
