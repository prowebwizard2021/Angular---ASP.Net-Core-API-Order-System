using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class UserPhoto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public bool IsApproved { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
