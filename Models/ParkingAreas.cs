using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public class ParkingAreas
    {

        // public ParkingAreas(ParkingAreaRequest request)
        // {
        //     ParkingAreaTypeID = request.ParkingAreaTypeID;
        //     ParkingAreaName = request.ParkingAreaName;
        //     Latitude = request.Latitude;
        //     Longitude = request.Longitude;
        //     DateCreated = DateTime.Now;
        //     Inactive = request.Inactive;
        // }
        [Key]
        public int Id { get; set; }

        [ForeignKey("ParkingAreaType")]
        public int ParkingAreaTypeID { get; set; }

        [StringLength(50)]
        public string ParkingAreaName{get;set;}

        public float Latitude {  get; set; }
        public float Longitude { get; set; }

        [StringLength(50)]
        public DateTime DateCreated {  get; set; }
        public bool Inactive {  get; set; }

        public virtual ParkingAreaTypes ParkingAreaType { get; set; }
        //public virtual ICollection<ParkingPermits> ParkingPermits { get; set; }
       //This might not be needed 



    }

