using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public int ScheduleId { get; set; }

        public int UserId { get; set; }

        public int MapId { get; set; }

        public string AgeId { get; set; }
    }
}
