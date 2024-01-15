
struct RequestLinks
{
        
       public static string GetClimateList { get; private set; } = "http://localhost:5141/api/API/GetClimateList";
       public static string GetRegionsList { get; private set; } = "http://localhost:5141/api/API/GetRegionsList";
       public static string PostRegion { get; private set; } = "http://localhost:5141/api/API/PostRegion";
       public static string DeleteRegion { get; private set; } = "http://localhost:5141/api/API/DeleteRegions";

}

