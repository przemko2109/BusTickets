using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }

        public string ExitCityId { get; set; }

        public string DestinationCityId { get; set; }

        public int Distance { get; set; }
    }
}
