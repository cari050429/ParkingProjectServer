using System;

public interface IParkingService
{
    //Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync();
  // Task<ParkingAreaResponse> CreateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest);
   // Task<ParkingAreaResponse> UpdateParkingAreaAsync(int id, ParkingAreaRequest parkingAreaRequest);
//    Task<bool> DeleteParkingAreaAsync(int id);

    public Task<ParkingAreaTypeResponse> CreateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest);

}
