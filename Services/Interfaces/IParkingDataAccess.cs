using System;
using Microsoft.AspNetCore.Authentication;

public interface IParkingDataAccess
{ 
    //Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync();

    public Task<IEnumerable<ParkingAreas>> GetAllParkingAreasAsync();

    public Task<IEnumerable<ParkingAreaTypes>> GetAllParkingAreaTypesAsync();

    public Task<IEnumerable<ParkingPermits>> GetAllParkingPermitsAsync();

    public Task<bool> CreateParkingAreaAsync(ParkingAreas parkingArea);
   

    public Task<bool> CreateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaType);

    public Task<bool> CreateParkingPermitAsync(ParkingPermits parkingPermit);

    public Task<ParkingPermits> getParkingPermitByIdAsync(int id);
    public Task<ParkingAreas> getParkingAreaByIdAsync(int id);

    public Task<ParkingAreaTypes> getParkingAreaTypeByIdAsync(int id);


    public Task<bool> UpdateParkingAreaAsync(ParkingAreas parkingArea, int id);

    public Task<bool> UpdateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaType, int id);

    public Task<bool> UpdateParkingPermitAsync(ParkingPermits parkingPermit, int id);

    public Task<bool> DeleteParkingAreaAsync(int id); 
    public Task<bool> DeleteParkingPermitAsync(int id); 
    public Task<bool> DeleteParkingAreaTypeAsync(int id); 


}
