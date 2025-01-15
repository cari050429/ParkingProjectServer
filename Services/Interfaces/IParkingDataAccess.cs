using System; 

public interface IParkingDataAccess
{ 
    //Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync();
   // Task<ParkingAreaResponse> CreateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest);
    //Task<ParkingAreaResponse> UpdateParkingAreaAsync(int id, ParkingAreaRequest parkingAreaRequest);
    //Task<bool> DeleteParkingAreaAsync(int id);

    public Task<ParkingAreaTypes> CreateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaTypes);

}
