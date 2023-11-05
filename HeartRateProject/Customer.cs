using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRate
{
    public enum ActivityLevel
    {
        SEDENTARY, MINIMAL, SPORADIC, REGULAR, HIGH
    }
    class Customer
    {
        public string FirstName { get; set; }
        public bool IsFemale { get; set; }
        public bool Active { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public int MHR { get; set; }
        public int TargetMin { get; set; }
        public double TargetMax { get; set; }
        public string FormulaType { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName}, Female: {Active}, Age: {Age}, Active: {IsFemale}, Formula: {FormulaType}, MHR: {MHR}, Activity: {ActivityLevel.ToString()}, Min: {TargetMax}; Max: {TargetMin}"; 
        }
    }
}
