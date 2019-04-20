using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class NonOperatingAssets:EntityBase
    {
        [Required]
        public string VillageName { get; set; }
        [Required]
        public int OfficeBuildingNumber { get; set; }
        [Required]
        public float OfficeBuildingArea { get; set; }
        [Required]
        public int ServiceStationNumber { get; set; }
        [Required]
        public int SeniorCitizenCenterNumber { get; set; }
        [Required]
        public float SeniorCitizenCenterArea { get; set; }
        [Required]
        public int SportsActivityRoomNumber { get; set; }
        [Required]
        public float SportActivityRoomArea { get; set; }
        [Required]
        public int StaffQuartersNumber { get; set; }
        [Required]
        public float StaffQuarterArea { get; set; }
        [Required]
        public int LibraryNumber { get; set; }
        [Required]
        public int LibaryCollectionsNumber { get; set; }

    }
}
