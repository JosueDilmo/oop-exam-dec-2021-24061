using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1.Models
{
    public class BuildingCodes
    {
        public int BuildingId { get; set; }
        public string BuildingLocation { get; set; }
        public string BuildingCode { get; set; }

        public BuildingCodes( int _BuildingId, string _BuildingLocation, string _BuildingCode) 
        {
            BuildingId = _BuildingId;
            BuildingLocation = _BuildingLocation;
            BuildingCode = _BuildingCode;
        }
        public BuildingCodes()
        {

        }

        public List<BuildingCodes> ListOfBuildingCodes = new() 
        { 

        };

        public void ListBuildingCodes(bool sortAsc = true)
        {
            List<BuildingCodes> sortedList = ListOfBuildingCodes.OrderBy(x => x.BuildingId).ToList();

            if (!sortAsc)
            {
                sortedList = ListOfBuildingCodes.OrderByDescending(x => x.BuildingId).ToList();
            }

            foreach (BuildingCodes codeItem in sortedList)
            {

                Console.WriteLine($"Building ID: {codeItem.BuildingId} Location: {codeItem.BuildingLocation} Code: {codeItem.BuildingCode}");


            }
        }
    }
    

}
