using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class AppointmentsOrder
    {
        public int Id { get; set; }
        public int? AppointmentId { get; set; }
        public int? OrderId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Order Order { get; set; }
    }
}
