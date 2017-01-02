﻿
using System.Collections.Generic;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class locationExamples
    {
        public static BrightLocalLocation Create()
        {
            var myLocation = new LocationOptions();
            myLocation.name = "Le Bernardin";
            myLocation.url = "le-bernardin.com";
            myLocation.businessCategoryId = 791;
            myLocation.country = "USA";
            myLocation.address1 = "155 Weest 51st Street";
            myLocation.address2 = "";
            myLocation.region = "NY"; // state or region
            myLocation.city = "New York";
            myLocation.postcode = "10019";
            myLocation.telephone = "+1 212-554-1515";

            var locationService = new LocationService();

            BrightLocalLocation newLocation = locationService.Create(myLocation);
            return newLocation;
        }

        public static BrightLocalLocation Update()
        {
            var myLocation = new UpdateLocationOptions();
            myLocation.locationId = 1;
            myLocation.name = "Le Bernardin";
            myLocation.url = "le-bernardin.com";
            myLocation.businessCategoryId = 791;
            myLocation.country = "USA";
            myLocation.address1 = "155 Weest 51st Street";
            myLocation.address2 = "";
            myLocation.region = "NY"; // state or region
            myLocation.city = "New York";
            myLocation.postcode = "10019";
            myLocation.telephone = "+1 212-554-1515";

            var locationService = new LocationService();

            BrightLocalLocation newLocation = locationService.Update(myLocation);
            return newLocation;
        }

        public static BrightLocalLocation Delete()
        {
            var locationId = 1;

            var locationService = new LocationService();

            BrightLocalLocation deleteLocation = locationService.Delete(locationId);
            return deleteLocation;
        }

        public static BrightLocalLocation Get()
        {
            var locationId = 1;

            var locationService = new LocationService();

            BrightLocalLocation getLocation = locationService.Get(locationId);
            return getLocation;
        }

        public static List<BrightLocalLocation> Search()
        {
            var searchQuery = "le-bernardin";
            var locationService = new LocationService();

            List<BrightLocalLocation> results = locationService.Search(searchQuery);
            return results;
        }
    }
}
