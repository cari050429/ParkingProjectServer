using System;

public class ParkingService : IParkingService
{
    private readonly IParkingDataAccess _dataAccess;

    public ParkingService(IParkingDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

   //public async Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync()
   // {
   //     var parkingAreas = await _dataAccess.GetAllParkingAreasAsync();
   //     var parkingAreaResponses = new List<ParkingAreaResponse>();

   //     foreach (var parkingArea in parkingAreas)
   //     {
   //         parkingAreaResponses.Add(new ParkingAreaResponse(parkingArea));
   //     }

   //     return parkingAreaResponses;
   // }

   // Task<ParkingAreaResponse> CreateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest)
   // {

   // }
   // Task<ParkingAreaResponse> UpdateParkingAreaAsync(int id, ParkingAreaRequest parkingAreaRequest);
   // Task<bool> DeleteParkingAreaAsync(int id);

    public async Task<ParkingAreaTypeResponse> CreateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest)
    {

        var parkingAreaType = new ParkingAreaTypes{
            ParkingAreaTypeDescription = parkingAreaTypeRequest.ParkingAreaTypeDescription, 
            Inactive = parkingAreaTypeRequest.Inactive
        };
       return new ParkingAreaTypeResponse(await _dataAccess.CreateParkingAreaTypeAsync( parkingAreaType));
       
    }

}

