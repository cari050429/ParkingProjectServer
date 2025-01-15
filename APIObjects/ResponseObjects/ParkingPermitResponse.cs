using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

public class ParkingPermitResponse
{

    public ParkingPermitResponse(ParkingPermits parkingPermit) 
    {
        Id= parkingPermit.Id;
        ParkingAreaName= parkingPermit.ParkingArea.ParkingAreaName;
        EffectiveDate = parkingPermit.EffectiveDate;
        ExpirationDate = parkingPermit.ExpirationDate;
        LicensePlate = parkingPermit.LicensePlate;
        DateCreated = parkingPermit.DateCreated;
        Inactive = parkingPermit.Inactive;
    
    }
    public int Id { get; set; }

    public int ParkingAreaID { get; set; }

    public DateTime EffectiveDate { get; set; }
    public DateTime ExpirationDate { get; set; }

    [StringLength(50)]
    public string ParkingAreaName { get; set; }

    [StringLength(50)]
    public string LicensePlate { get; set; }

    public DateTime DateCreated { get; set; } 

    public bool Inactive { get; set; }
}
