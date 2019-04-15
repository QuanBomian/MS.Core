using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Entity
{
    public class Family:EntityBase
    {
        public string FamilyCode { get; set; }

        public string Householder { get; set; }

        public int PeopleNumber { get; set; }

        public string AccountCharacter { get; set; }

        public string VillageName { get; set; }

        public string VillageGroupCode { get; set; }

        public int AverageAnnualIncome { get; set; }

        public float HousingArea { get; set; }

        public float AverageHousingArea { get; set; }

        public bool IsLowIncome { get; set; }

        public bool IsPoor { get; set; }
    }
}
