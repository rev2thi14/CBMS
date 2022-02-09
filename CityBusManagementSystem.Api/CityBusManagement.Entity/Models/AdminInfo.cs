using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CityBusManagement.Entity.Models
{
    public class AdminInfo
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
