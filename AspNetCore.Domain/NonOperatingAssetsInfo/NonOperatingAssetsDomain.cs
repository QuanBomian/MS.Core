using AspNetCore.Domain.Repository;
using AspNetCore.Domain.NonOperatingAssetsInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.NonOperatingAssetsInfo
{
    public class NonOperatingAssetsDomain : Domain<NonOperatingAssets, Guid>, INonOperatingAssetsDomain
    {

        public NonOperatingAssetsDomain(INonOperatingAssetsRepository repository) : base(repository) { }

        public List<NonOperatingAssets> Get(NonOperatingAssetsQueryDto condition)
        {
            IQueryable<NonOperatingAssets> query = _repository.Query();
            if (condition.VillageName != null && condition.VillageName.Trim() != "")
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.VillageName.Contains(condition.VillageName));
            }
            if (condition.LibaryCollectionsNumber != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.LibaryCollectionsNumber == condition.LibaryCollectionsNumber);
            }
            if (condition.LibraryNumber != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.LibraryNumber == condition.LibraryNumber);
            }
            if (condition.OfficeBuildingNumber != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.OfficeBuildingNumber == condition.OfficeBuildingNumber);
            }
            if (condition.OfficeBuildingArea != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.OfficeBuildingArea == condition.OfficeBuildingArea);
            }
            if (condition.SeniorCitizenCenterNumber != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.SeniorCitizenCenterNumber == condition.SeniorCitizenCenterNumber);
            }
            if (condition.SeniorCitizenCenterArea != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.SeniorCitizenCenterArea == condition.SeniorCitizenCenterArea);
            }
            if (condition.ServiceStationNumber != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.ServiceStationNumber == condition.ServiceStationNumber);
            }
            if (condition.SportsActivityRoomNumber != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.SportsActivityRoomNumber == condition.SportsActivityRoomNumber);
            }
            if (condition.SportActivityRoomArea != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.SportActivityRoomArea == condition.SportActivityRoomArea);
            }
            if (condition.StaffQuartersNumber != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.StaffQuartersNumber == condition.StaffQuartersNumber);
            }
            if (condition.StaffQuarterArea != null)
            {
                query = query.Where(NonOperatingAssets => NonOperatingAssets.StaffQuarterArea == condition.StaffQuarterArea);
            }





            return query.ToList();
        }
    }
}
