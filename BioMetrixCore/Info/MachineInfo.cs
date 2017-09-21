using System;

namespace BioMetrixCore
{
    public class MachineInfo
    {
        //public int MachineNumber { get; set; }

        public int EmployeeID { get; set; }

        public string DateTimeRecord { get; set; }

        public string InOut { get; set; }

        /*public DateTime DateOnlyRecord
        {
            get { return DateTime.Parse(DateTime.Parse(DateTimeRecord).ToString("yyyy-MM-dd")); }
        }

        public DateTime TimeOnlyRecord
        {
            get { return DateTime.Parse(DateTime.Parse(DateTimeRecord).ToString("hh:mm:ss")); }
        }*/
    }
}
