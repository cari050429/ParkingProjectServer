using System;
using System.ComponentModel.DataAnnotations;

public class ParkingAreaRequest
{
    public int ParkingAreaTypeID { get; set; }

    public float Latitude { get; set; }

    public float Longitude { get; set; }

    [StringLength(50)]
    public string ParkingAreaName { get; set; }

    public bool Inactive { get; set; }
}
