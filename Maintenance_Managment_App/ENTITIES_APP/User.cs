using System;
using System.IO;
using System.Linq;

namespace ENTITIES_APP
{
    public abstract class User
    {
        private bool active;
        protected int fileNumber;
        protected string username;
        protected string password;
        protected bool admin;
        protected string name;
        protected string surname;
        protected int age;
        protected DateTime entryDate;

        protected User(int inputFileNumber, string inputUser, string inputPassword, bool inputAdmin)
        {
            this.active = true;
            this.fileNumber = inputFileNumber;
            this.username = inputUser;
            this.password = inputPassword;
            this.admin = inputAdmin;
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        public int FileNumber
        {
            get { return this.fileNumber; }
            set { this.fileNumber = value; }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public bool Admin
        {
            get { return this.admin; }
            set { this.admin = value; }
        }
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
        public static bool ValidateEntries(string inputName)
        {
            if (!ValidateName(inputName))
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
        public virtual string WriteAsText()
        {
            string[] attributes = new string[9];

            attributes[0] = this.Active.ToString();
            attributes[1] = this.FileNumber.ToString();
            attributes[2] = this.Username;
            attributes[3] = this.Password;
            attributes[4] = this.Admin.ToString();
            attributes[5] = this.Name;
            attributes[6] = this.Surname;
            attributes[7] = this.Age.ToString();
            attributes[8] = this.EntryDate.ToString("yyyy/MM/dd");

            return $"{attributes[0]},{attributes[1]},{attributes[2]},{attributes[3]},{attributes[4]},{attributes[5]},{attributes[6]},{attributes[7]},{attributes[8]}";
        }
        public static User ReadFromText(string inputLine)
        {
            User auxUser = new Operator(0, null, null);
            if (!string.IsNullOrEmpty(inputLine))
            {
                string[] buffer = inputLine.Split(',');

                bool.TryParse(buffer[0], out bool inputActive);
                int.TryParse(buffer[1], out int inputFileNumber);
                string inputUsername = buffer[2];
                string inputPassword = buffer[3];
                bool.TryParse(buffer[4], out bool inputAdmin);
                string inputName = buffer[5];
                string inputSurname = buffer[6];
                int.TryParse(buffer[7], out int inputAge);
                DateTime.TryParse(buffer[8], out DateTime inputEntryDate);

                if (inputAdmin)
                {
                    auxUser = new Supervisor(inputFileNumber, inputUsername, inputPassword);
                    auxUser.Active = inputActive;
                    auxUser.Name = inputName;
                    auxUser.Surname = inputSurname;
                    auxUser.Age = inputAge;
                    auxUser.EntryDate = inputEntryDate;
                    return auxUser;
                }
                else
                {
                    Enum.TryParse(buffer[9], out Division inputDivision);
                    Enum.TryParse(buffer[10], out Shift inputShift);
                    Enum.TryParse(buffer[11], out Category inputCategory);
                    auxUser = new Operator(inputFileNumber, inputUsername, inputPassword);
                    auxUser.Active = inputActive;
                    auxUser.Name = inputName;
                    auxUser.Surname = inputSurname;
                    auxUser.Age = inputAge;
                    auxUser.EntryDate = inputEntryDate;
                    ((Operator)auxUser).Division = inputDivision;
                    ((Operator)auxUser).Shift = inputShift;
                    ((Operator)auxUser).Category = inputCategory;
                    return auxUser;
                }
            }
            return auxUser;
        }
    }
}
