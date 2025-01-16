using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


public class ParkingAreaResponse
{
    public ParkingAreaResponse(ParkingAreas parkingArea)
    {
        Id = parkingArea.Id;
        ParkingAreaTypeID = parkingArea.ParkingAreaTypeID;
        ParkingAreaName = parkingArea.ParkingAreaName;
        Latitude = parkingArea.Latitude;
        Longitude = parkingArea.Longitude;
        DateCreated = parkingArea.DateCreated;
        Inactive = parkingArea.Inactive;
        ParkingAreaTypeDescription = parkingArea.ParkingAreaType.ParkingAreaTypeDescription;
    }

    

    public int Id { get; set; }

    public int ParkingAreaTypeID { get; set; }

    [StringLength(50)]
    public string ParkingAreaName { get; set; }

    public float Latitude { get; set; }
    public float Longitude { get; set; }


    public DateTime DateCreated { get; set; }
    public bool Inactive { get; set; }

    [Required]
    public string ParkingAreaTypeDescription { get; set; }

}
