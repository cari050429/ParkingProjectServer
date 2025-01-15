using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class ParkingAreaTypeResponse
{
    public ParkingAreaTypeResponse(ParkingAreaTypes parkingAreaType)
    {
        Id = parkingAreaType.Id;
        ParkingAreaTypeDescription = parkingAreaType.ParkingAreaTypeDescription;
        Inactive = parkingAreaType.Inactive;
    }

    public int Id { get; set; }

    [StringLength(50)]
    public string ParkingAreaTypeDescription { get; set; }
    public bool Inactive { get; set; }
}
