using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CityBusManagement.Entity.Models
{
    public class BusDetails 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int busNo { get; set; }
        public string busName { get; set; }
        public int arrivalTime { get; set; }

        public virtual ICollection<Trip> trip { get; set; }
    }
}
