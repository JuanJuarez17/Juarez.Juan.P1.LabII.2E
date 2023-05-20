using System;
using System.Linq;

namespace ENTITIES_APP
{
    public abstract class User
    {
        #region USED ATTRIBUTES
        private bool active;
        protected int fileNumber;
        protected string username;
        protected string password;
        protected bool admin;
        protected string name;
        protected string surname;
        protected int age;
        protected DateTime entryDate;
        #endregion

        #region CONSTRUCTOR
        protected User(int inputFileNumber, string inputUser, string inputPassword, bool inputAdmin)
        {
            this.active = true;
            this.fileNumber = inputFileNumber;
            this.username = inputUser;
            this.password = inputPassword;
            this.admin = inputAdmin;
        }
        #endregion

        #region READONLY PROPERTIES

        // No sobreescribo el get porque son atributos con los que creo un usuario "siempre van a estar bien"
        public bool Active { get { return active; } }
        public int FileNumber { get { return this.fileNumber; } }
        public string Username { get { return this.username; } }
        public string Password { get { return this.password; } }
        public bool Admin { get { return this.admin; } }

        // Estos atributos "pueden no estar bien"
        public string Name
        {
            get
            {
                /* En caso de que no hubiese que devolver null por algun motivo
                string rtn = this.name;
                if (rtn == null)
                {
                    rtn = string.Empty;
                }
                return rtn;
                */
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public DateTime EntryDate
        {
            get { return entryDate; }
            set { this.entryDate = value; }
        }

        #endregion

        #region METHODS
        public bool CheckUsername(string inputUsername)
        {
            return Username.Equals(inputUsername);
        }
        public bool CheckPassword(string inputPassword)
        {
            return Password.Equals(inputPassword);
        }

        public static bool ValidateEntries(string inputName, string inputSurname, string inputAge, string inputDate)
        {
            bool isInt = int.TryParse(inputAge, out int value);
            if (!ValidateName(inputName) || !ValidateName(inputSurname) || !isInt || !ValidateDate(inputDate))
            {
                return false;
            }
            return true;
        }

        private static bool ValidateDate(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime auxDate))
            {
                DateTime minDateAccepted = new DateTime(1950, 01, 01);
                if (auxDate >= minDateAccepted && auxDate <= DateTime.Now)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidateName(string inputName)
        {
            if (inputName == "")
            {
                return true;
            }
            if (inputName is null || inputName.Length <= 1 || inputName.Length >= 15 || !ValidateLetters(inputName))
            {
                return false;
            }
            return true;
        }
        private static bool ValidateLetters(string inputLetters)
        {
            foreach (char c in inputLetters)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
