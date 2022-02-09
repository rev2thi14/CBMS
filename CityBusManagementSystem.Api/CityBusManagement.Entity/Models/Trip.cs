using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CityBusManagement.Entity.Models
{
   public class Trip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tripId { get; set; }
        public int tripCount { get; set; }
        public virtual BusDetails busDetails { get; set; }
        public virtual RouteDetails routeDetails { get; set; }
        public virtual ICollection<Employee> employeeDetails { get; set; }
    }
}
