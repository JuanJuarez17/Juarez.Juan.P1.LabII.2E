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

        private bool active;
        private User maker;
        private Machine faultyUnit;
        private Section faultyUnitSection;
        private Urgency failureUrgency;
        private string description;
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
            set { this.maker = value; }
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
            this.active = true;
            this.creationDate = DateTime.Now;
            this.completed = false;
        }
        public MaintenanceOrder(User inputMaker, Section inputSection, Machine inputMachine, Urgency inputUrgency, string inputDescription)
                 : this()
        {
            this.maker = inputMaker;
            this.faultyUnitSection = inputSection;
            this.faultyUnit = inputMachine;
            this.failureUrgency = inputUrgency;
            this.description = inputDescription;
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

        public static bool SetDescription(string inputDescription)
        {
            bool rtn = false;
            if (inputDescription.Length == 0 || (inputDescription.Length >= 10 && inputDescription.Length <= 50))
            {
                rtn = true;
            }
            return rtn;
        }
        public virtual string WriteAsText()
        {
            string[] attributes = new string[9];

            attributes[0] = this.Active.ToString();
            attributes[1] = this.Username;
            attributes[2] = this.Section.ToString();
            attributes[3] = this.Machine.ToString();
            attributes[4] = this.Urgency.ToString();
            attributes[5] = this.Description;
            attributes[6] = this.CreationDate.ToString("yyyy/MM/dd");
            attributes[7] = this.Completed.ToString();
            attributes[8] = this.EndDate.ToString("yyyy/MM/dd");

            return $"{attributes[0]},{attributes[1]},{attributes[2]},{attributes[3]},{attributes[4]},{attributes[5]},{attributes[6]},{attributes[7]},{attributes[8]}";
        }
        public static MaintenanceOrder ReadFromText(string inputLine)
        {
            MaintenanceOrder auxMaintOrder = new MaintenanceOrder();
            if (!string.IsNullOrEmpty(inputLine))
            {
                string[] buffer = inputLine.Split(',');

                bool.TryParse(buffer[0], out bool inputActive);
                string inputUser = buffer[1];
                Enum.TryParse(buffer[2], out Section inputSection);
                Enum.TryParse(buffer[3], out Machine inputMachine);
                Enum.TryParse(buffer[4], out Urgency inputUrgency);
                string inputDescription = buffer[5];
                DateTime.TryParse(buffer[6], out DateTime inputCreationDate);
                bool.TryParse(buffer[7], out bool inputCompleted);
                DateTime.TryParse(buffer[8], out DateTime inputEndDate);

                auxMaintOrder.Active = inputActive;


                return auxMaintOrder;
            }
            return auxMaintOrder;
        }

    }
}

