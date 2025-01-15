using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
[ApiController]
[Route("api/[controller]")]
public class ParkingController : ControllerBase
{
    private readonly IParkingService _parkingservice;

    public ParkingController(IParkingService parkingService)
	{
        _parkingservice = parkingService;

    }

    //Get All ParkingAreas
   [HttpGet("getParkingAreas")]
	public async Task<ActionResult<IEnumerable<ParkingAreaResponse>>> GetParkingAreas()
	{
		var parkingAreas = await _parkingservice.GetAllParkingAreasAsync();

        return Ok(parkingAreas);
	}

    //Get All ParkingAreaTypes
       [HttpGet("getParkingTypes")]
	public async Task<ActionResult<IEnumerable<ParkingAreaResponse>>> getParkingTypes()
	{
		var parkingAreaTypes = await _parkingservice.GetAllParkingAreaTypesAsync();

        return Ok(parkingAreaTypes);
	}

    //Get All ParkingPermits
      [HttpGet("getParkingPermits")]
	public async Task<ActionResult<IEnumerable<ParkingPermitResponse>>> getParkingPermits()
	{
		var parkingPermitType = await _parkingservice.GetAllParkingPermitsAsync();

        return Ok(parkingPermitType);
	}

    //Get One Parking Permit
    [HttpGet("getParkingArea/{id}")]
    public async Task<ActionResult<ParkingAreaResponse>> GetParkingAreaById(int id)
    {

        return await _parkingservice.GetParkingAreaByIdAsync(id);
    }


    //Create one ParkingArea
    [HttpPost("CreateParkingArea")]

      public async Task<ActionResult<ParkingAreaResponse>> CreateParkingArea(ParkingAreaRequest request)
    {

        return await _parkingservice.CreateParkingAreaAsync(request);
    }

    //Create one ParkingAreaType

    [HttpPost("createParkingAreaType")]
    public async Task<ActionResult<ParkingAreaTypeResponse>> CreateParkingAreaType(ParkingAreaTypeRequest request)
    {

        return await _parkingservice.CreateParkingAreaTypeAsync(request);
    }

    //Create one Parking Permit
    [HttpPost("createParkingPermit")]
    public async Task<ActionResult<ParkingPermitResponse>> CreateParkingPermit(ParkingPermitRequest request)
    {

        return await _parkingservice.CreateParkingPermitTypeAsync(request);
    }



    //Update ParkingArea
    [HttpPut("UpdateParkingArea/{id}")]
      public async Task<ActionResult<ParkingAreaResponse>> UpdateParkingArea(ParkingAreaRequest request, int id)
    {

        return await _parkingservice.UpdateParkingAreaAsync(request, id);
    }

    //Update ParkingAreaType

    [HttpPut("UpdateParkingAreaType/{id}")]
      public async Task<ActionResult<ParkingAreaTypeResponse>> UpdateParkingAreaType(ParkingAreaTypeRequest request, int id)
    {

        return await _parkingservice.UpdateParkingAreaTypeAsync(request, id);
    }

    //Update Parking Permit

    [HttpPut("UpdateParkingPermit/{id}")]
      public async Task<ActionResult<ParkingPermitResponse>> UpdateParkingPermit(ParkingPermitRequest request, int id)
    {

        return await _parkingservice.UpdateParkingPermitAsync(request, id);
    }

    //Delete one ParkingArea
    [HttpDelete("DeleteParkingArea/{id}")]
    public async Task<ActionResult<bool>> DeleteParkingArea(int id)
    {
        return await _parkingservice.DeleteParkingAreaAsync(id);

    }
    //Delete one ParkingAreaType
    [HttpDelete("DeleteParkingAreaType/{id}")]

    public async Task<ActionResult<bool>> DeleteParkingAreaType(int id)
    {
        return await _parkingservice.DeleteParkingAreaTypeAsync(id);

    }

    //Delete one ParkingPermit
    [HttpDelete("DeleteParkingPermit/{id}")]

    public async Task<ActionResult<bool>> DeleteParkingPermit(int id)
    {
        return await _parkingservice.DeleteParkingPermitAsync(id);

    }


}
