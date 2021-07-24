using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class AppointmentsFactory
    {
        public int Id { get; set; }
        public int? AppointmentId { get; set; }
        public int? FactoryId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Factory Factory { get; set; }
    }
}
