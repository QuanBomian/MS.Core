using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Entity
{
    public class NonOperatingAssets:EntityBase
    {
        public string VillageName { get; set; }

        public int OfficeBuildingNumber { get; set; }

        public float OfficeBuildingArea { get; set; }

        public int ServiceStationNumber { get; set; }

        public int SeniorCitizenCenterNumber { get; set; }

        public float SeniorCitizenCenterArea { get; set; }

        public int SportsActivityRoomNumber { get; set; }

        public float SportActivityRoomArea { get; set; }

        public int StaffQuartersNumber { get; set; }

        public float StaffQuarterArea { get; set; }

        public int LibraryNumber { get; set; }

        public int LibaryCollectionsNumber { get; set; }

    }
}
