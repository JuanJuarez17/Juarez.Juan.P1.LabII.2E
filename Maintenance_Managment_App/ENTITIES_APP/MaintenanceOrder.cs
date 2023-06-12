﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_APP
{
    public class MaintenanceOrder
    {
        #region ATTRIBUTES
        private int id;
        private bool active;
        private string maker;
        private Section faultyUnitSection;
        private Machine faultyUnit;
        private Urgency failureUrgency;
        private string description;
        private DateTime creationDate;
        private bool completed;
        private DateTime endDate;
        #endregion

        #region PROPERTIES
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
        public string Username
        {
            get { return this.maker; }
            set { this.maker = value; }
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
            set { this.creationDate = value; }
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
        public MaintenanceOrder()
        {
            this.active = true;
            this.creationDate = DateTime.Now;
            this.completed = false;
            this.endDate = new DateTime(1753,1,1);
        }
        public MaintenanceOrder(string inputMaker, Section inputSection, Machine inputMachine, Urgency inputUrgency, string inputDescription)
                 : this()
        {
            this.maker = inputMaker;
            this.faultyUnitSection = inputSection;
            this.faultyUnit = inputMachine;
            this.failureUrgency = inputUrgency;
            this.description = inputDescription;
        }
        #endregion

        public static bool ValidateDescription(string inputDescription)
        {
            bool rtn = false;
            if (inputDescription.Length == 0 || (inputDescription.Length >= 5 && inputDescription.Length <= 200))
            {
                rtn = true;
            }
            return rtn;
        }

        public static bool ValidateEntries(string inputName)
        {
            if (!ValidateDescription(inputName))
            {
                return false;
            }
            return true;
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
                auxMaintOrder.Username = inputUser;
                auxMaintOrder.Section = inputSection;
                auxMaintOrder.Machine = inputMachine;
                auxMaintOrder.Urgency = inputUrgency;
                auxMaintOrder.Description = inputDescription;
                auxMaintOrder.CreationDate = inputCreationDate;
                auxMaintOrder.Completed = inputCompleted;
                auxMaintOrder.EndDate = inputEndDate;

                return auxMaintOrder;
            }
            return auxMaintOrder;
        }
    }
}

