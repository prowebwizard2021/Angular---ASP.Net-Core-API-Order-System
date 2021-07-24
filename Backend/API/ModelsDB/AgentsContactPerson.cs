using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class AgentsContactPerson
    {
        public int Id { get; set; }
        public int? AgentId { get; set; }
        public int? ContactPersonId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ContactPerson ContactPerson { get; set; }
    }
}
