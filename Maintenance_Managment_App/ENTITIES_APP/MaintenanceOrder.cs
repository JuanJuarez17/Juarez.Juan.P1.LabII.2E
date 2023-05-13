using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_APP
{
    public class MaintenanceOrder
    {
        #region ATTRIBUTES

        private static int lastId;

        private readonly int id;
        private User maker;
        private Machine faultyUnit;
        private Section faultyUnitSection;
        private Urgency failureUrgency;
        private string description;
        private bool active;
        private DateTime creationDate;
        private bool completed;
        private DateTime endDate;
        #endregion

        #region READONLY PROPERTIES
        public int Id
        {
            get { return this.id; }
        }
        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
        public User User
        {
            get { return this.maker; }
        }
        public string Username
        {
            get { return this.maker.Username; }
        }
        public Section Section
        {
            get { return this.faultyUnitSection; }
            set { this.faultyUnitSection = value; }
        }
        public Machine Machine
        {
            get { return this.faultyUnit; }
            set { this.faultyUnit = value; }
        }
        public Urgency Urgency
        {
            get { return this.failureUrgency; }
            set { this.failureUrgency = value; }
        }
        public DateTime CreationDate
        {
            get { return this.creationDate.Date; }
        }
        public string Description
        {
            get
            {
                string rtn = this.description;
                if (rtn == null)
                {
                    rtn = string.Empty;
                }
                return rtn;
            }
            set { this.description = value; }
        }
        public bool Completed
        {
            get { return this.completed; }
            set { this.completed = value; }
        }
        public DateTime EndDate
        {
            get { return this.endDate.Date; }
            set { this.endDate = value; }
        }
        public int Antiquity
        {
            get
            {
                return (DateTime.Now - this.creationDate).Days;
            }
        }
        #endregion

        #region CONSTRUCTOR
        static MaintenanceOrder()
        {
            lastId = 100;
        }
        private MaintenanceOrder()
        {
            this.id = lastId++;
        }
        public MaintenanceOrder(User inputMaker, Section inputSection, Machine inputMachine, Urgency inputUrgency, string inputDescription)
                 : this()
        {
            this.maker = inputMaker; //
            this.faultyUnit = inputMachine; //
            this.faultyUnitSection = inputSection; //
            this.failureUrgency = inputUrgency; //
            this.description = inputDescription; //
            this.active = true;
            this.creationDate = DateTime.Now;
            this.completed = false;
        }
        public MaintenanceOrder(User inputMaker, Section inputSection, Machine inputMachine, Urgency inputUrgency, string inputDescription, bool inputStatus, DateTime inputCreation, bool inputCompleted)
                 : this(inputMaker, inputSection, inputMachine, inputUrgency, inputDescription) // Solo para uso en hardcodeo
        {
            this.active = inputStatus;
            this.creationDate = inputCreation;
            this.completed = inputCompleted;
            if (inputCompleted)
            {
                this.endDate = DateTime.Now;
            }
        }
        #endregion

        #region METHOD W/ EXCEPTION
        public static bool SetDescription(string inputDescription)
        {
            bool rtn = false;
            if (inputDescription.Length == 0 || (inputDescription.Length >= 10 && inputDescription.Length <= 50))
            {
                rtn = true;
            }
            return rtn;
        }
        #endregion

        #region METHODS

        #endregion




    }
}

