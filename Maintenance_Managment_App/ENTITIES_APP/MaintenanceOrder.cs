using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Net.Mime.MediaTypeNames;

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
        [JsonConverter(typeof(StringEnumConverter))]
        public Section Section
        {
            get { return this.faultyUnitSection; }
            set { this.faultyUnitSection = value; }
        }
        [JsonConverter(typeof(StringEnumConverter))]
        public Machine Machine
        {
            get { return this.faultyUnit; }
            set { this.faultyUnit = value; }
        }
        [JsonConverter(typeof(StringEnumConverter))]
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
        [JsonIgnore]
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
            this.endDate = new DateTime(1753, 1, 1);
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

        #region METHODS
        public static bool ValidateEntries(string inputName)
        {
            if (!ValidateDescription(inputName))
            {
                return false;
            }
            return true;
        }
        private static bool ValidateDescription(string inputDescription)
        {
            bool rtn = false;
            if (inputDescription.Length == 0 || (inputDescription.Length >= 5 && inputDescription.Length <= 200))
            {
                rtn = true;
            }
            return rtn;
        }
        public override string ToString()
        {
            string[] attributes = new string[10];

            attributes[0] = this.Id.ToString();
            attributes[1] = this.Active.ToString();
            attributes[2] = this.Username;
            attributes[3] = this.Section.ToString();
            attributes[4] = this.Machine.ToString();
            attributes[5] = this.Urgency.ToString();
            attributes[6] = this.Description;
            attributes[7] = this.CreationDate.ToString("yyyy/MM/dd");
            attributes[8] = this.Completed.ToString();
            attributes[9] = this.EndDate.ToString("yyyy/MM/dd");

            return $"{attributes[0]},{attributes[1]},{attributes[2]},{attributes[3]},{attributes[4]},{attributes[5]},{attributes[6]},{attributes[7]},{attributes[8]},{attributes[9]}";
        }
        public static string GetMaintOrderId(List<MaintenanceOrder> inputList)
        {
            string rtn = string.Empty;
            foreach (MaintenanceOrder item in inputList)
            {
                rtn += $"{item.Id} - ";
            }
            return rtn;
        }
        public static bool CompareUsername(MaintenanceOrder inputItem, string valueFilter)
        {
            return inputItem.Username == valueFilter;
        }

        // FILES & SERIALIZATION
        private static string WriteAsText(List<MaintenanceOrder> inputList)
        {
            StringBuilder sb = new StringBuilder();
            if (inputList != null && inputList.Count > 0)
            {
                sb.AppendLine("id,active,user,section,machine,urgency,description,creationDate,completed,endDate");
                foreach (MaintenanceOrder item in inputList)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
        public static bool SaveAsText(List<MaintenanceOrder> inputList)
        {
            bool rtn = false;
            string route = Path.GetFullPath(".\\..\\..\\..\\..\\FILES\\MaintOrderDb.csv");
            string text = WriteAsText(inputList);
            if (!string.IsNullOrEmpty(text))
            {
                if (File.Exists(route))
                {
                    File.Delete(route);
                }
                File.WriteAllText(route, text);
                rtn = true;
            }
            return rtn;
        }
        public static bool SerializeToJson<T>(T element)
        {
            bool rtn = false;
            string route = Path.GetFullPath(".\\..\\..\\..\\..\\FILES\\MaintOrderDb.json");
            string JsonText = JsonConvert.SerializeObject(element);
            if (!string.IsNullOrEmpty(JsonText))
            {
                if (File.Exists(route))
                {
                    File.Delete(route);
                }
                File.WriteAllText(route, JsonText);
                rtn = true;
            }
            return rtn;
        }

        // SORT
        public static List<MaintenanceOrder> Sort(List<MaintenanceOrder> inputList, string parameter, int inputOrder)
        {
            List<MaintenanceOrder> rtn = inputList;
            switch (parameter)
            {
                case "CREATION_DATE":
                    if (inputOrder == 0) { rtn.Sort(CreationDateDecreasing); }
                    else { rtn.Sort(CreationDateCreasing); }
                    break;
                case "SECTION":
                    if (inputOrder == 0) { rtn.Sort(SectionDecreasing); }
                    else { rtn.Sort(SectionCreasing); }
                    break;
                case "MACHINE":
                    if (inputOrder == 0) { rtn.Sort(MachineDecreasing); }
                    else { rtn.Sort(MachineCreasing); }
                    break;
                case "URGENCY":
                    if (inputOrder == 0) { rtn.Sort(PriorityDecreasing); }
                    else { rtn.Sort(PriorityCreasing); }
                    break;
                default:
                    break;
            }
            return rtn;
        }
        public static int CreationDateDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return input2.Antiquity - input1.Antiquity;
        }
        public static int CreationDateCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -CreationDateDecreasing(input1, input2);
        }
        public static int SectionDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return string.Compare(input2.Section.ToString(), input1.Section.ToString());
        }
        public static int SectionCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -SectionDecreasing(input1, input2);
        }
        public static int MachineDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return string.Compare(input2.Machine.ToString(), input1.Machine.ToString());
        }
        public static int MachineCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -MachineDecreasing(input1, input2);
        }
        public static int PriorityDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return string.Compare(input2.Urgency.ToString(), input1.Urgency.ToString());
        }
        public static int PriorityCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -PriorityDecreasing(input1, input2);
        } 
        #endregion
    }
}

