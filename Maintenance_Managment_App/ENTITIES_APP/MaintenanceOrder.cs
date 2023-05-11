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
        private DateTime creationDate;
        private string description;
        private bool completed;
        private DateTime endDate;
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
        public MaintenanceOrder(User inputMaker, Machine inputMachine, Section inputSection, Urgency inputUrgency)
                         : this()
        {
            this.maker = inputMaker;
            this.faultyUnit = inputMachine;
            this.faultyUnitSection = inputSection;
            this.failureUrgency = inputUrgency;
            this.creationDate = DateTime.Now;
            this.completed = false;
        }
        public MaintenanceOrder(User inputMaker, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription)
                 : this(inputMaker, inputMachine, inputSection, inputUrgency)
        {
            this.description = inputDescription;
        }
        public MaintenanceOrder(User inputMaker, Machine inputMachine, Section inputSection, Urgency inputUrgency, DateTime inputDate)
                 : this(inputMaker, inputMachine, inputSection, inputUrgency) // Solo para uso en hardcodeo
        {
            this.creationDate = inputDate;
        }
        #endregion

        #region READONLY PROPERTIES
        public int Id
        {
            get { return this.id; }
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
                    rtn = "No se cargo descripcion";
                }
                return rtn; 
            }
            set { this.description = value; }
        }
        public bool Completed
        {
            get { return this.completed; }
        }
        public DateTime EndDate
        {
            get { return this.endDate; }
        }

        public int Antiquity
        {
            get
            {
                return (DateTime.Now - this.creationDate).Days;
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
        public string MaintenanceOrder_print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID {this.Id}");
            sb.AppendLine($"Genero: {this.Username}");
            sb.AppendLine($"Sector: {this.Section}");
            sb.AppendLine($"Maquina: {this.Machine}");
            sb.AppendLine($"Urgencia: {this.Urgency}");
            sb.AppendLine($"Fecha de creacion: {this.CreationDate}");
            if (!string.IsNullOrWhiteSpace(this.Description))
            {
                sb.AppendLine($"Descripcion: {this.Description}");
            }
            return sb.ToString();
        }

        /*
        public bool MaintenanceOrder_print(out string message) // Mismo metodo que el anterior pero con otra firma
        {
            bool rtn = false;
            StringBuilder sb = new StringBuilder();
            if (this is not null)
            {
                sb.AppendLine($"ID {this.id}");
                sb.AppendLine($"Genero: {this.maker.Username}");
                sb.AppendLine($"Maquina: {this.faultyUnit}");
                sb.AppendLine($"Sector: {this.faultyUnitSection}");
                sb.AppendLine($"Urgencia: {this.failureUrgency}");
                sb.AppendLine($"Fecha de creacion: {this.creationDate.Date}");
                rtn = true;
            }
            message = sb.ToString();
            return rtn;
        }
        */
        #endregion
    }
}

