﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ENTITIES_APP
{
    public abstract class User
    {
        #region ATTRIBUTES
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
            this.entryDate = new DateTime(1753, 1, 1);
        }
        #endregion

        #region PROPERTIES
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
                string rtn = this.name;
                if (rtn == null)
                {
                    rtn = string.Empty;
                }
                return rtn;                
            }
            set
            {
                this.name = value;
            }
        }
        public string Surname
        {
            get 
            {
                string rtn = this.surname;
                if (rtn == null)
                {
                    rtn = string.Empty;
                }
                return rtn;
            }
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
        public static List<string> ImportUsernames(List<User> inputList)
        {
            List<string> rtn = new List<string>();
            foreach (User item in inputList)
            {
                if (!item.Admin && item.Username != "Operario")
                {
                    rtn.Add(item.Username);
                }
            }
            return rtn;
        }
        public bool CheckUsername(string inputUsername)
        {
            return this.Username.Equals(inputUsername);
        }
        public bool CheckPassword(string inputPassword)
        {
            return this.Password.Equals(inputPassword);
        }
        public static bool CheckFileNumberAvailable(List<User> inputList, int inputFileNumber)
        {
            bool rtn = true;
            if (inputList.Count == 0)
            {
                rtn = false;
            }
            else
            {
                foreach (User item in inputList)
                {
                    if (item.FileNumber == inputFileNumber)
                    {
                        return false;
                    }
                }
            }
            return rtn;
        }
        public static bool ValidateEntries(string inputName)
        {
            if (!ValidateName(inputName))
            {
                return false;
            }
            return true;
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
