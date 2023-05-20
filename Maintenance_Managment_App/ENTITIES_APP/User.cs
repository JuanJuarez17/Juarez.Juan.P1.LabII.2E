using System;

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
        public string Username { get { return this.username; } }
        public string Password { get { return this.password; } }
        public bool Admin { get { return this.admin; } }
        public int FileNumber { get { return this.fileNumber; } }
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
        #endregion
    }
}
