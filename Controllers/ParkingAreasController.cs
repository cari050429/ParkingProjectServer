using System;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class ParkingController
{
    private readonly IParkingService _parkingservice;

    public ParkingController(IParkingService parkingService)
	{
        _parkingservice = parkingService;

    }

    //Get All ParkingArea
 //   [HttpGet("getParkingAreas")]
	//public async Task<ActionResult<IEnumerable<ParkingAreaResponse>>> GetParkingAreas()
	//{
	//	return await _parkingDataAccess.GetParkingAreasAsync();
	//}

    //Get All ParkingAreaTypes

    //Get All ParkingPermits

    //Get one ParkingPermit

    //Update one ParkingArea

    //Update one ParkingAreaType 

    //Update one ParkingPermit

    //Create one ParkingArea

    //Create one ParkingAreaType

    [HttpPost("createParkingAreaType")]
    public async Task<ActionResult<ParkingAreaTypeResponse>> CreateParkingAreaType(ParkingAreaTypeRequest request)
    {
        return await _parkingservice.CreateParkingAreaTypeAsync(request);
    }
    //Create one ParkingPermit

    //Delete one ParkingArea

    //Delete one ParkingAreaType

    //Delete one ParkingPermit


}
