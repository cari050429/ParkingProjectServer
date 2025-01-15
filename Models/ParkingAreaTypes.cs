using System.ComponentModel.DataAnnotations;


    public class ParkingAreaTypes
    {

        public ParkingAreaTypes(ParkingAreaTypeRequest request) 
        {
            ParkingAreaTypeDescription = request.ParkingAreaTypeDescription;
            Inactive= request.Inactive;
        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string ParkingAreaTypeDescription { get; set; }
        public bool Inactive { get; set; }
    }

