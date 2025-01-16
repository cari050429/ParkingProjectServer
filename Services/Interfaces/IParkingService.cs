using System;
using System.Diagnostics.Eventing.Reader;

public interface IParkingService
{
    public Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync();
    public Task<bool> CreateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest);

    public Task<bool> CreateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest);

    public Task<bool> CreateParkingPermitTypeAsync(ParkingPermitRequest parkingPermitRequest);

    public Task<ParkingPermitDetailResponse> getParkingPermitByIdAsync(int id);
    public Task<ParkingAreaResponse> getParkingAreaByIdAsync(int id);

    public Task<ParkingAreaTypeResponse> getParkingAreaTypeByIdAsync(int id);


    public Task<IEnumerable<ParkingAreaTypeResponse>>GetAllParkingAreaTypesAsync();

    public Task<IEnumerable<ParkingPermitResponse>>GetAllParkingPermitsAsync();

    public Task<bool> UpdateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest, int id);

    public Task<bool> UpdateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest, int id);

    public Task<bool> UpdateParkingPermitAsync(ParkingPermitRequest parkingPermitRequest, int id);

    public Task<bool> DeleteParkingAreaAsync(int id); 
    public Task<bool> DeleteParkingPermitAsync(int id); 
    public Task<bool> DeleteParkingAreaTypeAsync(int id); 



}
