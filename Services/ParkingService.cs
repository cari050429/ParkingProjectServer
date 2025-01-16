using System;
using System.Diagnostics.Eventing.Reader;

public class ParkingService : IParkingService
{
    private readonly IParkingDataAccess _dataAccess;

    public ParkingService(IParkingDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

   public async Task<IEnumerable<ParkingAreaResponse>> GetAllParkingAreasAsync()
   {
       var parkingAreas = await _dataAccess.GetAllParkingAreasAsync();
       var parkingAreaResponses = new List<ParkingAreaResponse>();

       foreach (var parkingArea in parkingAreas)
       {
           parkingAreaResponses.Add(new ParkingAreaResponse(parkingArea));
       }

       return parkingAreaResponses;
   }

    public async Task<IEnumerable<ParkingAreaTypeResponse>>GetAllParkingAreaTypesAsync()
    {
       var parkingAreaTypes = await _dataAccess.GetAllParkingAreaTypesAsync();
       var parkingAreaTypeResponses = new List<ParkingAreaTypeResponse>();

       foreach (var parkingAreaType in parkingAreaTypes)
       {
           parkingAreaTypeResponses.Add(new ParkingAreaTypeResponse(parkingAreaType));
       }

       return parkingAreaTypeResponses;
    }

    public async Task<IEnumerable<ParkingPermitResponse>>GetAllParkingPermitsAsync()
    {
       var parkingPermits = await _dataAccess.GetAllParkingPermitsAsync();
       var parkingPermitResponses = new List<ParkingPermitResponse>();

       foreach (var parkingPermit in parkingPermits)
       {
           parkingPermitResponses.Add(new ParkingPermitResponse(parkingPermit));
       }

       return parkingPermitResponses;
    }



   public async Task<bool> CreateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest)
   {
    var parkingArea = new ParkingAreas{
            ParkingAreaTypeID = parkingAreaRequest.ParkingAreaTypeID,
           ParkingAreaName = parkingAreaRequest.ParkingAreaName,
            Latitude = parkingAreaRequest.Latitude,
            Longitude = parkingAreaRequest.Longitude,
            DateCreated = DateTime.Now,
            Inactive = parkingAreaRequest.Inactive,
        };
       return await _dataAccess.CreateParkingAreaAsync( parkingArea);

   }
//    Task<ParkingAreaResponse> UpdateParkingAreaAsync(int id, ParkingAreaRequest parkingAreaRequest);
//    Task<bool> DeleteParkingAreaAsync(int id);

    public async Task<bool> CreateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest)
    {

        var parkingAreaType = new ParkingAreaTypes{
            ParkingAreaTypeDescription = parkingAreaTypeRequest.ParkingAreaTypeDescription, 
            Inactive = parkingAreaTypeRequest.Inactive
        };
       return await _dataAccess.CreateParkingAreaTypeAsync( parkingAreaType);
       
    }

        public async Task<bool> CreateParkingPermitTypeAsync(ParkingPermitRequest parkingPermitRequest)
    {


        var parkingPermit = new ParkingPermits{
            ParkingAreaID = parkingPermitRequest.ParkingAreaID,
            EffectiveDate = parkingPermitRequest.EffectiveDate,
            ExpirationDate = parkingPermitRequest.ExpirationDate,
            LicensePlate = parkingPermitRequest.LicensePlate,
            DateCreated = DateTime.Now,
            Inactive = parkingPermitRequest.Inactive,
        };

       return await _dataAccess.CreateParkingPermitAsync( parkingPermit);
       
    }

        public async Task<ParkingPermitDetailResponse> getParkingPermitByIdAsync(int id)
    {
            return new ParkingPermitDetailResponse(await _dataAccess.getParkingPermitByIdAsync(id));
    }

     public async Task<ParkingAreaResponse> getParkingAreaByIdAsync(int id)
     {
        return new ParkingAreaResponse(await _dataAccess.getParkingAreaByIdAsync(id));
    }
     

    public async Task<ParkingAreaTypeResponse> getParkingAreaTypeByIdAsync(int id)
    {
        return new ParkingAreaTypeResponse(await _dataAccess.getParkingAreaTypeByIdAsync(id));
    }
    

    public async Task<bool> UpdateParkingAreaAsync(ParkingAreaRequest parkingAreaRequest, int id)
    {
        var parkingArea = new ParkingAreas{
            ParkingAreaTypeID = parkingAreaRequest.ParkingAreaTypeID,
           ParkingAreaName = parkingAreaRequest.ParkingAreaName,
            Latitude = parkingAreaRequest.Latitude,
            Longitude = parkingAreaRequest.Longitude,
            DateCreated = DateTime.Now,
            Inactive = parkingAreaRequest.Inactive,
        };
       return await _dataAccess.UpdateParkingAreaAsync( parkingArea, id);

    }

    public async Task<bool> UpdateParkingAreaTypeAsync(ParkingAreaTypeRequest parkingAreaTypeRequest, int id)
    {
        var parkingAreaType = new ParkingAreaTypes{
            ParkingAreaTypeDescription = parkingAreaTypeRequest.ParkingAreaTypeDescription, 
            Inactive = parkingAreaTypeRequest.Inactive
        };
       return await _dataAccess.UpdateParkingAreaTypeAsync( parkingAreaType, id);
    }

    public async Task<bool> UpdateParkingPermitAsync(ParkingPermitRequest parkingPermitRequest, int id)
    {
        var parkingPermit = new ParkingPermits{
            ParkingAreaID = parkingPermitRequest.ParkingAreaID,
            EffectiveDate = parkingPermitRequest.EffectiveDate,
            ExpirationDate = parkingPermitRequest.ExpirationDate,
            LicensePlate = parkingPermitRequest.LicensePlate,
            DateCreated = DateTime.Now,
            Inactive = parkingPermitRequest.Inactive,
        };

       return await _dataAccess.UpdateParkingPermitAsync( parkingPermit, id);
       
    }

    public async Task<bool> DeleteParkingPermitAsync(int id)
    {
        return await _dataAccess.DeleteParkingPermitAsync(id);
    }
    public async Task<bool> DeleteParkingAreaAsync(int id)
    {
        return await _dataAccess.DeleteParkingAreaAsync(id);
    }
    public async Task<bool> DeleteParkingAreaTypeAsync(int id)
    {
        return await _dataAccess.DeleteParkingAreaTypeAsync(id);
    }


}

