using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

public class ParkingPermitDetailResponse
{

    public ParkingPermitDetailResponse(ParkingPermits parkingPermit) 
    {
        Id = parkingPermit.Id;
        ParkingAreaName= parkingPermit.ParkingArea.ParkingAreaName;
        EffectiveDate = parkingPermit.EffectiveDate;
        ExpirationDate = parkingPermit.ExpirationDate;
        LicensePlate = parkingPermit.LicensePlate;
        Inactive = parkingPermit.Inactive;
        EffectiveDate = parkingPermit.EffectiveDate; 
        Longitude = parkingPermit.ParkingArea.Longitude; 
        Latitude = parkingPermit.ParkingArea.Latitude;
        ParkingAreaTypeDescription = parkingPermit.ParkingArea.ParkingAreaType.ParkingAreaTypeDescription;
    
    }

    public DateTime EffectiveDate { get; set; }

    public int Id{get; set;}
    public DateTime ExpirationDate { get; set; }

    [StringLength(50)]
    public string ParkingAreaName { get; set; }

    [StringLength(50)]
    public string LicensePlate { get; set; }

    public bool Inactive { get; set; }

    [Required]
    public double Longitude { get; set; }

    [Required]
    public double Latitude { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateCreated { get; set; }

    [Required]
    public string ParkingAreaTypeDescription { get; set; }

}
