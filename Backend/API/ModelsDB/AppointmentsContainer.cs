using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class AppointmentsContainer
    {
        public int Id { get; set; }
        public int? AppointmentId { get; set; }
        public int? ContainerId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Container Container { get; set; }
    }
}
