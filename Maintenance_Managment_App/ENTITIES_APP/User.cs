using System;

namespace ENTITIES_APP
{
    public abstract class User
    {
        #region USED ATTRIBUTES
        protected string username;
        protected string password;
        protected bool admin;
        #endregion

        #region UNUSED ATTRIBUTES
        // TODO: Revisar cuales de estos atributos son utiles y como utilizarlos
        protected int id; // Identificacion para uso sofware (No creo que sea necesario)
        protected string name;
        protected string surname;
        protected int file; // Legajo (Identificacion para uso fabril
        protected DateTime entryDate;
        #endregion

        #region CONSTRUCTOR
        protected User(string inputUser, string inputPassword, bool inputAdmin)
        {
            username = inputUser;
            password = inputPassword;
            admin = inputAdmin;
        }
        #endregion

        #region READONLY PROPERTIES
        public string Username
        {
            get { return username; }
        }
        public string Password
        {
            get { return password; }
        }
        public bool Admin
        {
            get { return admin; }
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
