using System;
using System.ComponentModel.DataAnnotations;

public class ParkingAreaTypeRequest
{
    [StringLength(50)]
    public string ParkingAreaTypeDescription { get; set; }
    public bool Inactive { get; set; }
}
