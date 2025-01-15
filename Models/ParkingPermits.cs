using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

    public class ParkingPermits
    {

        public ParkingPermits(ParkingPermitRequest request) 
        { 
            ParkingAreaID = request.ParkingAreaID;
            EffectiveDate = request.EffectiveDate;
            ExpirationDate = request.ExpirationDate;
            LicensePlate = request.LicensePlate;
            DateCreated = DateTime.Now;
            Inactive = request.Inactive;
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("ParkingArea")]
        public int ParkingAreaID { get; set; }

        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        [StringLength(50)]
        public string LicensePlate {  get; set; }

        public DateTime DateCreated { get; set; }
        public bool Inactive { get; set; }

        public virtual ParkingAreas ParkingArea { get; set; }


    }

