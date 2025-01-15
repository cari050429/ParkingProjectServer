using System;
using Microsoft.AspNetCore.Authentication;

public interface IParkingDataAccess
{ 
    //Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync();

    public Task<IEnumerable<ParkingAreas>> GetAllParkingAreasAsync();

    public Task<IEnumerable<ParkingAreaTypes>> GetAllParkingAreaTypesAsync();

    public Task<IEnumerable<ParkingPermits>> GetAllParkingPermitsAsync();

    public Task<ParkingAreas> CreateParkingAreaAsync(ParkingAreas parkingArea);
   

    public Task<ParkingAreaTypes> CreateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaType);

    public Task<ParkingPermits> CreateParkingPermitAsync(ParkingPermits parkingPermit);

    public Task<ParkingAreas> GetParkingAreaByIdAsync(int id);

    public Task<ParkingAreas> UpdateParkingAreaAsync(ParkingAreas parkingArea, int id);

    public Task<ParkingAreaTypes> UpdateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaType, int id);

    public Task<ParkingPermits> UpdateParkingPermitAsync(ParkingPermits parkingPermit, int id);

    public Task<bool> DeleteParkingAreaAsync(int id); 
    public Task<bool> DeleteParkingPermitAsync(int id); 
    public Task<bool> DeleteParkingAreaTypeAsync(int id); 


}
