using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentsContainers = new HashSet<AppointmentsContainer>();
            AppointmentsFactories = new HashSet<AppointmentsFactory>();
            AppointmentsOrders = new HashSet<AppointmentsOrder>();
        }

        public int Id { get; set; }
        public DateTime? AppointmentEnd { get; set; }
        public int? CertificationBodyId { get; set; }
        public DateTime? Date { get; set; }
        public string FactoryVisitId { get; set; }
        public string GeneralComments { get; set; }
        public int ItemId { get; set; }
        public string PlaceOfFactoryVisit { get; set; }
        public int? PurposeOfFactoryVisitId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CertificationBody CertificationBody { get; set; }
        public virtual FactoryVisitPurpose PurposeOfFactoryVisit { get; set; }
        public virtual ICollection<AppointmentsContainer> AppointmentsContainers { get; set; }
        public virtual ICollection<AppointmentsFactory> AppointmentsFactories { get; set; }
        public virtual ICollection<AppointmentsOrder> AppointmentsOrders { get; set; }
    }
}
