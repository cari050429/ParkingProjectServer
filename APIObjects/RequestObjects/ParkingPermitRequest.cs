using System;
using System.ComponentModel.DataAnnotations;

public class ParkingPermitRequest
{
    public int ParkingAreaID { get; set; }

    public DateTime EffectiveDate { get; set; }
    public DateTime ExpirationDate { get; set; }

    [StringLength(50)]
    public string LicensePlate { get; set; }

    public bool Inactive { get; set; }
}
