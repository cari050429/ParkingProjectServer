using System;
using System.Diagnostics.Eventing.Reader;

public interface IParkingService
{
    public Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync();
    public Task<ParkingAreaResponse> CreateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest);
   // Task<ParkingAreaResponse> UpdateParkingAreaAsync(int id, ParkingAreaRequest parkingAreaRequest);
//    Task<bool> DeleteParkingAreaAsync(int id);

    public Task<ParkingAreaTypeResponse> CreateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest);

    public Task<ParkingPermitResponse> CreateParkingPermitTypeAsync(ParkingPermitRequest parkingPermitRequest);

    public Task<ParkingAreaResponse> GetParkingAreaByIdAsync(int id);

    public Task<IEnumerable<ParkingAreaTypeResponse>>GetAllParkingAreaTypesAsync();

    public Task<IEnumerable<ParkingPermitResponse>>GetAllParkingPermitsAsync();

    //UpdateParkingPermitAsync

    public Task<ParkingAreaResponse> UpdateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest, int id);

    public Task<ParkingAreaTypeResponse> UpdateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest, int id);

    public Task<ParkingPermitResponse> UpdateParkingPermitAsync(ParkingPermitRequest parkingPermitRequest, int id);

    public Task<bool> DeleteParkingAreaAsync(int id); 
    public Task<bool> DeleteParkingPermitAsync(int id); 
    public Task<bool> DeleteParkingAreaTypeAsync(int id); 



}
