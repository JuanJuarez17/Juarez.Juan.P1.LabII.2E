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
        private readonly int id; // automatico
        private User maker;
        private Machine faultyUnit;
        private Section faultyUnitSection;
        private Urgency failureUrgency;
        private DateTime creationDate; // Deberia autocompletarse con la fecha de carga
        // Sin usar
        private string description; // Puede ser opcional
        private bool completed;
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
        }
        public MaintenanceOrder(User inputMaker, Machine inputMachine, Section inputSection, Urgency inputUrgency, DateTime inputDate)
                 : this() // Solo para uso en hardcodeo
        {
            this.maker = inputMaker;
            this.faultyUnit = inputMachine;
            this.faultyUnitSection = inputSection;
            this.failureUrgency = inputUrgency;
            this.creationDate = inputDate;
        }
        #endregion

        #region METHODS
        public string MaintenanceOrder_print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID {this.id}");
            sb.AppendLine($"Genero: {this.maker.Username}");
            sb.AppendLine($"Maquina: {this.faultyUnit}");
            sb.AppendLine($"Sector: {this.faultyUnitSection}");
            sb.AppendLine($"Urgencia: {this.failureUrgency}");
            sb.AppendLine($"Fecha de creacion: {this.creationDate.Date}");
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

